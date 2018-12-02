using System;
using System.Collections.Generic;
using System.Text;

namespace FileProcessors
{
    public static class FileObjectCreator
    {
        public static List<IFileProcessor> CreteListOfFileProcessors()
        {
            List<IFileProcessor> output = new List<IFileProcessor>
            {
                new TextFileProcessor(FileName.dekriptirani_tekst.ToString()),
                new TextFileProcessor(FileName.javni_kljuc.ToString()),
                new TextFileProcessor(FileName.kriptirani_tekst_asimetricno.ToString()),
                new TextFileProcessor(FileName.kriptirani_tekst_simetricno.ToString()),
                new TextFileProcessor(FileName.potpis.ToString()),
                new TextFileProcessor(FileName.privatni_kljuc.ToString()),
                new TextFileProcessor(FileName.sazetak.ToString()),
                new TextFileProcessor(FileName.tajni_kljuc.ToString()),
            };
            return output;
        }

        public static IFileProcessor CreatePrivatniKljuc()
        {
            return new TextFileProcessor(FileName.privatni_kljuc.ToString());
        }

        public static IFileProcessor CreateJavniKljuc()
        {
            return new TextFileProcessor(FileName.javni_kljuc.ToString());
        }

        public static IFileProcessor CreateTajniKljuc()
        {
            return new TextFileProcessor(FileName.tajni_kljuc.ToString());
        }
        
        public static IFileProcessor CreateDekriptiraniTekst()
        {
            return new TextFileProcessor(FileName.dekriptirani_tekst.ToString());
        }

        public static IFileProcessor CreateKriptiraniTekstAsimetricno()
        {
            return new TextFileProcessor(FileName.kriptirani_tekst_asimetricno.ToString());
        }

        public static IFileProcessor CreateKriptiraniTekstSimetricno()
        {
            return new TextFileProcessor(FileName.kriptirani_tekst_simetricno.ToString());
        }

        public static IFileProcessor CreateSazetak()
        {
            return new TextFileProcessor(FileName.sazetak.ToString());
        }

        public static IFileProcessor CreateDigitalniPotpis()
        {
            return new TextFileProcessor(FileName.potpis.ToString());
        }
    }
}
