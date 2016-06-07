using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FileIO;

namespace Cryptography
{
    public partial class Form_FileIO : Form
    {
        FileHelper f = new FileHelper("data.txt");
        public Form_FileIO()
        {
            InitializeComponent();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            f.WriteString(txtTextForWrite.Text, true);
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            txtTextAfterRead.Text = f.ReadString(true);
        }
    }
}
