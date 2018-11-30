using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;
using HashFunctions;

namespace AsymmetricCryptosystems
{
    public class RSAProcessor : IAsymmetricCryptosystem
    {
        private readonly RSACryptoServiceProvider _csp;
        private readonly RSAParameters _privateKey;
        private readonly RSAParameters _publicKey;
        private readonly string _publicKeyString;
        private readonly string _privateKeyString;

        public RSAProcessor()
            : this(new RSACryptoServiceProvider(2048))
        {

        }
        public RSAProcessor(RSACryptoServiceProvider csp)
        {
            _csp = csp;
            _privateKey = _csp.ExportParameters(true);
            _publicKey = _csp.ExportParameters(false);
            _publicKeyString = PublicKeyToString();
            _privateKeyString = PrivateKeyToString();
        }

        public string PublicKeyToString()
        {
            var sw = new System.IO.StringWriter();
            var xs = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));
            xs.Serialize(sw, _publicKey);
            return sw.ToString();
        }

        public string PrivateKeyToString()
        {
            var sw = new System.IO.StringWriter();
            var xs = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));
            xs.Serialize(sw, _privateKey);
            return sw.ToString();
        }

        public string Encrypt(string plainText)
        {
            var bytesPlainText = System.Text.Encoding.Unicode.GetBytes(plainText);
            var bytesCypherText = _csp.Encrypt(bytesPlainText, false);
            string output = Convert.ToBase64String(bytesCypherText);
            return output;

        }

        public string Decrypt(string cypherText)
        {
            var bytesCypherText = Convert.FromBase64String(cypherText);
            var bytesPlainText = _csp.Decrypt(bytesCypherText, false);

            string output = System.Text.Encoding.Unicode.GetString(bytesPlainText);
            return output;
            
        }

        public string SignHash(string message,string hashFunctionName)
        {
            byte[] output;
            
                RSAPKCS1SignatureFormatter signatureFormatter = new RSAPKCS1SignatureFormatter();
                signatureFormatter.SetKey(_csp);
                signatureFormatter.SetHashAlgorithm(hashFunctionName);
                byte[] originalData = Convert.FromBase64String(message);
                
                output = signatureFormatter.CreateSignature(originalData);
            
            return Convert.ToBase64String(output);
        }
        public bool VerifyHash(string signedHash, string hashFunctionName,string hash)
        {
            
                RSAPKCS1SignatureDeformatter signatureDeformatter = new RSAPKCS1SignatureDeformatter(_csp);
                signatureDeformatter.SetHashAlgorithm(hashFunctionName);
                byte[] originalSignedHash = Convert.FromBase64String(signedHash);
                byte[] originalHash = Convert.FromBase64String(hash);
                //bool output = signatureDeformatter.VerifySignature(originalHash, originalSignedHash);
                
                bool output =_csp.VerifyHash(originalHash,CryptoConfig.MapNameToOID(hashFunctionName), originalSignedHash);
                return output;
            
           
            
        }
    }
}
