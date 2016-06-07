using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CryptoCore;
using System.Reflection;
using System.IO;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace FileIO
{
    public class FileHelper
    {
        public string FileName { get; set; }
        string cryptdll = @"CryptoCore.dll";
        public FileHelper(string filename)
        {
            if (filename.Length != 0)
                this.FileName = filename;
            else throw new Exception("file name and location is invalid");
            AppDomain.CurrentDomain.AssemblyResolve += (s, e) =>
            {
                string res = Assembly.GetExecutingAssembly().GetManifestResourceNames().Where(x => x.Contains(Path.GetFileName(cryptdll))).FirstOrDefault();
                Assembly ass = Assembly.GetExecutingAssembly();
                byte[] rawDll;
                using (Stream str = ass.GetManifestResourceStream(res))
                {
                    rawDll = new byte[(int)str.Length];
                    str.Read(rawDll, 0, (int)str.Length);
                    return Assembly.Load(rawDll);
                }

            };
        }
        public void WriteString(string data, bool withEncrypt = false, string algorithm = "AES", string password = "12345678")
        {
            using (FileStream fs = new FileStream(this.FileName, FileMode.OpenOrCreate, FileAccess.Write))
            using (StreamWriter swr = new StreamWriter(fs))
            {
                if (withEncrypt)
                {
                    Symmetric sym = new Symmetric(CryptoFactory.GetSymmetricInstance(algorithm, password));
                    swr.Write(sym.EncryptString(data));
                    swr.Flush();
                }
                else
                {
                    swr.Write(data);
                    swr.Flush();
                }
            }
        }
        public string ReadString(bool withEncrypt = false, string algorithm = "AES", string password = "12345678")
        {
            string data = "";
            using (FileStream fs = new FileStream(this.FileName, FileMode.Open, FileAccess.Read))
            using (StreamReader srd = new StreamReader(fs))
            {
                if (withEncrypt)
                {
                    Symmetric sym = new Symmetric(CryptoFactory.GetSymmetricInstance(algorithm, password));
                    data = sym.DecryptString(srd.ReadToEnd());
                }
                else
                {
                    data = srd.ReadToEnd();
                }
            }
            return data;
        }
    }

}
