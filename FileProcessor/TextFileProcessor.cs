
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Runtime.InteropServices;
using System.Linq;

namespace FileProcessors
{
    public class TextFileProcessor : IFileProcessor
    {
        public FileStream _file;
        private readonly string _fileName;
        public TextFileProcessor(string fileName)
        {
            _fileName = fileName + ".txt";
        }
        public void Close()
        {
            _file.Close();
        }

        public string Read()
        {
            if (!IsCreated())
            {
                throw new FileNotFoundException($"Datoteka {_fileName} nije pronađena!");
            }


            if (new FileInfo(GetPath()).Length == 0)
            {
                throw new ArgumentException($"Datoteka {_fileName} je prazna!");
            }
            string lines = null;
            using (_file)
            {
                lines = File.ReadAllLines(GetPath()).First().ToString();
            }

            return lines;
        }

        public bool Write(string lines)
        {
            if (!IsCreated())
            {
                throw new FileNotFoundException($"Datoteka {_fileName} nije pronađena!");
            }
            Clear();
            File.WriteAllText(GetPath(), lines + Environment.NewLine);

            return true;
        }



        public string GetPath()
        {
            return AppDomain.CurrentDomain.BaseDirectory + _fileName;
        }

        public bool Clear()
        {
            using (_file)
            {
                File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + _fileName, String.Empty);
            }
            
            return true;
        }

        public void Create()
        {
            using (_file = File.Create(GetPath()))
            {

            }


        }
        public bool Exists()
        {
            if (IsCreated())
            {
                return true;
            }
            return false;
        }
        public bool IsCreated()
        {
            if (File.Exists(GetPath()))
            {
                return true;
            }
            return false;
        }

        public string ReadAll()
        {
            string[] allLines;
            string output = "";
            using (_file)
            {
               allLines= File.ReadAllLines(GetPath());
            }
            foreach (var line in allLines)
            {
                output += line + Environment.NewLine;
            }
            return output;
        }
    }
    public enum FileName
    {
        dekriptirani_tekst,
        javni_kljuc,
        kriptirani_tekst_asimetricno,
        kriptirani_tekst_simetricno,
        potpis,
        privatni_kljuc,
        sazetak,
        tajni_kljuc
    }
}
