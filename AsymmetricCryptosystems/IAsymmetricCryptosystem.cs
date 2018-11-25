using System;
using System.Collections.Generic;
using System.Text;

namespace AsymmetricCryptosystems
{
    public interface IAsymmetricCryptosystem
    {
        string Encrypt(string plainText);
        string Decrypt(string cypherText);
        string PublicKeyToString();
        string PrivateKeyToString();
    }
}
