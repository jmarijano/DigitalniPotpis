using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace SymmetricCryptosystems
{
    public class AESProcessor
    {
        private readonly TripleDESCryptoServiceProvider _des;
        private readonly string _key;

        public AESProcessor()
            :this(new TripleDESCryptoServiceProvider())
        {

        }

        public AESProcessor(TripleDESCryptoServiceProvider des)
        {
            _des = des;
            _des.GenerateKey();
        }

        public string Encrypt(string plainText)
        {
            return "0";
        }
    }
}
