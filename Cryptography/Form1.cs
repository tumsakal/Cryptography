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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnmd5_Click(object sender, EventArgs e)
        {
            Hash h = new Hash(new MD5());
            txtHValue.Text = h.ComputeString(txtOText.Text);
        }

        private void btnsha384_Click(object sender, EventArgs e)
        {
            Hash h = new Hash(new SHA384());
            txtHValue.Text = h.ComputeString(txtOText.Text);
        }

        private void btnsha512_Click(object sender, EventArgs e)
        {
            Hash h = new Hash(new SHA512());
            txtHValue.Text = h.ComputeString(txtOText.Text);
        }

        private void btnsha256_Click(object sender, EventArgs e)
        {
            Hash h = new Hash(new SHA256());
            txtHValue.Text = h.ComputeString(txtOText.Text);
        }

        private void btnsha1_Click(object sender, EventArgs e)
        {
            Hash h = new Hash(new SHA1());
            txtHValue.Text = h.ComputeString(txtOText.Text);
        }

        private void btnRIPEMD160_Click(object sender, EventArgs e)
        {
            Hash h = new Hash(new RIPEMD160());
            txtHValue.Text = h.ComputeString(txtOText.Text);
        }
    }
}
