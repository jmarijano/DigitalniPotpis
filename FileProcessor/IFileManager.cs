using System;
using System.Collections.Generic;
using System.Text;

namespace FileProcessors
{
    public interface IFileManager
    {
        bool CheckIfAllFIlesExist(List<IFileProcessor> fileProcessors);
        void CreateTextFiles(List<IFileProcessor> fileProcessors); 
    }
}
