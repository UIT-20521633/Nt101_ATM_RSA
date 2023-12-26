namespace RSA
{
    partial class HaskCheck
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HaskCheck));
            this.btResetCheck = new System.Windows.Forms.Button();
            this.txtSHA1 = new System.Windows.Forms.TextBox();
            this.txtSHA256 = new System.Windows.Forms.TextBox();
            this.txtMD5 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lable12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btCheck = new System.Windows.Forms.Button();
            this.txtFileCheck = new System.Windows.Forms.TextBox();
            this.btOpenFile = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCheck1 = new System.Windows.Forms.TextBox();
            this.txtCheck2 = new System.Windows.Forms.TextBox();
            this.txtCheck3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btResetCheck
            // 
            this.btResetCheck.BackColor = System.Drawing.Color.LemonChiffon;
            this.btResetCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btResetCheck.ForeColor = System.Drawing.Color.Black;
            this.btResetCheck.Location = new System.Drawing.Point(592, 355);
            this.btResetCheck.Margin = new System.Windows.Forms.Padding(4);
            this.btResetCheck.Name = "btResetCheck";
            this.btResetCheck.Size = new System.Drawing.Size(100, 28);
            this.btResetCheck.TabIndex = 66;
            this.btResetCheck.Text = "Cài lại";
            this.btResetCheck.UseVisualStyleBackColor = false;
            this.btResetCheck.Click += new System.EventHandler(this.btResetCheck_Click);
            // 
            // txtSHA1
            // 
            this.txtSHA1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSHA1.ForeColor = System.Drawing.Color.Black;
            this.txtSHA1.Location = new System.Drawing.Point(186, 257);
            this.txtSHA1.Margin = new System.Windows.Forms.Padding(4);
            this.txtSHA1.Name = "txtSHA1";
            this.txtSHA1.Size = new System.Drawing.Size(369, 26);
            this.txtSHA1.TabIndex = 65;
            // 
            // txtSHA256
            // 
            this.txtSHA256.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSHA256.ForeColor = System.Drawing.Color.Black;
            this.txtSHA256.Location = new System.Drawing.Point(186, 296);
            this.txtSHA256.Margin = new System.Windows.Forms.Padding(4);
            this.txtSHA256.Name = "txtSHA256";
            this.txtSHA256.Size = new System.Drawing.Size(369, 26);
            this.txtSHA256.TabIndex = 64;
            // 
            // txtMD5
            // 
            this.txtMD5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMD5.ForeColor = System.Drawing.Color.Black;
            this.txtMD5.Location = new System.Drawing.Point(186, 218);
            this.txtMD5.Margin = new System.Windows.Forms.Padding(4);
            this.txtMD5.Name = "txtMD5";
            this.txtMD5.Size = new System.Drawing.Size(369, 26);
            this.txtMD5.TabIndex = 63;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label12.Location = new System.Drawing.Point(213, 176);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 16);
            this.label12.TabIndex = 62;
            // 
            // lable12
            // 
            this.lable12.AutoSize = true;
            this.lable12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable12.ForeColor = System.Drawing.Color.Black;
            this.lable12.Location = new System.Drawing.Point(108, 299);
            this.lable12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lable12.Name = "lable12";
            this.lable12.Size = new System.Drawing.Size(70, 20);
            this.lable12.TabIndex = 61;
            this.lable12.Text = "SHA256";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(108, 260);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 20);
            this.label11.TabIndex = 60;
            this.label11.Text = "SHA1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(108, 224);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 20);
            this.label10.TabIndex = 59;
            this.label10.Text = "MD5";
            // 
            // btCheck
            // 
            this.btCheck.BackColor = System.Drawing.Color.RoyalBlue;
            this.btCheck.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCheck.ForeColor = System.Drawing.Color.White;
            this.btCheck.Location = new System.Drawing.Point(592, 174);
            this.btCheck.Margin = new System.Windows.Forms.Padding(4);
            this.btCheck.Name = "btCheck";
            this.btCheck.Size = new System.Drawing.Size(100, 32);
            this.btCheck.TabIndex = 58;
            this.btCheck.Text = "Kiểm tra";
            this.btCheck.UseVisualStyleBackColor = false;
            this.btCheck.Click += new System.EventHandler(this.btCheck_Click);
            // 
            // txtFileCheck
            // 
            this.txtFileCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileCheck.ForeColor = System.Drawing.Color.Black;
            this.txtFileCheck.Location = new System.Drawing.Point(186, 178);
            this.txtFileCheck.Margin = new System.Windows.Forms.Padding(4);
            this.txtFileCheck.Name = "txtFileCheck";
            this.txtFileCheck.Size = new System.Drawing.Size(270, 26);
            this.txtFileCheck.TabIndex = 57;
            // 
            // btOpenFile
            // 
            this.btOpenFile.BackColor = System.Drawing.Color.RoyalBlue;
            this.btOpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btOpenFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOpenFile.ForeColor = System.Drawing.Color.White;
            this.btOpenFile.Location = new System.Drawing.Point(477, 174);
            this.btOpenFile.Margin = new System.Windows.Forms.Padding(4);
            this.btOpenFile.Name = "btOpenFile";
            this.btOpenFile.Size = new System.Drawing.Size(100, 30);
            this.btOpenFile.TabIndex = 56;
            this.btOpenFile.Text = "Mở ";
            this.btOpenFile.UseVisualStyleBackColor = false;
            this.btOpenFile.Click += new System.EventHandler(this.btOpenFile_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(108, 186);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 20);
            this.label9.TabIndex = 55;
            this.label9.Text = "File";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(308, 127);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 28);
            this.label8.TabIndex = 54;
            this.label8.Text = "HASH Check";
            // 
            // txtCheck1
            // 
            this.txtCheck1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCheck1.ForeColor = System.Drawing.Color.Black;
            this.txtCheck1.Location = new System.Drawing.Point(592, 218);
            this.txtCheck1.Margin = new System.Windows.Forms.Padding(4);
            this.txtCheck1.Name = "txtCheck1";
            this.txtCheck1.Size = new System.Drawing.Size(100, 26);
            this.txtCheck1.TabIndex = 67;
            // 
            // txtCheck2
            // 
            this.txtCheck2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCheck2.ForeColor = System.Drawing.Color.Black;
            this.txtCheck2.Location = new System.Drawing.Point(592, 257);
            this.txtCheck2.Margin = new System.Windows.Forms.Padding(4);
            this.txtCheck2.Name = "txtCheck2";
            this.txtCheck2.Size = new System.Drawing.Size(100, 26);
            this.txtCheck2.TabIndex = 68;
            // 
            // txtCheck3
            // 
            this.txtCheck3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCheck3.ForeColor = System.Drawing.Color.Black;
            this.txtCheck3.Location = new System.Drawing.Point(592, 299);
            this.txtCheck3.Margin = new System.Windows.Forms.Padding(4);
            this.txtCheck3.Name = "txtCheck3";
            this.txtCheck3.Size = new System.Drawing.Size(100, 26);
            this.txtCheck3.TabIndex = 69;
            // 
            // HaskCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCheck3);
            this.Controls.Add(this.txtCheck2);
            this.Controls.Add(this.txtCheck1);
            this.Controls.Add(this.btResetCheck);
            this.Controls.Add(this.txtSHA1);
            this.Controls.Add(this.txtSHA256);
            this.Controls.Add(this.txtMD5);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lable12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btCheck);
            this.Controls.Add(this.txtFileCheck);
            this.Controls.Add(this.btOpenFile);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Name = "HaskCheck";
            this.Text = "Hask Check";
            this.Load += new System.EventHandler(this.HaskCheck_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btResetCheck;
        private System.Windows.Forms.TextBox txtSHA1;
        private System.Windows.Forms.TextBox txtSHA256;
        private System.Windows.Forms.TextBox txtMD5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lable12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btCheck;
        private System.Windows.Forms.TextBox txtFileCheck;
        private System.Windows.Forms.Button btOpenFile;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCheck1;
        private System.Windows.Forms.TextBox txtCheck2;
        private System.Windows.Forms.TextBox txtCheck3;
    }
}