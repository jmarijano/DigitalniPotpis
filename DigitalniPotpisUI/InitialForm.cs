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
        string hashValue;
        string signatureValue;

        public InitialForm()
        {
            InitializeComponent();
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
            rsaProcessor = new RSAProcessor();
            tripleDES = new TripleDESProcessor();
            MessageBox.Show("Stvoreni su novi ključevi!");
        }

        private void InitialForm_Load(object sender, EventArgs e)
        {
            uiSaveChanges.Visible = false;
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

        private void JasniTekstToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ClearRichBox();
                ShowTextBox();
                uiShowData.Text = FileObjectCreator.CreateDekriptiraniTekst().ReadAll();
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
                uiShowData.Text = FileObjectCreator.CreateKriptiraniTekstSimetricno().ReadAll();
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
                uiShowData.Text = FileObjectCreator.CreateKriptiraniTekstAsimetricno().ReadAll();
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
                uiShowData.Text = FileObjectCreator.CreateTajniKljuc().ReadAll();
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
                uiShowData.Text = FileObjectCreator.CreateSazetak().ReadAll();
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
                uiShowData.Text = FileObjectCreator.CreateDigitalniPotpis().ReadAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void SimetričnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearRichBox();
            if (MessageBox.Show("Simetrično kriptiranje", "Simetrično kriptiraj tekst", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    secretKey.Write(tripleDES.GetKey());
                    cyphertextSimetricno.Write(tripleDES.Encrypt(plainText.ReadAll()));
                    ShowTextBox();
                    uiShowData.Text = cyphertextSimetricno.ReadAll();
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
                    cypherTextAsimetricno.Write(rsaProcessor.Encrypt(plainText.ReadAll()));
                    ShowTextBox();
                    uiShowData.Text = cypherTextAsimetricno.ReadAll();
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
                    uiShowData.Text = "Jasni tekst: " + Environment.NewLine + plainText.ReadAll() + AddNewLine();
                    uiShowData.Text += "Simetrično kriptiran tekst: " + cyphertextSimetricno.ReadAll() + AddNewLine();
                    uiShowData.Text += "Simetrično dekriptiran tekst: " + Environment.NewLine + tripleDES.Decrypt(cyphertextSimetricno.ReadAll());
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
                    uiShowData.Text = "Jasni tekst: " + Environment.NewLine + plainText.ReadAll() + AddNewLine();
                    uiShowData.Text += "Asimetrično kriptiran tekst: " + cypherTextAsimetricno.ReadAll() + AddNewLine();
                    uiShowData.Text += "Asimetrično dekriptiran tekst: " + Environment.NewLine + rsaProcessor.Decrypt(cypherTextAsimetricno.ReadAll());
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
                hashFunction.GetData(plainText.ReadAll());
                hashValue = hashFunction.ReturnHash();
                hash.Write(hashValue);
                uiShowData.Text = "Sažetak: " + hashValue + AddNewLine();
                signatureValue = rsaProcessor.SignHash(hashValue, "SHA256");
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
                uiShowData.Text = "Sažetak: " + hash.ReadAll() + AddNewLine();
                uiShowData.Text += "Digitalni potpis: " + signature.ReadAll();
                if (rsaProcessor.VerifyHash(signature.ReadAll(), "SHA256", hash.ReadAll()))
                {
                    MessageBox.Show("Digitalni potpis je valjan!");
                }
                else
                {
                    MessageBox.Show("Digitalni potpis nije valjan!");
                }
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
            uiSaveChanges.Visible = false;
        }

        private string AddNewLine()
        {
            return Environment.NewLine + Environment.NewLine;
        }

        private void JasniTekstToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ClearRichBox();
            try
            {
                uiSaveChanges.Visible = true;
                uiShowData.ReadOnly = false;
                uiShowData.Text = plainText.ReadAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UiSaveChanges_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Spremi promjene", "Spremi promjene?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                plainText.Write(uiShowData.Text);
                uiSaveChanges.Visible = false;
                uiShowData.ReadOnly = true;
            }
        }

    }
}
