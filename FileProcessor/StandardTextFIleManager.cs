using System;
using System.Collections.Generic;
using System.Text;

namespace FileProcessors
{
    public class StandardTextFIleManager : IFileManager
    {
        public bool CheckIfAllFIlesExist(List<IFileProcessor> fileProcessors)
        {
            foreach (var file in fileProcessors)
            {
                if (!file.Exists())
                {
                    return false;
                }
            }
            return true;
            
        }

        public void CreateTextFiles(List<IFileProcessor> fileProcessors)
        {
            foreach (var file in fileProcessors)
            {
                if (!file.Exists())
                {
                    file.Create();

                }
            }
        }
    }
}
