using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CryptoCore
{
    #region HashInterface
    public abstract class HashStrategy
    {
        public abstract string StringHashAlgorithm(string value);
        public abstract byte[] ByteHashAlgorithm(string value);
    }
    #endregion

    #region HMACHashInerface
    public abstract class HMACStrategy
    {
        public abstract string StringHashAlgorithm(string value, string key);
        public abstract byte[] ByteHashAlgorithm(string value, string key);
    }
    #endregion
    #region SymmetricInterface
    public abstract class SymmetricStrategy
    {
        public abstract string Password { set; }
        public abstract string EncrptStringAlgorithm(string plainText);
        public abstract string DecrptStringAlgorithm(string ciperText);
    }
    #endregion

}
