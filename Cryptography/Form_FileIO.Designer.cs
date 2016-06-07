namespace Cryptography
{
    partial class Form_FileIO
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTextForWrite = new System.Windows.Forms.TextBox();
            this.btnWrite = new System.Windows.Forms.Button();
            this.txtTextAfterRead = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRead = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Text For Write";
            // 
            // txtTextForWrite
            // 
            this.txtTextForWrite.Location = new System.Drawing.Point(19, 31);
            this.txtTextForWrite.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTextForWrite.Multiline = true;
            this.txtTextForWrite.Name = "txtTextForWrite";
            this.txtTextForWrite.Size = new System.Drawing.Size(315, 77);
            this.txtTextForWrite.TabIndex = 1;
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(215, 5);
            this.btnWrite.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(119, 28);
            this.btnWrite.TabIndex = 2;
            this.btnWrite.Text = "Write";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // txtTextAfterRead
            // 
            this.txtTextAfterRead.Location = new System.Drawing.Point(19, 168);
            this.txtTextAfterRead.Margin = new System.Windows.Forms.Padding(4);
            this.txtTextAfterRead.Multiline = true;
            this.txtTextAfterRead.Name = "txtTextAfterRead";
            this.txtTextAfterRead.Size = new System.Drawing.Size(315, 77);
            this.txtTextAfterRead.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Text After Read";
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(215, 142);
            this.btnRead.Margin = new System.Windows.Forms.Padding(4);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(119, 28);
            this.btnRead.TabIndex = 5;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // Form_FileIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 301);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.txtTextAfterRead);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.txtTextForWrite);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_FileIO";
            this.Text = "Form_FileIO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTextForWrite;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.TextBox txtTextAfterRead;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRead;
    }
}