using System;
using Vigenere;

namespace CodeVigenere
{
    class Program
    {
        static void Main(string[] args)
        {
            var cryptor = new  CryptVigenere();

            cryptor.Encrypt("LEMON", "ATTACKATDAWN");
            cryptor.Decrypt("LEMON", "LXFOPVEFRNHR");
        }
    }
}
