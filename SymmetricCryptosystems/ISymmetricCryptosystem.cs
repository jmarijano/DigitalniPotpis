using System;
using System.Collections.Generic;
using System.Text;

namespace SymmetricCryptosystems
{
    public interface ISymmetricCryptosystem
    {
        string Encrypt(string plainText);
        string Decrypt(string cypherText);
        string GetKey();
    }
}
