using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CryptoCore;

namespace Cryptography
{
    public partial class Form_Symmetric : Form
    {
        public Form_Symmetric()
        {
            InitializeComponent();
        }

        private void btnDecryptRijndael_Click(object sender, EventArgs e)
        {

            Symmetric sym = new Symmetric(CryptoFactory.GetSymmetricInstance("Rijndael", "12345678"));
            txtDecrypted.Text = sym.DecryptString(txtEncrypted.Text);
        }

        private void btnEncryptAES_Click(object sender, EventArgs e)
        {
            Symmetric sym = new Symmetric(CryptoFactory.GetSymmetricInstance("AES", "tumsakal_0963189366"));
            txtEncrypted.Text = sym.EncryptString(txtPlainText.Text.Trim());
        }

        private void btnDecryptAES_Click(object sender, EventArgs e)
        {
            Symmetric sym = new Symmetric(CryptoFactory.GetSymmetricInstance("AES", "tumsakal_0963189366"));
            txtDecrypted.Text = sym.DecryptString(txtEncrypted.Text);
        }

        private void btnEncryptDES_Click(object sender, EventArgs e)
        {
            Symmetric sym = new Symmetric(CryptoFactory.GetSymmetricInstance("DES", "12345678"));
            txtEncrypted.Text = sym.EncryptString(txtPlainText.Text.Trim());
        }

        private void btnDecryptDES_Click(object sender, EventArgs e)
        {
            Symmetric sym = new Symmetric(CryptoFactory.GetSymmetricInstance("DES", "12345678"));
            txtDecrypted.Text = sym.DecryptString(txtEncrypted.Text);
        }

        private void btnEncryptTripleDES_Click(object sender, EventArgs e)
        {
            Symmetric sym = new Symmetric(CryptoFactory.GetSymmetricInstance("TripleDES", "12345678"));
            txtEncrypted.Text = sym.EncryptString(txtPlainText.Text.Trim());
        }

        private void btnDecryptTripleDES_Click(object sender, EventArgs e)
        {
            Symmetric sym = new Symmetric(CryptoFactory.GetSymmetricInstance("TripleDES", "12345678"));
            txtDecrypted.Text = sym.DecryptString(txtEncrypted.Text);
        }

        private void btnEncryptRijndael_Click(object sender, EventArgs e)
        {
            Symmetric sym = new Symmetric(CryptoFactory.GetSymmetricInstance("Rijndael", "12345678"));
            txtEncrypted.Text = sym.EncryptString(txtPlainText.Text.Trim());
        }

        private void Form_Symmetric_Load(object sender, EventArgs e)
        {

        }
    }
}
