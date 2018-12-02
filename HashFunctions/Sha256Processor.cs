using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace HashFunctions
{
    public class SHA256Processor : IHashFunction
    {
        private byte[] _hashedText;

        public void GetData(string data)
        {
            var crypt = new SHA256Managed();
            _hashedText = crypt.ComputeHash(Encoding.UTF8.GetBytes(data));
        }

        public string ReturnHash()
        {
            return Convert.ToBase64String(_hashedText);
        }
    }
}
