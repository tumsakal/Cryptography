using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCore
{
    #region HashContext
    public sealed class Hash
    {
        private HashStrategy hashStrategy;
        public Hash(HashStrategy hashStrategy)
        {
            this.hashStrategy = hashStrategy;
        }
        /// <summary>
        /// Encrypt and return a string depend on specific algorithm.
        /// </summary>
        /// <param name="value">The data you want to encrypt.</param>
        /// <returns>String of 32 bit charactor.</returns>
        public string ComputeString(string value) => this.hashStrategy.StringHashAlgorithm(value);
        public byte[] ComputeBytes(string value) => this.hashStrategy.ByteHashAlgorithm(value);
    }
    #endregion
    #region HMACHash
    public sealed class HMAC
    {
        private HMACStrategy hmacStrategy;
        public HMAC(HMACStrategy hmacStrategy)
        {
            this.hmacStrategy = hmacStrategy;
        }
        public string ComputerString(string value, string key) => this.hmacStrategy.StringHashAlgorithm(value, key);
        public Byte[] ComputerByte(string value, string key) => this.hmacStrategy.ByteHashAlgorithm(value, key);
    }
    #endregion
    #region SymmetricContext
    public sealed class Symmetric
    {
        private SymmetricStrategy symmetricStrategy;
        public Symmetric(SymmetricStrategy symmetricStrategy)
        {
            this.symmetricStrategy = symmetricStrategy;
        }
        public string EncryptString(string plainText) => this.symmetricStrategy.EncrptStringAlgorithm(plainText);
        public string DecryptString(string ciperText) => this.symmetricStrategy.DecrptStringAlgorithm(ciperText);
    }
    #endregion
}
