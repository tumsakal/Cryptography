namespace Cryptography
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btnmd5 = new System.Windows.Forms.Button();
            this.txtOText = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtHValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnsha1 = new System.Windows.Forms.Button();
            this.btnsha256 = new System.Windows.Forms.Button();
            this.btnsha384 = new System.Windows.Forms.Button();
            this.btnsha512 = new System.Windows.Forms.Button();
            this.btnRIPEMD160 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnmd5
            // 
            this.btnmd5.Location = new System.Drawing.Point(18, 74);
            this.btnmd5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnmd5.Name = "btnmd5";
            this.btnmd5.Size = new System.Drawing.Size(180, 35);
            this.btnmd5.TabIndex = 0;
            this.btnmd5.Text = "Compute MD5";
            this.btnmd5.UseVisualStyleBackColor = true;
            this.btnmd5.Click += new System.EventHandler(this.btnmd5_Click);
            // 
            // txtOText
            // 
            this.txtOText.Location = new System.Drawing.Point(18, 38);
            this.txtOText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOText.Name = "txtOText";
            this.txtOText.Size = new System.Drawing.Size(535, 26);
            this.txtOText.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtHValue
            // 
            this.txtHValue.Location = new System.Drawing.Point(18, 194);
            this.txtHValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHValue.Name = "txtHValue";
            this.txtHValue.Size = new System.Drawing.Size(535, 26);
            this.txtHValue.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Original Text";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 169);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hashed value";
            // 
            // btnsha1
            // 
            this.btnsha1.Location = new System.Drawing.Point(221, 74);
            this.btnsha1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnsha1.Name = "btnsha1";
            this.btnsha1.Size = new System.Drawing.Size(157, 35);
            this.btnsha1.TabIndex = 7;
            this.btnsha1.Text = "Compute SHA1";
            this.btnsha1.UseVisualStyleBackColor = true;
            this.btnsha1.Click += new System.EventHandler(this.btnsha1_Click);
            // 
            // btnsha256
            // 
            this.btnsha256.Location = new System.Drawing.Point(400, 74);
            this.btnsha256.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnsha256.Name = "btnsha256";
            this.btnsha256.Size = new System.Drawing.Size(153, 35);
            this.btnsha256.TabIndex = 8;
            this.btnsha256.Text = "Compute SHA256";
            this.btnsha256.UseVisualStyleBackColor = true;
            this.btnsha256.Click += new System.EventHandler(this.btnsha256_Click);
            // 
            // btnsha384
            // 
            this.btnsha384.Location = new System.Drawing.Point(221, 119);
            this.btnsha384.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnsha384.Name = "btnsha384";
            this.btnsha384.Size = new System.Drawing.Size(157, 35);
            this.btnsha384.TabIndex = 9;
            this.btnsha384.Text = "Compute SHA384";
            this.btnsha384.UseVisualStyleBackColor = true;
            this.btnsha384.Click += new System.EventHandler(this.btnsha384_Click);
            // 
            // btnsha512
            // 
            this.btnsha512.Location = new System.Drawing.Point(400, 119);
            this.btnsha512.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnsha512.Name = "btnsha512";
            this.btnsha512.Size = new System.Drawing.Size(153, 35);
            this.btnsha512.TabIndex = 10;
            this.btnsha512.Text = "Compute SHA512";
            this.btnsha512.UseVisualStyleBackColor = true;
            this.btnsha512.Click += new System.EventHandler(this.btnsha512_Click);
            // 
            // btnRIPEMD160
            // 
            this.btnRIPEMD160.Location = new System.Drawing.Point(18, 119);
            this.btnRIPEMD160.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRIPEMD160.Name = "btnRIPEMD160";
            this.btnRIPEMD160.Size = new System.Drawing.Size(180, 35);
            this.btnRIPEMD160.TabIndex = 11;
            this.btnRIPEMD160.Text = "Compute RIPEMD160";
            this.btnRIPEMD160.UseVisualStyleBackColor = true;
            this.btnRIPEMD160.Click += new System.EventHandler(this.btnRIPEMD160_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 245);
            this.Controls.Add(this.btnRIPEMD160);
            this.Controls.Add(this.btnsha512);
            this.Controls.Add(this.btnsha384);
            this.Controls.Add(this.btnsha256);
            this.Controls.Add(this.btnsha1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHValue);
            this.Controls.Add(this.txtOText);
            this.Controls.Add(this.btnmd5);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnmd5;
        private System.Windows.Forms.TextBox txtOText;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtHValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnsha1;
        private System.Windows.Forms.Button btnsha256;
        private System.Windows.Forms.Button btnsha384;
        private System.Windows.Forms.Button btnsha512;
        private System.Windows.Forms.Button btnRIPEMD160;
    }
}

