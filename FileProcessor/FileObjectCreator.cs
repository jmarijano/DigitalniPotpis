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
                new TextFileProcessor(FileName.dekriptirani_tekst_asimetricno.ToString()),
                new TextFileProcessor(FileName.dekriptirani_tekst_simetricno.ToString()),
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
    }
}
