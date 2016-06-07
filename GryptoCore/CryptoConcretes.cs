using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace CryptoCore
{
    #region HashAlgorithmConrete
    /// <summary>
    /// 128 bits MD5 Algorithm Class.
    /// </summary>
    public sealed class MD5 : HashStrategy
    {
        public override byte[] ByteHashAlgorithm(string value)
        {
            System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] bytes = md5.ComputeHash(System.Text.ASCIIEncoding.UTF8.GetBytes(value));

            return bytes;
        }

        /// <summary>
        /// Compute and return hash value.
        /// </summary>
        /// <param name="value">The data for encryption.</param>
        /// <returns>String of 32 charactors</returns>
        public override string StringHashAlgorithm(string value)
        {
            System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] bytes = md5.ComputeHash(System.Text.ASCIIEncoding.UTF8.GetBytes(value));
            StringBuilder sb = new StringBuilder();
            foreach (var b in bytes)
            {
                sb.Append(b.ToString("x2"));
            }
            return sb.ToString();
        }
    }

    public sealed class SHA1 : HashStrategy
    {
        public override byte[] ByteHashAlgorithm(string value)
        {
            System.Security.Cryptography.SHA1 sha1 = System.Security.Cryptography.SHA1.Create();
            byte[] bytes = sha1.ComputeHash(System.Text.ASCIIEncoding.UTF8.GetBytes(value));
            return bytes;
        }

        public override string StringHashAlgorithm(string value)
        {
            System.Security.Cryptography.SHA1 sha1 = System.Security.Cryptography.SHA1.Create();
            byte[] bytes = sha1.ComputeHash(System.Text.ASCIIEncoding.UTF8.GetBytes(value));
            StringBuilder sb = new StringBuilder();
            foreach (var b in bytes)
            {
                sb.Append(b.ToString("x2"));
            }
            return sb.ToString();
        }
    }
    public sealed class SHA256 : HashStrategy
    {
        public override byte[] ByteHashAlgorithm(string value)
        {
            System.Security.Cryptography.SHA256 sha256 = System.Security.Cryptography.SHA256.Create();
            byte[] bytes = sha256.ComputeHash(System.Text.ASCIIEncoding.UTF8.GetBytes(value));
            return bytes;
        }

        public override string StringHashAlgorithm(string value)
        {
            System.Security.Cryptography.SHA256 sha256 = System.Security.Cryptography.SHA256.Create();
            byte[] bytes = sha256.ComputeHash(System.Text.ASCIIEncoding.UTF8.GetBytes(value));
            StringBuilder sb = new StringBuilder();
            foreach (var b in bytes)
            {
                sb.Append(b.ToString("x2"));
            }
            return sb.ToString();
        }
    }
    public sealed class SHA384 : HashStrategy
    {
        public override byte[] ByteHashAlgorithm(string value)
        {
            System.Security.Cryptography.SHA384 sha = System.Security.Cryptography.SHA384.Create();
            byte[] bytes = sha.ComputeHash(System.Text.ASCIIEncoding.UTF8.GetBytes(value));
            return bytes;
        }

        public override string StringHashAlgorithm(string value)
        {
            System.Security.Cryptography.SHA384 sha = System.Security.Cryptography.SHA384.Create();
            byte[] bytes = sha.ComputeHash(System.Text.ASCIIEncoding.UTF8.GetBytes(value));
            StringBuilder sb = new StringBuilder();
            foreach (var b in bytes)
            {
                sb.Append(b.ToString("x2"));
            }
            return sb.ToString();
        }
    }
    public sealed class SHA512 : HashStrategy
    {
        public override byte[] ByteHashAlgorithm(string value)
        {
            System.Security.Cryptography.SHA512 sha = System.Security.Cryptography.SHA512.Create();
            byte[] bytes = sha.ComputeHash(System.Text.ASCIIEncoding.UTF8.GetBytes(value));
            return bytes;
        }

        public override string StringHashAlgorithm(string value)
        {
            System.Security.Cryptography.SHA512 sha = System.Security.Cryptography.SHA512.Create();
            byte[] bytes = sha.ComputeHash(System.Text.ASCIIEncoding.UTF8.GetBytes(value));
            StringBuilder sb = new StringBuilder();
            foreach (var b in bytes)
            {
                sb.Append(b.ToString("x2"));
            }
            return sb.ToString();
        }
    }
    public sealed class RIPEMD160 : HashStrategy
    {
        public override byte[] ByteHashAlgorithm(string value)
        {
            System.Security.Cryptography.RIPEMD160 md5_160Bit = System.Security.Cryptography.RIPEMD160.Create();
            byte[] bytes = md5_160Bit.ComputeHash(System.Text.ASCIIEncoding.UTF8.GetBytes(value));
            return bytes;
        }

        public override string StringHashAlgorithm(string value)
        {
            System.Security.Cryptography.RIPEMD160 md5_160Bit = System.Security.Cryptography.RIPEMD160.Create();
            byte[] bytes = md5_160Bit.ComputeHash(System.Text.ASCIIEncoding.UTF8.GetBytes(value));
            StringBuilder sb = new StringBuilder();
            foreach (var b in bytes)
            {
                sb.Append(b.ToString("x2"));
            }
            return sb.ToString();
        }
    }

    #endregion

    #region HMACHashAlgorithmConcrete
    public sealed class HMD5 : HMACStrategy
    {
        public override byte[] ByteHashAlgorithm(string value, string key)
        {
            HMACMD5 hmd5 = new HMACMD5((System.Security.Cryptography.SHA1.Create()).ComputeHash(ASCIIEncoding.ASCII.GetBytes(key)));
            return hmd5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(value));
        }

        public override string StringHashAlgorithm(string value, string key)
        {
            HMACMD5 hmd5 = new HMACMD5((System.Security.Cryptography.SHA1.Create()).ComputeHash(ASCIIEncoding.ASCII.GetBytes(key)));
            byte[] b = this.ByteHashAlgorithm(value, key);
            StringBuilder sb = new StringBuilder();
            foreach (var c in b)
            {
                sb.Append(c.ToString("x2"));
            }
            return sb.ToString();
        }
    }

    public sealed class HSHA1 : HMACStrategy
    {
        public override byte[] ByteHashAlgorithm(string value, string key)
        {
            HMACSHA1 sha = new HMACSHA1((System.Security.Cryptography.SHA1.Create()).ComputeHash(ASCIIEncoding.ASCII.GetBytes(key)));
            return sha.ComputeHash(ASCIIEncoding.ASCII.GetBytes(value));
        }

        public override string StringHashAlgorithm(string value, string key)
        {
            byte[] b = this.ByteHashAlgorithm(value, key);
            StringBuilder sb = new StringBuilder();
            foreach (var c in b)
            {
                sb.Append(c.ToString("x2"));
            }
            return sb.ToString();
        }
    }
    public sealed class HSHA256 : HMACStrategy
    {
        public override byte[] ByteHashAlgorithm(string value, string key)
        {
            HMACSHA256 sha = new HMACSHA256((System.Security.Cryptography.SHA1.Create()).ComputeHash(ASCIIEncoding.ASCII.GetBytes(key)));
            return sha.ComputeHash(ASCIIEncoding.ASCII.GetBytes(value));
        }

        public override string StringHashAlgorithm(string value, string key)
        {
            byte[] b = this.ByteHashAlgorithm(value, key);
            StringBuilder sb = new StringBuilder();
            foreach (var c in b)
            {
                sb.Append(c.ToString("x2"));
            }
            return sb.ToString();
        }
    }
    public sealed class HSHA384 : HMACStrategy
    {
        public override byte[] ByteHashAlgorithm(string value, string key)
        {
            HMACSHA384 sha = new HMACSHA384((System.Security.Cryptography.SHA1.Create()).ComputeHash(ASCIIEncoding.ASCII.GetBytes(key)));
            return sha.ComputeHash(ASCIIEncoding.ASCII.GetBytes(value));
        }

        public override string StringHashAlgorithm(string value, string key)
        {
            byte[] b = this.ByteHashAlgorithm(value, key);
            StringBuilder sb = new StringBuilder();
            foreach (var c in b)
            {
                sb.Append(c.ToString("x2"));
            }
            return sb.ToString();
        }
    }
    public sealed class HSHA512 : HMACStrategy
    {
        public override byte[] ByteHashAlgorithm(string value, string key)
        {
            HMACSHA512 sha = new HMACSHA512((System.Security.Cryptography.SHA1.Create()).ComputeHash(ASCIIEncoding.ASCII.GetBytes(key)));
            return sha.ComputeHash(ASCIIEncoding.ASCII.GetBytes(value));
        }

        public override string StringHashAlgorithm(string value, string key)
        {
            byte[] b = this.ByteHashAlgorithm(value, key);
            StringBuilder sb = new StringBuilder();
            foreach (var c in b)
            {
                sb.Append(c.ToString("x2"));
            }
            return sb.ToString();
        }
    }
    public sealed class HRIPEMD160 : HMACStrategy
    {
        public override byte[] ByteHashAlgorithm(string value, string key)
        {
            HMACRIPEMD160 sha = new HMACRIPEMD160((System.Security.Cryptography.SHA1.Create()).ComputeHash(ASCIIEncoding.ASCII.GetBytes(key)));
            return sha.ComputeHash(ASCIIEncoding.ASCII.GetBytes(value));
        }

        public override string StringHashAlgorithm(string value, string key)
        {
            byte[] b = this.ByteHashAlgorithm(value, key);
            StringBuilder sb = new StringBuilder();
            foreach (var c in b)
            {
                sb.Append(c.ToString("x2"));
            }
            return sb.ToString();
        }
    }
    #endregion

    #region SymmetricAlgorithmConcrete
    public sealed class AES : SymmetricStrategy
    {
        private System.Security.Cryptography.Aes aes;

        public override string Password
        {
            set
            {
                if (value.Length > 0)
                {
                    Hash h = new Hash(new MD5());
                    byte[] bytes = h.ComputeBytes(value);
                    this.aes.Key = bytes;
                    this.aes.IV = bytes;
                }
                else
                {
                    throw new Exception("!!! 0 Length Password !!!");
                }
            }
        }
        public AES()
        {
            aes = System.Security.Cryptography.Aes.Create();
        }

        public override string DecrptStringAlgorithm(string ciperText)
        {
            string res = "";
            MemoryStream mem = new MemoryStream(Convert.FromBase64String(ciperText));
            CryptoStream cs = new CryptoStream(mem, this.aes.CreateDecryptor(), CryptoStreamMode.Read);
            using (StreamReader srd = new StreamReader(cs))
            {
                res = srd.ReadToEnd();
            }
            return res;
        }

        public override string EncrptStringAlgorithm(string plainText)
        {
            string res = "";
            MemoryStream mem = new MemoryStream();
            CryptoStream cs = new CryptoStream(mem, this.aes.CreateEncryptor(), CryptoStreamMode.Write);
            using (StreamWriter swr = new StreamWriter(cs))
            {
                swr.Write(plainText);
                swr.Flush();
                cs.FlushFinalBlock();
                res = Convert.ToBase64String(mem.ToArray());
            }
            return res;
        }
    }

    public sealed class DES : SymmetricStrategy
    {
        private System.Security.Cryptography.DES _des;
        /// <summary>
        /// 64bit or 8 charactor Password.
        /// </summary>
        public override string Password
        {
            set
            {
                if (value.Length == 8)
                {
                    byte[] bytes = Encoding.ASCII.GetBytes(value);
                    this._des.IV = bytes;
                    this._des.Key = bytes;
                }
                else if (value.Length == 0)
                {
                    throw new Exception("!!! Zero Length Password !!!");
                }
                else if (value.Length > 8)
                {
                    throw new Exception("!!! Password Content More Than 8 Charactor !!!");
                }
            }
        }
        public DES()
        {
            this._des = System.Security.Cryptography.DES.Create();
        }
        public override string DecrptStringAlgorithm(string ciperText)
        {
            string res = "";
            MemoryStream mem = new MemoryStream(Convert.FromBase64String(ciperText));
            CryptoStream cs = new CryptoStream(mem, this._des.CreateDecryptor(), CryptoStreamMode.Read);
            using (StreamReader srd = new StreamReader(cs))
            {
                res = srd.ReadToEnd();
            }
            return res;
        }

        public override string EncrptStringAlgorithm(string plainText)
        {
            string res = "";
            MemoryStream mem = new MemoryStream();
            CryptoStream cs = new CryptoStream(mem, this._des.CreateEncryptor(), CryptoStreamMode.Write);
            using (StreamWriter swr = new StreamWriter(cs))
            {
                swr.Write(plainText);
                swr.Flush();
                cs.FlushFinalBlock();
                res = Convert.ToBase64String(mem.ToArray());
            }
            return res;
        }
    }

    public sealed class TripleDES : SymmetricStrategy
    {
        private System.Security.Cryptography.TripleDES _trdes;
        public override string Password
        {
            set
            {
                if (value.Length != 0)
                {
                    Hash h = new Hash(new MD5());
                    byte[] bytes = h.ComputeBytes(value);
                    this._trdes.IV = Encoding.ASCII.GetBytes(value.Substring(0, 8));
                    this._trdes.Key = bytes;
                }
                else
                {
                    throw new Exception("!!! Zero Length Password !!!");
                }
            }
        }

        public TripleDES()
        {
            this._trdes = System.Security.Cryptography.TripleDES.Create();
        }
        public override string DecrptStringAlgorithm(string ciperText)
        {
            string res = "";
            MemoryStream mem = new MemoryStream(Convert.FromBase64String(ciperText));
            CryptoStream cs = new CryptoStream(mem, this._trdes.CreateDecryptor(), CryptoStreamMode.Read);
            using (StreamReader srd = new StreamReader(cs))
            {
                res = srd.ReadToEnd();
            }
            return res;
        }

        public override string EncrptStringAlgorithm(string plainText)
        {
            string res = "";
            MemoryStream mem = new MemoryStream();
            CryptoStream cs = new CryptoStream(mem, this._trdes.CreateEncryptor(), CryptoStreamMode.Write);
            using (StreamWriter swr = new StreamWriter(cs))
            {
                swr.Write(plainText);
                swr.Flush();
                cs.FlushFinalBlock();
                res = Convert.ToBase64String(mem.ToArray());
            }
            return res;
        }
    }

    public sealed class Rijndael : SymmetricStrategy
    {
        private System.Security.Cryptography.Rijndael _r;
        public override string Password
        {
            set
            {
                if (value.Length != 0)
                {
                    Hash h = new Hash(new MD5());
                    byte[] bytes = h.ComputeBytes(value);
                    this._r.IV = bytes;
                    this._r.Key = bytes;
                }
                else
                {
                    throw new Exception("!!! Zero Length Password !!!");
                }
            }
        }

        public Rijndael()
        {
            this._r = System.Security.Cryptography.Rijndael.Create();
        }
        public override string DecrptStringAlgorithm(string ciperText)
        {
            string res = "";
            MemoryStream mem = new MemoryStream(Convert.FromBase64String(ciperText));
            CryptoStream cs = new CryptoStream(mem, this._r.CreateDecryptor(), CryptoStreamMode.Read);
            using (StreamReader srd = new StreamReader(cs))
            {
                res = srd.ReadToEnd();
            }
            return res;
        }

        public override string EncrptStringAlgorithm(string plainText)
        {
            string res = "";
            MemoryStream mem = new MemoryStream();
            CryptoStream cs = new CryptoStream(mem, this._r.CreateEncryptor(), CryptoStreamMode.Write);
            using (StreamWriter swr = new StreamWriter(cs))
            {
                swr.Write(plainText);
                swr.Flush();
                cs.FlushFinalBlock();
                res = Convert.ToBase64String(mem.ToArray());
            }
            return res;
        }
    }
    #endregion
}