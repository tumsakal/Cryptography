namespace Cryptography
{
    partial class Form_Symmetric
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label5 = new System.Windows.Forms.Label();
            this.txtDecrypted = new System.Windows.Forms.TextBox();
            this.btnDecryptAES = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEncrypted = new System.Windows.Forms.TextBox();
            this.txtPlainText = new System.Windows.Forms.TextBox();
            this.btnEncryptAES = new System.Windows.Forms.Button();
            this.btnDecryptDES = new System.Windows.Forms.Button();
            this.btnEncryptDES = new System.Windows.Forms.Button();
            this.btnDecryptTripleDES = new System.Windows.Forms.Button();
            this.btnEncryptTripleDES = new System.Windows.Forms.Button();
            this.btnDecryptRijndael = new System.Windows.Forms.Button();
            this.btnEncryptRijndael = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 243);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Decrypted Text";
            // 
            // txtDecrypted
            // 
            this.txtDecrypted.Location = new System.Drawing.Point(11, 265);
            this.txtDecrypted.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDecrypted.Multiline = true;
            this.txtDecrypted.Name = "txtDecrypted";
            this.txtDecrypted.Size = new System.Drawing.Size(573, 68);
            this.txtDecrypted.TabIndex = 21;
            // 
            // btnDecryptAES
            // 
            this.btnDecryptAES.Location = new System.Drawing.Point(11, 213);
            this.btnDecryptAES.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDecryptAES.Name = "btnDecryptAES";
            this.btnDecryptAES.Size = new System.Drawing.Size(130, 28);
            this.btnDecryptAES.TabIndex = 20;
            this.btnDecryptAES.Text = "Decrypt AES";
            this.btnDecryptAES.UseVisualStyleBackColor = true;
            this.btnDecryptAES.Click += new System.EventHandler(this.btnDecryptAES_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Encrypted Text";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 7);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "PlainText";
            // 
            // txtEncrypted
            // 
            this.txtEncrypted.Location = new System.Drawing.Point(9, 149);
            this.txtEncrypted.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEncrypted.Name = "txtEncrypted";
            this.txtEncrypted.Size = new System.Drawing.Size(575, 26);
            this.txtEncrypted.TabIndex = 17;
            // 
            // txtPlainText
            // 
            this.txtPlainText.Location = new System.Drawing.Point(13, 34);
            this.txtPlainText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPlainText.Name = "txtPlainText";
            this.txtPlainText.Size = new System.Drawing.Size(573, 26);
            this.txtPlainText.TabIndex = 16;
            // 
            // btnEncryptAES
            // 
            this.btnEncryptAES.Location = new System.Drawing.Point(14, 64);
            this.btnEncryptAES.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEncryptAES.Name = "btnEncryptAES";
            this.btnEncryptAES.Size = new System.Drawing.Size(127, 28);
            this.btnEncryptAES.TabIndex = 15;
            this.btnEncryptAES.Text = "Encrypt AES";
            this.btnEncryptAES.UseVisualStyleBackColor = true;
            this.btnEncryptAES.Click += new System.EventHandler(this.btnEncryptAES_Click);
            // 
            // btnDecryptDES
            // 
            this.btnDecryptDES.Location = new System.Drawing.Point(145, 213);
            this.btnDecryptDES.Margin = new System.Windows.Forms.Padding(2);
            this.btnDecryptDES.Name = "btnDecryptDES";
            this.btnDecryptDES.Size = new System.Drawing.Size(127, 28);
            this.btnDecryptDES.TabIndex = 24;
            this.btnDecryptDES.Text = "Decrypt DES";
            this.btnDecryptDES.UseVisualStyleBackColor = true;
            this.btnDecryptDES.Click += new System.EventHandler(this.btnDecryptDES_Click);
            // 
            // btnEncryptDES
            // 
            this.btnEncryptDES.Location = new System.Drawing.Point(145, 64);
            this.btnEncryptDES.Margin = new System.Windows.Forms.Padding(2);
            this.btnEncryptDES.Name = "btnEncryptDES";
            this.btnEncryptDES.Size = new System.Drawing.Size(127, 28);
            this.btnEncryptDES.TabIndex = 23;
            this.btnEncryptDES.Text = "Encrypt DES";
            this.btnEncryptDES.UseVisualStyleBackColor = true;
            this.btnEncryptDES.Click += new System.EventHandler(this.btnEncryptDES_Click);
            // 
            // btnDecryptTripleDES
            // 
            this.btnDecryptTripleDES.Location = new System.Drawing.Point(276, 213);
            this.btnDecryptTripleDES.Margin = new System.Windows.Forms.Padding(2);
            this.btnDecryptTripleDES.Name = "btnDecryptTripleDES";
            this.btnDecryptTripleDES.Size = new System.Drawing.Size(163, 28);
            this.btnDecryptTripleDES.TabIndex = 26;
            this.btnDecryptTripleDES.Text = "Decrypt TripleDES";
            this.btnDecryptTripleDES.UseVisualStyleBackColor = true;
            this.btnDecryptTripleDES.Click += new System.EventHandler(this.btnDecryptTripleDES_Click);
            // 
            // btnEncryptTripleDES
            // 
            this.btnEncryptTripleDES.Location = new System.Drawing.Point(276, 64);
            this.btnEncryptTripleDES.Margin = new System.Windows.Forms.Padding(2);
            this.btnEncryptTripleDES.Name = "btnEncryptTripleDES";
            this.btnEncryptTripleDES.Size = new System.Drawing.Size(163, 28);
            this.btnEncryptTripleDES.TabIndex = 25;
            this.btnEncryptTripleDES.Text = "Encrypt TripleDES";
            this.btnEncryptTripleDES.UseVisualStyleBackColor = true;
            this.btnEncryptTripleDES.Click += new System.EventHandler(this.btnEncryptTripleDES_Click);
            // 
            // btnDecryptRijndael
            // 
            this.btnDecryptRijndael.Location = new System.Drawing.Point(447, 213);
            this.btnDecryptRijndael.Margin = new System.Windows.Forms.Padding(2);
            this.btnDecryptRijndael.Name = "btnDecryptRijndael";
            this.btnDecryptRijndael.Size = new System.Drawing.Size(140, 28);
            this.btnDecryptRijndael.TabIndex = 28;
            this.btnDecryptRijndael.Text = "Decrypt Rijndael";
            this.btnDecryptRijndael.UseVisualStyleBackColor = true;
            this.btnDecryptRijndael.Click += new System.EventHandler(this.btnDecryptRijndael_Click);
            // 
            // btnEncryptRijndael
            // 
            this.btnEncryptRijndael.Location = new System.Drawing.Point(446, 64);
            this.btnEncryptRijndael.Margin = new System.Windows.Forms.Padding(2);
            this.btnEncryptRijndael.Name = "btnEncryptRijndael";
            this.btnEncryptRijndael.Size = new System.Drawing.Size(140, 28);
            this.btnEncryptRijndael.TabIndex = 27;
            this.btnEncryptRijndael.Text = "Encrypt Rijndael";
            this.btnEncryptRijndael.UseVisualStyleBackColor = true;
            this.btnEncryptRijndael.Click += new System.EventHandler(this.btnEncryptRijndael_Click);
            // 
            // Form_Symmetric
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 352);
            this.Controls.Add(this.btnDecryptRijndael);
            this.Controls.Add(this.btnEncryptRijndael);
            this.Controls.Add(this.btnDecryptTripleDES);
            this.Controls.Add(this.btnEncryptTripleDES);
            this.Controls.Add(this.btnDecryptDES);
            this.Controls.Add(this.btnEncryptDES);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDecrypted);
            this.Controls.Add(this.btnDecryptAES);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEncrypted);
            this.Controls.Add(this.txtPlainText);
            this.Controls.Add(this.btnEncryptAES);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form_Symmetric";
            this.Text = "Form_Symmetric";
            this.Load += new System.EventHandler(this.Form_Symmetric_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDecrypted;
        private System.Windows.Forms.Button btnDecryptAES;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEncrypted;
        private System.Windows.Forms.TextBox txtPlainText;
        private System.Windows.Forms.Button btnEncryptAES;
        private System.Windows.Forms.Button btnDecryptDES;
        private System.Windows.Forms.Button btnEncryptDES;
        private System.Windows.Forms.Button btnDecryptTripleDES;
        private System.Windows.Forms.Button btnEncryptTripleDES;
        private System.Windows.Forms.Button btnDecryptRijndael;
        private System.Windows.Forms.Button btnEncryptRijndael;
    }
}