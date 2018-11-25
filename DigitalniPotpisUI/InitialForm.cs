using AsymmetricCryptosystems;
using FileProcessors;
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
            TextFileProcessor privateKey = new TextFileProcessor(FileName.privatni_kljuc.ToString());
            TextFileProcessor publicKey = new TextFileProcessor(FileName.javni_kljuc.ToString());
            TextFileProcessor secretKey = new TextFileProcessor(FileName.tajni_kljuc.ToString());
            if (privateKey.Exists() && publicKey.Exists())
            {
                IAsymmetricCryptosystem rSAProcessor = new RSAProcessor();
                ISymmetricCryptosystem tripleDESProcessor = new TripleDESProcessor();
                publicKey.Write(rSAProcessor.PublicKeyToString());
                privateKey.Write(rSAProcessor.PrivateKeyToString());
                secretKey.Write(tripleDESProcessor.GetKey());
            }
            
      
        }
    }
}
