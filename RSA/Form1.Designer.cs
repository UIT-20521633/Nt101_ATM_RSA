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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMumahoa = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtModule = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cbbKeyLength = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnOpenFileKeys = new System.Windows.Forms.Button();
            this.txtKeyFileXML = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnResetForm = new System.Windows.Forms.Button();
            this.txtMugiaima = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSelectFileOutput = new System.Windows.Forms.Button();
            this.btnCheckHashValue = new System.Windows.Forms.Button();
            this.btnShowResult = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtInformation = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtMugiaima);
            this.panel1.Controls.Add(this.flowLayoutPanel2);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.txtMumahoa);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.txtModule);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.cbbKeyLength);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnGenerate);
            this.panel1.Controls.Add(this.btnOpenFileKeys);
            this.panel1.Controls.Add(this.txtKeyFileXML);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(13, 130);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(609, 594);
            this.panel1.TabIndex = 1;
            // 
            // txtMumahoa
            // 
            this.txtMumahoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMumahoa.ForeColor = System.Drawing.Color.Black;
            this.txtMumahoa.Location = new System.Drawing.Point(164, 481);
            this.txtMumahoa.Margin = new System.Windows.Forms.Padding(4);
            this.txtMumahoa.Name = "txtMumahoa";
            this.txtMumahoa.Size = new System.Drawing.Size(428, 26);
            this.txtMumahoa.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DarkRed;
            this.label13.Location = new System.Drawing.Point(220, 12);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(110, 28);
            this.label13.TabIndex = 10;
            this.label13.Text = "Tạo Khóa";
            // 
            // txtModule
            // 
            this.txtModule.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModule.ForeColor = System.Drawing.Color.Black;
            this.txtModule.Location = new System.Drawing.Point(164, 435);
            this.txtModule.Margin = new System.Windows.Forms.Padding(4);
            this.txtModule.Name = "txtModule";
            this.txtModule.Size = new System.Drawing.Size(428, 26);
            this.txtModule.TabIndex = 10;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(6, 482);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(140, 24);
            this.label16.TabIndex = 12;
            this.label16.Text = "Mũ mã hóa (E):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 132);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Key File (XML):";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(9, 437);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(110, 24);
            this.label15.TabIndex = 11;
            this.label15.Text = "Module (N):";
            // 
            // cbbKeyLength
            // 
            this.cbbKeyLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbKeyLength.ForeColor = System.Drawing.Color.Black;
            this.cbbKeyLength.FormattingEnabled = true;
            this.cbbKeyLength.Location = new System.Drawing.Point(145, 76);
            this.cbbKeyLength.Margin = new System.Windows.Forms.Padding(4);
            this.cbbKeyLength.Name = "cbbKeyLength";
            this.cbbKeyLength.Size = new System.Drawing.Size(160, 30);
            this.cbbKeyLength.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(7, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Độ dài Khóa:";
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnGenerate.FlatAppearance.BorderSize = 0;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnGenerate.Location = new System.Drawing.Point(490, 78);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(102, 28);
            this.btnGenerate.TabIndex = 3;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            // 
            // btnOpenFileKeys
            // 
            this.btnOpenFileKeys.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnOpenFileKeys.FlatAppearance.BorderSize = 0;
            this.btnOpenFileKeys.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOpenFileKeys.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenFileKeys.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnOpenFileKeys.Location = new System.Drawing.Point(490, 125);
            this.btnOpenFileKeys.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpenFileKeys.Name = "btnOpenFileKeys";
            this.btnOpenFileKeys.Size = new System.Drawing.Size(102, 28);
            this.btnOpenFileKeys.TabIndex = 2;
            this.btnOpenFileKeys.Text = "Open";
            this.btnOpenFileKeys.UseVisualStyleBackColor = false;
            // 
            // txtKeyFileXML
            // 
            this.txtKeyFileXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKeyFileXML.ForeColor = System.Drawing.Color.Black;
            this.txtKeyFileXML.Location = new System.Drawing.Point(145, 128);
            this.txtKeyFileXML.Margin = new System.Windows.Forms.Padding(4);
            this.txtKeyFileXML.Name = "txtKeyFileXML";
            this.txtKeyFileXML.Size = new System.Drawing.Size(337, 28);
            this.txtKeyFileXML.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(220, 369);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 28);
            this.label5.TabIndex = 3;
            this.label5.Text = "Thông tin Khóa";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.txtInformation);
            this.panel2.Controls.Add(this.btnReset);
            this.panel2.Controls.Add(this.btnShowResult);
            this.panel2.Controls.Add(this.btnCheckHashValue);
            this.panel2.Controls.Add(this.btnSelectFileOutput);
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
            this.panel2.Location = new System.Drawing.Point(640, 130);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(625, 594);
            this.panel2.TabIndex = 2;
            // 
            // btnSelectFolderOutput
            // 
            this.btnSelectFolderOutput.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSelectFolderOutput.FlatAppearance.BorderSize = 0;
            this.btnSelectFolderOutput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectFolderOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectFolderOutput.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnSelectFolderOutput.Location = new System.Drawing.Point(472, 168);
            this.btnSelectFolderOutput.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectFolderOutput.Name = "btnSelectFolderOutput";
            this.btnSelectFolderOutput.Size = new System.Drawing.Size(129, 28);
            this.btnSelectFolderOutput.TabIndex = 15;
            this.btnSelectFolderOutput.Text = "Chọn Folder";
            this.btnSelectFolderOutput.UseVisualStyleBackColor = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Maroon;
            this.label14.Location = new System.Drawing.Point(214, 12);
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
            this.btnSelectFolderInput.Location = new System.Drawing.Point(472, 90);
            this.btnSelectFolderInput.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectFolderInput.Name = "btnSelectFolderInput";
            this.btnSelectFolderInput.Size = new System.Drawing.Size(129, 28);
            this.btnSelectFolderInput.TabIndex = 12;
            this.btnSelectFolderInput.Text = "Chọn Folder";
            this.btnSelectFolderInput.UseVisualStyleBackColor = false;
            // 
            // pgbProcess
            // 
            this.pgbProcess.BackColor = System.Drawing.SystemColors.Window;
            this.pgbProcess.ForeColor = System.Drawing.Color.Black;
            this.pgbProcess.Location = new System.Drawing.Point(39, 301);
            this.pgbProcess.Margin = new System.Windows.Forms.Padding(4);
            this.pgbProcess.Name = "pgbProcess";
            this.pgbProcess.Size = new System.Drawing.Size(550, 28);
            this.pgbProcess.TabIndex = 9;
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDecrypt.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecrypt.ForeColor = System.Drawing.Color.White;
            this.btnDecrypt.Location = new System.Drawing.Point(396, 231);
            this.btnDecrypt.Margin = new System.Windows.Forms.Padding(4);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(133, 43);
            this.btnDecrypt.TabIndex = 11;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(19, 149);
            this.label4.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Output";
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEncrypt.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncrypt.ForeColor = System.Drawing.Color.White;
            this.btnEncrypt.Location = new System.Drawing.Point(104, 231);
            this.btnEncrypt.Margin = new System.Windows.Forms.Padding(4);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(123, 42);
            this.btnEncrypt.TabIndex = 10;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = false;
            // 
            // txtOutput
            // 
            this.txtOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.ForeColor = System.Drawing.Color.Black;
            this.txtOutput.Location = new System.Drawing.Point(104, 143);
            this.txtOutput.Margin = new System.Windows.Forms.Padding(4);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(360, 28);
            this.txtOutput.TabIndex = 7;
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.ForeColor = System.Drawing.Color.Black;
            this.txtInput.Location = new System.Drawing.Point(104, 75);
            this.txtInput.Margin = new System.Windows.Forms.Padding(4);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(360, 28);
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
            this.label3.Size = new System.Drawing.Size(51, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Input";
            // 
            // btnSelectFileInput
            // 
            this.btnSelectFileInput.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSelectFileInput.FlatAppearance.BorderSize = 0;
            this.btnSelectFileInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectFileInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectFileInput.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnSelectFileInput.Location = new System.Drawing.Point(472, 54);
            this.btnSelectFileInput.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectFileInput.Name = "btnSelectFileInput";
            this.btnSelectFileInput.Size = new System.Drawing.Size(129, 28);
            this.btnSelectFileInput.TabIndex = 0;
            this.btnSelectFileInput.Text = "Chọn File";
            this.btnSelectFileInput.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("flowLayoutPanel1.BackgroundImage")));
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(18, 203);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(172, 156);
            this.flowLayoutPanel1.TabIndex = 15;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel5.Location = new System.Drawing.Point(353, 13);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(467, 109);
            this.panel5.TabIndex = 14;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("flowLayoutPanel2.BackgroundImage")));
            this.flowLayoutPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(420, 203);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(172, 156);
            this.flowLayoutPanel2.TabIndex = 16;
            // 
            // btnResetForm
            // 
            this.btnResetForm.BackColor = System.Drawing.Color.White;
            this.btnResetForm.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnResetForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnResetForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetForm.ForeColor = System.Drawing.Color.Black;
            this.btnResetForm.Location = new System.Drawing.Point(1058, 76);
            this.btnResetForm.Margin = new System.Windows.Forms.Padding(4);
            this.btnResetForm.Name = "btnResetForm";
            this.btnResetForm.Size = new System.Drawing.Size(173, 46);
            this.btnResetForm.TabIndex = 54;
            this.btnResetForm.Text = "Reset Form";
            this.btnResetForm.UseVisualStyleBackColor = false;
            // 
            // txtMugiaima
            // 
            this.txtMugiaima.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMugiaima.ForeColor = System.Drawing.Color.Black;
            this.txtMugiaima.Location = new System.Drawing.Point(164, 535);
            this.txtMugiaima.Margin = new System.Windows.Forms.Padding(4);
            this.txtMugiaima.Name = "txtMugiaima";
            this.txtMugiaima.Size = new System.Drawing.Size(428, 26);
            this.txtMugiaima.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(6, 535);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 24);
            this.label6.TabIndex = 18;
            this.label6.Text = "Mũ giải mã (D):";
            // 
            // btnSelectFileOutput
            // 
            this.btnSelectFileOutput.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSelectFileOutput.FlatAppearance.BorderSize = 0;
            this.btnSelectFileOutput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectFileOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectFileOutput.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnSelectFileOutput.Location = new System.Drawing.Point(472, 132);
            this.btnSelectFileOutput.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectFileOutput.Name = "btnSelectFileOutput";
            this.btnSelectFileOutput.Size = new System.Drawing.Size(129, 28);
            this.btnSelectFileOutput.TabIndex = 16;
            this.btnSelectFileOutput.Text = "Chọn File";
            this.btnSelectFileOutput.UseVisualStyleBackColor = false;
            // 
            // btnCheckHashValue
            // 
            this.btnCheckHashValue.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCheckHashValue.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnCheckHashValue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCheckHashValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckHashValue.ForeColor = System.Drawing.Color.White;
            this.btnCheckHashValue.Location = new System.Drawing.Point(52, 464);
            this.btnCheckHashValue.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheckHashValue.Name = "btnCheckHashValue";
            this.btnCheckHashValue.Size = new System.Drawing.Size(237, 42);
            this.btnCheckHashValue.TabIndex = 17;
            this.btnCheckHashValue.Text = "Kiểm tra giá trị băm";
            this.btnCheckHashValue.UseVisualStyleBackColor = false;
            this.btnCheckHashValue.Click += new System.EventHandler(this.btnCheckHashValue_Click);
            // 
            // btnShowResult
            // 
            this.btnShowResult.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnShowResult.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnShowResult.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShowResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowResult.ForeColor = System.Drawing.Color.White;
            this.btnShowResult.Location = new System.Drawing.Point(321, 464);
            this.btnShowResult.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowResult.Name = "btnShowResult";
            this.btnShowResult.Size = new System.Drawing.Size(248, 42);
            this.btnShowResult.TabIndex = 18;
            this.btnShowResult.Text = "Hiển thị kết quả";
            this.btnShowResult.UseVisualStyleBackColor = false;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(239, 525);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(133, 43);
            this.btnReset.TabIndex = 19;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            // 
            // txtInformation
            // 
            this.txtInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInformation.ForeColor = System.Drawing.Color.Black;
            this.txtInformation.Location = new System.Drawing.Point(52, 380);
            this.txtInformation.Margin = new System.Windows.Forms.Padding(4);
            this.txtInformation.Name = "txtInformation";
            this.txtInformation.Size = new System.Drawing.Size(517, 28);
            this.txtInformation.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1278, 731);
            this.Controls.Add(this.btnResetForm);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtMumahoa;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtModule;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbbKeyLength;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnOpenFileKeys;
        private System.Windows.Forms.TextBox txtKeyFileXML;
        private System.Windows.Forms.Label label5;
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
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnResetForm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMugiaima;
        private System.Windows.Forms.Button btnSelectFileOutput;
        private System.Windows.Forms.Button btnShowResult;
        private System.Windows.Forms.Button btnCheckHashValue;
        private System.Windows.Forms.TextBox txtInformation;
        private System.Windows.Forms.Button btnReset;
    }
}

