using FileProcessors;
using System;
using System.Collections.Generic;
using System.Text;

namespace FileProcessors
{
    public interface IFileProcessor
    {

        
        string ReadAll();
        bool Write(string Line);

        bool Clear();

        void Create();

        string GetPath();
        bool Exists();
    }
}
