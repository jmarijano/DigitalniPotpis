using System;
using System.Collections.Generic;
using System.Text;

namespace HashFunctions
{
    public interface IHashFunction
    {
        void GetData(string data);
        string ReturnHash();
    }
}
