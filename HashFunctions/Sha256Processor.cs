using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace HashFunctions
{
    public class SHA256Processor : IHashFunction
    {
        private string _hashedText;
        public void GetData(string data)
        {
            var crypt = new SHA256Managed();
            var hash = new StringBuilder();
            byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(data));
            foreach (byte @byte in crypto)
            {
                hash.Append(@byte.ToString("x2"));
            }
            _hashedText = hash.ToString();
        }

        public string ReturnHash()
        {
            return _hashedText;
        }
    }
}
