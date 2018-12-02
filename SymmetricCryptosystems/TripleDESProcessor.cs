using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace SymmetricCryptosystems
{
    public class TripleDESProcessor : ISymmetricCryptosystem
    {
        private TripleDESCryptoServiceProvider _tdes = new TripleDESCryptoServiceProvider();
        private ICryptoTransform _cryptoTransform;
        private Random keyRandom;
        private Random IVRandom;
        private readonly byte[] forKey = new byte[24];
        private readonly byte[] forIV = new byte[8];


        public TripleDESProcessor()
        {
            keyRandom = new Random();
            IVRandom = new Random();
            keyRandom.NextBytes(forKey);
            IVRandom.NextBytes(forIV);
            SetIVAndKey();

        }
        public string Encrypt(string plainText)
        {
            SetIVAndKey();
            byte[] plainTextByteArray = Convert.FromBase64String(plainText);
            _cryptoTransform = _tdes.CreateEncryptor();
            byte[] resultArray = _cryptoTransform.TransformFinalBlock(plainTextByteArray, 0, plainTextByteArray.Length);
            string output = Convert.ToBase64String(resultArray);
            _tdes.Clear();
            _cryptoTransform.Dispose();
            return output;
        }

        public string Decrypt(string cypherText)
        {
            SetIVAndKey();
            byte[] cypherTextByteArray = Convert.FromBase64String(cypherText);
            _cryptoTransform = _tdes.CreateDecryptor();
            byte[] resultArray;
            try
            {
                resultArray = _cryptoTransform.TransformFinalBlock(cypherTextByteArray, 0, cypherTextByteArray.Length);
            }
            catch (CryptographicException)
            {

                throw new CryptographicException("Dogodila se greška!");
            }
            
            string output = Convert.ToBase64String(resultArray);
            _tdes.Clear();
            _cryptoTransform.Dispose();
            return output;
        }

        public string GetKey()
        {
            return Convert.ToBase64String(_tdes.Key);
        }

        public void SetIVAndKey()
        {
            _tdes.Key = forKey;
            _tdes.IV = forIV;
        }

    }
}
