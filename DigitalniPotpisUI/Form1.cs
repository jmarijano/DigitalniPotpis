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
using FileProcessors;
using HashFunctions;

namespace DigitalniPotpisUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            IFileProcessor fileProcessor = new TextFileProcessor(FileName.dekriptirani_tekst.ToString());
            fileProcessor.Create();
            try
            {
                //fileProcessor.ReadAll();
            }
            catch (FileNotFoundException message)
            {

                MessageBox.Show(message.Message);
            }
            if (File.Exists(fileProcessor.GetPath()))
            {
                MessageBox.Show("da");
            }
            else
            {
                MessageBox.Show("ne");
            }
            IHashFunction hashFunction = new SHA384Processor();
            hashFunction.GetData("dasdasdassadasdasd");
            var nesto = hashFunction.ReturnHash();
            MessageBox.Show(nesto);
            fileProcessor.Write(nesto);
        }
    }
}
