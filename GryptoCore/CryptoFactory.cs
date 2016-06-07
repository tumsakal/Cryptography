using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCore
{
    public static class CryptoFactory
    {
        public static SymmetricStrategy GetSymmetricInstance(string algorithm, string password)
        {
            SymmetricStrategy sym = null;
            switch (algorithm)
            {
                case "AES":
                    sym = new AES() { Password = password };
                    break;
                case "DES":
                    sym = new DES() { Password = password };
                    break;
                case "TripleDES":
                    sym = new TripleDES() { Password = password };
                    break;
                case "Rijndael":
                    sym = new Rijndael() { Password = password };
                    break;
                default: throw new Exception("!!! Wrong Algorithm !!!");
            }
            return sym;
        }
    }
}
