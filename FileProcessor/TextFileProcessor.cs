
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
            _fileName = fileName;
        }
        public void Close()
        {
            _file.Close();
        }

        public string ReadAll()
        {
            if (!IsCreated())
            {
                throw new FileNotFoundException($"Datoteka {_fileName} nije pronađena!");
            }

            List<TextFileLine> listOfLines = new List<TextFileLine>();


            if (new FileInfo(GetPath()).Length == 0)
            {
                throw new ArgumentException($"Datoteka {_fileName} je prazna!" );
            }


            string lines = File.ReadAllLines(GetPath()).ToString();
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
            return AppDomain.CurrentDomain.BaseDirectory + _fileName + ".txt";
        }

        public bool Clear()
        {
            File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + _fileName, String.Empty);
            return true;
        }

        public void Create()
        {
            if (!IsCreated())
            {
                File.Create(GetPath());
            }
            
        }

        public bool IsCreated()
        {
            if (File.Exists(GetPath()))
            {
                return true;
            }
            return false;
        }
    }
    public enum FileName
    {
        dekriptirani_tekst,
        javni_kljuc,
        kriptirani_tekst,
        potpis,
        privatni_kljuc,
        sazetak,
        tajni_kljuc
    }
}
