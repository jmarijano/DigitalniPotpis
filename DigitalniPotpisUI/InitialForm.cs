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
using System.Security.Cryptography;
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
        IFileProcessor publicKey;
        IFileProcessor signature;
        IFileProcessor hash;
        IHashFunction hashFunction;

        public InitialForm()
        {
            InitializeComponent();
            rsaProcessor = new RSAProcessor();
            tripleDES = new TripleDESProcessor();
            hashFunction = new SHA256Processor();
            secretKey = FileObjectCreator.CreateTajniKljuc();
            plainText = FileObjectCreator.CreateDekriptiraniTekst();
            cyphertextSimetricno = FileObjectCreator.CreateKriptiraniTekstSimetricno();
            cypherTextAsimetricno = FileObjectCreator.CreateKriptiraniTekstAsimetricno();
            privateKey = FileObjectCreator.CreatePrivatniKljuc();
            publicKey = FileObjectCreator.CreateJavniKljuc();
            signature = FileObjectCreator.CreateDigitalniPotpis();
            hash = FileObjectCreator.CreateSazetak();
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
            try
            {
                ClearRichBox();
                ShowTextBox();
                uiShowData.Text = FileObjectCreator.CreateDekriptiraniTekst().Read();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void SimetričnoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                ClearRichBox();
                ShowTextBox();
                uiShowData.Text = FileObjectCreator.CreateKriptiraniTekstSimetricno().Read();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void AsimetričnoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                ClearRichBox();
                ShowTextBox();
                uiShowData.Text = FileObjectCreator.CreateKriptiraniTekstAsimetricno().Read();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void TajniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                ClearRichBox();
                ShowTextBox();
                uiShowData.Text = FileObjectCreator.CreateTajniKljuc().Read();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void JavniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                ClearRichBox();
                ShowTextBox();
                uiShowData.Text = FileObjectCreator.CreateJavniKljuc().ReadAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PrivatniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                ClearRichBox();
                ShowTextBox();
                uiShowData.Text = FileObjectCreator.CreatePrivatniKljuc().ReadAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SažetakToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ClearRichBox();
                ShowTextBox();
                uiShowData.Text = FileObjectCreator.CreateSazetak().Read();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void DigitalniPotpisToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                ClearRichBox();
                ShowTextBox();
                uiShowData.Text = FileObjectCreator.CreateDigitalniPotpis().Read();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void SimetričnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearRichBox();
            if (MessageBox.Show("Simetrično kriptiranje","Simetrično kriptiraj tekst",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    secretKey.Write(tripleDES.GetKey());
                    cyphertextSimetricno.Write(tripleDES.Encrypt(plainText.Read()));
                    ShowTextBox();
                    uiShowData.Text = cyphertextSimetricno.Read();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }   
            } 
        }

        private void AsimetričnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearRichBox();
            if (MessageBox.Show("Asimetrično kriptiranje", "Asimetrično kriptiraj tekst", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    privateKey.Write(rsaProcessor.PrivateKeyToString());
                    publicKey.Write(rsaProcessor.PublicKeyToString());
                    cypherTextAsimetricno.Write(rsaProcessor.Encrypt(plainText.Read()));
                    ShowTextBox();
                    uiShowData.Text = cypherTextAsimetricno.Read();
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
               
            }
        }

        private void SimetričnoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ClearRichBox();
            if (MessageBox.Show("Simetrično dekriptiranje", "Simetrično dekriptiraj tekst", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    ShowTextBox();
                    uiShowData.Text = "Jasni tekst: " + plainText.Read() + AddNewLine();
                    uiShowData.Text += "Simetrično kriptiran tekst: " + cyphertextSimetricno.Read() + AddNewLine();
                    uiShowData.Text += "Simetrično dekriptiran tekst: " + tripleDES.Decrypt(cyphertextSimetricno.Read());
                }
                catch (Exception exception)
                {
                    ClearRichBox();
                    MessageBox.Show(exception.Message);
                   
                }
            }
        }

        private void AsimetričnoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ClearRichBox();
            if (MessageBox.Show("Asimetrično dekriptiranje", "Asimetrično dekriptiraj tekst", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    ShowTextBox();
                    uiShowData.Text = "Jasni tekst: " + plainText.Read() + AddNewLine();
                    uiShowData.Text += "Asimetrično kriptiran tekst: " + cypherTextAsimetricno.Read() + AddNewLine();
                    uiShowData.Text += "Asimetrično dekriptiran tekst: " + rsaProcessor.Decrypt(cypherTextAsimetricno.Read());
                }
                catch (CryptographicException exception)
                {

                    MessageBox.Show(exception.GetBaseException().Message);
                    ClearRichBox();
                }
                
            }
        }

        private void PotpišiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            ClearRichBox();
            try
            {
                hashFunction.GetData(plainText.Read());
                string hashValue = hashFunction.ReturnHash();
                hash.Write(hashValue);
                uiShowData.Text = "Sažetak: " + hashValue + AddNewLine();
                string signatureValue = rsaProcessor.SignHash(hashValue, "SHA256");
                uiShowData.Text += "Digitalni potpis: " + signatureValue;
                signature.Write(signatureValue);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ProvjeriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearRichBox();
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
