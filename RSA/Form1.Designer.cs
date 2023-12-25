namespace RSA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbProcess = new System.Windows.Forms.Label();
            this.txtInformation = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnShowResult = new System.Windows.Forms.Button();
            this.btnCheckHashValue = new System.Windows.Forms.Button();
            this.btnOpenFolderOutput = new System.Windows.Forms.Button();
            this.btnSelectFolderOutput = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.btnSelectFolderInput = new System.Windows.Forms.Button();
            this.pgbProcess = new System.Windows.Forms.ProgressBar();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSelectFileInput = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtE = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.cbShow = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrivate = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtPublic = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbKeyLength = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnOpenXML = new System.Windows.Forms.Button();
            this.txtKeyFileXML = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lbProcess);
            this.panel2.Controls.Add(this.txtInformation);
            this.panel2.Controls.Add(this.btnReset);
            this.panel2.Controls.Add(this.btnShowResult);
            this.panel2.Controls.Add(this.btnCheckHashValue);
            this.panel2.Controls.Add(this.btnOpenFolderOutput);
            this.panel2.Controls.Add(this.btnSelectFolderOutput);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.btnSelectFolderInput);
            this.panel2.Controls.Add(this.pgbProcess);
            this.panel2.Controls.Add(this.btnDecrypt);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnEncrypt);
            this.panel2.Controls.Add(this.txtOutput);
            this.panel2.Controls.Add(this.txtInput);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnSelectFileInput);
            this.panel2.Location = new System.Drawing.Point(867, 116);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(784, 653);
            this.panel2.TabIndex = 2;
            // 
            // lbProcess
            // 
            this.lbProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbProcess.Location = new System.Drawing.Point(341, 250);
            this.lbProcess.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbProcess.Name = "lbProcess";
            this.lbProcess.Size = new System.Drawing.Size(419, 44);
            this.lbProcess.TabIndex = 21;
            // 
            // txtInformation
            // 
            this.txtInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInformation.ForeColor = System.Drawing.Color.Black;
            this.txtInformation.Location = new System.Drawing.Point(39, 309);
            this.txtInformation.Margin = new System.Windows.Forms.Padding(4);
            this.txtInformation.Multiline = true;
            this.txtInformation.Name = "txtInformation";
            this.txtInformation.Size = new System.Drawing.Size(721, 268);
            this.txtInformation.TabIndex = 20;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(328, 595);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(172, 43);
            this.btnReset.TabIndex = 19;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnShowResult
            // 
            this.btnShowResult.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnShowResult.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnShowResult.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShowResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowResult.ForeColor = System.Drawing.Color.White;
            this.btnShowResult.Location = new System.Drawing.Point(549, 595);
            this.btnShowResult.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowResult.Name = "btnShowResult";
            this.btnShowResult.Size = new System.Drawing.Size(211, 42);
            this.btnShowResult.TabIndex = 18;
            this.btnShowResult.Text = "Xuất kết quả";
            this.btnShowResult.UseVisualStyleBackColor = false;
            this.btnShowResult.Click += new System.EventHandler(this.btnShowResult_Click);
            // 
            // btnCheckHashValue
            // 
            this.btnCheckHashValue.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCheckHashValue.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnCheckHashValue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCheckHashValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckHashValue.ForeColor = System.Drawing.Color.White;
            this.btnCheckHashValue.Location = new System.Drawing.Point(39, 596);
            this.btnCheckHashValue.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheckHashValue.Name = "btnCheckHashValue";
            this.btnCheckHashValue.Size = new System.Drawing.Size(237, 42);
            this.btnCheckHashValue.TabIndex = 17;
            this.btnCheckHashValue.Text = "Kiểm tra giá trị băm";
            this.btnCheckHashValue.UseVisualStyleBackColor = false;
            this.btnCheckHashValue.Click += new System.EventHandler(this.btnCheckHashValue_Click);
            // 
            // btnOpenFolderOutput
            // 
            this.btnOpenFolderOutput.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnOpenFolderOutput.FlatAppearance.BorderSize = 0;
            this.btnOpenFolderOutput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenFolderOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenFolderOutput.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnOpenFolderOutput.Location = new System.Drawing.Point(631, 123);
            this.btnOpenFolderOutput.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpenFolderOutput.Name = "btnOpenFolderOutput";
            this.btnOpenFolderOutput.Size = new System.Drawing.Size(129, 28);
            this.btnOpenFolderOutput.TabIndex = 16;
            this.btnOpenFolderOutput.Text = "Mở Folder";
            this.btnOpenFolderOutput.UseVisualStyleBackColor = false;
            this.btnOpenFolderOutput.Click += new System.EventHandler(this.btnOpenFolderOutput_Click);
            // 
            // btnSelectFolderOutput
            // 
            this.btnSelectFolderOutput.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSelectFolderOutput.FlatAppearance.BorderSize = 0;
            this.btnSelectFolderOutput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectFolderOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectFolderOutput.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnSelectFolderOutput.Location = new System.Drawing.Point(631, 159);
            this.btnSelectFolderOutput.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectFolderOutput.Name = "btnSelectFolderOutput";
            this.btnSelectFolderOutput.Size = new System.Drawing.Size(129, 28);
            this.btnSelectFolderOutput.TabIndex = 15;
            this.btnSelectFolderOutput.Text = "Chọn Folder";
            this.btnSelectFolderOutput.UseVisualStyleBackColor = false;
            this.btnSelectFolderOutput.Click += new System.EventHandler(this.btnSelectFolderOutput_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Maroon;
            this.label14.Location = new System.Drawing.Point(298, 12);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(202, 28);
            this.label14.TabIndex = 14;
            this.label14.Text = "Mã hóa và Giải mã";
            // 
            // btnSelectFolderInput
            // 
            this.btnSelectFolderInput.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSelectFolderInput.FlatAppearance.BorderSize = 0;
            this.btnSelectFolderInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectFolderInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectFolderInput.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnSelectFolderInput.Location = new System.Drawing.Point(631, 81);
            this.btnSelectFolderInput.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectFolderInput.Name = "btnSelectFolderInput";
            this.btnSelectFolderInput.Size = new System.Drawing.Size(129, 28);
            this.btnSelectFolderInput.TabIndex = 12;
            this.btnSelectFolderInput.Text = "Chọn Folder";
            this.btnSelectFolderInput.UseVisualStyleBackColor = false;
            this.btnSelectFolderInput.Click += new System.EventHandler(this.btnSelectFolderInput_Click);
            // 
            // pgbProcess
            // 
            this.pgbProcess.BackColor = System.Drawing.SystemColors.Window;
            this.pgbProcess.ForeColor = System.Drawing.Color.Black;
            this.pgbProcess.Location = new System.Drawing.Point(341, 218);
            this.pgbProcess.Margin = new System.Windows.Forms.Padding(4);
            this.pgbProcess.Name = "pgbProcess";
            this.pgbProcess.Size = new System.Drawing.Size(419, 28);
            this.pgbProcess.TabIndex = 9;
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDecrypt.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecrypt.ForeColor = System.Drawing.Color.White;
            this.btnDecrypt.Location = new System.Drawing.Point(182, 218);
            this.btnDecrypt.Margin = new System.Windows.Forms.Padding(4);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(133, 43);
            this.btnDecrypt.TabIndex = 11;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = false;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(19, 146);
            this.label4.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "OUTPUT:";
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEncrypt.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncrypt.ForeColor = System.Drawing.Color.White;
            this.btnEncrypt.Location = new System.Drawing.Point(39, 219);
            this.btnEncrypt.Margin = new System.Windows.Forms.Padding(4);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(123, 42);
            this.btnEncrypt.TabIndex = 10;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = false;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.ForeColor = System.Drawing.Color.Black;
            this.txtOutput.Location = new System.Drawing.Point(119, 143);
            this.txtOutput.Margin = new System.Windows.Forms.Padding(4);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(504, 28);
            this.txtOutput.TabIndex = 7;
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.ForeColor = System.Drawing.Color.Black;
            this.txtInput.Location = new System.Drawing.Point(119, 75);
            this.txtInput.Margin = new System.Windows.Forms.Padding(4);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(504, 28);
            this.txtInput.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(19, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "INPUT:";
            // 
            // btnSelectFileInput
            // 
            this.btnSelectFileInput.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSelectFileInput.FlatAppearance.BorderSize = 0;
            this.btnSelectFileInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectFileInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectFileInput.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnSelectFileInput.Location = new System.Drawing.Point(631, 45);
            this.btnSelectFileInput.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectFileInput.Name = "btnSelectFileInput";
            this.btnSelectFileInput.Size = new System.Drawing.Size(129, 28);
            this.btnSelectFileInput.TabIndex = 0;
            this.btnSelectFileInput.Text = "Chọn File";
            this.btnSelectFileInput.UseVisualStyleBackColor = false;
            this.btnSelectFileInput.Click += new System.EventHandler(this.btnSelectFileInput_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel5.Location = new System.Drawing.Point(223, 13);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(467, 95);
            this.panel5.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightBlue;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.txtE);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.cbShow);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txtPrivate);
            this.panel3.Controls.Add(this.flowLayoutPanel3);
            this.panel3.Controls.Add(this.flowLayoutPanel4);
            this.panel3.Controls.Add(this.txtPublic);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.txtN);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.cbKeyLength);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.btnGenerate);
            this.panel3.Controls.Add(this.btnOpenXML);
            this.panel3.Controls.Add(this.txtKeyFileXML);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Location = new System.Drawing.Point(96, 116);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(752, 653);
            this.panel3.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = global::RSA.Properties.Resources.hinh_nen_avatar_con_rong;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(232, 203);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(290, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // txtE
            // 
            this.txtE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtE.ForeColor = System.Drawing.Color.Black;
            this.txtE.Location = new System.Drawing.Point(164, 505);
            this.txtE.Margin = new System.Windows.Forms.Padding(4);
            this.txtE.Name = "txtE";
            this.txtE.Size = new System.Drawing.Size(564, 26);
            this.txtE.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(9, 505);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 24);
            this.label1.TabIndex = 22;
            this.label1.Text = "Exponent (e):";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(9, 413);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(79, 24);
            this.label18.TabIndex = 21;
            this.label18.Text = "Hiển thị:";
            // 
            // cbShow
            // 
            this.cbShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbShow.ForeColor = System.Drawing.Color.Black;
            this.cbShow.FormattingEnabled = true;
            this.cbShow.Items.AddRange(new object[] {
            "XML",
            "Hex",
            "Byte array"});
            this.cbShow.Location = new System.Drawing.Point(164, 409);
            this.cbShow.Margin = new System.Windows.Forms.Padding(4);
            this.cbShow.Name = "cbShow";
            this.cbShow.Size = new System.Drawing.Size(160, 30);
            this.cbShow.TabIndex = 20;
            this.cbShow.SelectedIndexChanged += new System.EventHandler(this.cbShow_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(9, 597);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 24);
            this.label7.TabIndex = 18;
            this.label7.Text = "Khóa bí mật:";
            // 
            // txtPrivate
            // 
            this.txtPrivate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrivate.ForeColor = System.Drawing.Color.Black;
            this.txtPrivate.Location = new System.Drawing.Point(164, 597);
            this.txtPrivate.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrivate.Name = "txtPrivate";
            this.txtPrivate.Size = new System.Drawing.Size(564, 26);
            this.txtPrivate.TabIndex = 17;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("flowLayoutPanel3.BackgroundImage")));
            this.flowLayoutPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(556, 203);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(172, 156);
            this.flowLayoutPanel3.TabIndex = 16;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("flowLayoutPanel4.BackgroundImage")));
            this.flowLayoutPanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(18, 203);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(172, 156);
            this.flowLayoutPanel4.TabIndex = 15;
            // 
            // txtPublic
            // 
            this.txtPublic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPublic.ForeColor = System.Drawing.Color.Black;
            this.txtPublic.Location = new System.Drawing.Point(164, 551);
            this.txtPublic.Margin = new System.Windows.Forms.Padding(4);
            this.txtPublic.Name = "txtPublic";
            this.txtPublic.Size = new System.Drawing.Size(564, 26);
            this.txtPublic.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkRed;
            this.label8.Location = new System.Drawing.Point(332, 12);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 28);
            this.label8.TabIndex = 10;
            this.label8.Text = "Tạo Khóa";
            // 
            // txtN
            // 
            this.txtN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN.ForeColor = System.Drawing.Color.Black;
            this.txtN.Location = new System.Drawing.Point(164, 459);
            this.txtN.Margin = new System.Windows.Forms.Padding(4);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(564, 26);
            this.txtN.TabIndex = 10;
            this.txtN.TextChanged += new System.EventHandler(this.txtN_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(9, 551);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 24);
            this.label9.TabIndex = 12;
            this.label9.Text = "Khóa công khai:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(9, 132);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 24);
            this.label10.TabIndex = 13;
            this.label10.Text = "Key File (XML):";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(9, 459);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 24);
            this.label11.TabIndex = 11;
            this.label11.Text = "Module (N):";
            // 
            // cbKeyLength
            // 
            this.cbKeyLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKeyLength.ForeColor = System.Drawing.Color.Black;
            this.cbKeyLength.FormattingEnabled = true;
            this.cbKeyLength.Items.AddRange(new object[] {
            "512-bit",
            "1024-bit",
            "2048-bit",
            "3072-bit",
            "4096-bit"});
            this.cbKeyLength.Location = new System.Drawing.Point(151, 77);
            this.cbKeyLength.Margin = new System.Windows.Forms.Padding(4);
            this.cbKeyLength.Name = "cbKeyLength";
            this.cbKeyLength.Size = new System.Drawing.Size(154, 30);
            this.cbKeyLength.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(13, 80);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 24);
            this.label12.TabIndex = 4;
            this.label12.Text = "Độ dài Khóa:";
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnGenerate.FlatAppearance.BorderSize = 0;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnGenerate.Location = new System.Drawing.Point(600, 77);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(128, 28);
            this.btnGenerate.TabIndex = 3;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnOpenXML
            // 
            this.btnOpenXML.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnOpenXML.FlatAppearance.BorderSize = 0;
            this.btnOpenXML.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOpenXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenXML.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnOpenXML.Location = new System.Drawing.Point(600, 128);
            this.btnOpenXML.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpenXML.Name = "btnOpenXML";
            this.btnOpenXML.Size = new System.Drawing.Size(128, 28);
            this.btnOpenXML.TabIndex = 2;
            this.btnOpenXML.Text = "Open";
            this.btnOpenXML.UseVisualStyleBackColor = false;
            this.btnOpenXML.Click += new System.EventHandler(this.btnOpenXML_Click);
            // 
            // txtKeyFileXML
            // 
            this.txtKeyFileXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKeyFileXML.ForeColor = System.Drawing.Color.Black;
            this.txtKeyFileXML.Location = new System.Drawing.Point(151, 128);
            this.txtKeyFileXML.Margin = new System.Windows.Forms.Padding(4);
            this.txtKeyFileXML.Name = "txtKeyFileXML";
            this.txtKeyFileXML.Size = new System.Drawing.Size(441, 28);
            this.txtKeyFileXML.TabIndex = 1;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.DarkRed;
            this.label17.Location = new System.Drawing.Point(282, 368);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(169, 28);
            this.label17.TabIndex = 3;
            this.label17.Text = "Thông tin Khóa";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::RSA.Properties.Resources.pngtree_happy_year_of_the_dragon_2024_font_png_image_13247914;
            this.pictureBox2.Location = new System.Drawing.Point(1073, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(486, 99);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1752, 803);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RSA ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSelectFolderOutput;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnSelectFolderInput;
        private System.Windows.Forms.ProgressBar pgbProcess;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSelectFileInput;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnOpenFolderOutput;
        private System.Windows.Forms.Button btnShowResult;
        private System.Windows.Forms.Button btnCheckHashValue;
        private System.Windows.Forms.TextBox txtInformation;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cbShow;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPrivate;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.TextBox txtPublic;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbKeyLength;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnOpenXML;
        private System.Windows.Forms.TextBox txtKeyFileXML;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbProcess;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

