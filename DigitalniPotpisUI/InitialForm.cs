using AsymmetricCryptosystems;
using FileProcessors;
using HashFunctions;
using SymmetricCryptosystems;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalniPotpisUI
{
    public partial class InitialForm : Form
    {
        IAsymmetricCryptosystem rsaProcessor;
        ISymmetricCryptosystem tripleDES;
        IFileProcessor secretKey;
        IFileProcessor plainText;
        IFileProcessor cypherTextAsimetricno;
        IFileProcessor cyphertextSimetricno;
        IFileProcessor privateKey;
        IFileProcessor publikKey;
        public InitialForm()
        {
            InitializeComponent();
            rsaProcessor = new RSAProcessor();
            tripleDES = new TripleDESProcessor();
            secretKey = FileObjectCreator.CreateTajniKljuc();
            plainText = FileObjectCreator.CreateDekriptiraniTekst();
            cyphertextSimetricno = FileObjectCreator.CreateKriptiraniTekstSimetricno();
            cypherTextAsimetricno = FileObjectCreator.CreateKriptiraniTekstAsimetricno();
            privateKey = FileObjectCreator.CreatePrivatniKljuc();
            publikKey = FileObjectCreator.CreateJavniKljuc();
        }

        private void DatotekaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            List<IFileProcessor> fileProcessors = FileObjectCreator.CreteListOfFileProcessors();
            IFileManager fileManager = new StandardTextFIleManager();
            if (fileManager.CheckIfAllFIlesExist(fileProcessors))
            {
                MessageBox.Show("Datoteke već postoje!");
            }
            
            else
            {
                fileManager.CreateTextFiles(fileProcessors);
                MessageBox.Show("Datoteke su stvorene!");
            }
        }

        private void KljučevaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextFileProcessor privateKey = new TextFileProcessor(FileName.privatni_kljuc.ToString());
            TextFileProcessor publicKey = new TextFileProcessor(FileName.javni_kljuc.ToString());
            TextFileProcessor secretKey = new TextFileProcessor(FileName.tajni_kljuc.ToString());
            TextFileProcessor plainTextFile = new TextFileProcessor(FileName.dekriptirani_tekst.ToString());
            TextFileProcessor cypherAsymmetric = new TextFileProcessor(FileName.kriptirani_tekst_asimetricno.ToString());
            TextFileProcessor cypherSymmetric = new TextFileProcessor(FileName.kriptirani_tekst_simetricno.ToString());
            TextFileProcessor hashedTextFile = new TextFileProcessor(FileName.sazetak.ToString());
            IHashFunction hash = new SHA256Processor();
            
            hash.GetData(plainTextFile.Read());
            string nesto1 = hash.ReturnHash();

            if (privateKey.Exists() && publicKey.Exists())
            {
                IAsymmetricCryptosystem rSAProcessor = new RSAProcessor();
                ISymmetricCryptosystem tripleDESProcessor = new TripleDESProcessor();
                publicKey.Write(rSAProcessor.PublicKeyToString());
                privateKey.Write(rSAProcessor.PrivateKeyToString());
                secretKey.Write(tripleDESProcessor.GetKey());
                string nesto = plainTextFile.Read();
                cypherSymmetric.Write(tripleDESProcessor.Encrypt(plainTextFile.Read()));
                hashedTextFile.Write(hash.ReturnHash());
                cypherAsymmetric.Write(rSAProcessor.Encrypt(plainTextFile.Read()));
                MessageBox.Show(tripleDESProcessor.Decrypt(cypherSymmetric.Read()));
                MessageBox.Show(rSAProcessor.Decrypt(cypherAsymmetric.Read()));
                MessageBox.Show(hash.ReturnHash());
                string nesto3 = rSAProcessor.SignHash(nesto1, "SHA256");
                MessageBox.Show(nesto3);
                string nesto4 = rSAProcessor.SignHash(hashedTextFile.Read(), "SHA256");
                if (rSAProcessor.VerifyHash(nesto4,"SHA256",nesto1))
                {
                    MessageBox.Show("radi");
                }
                else
                {
                    MessageBox.Show("neradi");
                }
                
            }

        }

        private void InitialForm_Load(object sender, EventArgs e)
        {
            
        }

        private void JasniTekstToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearRichBox();
            ShowTextBox();
            uiShowData.Text =FileObjectCreator.CreateDekriptiraniTekst().Read();
        }

        private void SimetričnoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ClearRichBox();
            ShowTextBox();
            uiShowData.Text = FileObjectCreator.CreateKriptiraniTekstSimetricno().Read();
        }

        private void AsimetričnoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ClearRichBox();
            ShowTextBox();
            uiShowData.Text = FileObjectCreator.CreateKriptiraniTekstAsimetricno().Read();
        }

        private void TajniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearRichBox();
            ShowTextBox();
            uiShowData.Text = FileObjectCreator.CreateTajniKljuc().Read();
        }

        private void JavniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearRichBox();
            ShowTextBox();
            uiShowData.Text = FileObjectCreator.CreateJavniKljuc().ReadAll();
        }

        private void PrivatniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearRichBox();
            ShowTextBox();
            uiShowData.Text = FileObjectCreator.CreatePrivatniKljuc().ReadAll();
        }

        private void SažetakToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearRichBox();
            ShowTextBox();
            uiShowData.Text = FileObjectCreator.CreateSazetak().Read();
        }

        private void DigitalniPotpisToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ClearRichBox();
            ShowTextBox();
            uiShowData.Text = FileObjectCreator.CreateDigitalniPotpis().Read();
        }

        private void SimetričnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearRichBox();
            if (MessageBox.Show("Simetrično kriptiranje","Simetrično kriptiraj tekst",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                secretKey.Write(tripleDES.GetKey());
                cyphertextSimetricno.Write(tripleDES.Encrypt(plainText.Read()));
                ShowTextBox();
                uiShowData.Text = cyphertextSimetricno.Read();
            } 
        }

        private void AsimetričnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearRichBox();
            if (MessageBox.Show("Asimetrično kriptiranje", "Asimetrično kriptiraj tekst", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                privateKey.Write(rsaProcessor.PrivateKeyToString());
                publikKey.Write(rsaProcessor.PublicKeyToString());
                cypherTextAsimetricno.Write(rsaProcessor.Encrypt(plainText.Read()));
                ShowTextBox();
                uiShowData.Text = cypherTextAsimetricno.Read();
            }
        }

        private void SimetričnoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ClearRichBox();
            if (MessageBox.Show("Simetrično dekriptiranje", "Simetrično dekriptiraj tekst", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ShowTextBox();
                uiShowData.Text = "Jasni tekst: " + plainText.Read() + AddNewLine();
                uiShowData.Text += "Simetrično kriptiran tekst: " + cyphertextSimetricno.Read() + AddNewLine();
                uiShowData.Text += "Simetrično dekriptiran tekst: " + tripleDES.Decrypt(cyphertextSimetricno.Read());
                
            }
        }

        private void AsimetričnoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ClearRichBox();
            if (MessageBox.Show("Asimetrično dekriptiranje", "Asimetrično dekriptiraj tekst", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ShowTextBox();
                uiShowData.Text = "Jasni tekst: " + plainText.Read() + AddNewLine();
                uiShowData.Text += "Asimetrično kriptiran tekst: " + cypherTextAsimetricno.Read() + AddNewLine();
                uiShowData.Text += "Simetrično dekriptiran tekst: " + rsaProcessor.Decrypt(cypherTextAsimetricno.Read());
            }
        }

        private void PotpišiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearRichBox();
        }

        private void ProvjeriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearRichBox();
        }

        private void ShowTextBox()
        {
            uiShowData.Show();
            uiShowDataLabel.Show();
        }

        private void ClearRichBox()
        {
            uiShowData.Clear();
        }

        private string AddNewLine()
        {
            return Environment.NewLine + Environment.NewLine;
        }
    }
}
