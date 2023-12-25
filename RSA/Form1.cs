using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using static RSA.Form1;

namespace RSA
{
    public partial class Form1 : Form
    {
        private delegate void btnEncryptDecrypt();
        private RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
        private string pathKey= ""; //Đường dẫn vào nơi lưu key
        private string pathFolderKey; //Đường dẫn chứa khóa public và private
        private string pathPublicKey= "";
        private bool isFile = true ; //Ma hoa File hay Folder 
        private string EncryptedPath = ""; //Đường dẫn lưu trữ data mã hóa
        private string DecryptedPath = ""; //Đường dẫn lưu trữ data giải mã
        bool isValidated = true;

        private string storedExponent = "";
        private string storedModulus = "";
        private string storedPublic = "";
        private string storedPrivate = "";

        private string storedHexModulus = "";
        private string storedHexExponent = "";
        private string storedHexPrivate = "";

        private string storedByteArrayModulus = "";
        private string storedByteArrayExponent = "";
        private string storedByteArrayPrivate = "";
        public enum KeyLength
        {
            [Description("512-bit")]
            Bits512 = 512,
            [Description("1024-bit")]
            Bits1024 = 1024,
            [Description("2048-bit")]
            Bits2048 = 2048,
            [Description("3072-bit")]
            Bits3072 = 3072,
            [Description("4096-bit")]
            Bits4096 = 4096,

        }
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheckHashValue_Click(object sender, EventArgs e)
        {
            var Checkfile = new HaskCheck();
            Checkfile.Show();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            this.cbShow.SelectedItem = "XML";
            Control.CheckForIllegalCrossThreadCalls = false;

        }

        //Tạo khóa 
        private void generateKey(KeyLength keyLength, string pathFolderKey)
        {
            var rsa = new RSACryptoServiceProvider((int)keyLength);//Tạo public và private key với độ dài khóa chỉ định

            pathKey = Path.Combine(pathFolderKey, "Key.xml");//Tạo đường dẫn đến file Key.xml
            pathPublicKey = Path.Combine(pathFolderKey, "PublicKey.xml");

            File.WriteAllText(pathKey, rsa.ToXmlString(true));//Lưu khóa public và private vào tệp Key.xml
            txtKeyFileXML.Text = pathKey;
            RSAParameters publicKey = rsa.ExportParameters(false);
            string publicKeyXML= SerializeRSAParameters(publicKey); //chuyển đổi key thành định dạng xml
            File.WriteAllText(pathPublicKey, publicKeyXML);
            showKey(rsa);
        }
        //Chuyển đổi thành chuỗi XML
        private string SerializeRSAParameters(RSAParameters parameter)
        {
            //Ghi data vào chuỗi
            using (var sw = new StringWriter())
            {
                var xs = new XmlSerializer(typeof(RSAParameters));
                xs.Serialize(sw, parameter);//Chuyển đổi thông tin khóa RSA thành dạng xml
                return sw.ToString();
            }
        }
        //Show info key 
        private void showKey(RSACryptoServiceProvider rsa)
        {
            RSAParameters publicKey = rsa.ExportParameters(false);
            RSAParameters privateKey = rsa.ExportParameters(true);

            // Chuyển đổi chuỗi hex thành mảng byte
            byte[] exponentBytes = publicKey.Exponent;
            byte[] modulusBytes = publicKey.Modulus;
            byte[] privateBytes = privateKey.D;

            string Exponent = Convert.ToBase64String(exponentBytes);
            string Modulus = Convert.ToBase64String(modulusBytes);
            string Private= Convert.ToBase64String(privateBytes);
            byte[] eByte = Encoding.Default.GetBytes(Exponent);
            byte[] nBytes = Encoding.Default.GetBytes(Modulus);
            byte[] pBytes = Encoding.Default.GetBytes(Private);


            //string hexExponent = BitConverter.ToString(exponentBytes).Replace("-", "");
            //string hexModulus = BitConverter.ToString(modulusBytes).Replace("-", "");
            //string publicBytes = hexExponent + hexModulus;
            //string publicBytes = BitConverter.ToString(bytes).Replace("-", "");
            
            //Lưu toàn bộ giá trị để không bị lỗi của combobox
            storedExponent = Exponent;
            storedModulus = Modulus;
            storedPublic = Exponent + Modulus;
            storedPrivate = Private;

            storedHexExponent = BitConverter.ToString(eByte).Replace("-", "");
            storedHexModulus = BitConverter.ToString(nBytes).Replace("-", "");
            storedHexPrivate = BitConverter.ToString(pBytes).Replace("-", "");

            storedByteArrayExponent = BitConverter.ToString(eByte).Replace("-", " ");
            storedByteArrayModulus = BitConverter.ToString(nBytes).Replace("-", " ");
            storedByteArrayPrivate = BitConverter.ToString(pBytes).Replace("-", " ");

            // Hiển thị dữ liệu từ các biến toàn cục
            if (cbShow.Text == "XML")
            {
                txtN.Text = storedModulus;
                txtE.Text = storedExponent;
                txtPublic.Text = storedPublic;
                txtPrivate.Text = storedPrivate;
            }
            else if (cbShow.Text == "Hex")
            {
                txtN.Text = storedHexModulus;
                txtE.Text = storedHexExponent;
                txtPublic.Text = storedHexExponent + storedHexModulus;
                txtPrivate.Text = storedHexPrivate;
            }
            else if (cbShow.Text == "Byte array")
            {
                txtN.Text = storedByteArrayModulus;
                txtE.Text = storedByteArrayExponent;
                txtPublic.Text = storedByteArrayExponent + " " + storedByteArrayModulus;
                txtPrivate.Text = storedByteArrayPrivate;
            }

        }
        private KeyLength GetEnumValueFromDescription(string description)
        {
            var values = Enum.GetValues(typeof(KeyLength));

            foreach (var value in values)
            {
                var fieldInfo = value.GetType().GetField(value.ToString());
                var attributes = (DescriptionAttribute[])fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);
                var enumDescription = attributes.Length > 0 ? attributes[0].Description : value.ToString();

                if (enumDescription == description)
                {
                    return (KeyLength)value;
                }
            }

            throw new ArgumentException("No matching enum value found for the given description", nameof(description));
        }

       
        private void cbShow_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbShow.SelectedItem != null && (cbShow.SelectedItem.ToString() == "XML"|| cbShow.SelectedItem.ToString() == "Byte array"|| cbShow.SelectedItem.ToString() == "Hex"))
            {
                if (!string.IsNullOrEmpty(txtKeyFileXML.Text) || !string.IsNullOrEmpty(cbKeyLength.Text))
                {
                    // Hiển thị dữ liệu từ các biến toàn cục
                    if (cbShow.Text == "XML")
                    {
                        txtN.Text = storedModulus;
                        txtE.Text = storedExponent;
                        txtPublic.Text = storedPublic;
                        txtPrivate.Text = storedPrivate;
                    }
                    else if (cbShow.Text == "Hex")
                    {
                        txtN.Text = storedHexModulus;
                        txtE.Text = storedHexExponent;
                        txtPublic.Text = storedHexExponent + storedHexModulus;
                        txtPrivate.Text = storedHexPrivate;
                    }
                    else if (cbShow.Text == "Byte array")
                    {
                        txtN.Text = storedByteArrayModulus;
                        txtE.Text = storedByteArrayExponent;
                        txtPublic.Text = storedByteArrayExponent + " " + storedByteArrayModulus;
                        txtPrivate.Text = storedByteArrayPrivate;
                    }
                }
                
            }
            else
                {
                    MessageBox.Show("Vui lòng tạo hoặc mở key trước khi hiển thị!");
                }
            
        }
     
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Stopwatch SW = Stopwatch.StartNew();
            SW.Start();
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                //KeyLength selectedKeyLength = (KeyLength)Enum.Parse(typeof(KeyLength), cbKeyLength.Text);
                string selectedDescription = cbKeyLength.Text;
                KeyLength selectedKeyLength = GetEnumValueFromDescription(selectedDescription);
                pathFolderKey = fbd.SelectedPath;
                generateKey(selectedKeyLength, pathFolderKey);
            }
            SW.Stop();
            double elapsedMs = SW.Elapsed.TotalMilliseconds / 1000;
            MessageBox.Show(
                cbKeyLength.Text + " khóa được tạo\n"
                + "Thời gian tạo khóa là : " + elapsedMs.ToString()+" s", "Tạo khóa thành công!!!", MessageBoxButtons.OK);
        }


        //OpenXML
        private void btnOpenXML_Click(object sender, EventArgs e)
        {
            string keyFile = SelectFileXML();
            pathKey = keyFile;//Tạo đường dẫn đến file Key.xml
            
            if (!string.IsNullOrEmpty(keyFile))
            {
                txtKeyFileXML.Text = keyFile;
                if (File.Exists(keyFile))
                {
                    if (Path.GetFileName(keyFile) == "Key.xml")
                    {
                        try
                        {
                            LoadAndShowKeyData(keyFile, "/RSAKeyValue/Exponent", "/RSAKeyValue/Modulus", "/RSAKeyValue/D");
                        }
                        catch
                        {
                            MessageBox.Show("Vui lòng chọn đúng file có tên là: Key.xml không phải PublicKey.xml");
                        }
                    }
                    else if (Path.GetFileName(keyFile) == "PublicKey.xml")
                    {
                        LoadAndShowKeyData(keyFile, "/RSAParameters/Exponent", "/RSAParameters/Modulus", null);
                    }
                }
                else
                {
                    // Nếu không có file được chọn, bạn có thể thông báo cho người dùng hoặc thực hiện hành động khác tùy thuộc vào logic ứng dụng của bạn.
                    MessageBox.Show("Vui lòng chọn một file để mở!");
                }
            }
        }
        private string SelectFileXML()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Xml File|*.xml";//lọc nhưng file có đuôi xml

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                return ofd.FileName;
            }

            return string.Empty;
        }
        private void LoadAndShowKeyData(string keyFile, string pathE, string pathN, string pathD)
        {
            try
            {
                
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.LoadXml(File.ReadAllText(keyFile));

                XmlNode xmlE = xmlDoc.SelectSingleNode(pathE); // Exponent 
                XmlNode xmlN = xmlDoc.SelectSingleNode(pathN); // Modulus 


                string publicKey = xmlE.InnerText + xmlN.InnerText;

                byte[] pBytes = Encoding.Default.GetBytes(publicKey);
                byte[] eBytes = Encoding.Default.GetBytes(xmlE.InnerText);
                byte[] nBytes = Encoding.Default.GetBytes(xmlN.InnerText);

                //Lưu toàn bộ giá trị để không bị lỗi của combobox
                storedExponent = xmlE.InnerText;
                storedModulus = xmlN.InnerText;
                storedPublic = publicKey;
                
                storedHexExponent = BitConverter.ToString(eBytes).Replace("-", "");
                storedHexModulus = BitConverter.ToString(nBytes).Replace("-", "");


                storedByteArrayExponent = BitConverter.ToString(eBytes).Replace("-", " ");
                storedByteArrayModulus = BitConverter.ToString(nBytes).Replace("-", " ");
                


                if (cbShow.Text == "XML")
                {
                    DisplayKey(storedModulus, storedExponent, storedPublic,
                                null);
                }
                else if (cbShow.Text == "Hex")
                {
                    DisplayKey(storedHexModulus, storedHexExponent
                        , storedHexExponent+ storedHexModulus
                       , null);
                }
                else if (cbShow.Text == "Byte array")
                {
                    DisplayKey(storedByteArrayModulus, storedByteArrayExponent
                       , storedByteArrayExponent + storedByteArrayModulus
                       ,null);
                }

                if (pathD != null)
                {
                    XmlNode xmlD = xmlDoc.SelectSingleNode(pathD); // private
                    byte[] dBytes = Encoding.Default.GetBytes(xmlD.InnerText);
                    storedPrivate = xmlD.InnerText;
                    storedHexPrivate = BitConverter.ToString(dBytes).Replace("-", "");
                    storedByteArrayPrivate = BitConverter.ToString(dBytes).Replace("-", " ");
                    if (cbShow.Text == "XML")
                    {
                        DisplayKey(null, null,null, storedPrivate);
                    }
                    else if (cbShow.Text == "Hex")
                    {
                        DisplayKey(null, null,null, storedHexPrivate);
                    }
                    else if (cbShow.Text == "Byte array")
                    {
                        DisplayKey(null, null,null, storedByteArrayPrivate);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void DisplayKey( string modulus, string exponent, string publickey, string privateKey)
        {
            if (exponent != null)
            {
                txtE.Text = exponent;
            }
            if (modulus != null)
            {
                txtN.Text = modulus;
            }
            if (privateKey != null)
            {
                txtPrivate.Text = privateKey;
            }
            if (publickey != null)
            {
                txtPublic.Text = publickey;
            }
        }

        //OpenFile&&FolderSelect
        private void btnSelectFileInput_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtInput.Text = openFileDialog.FileName;
            }
        }

        private void btnSelectFolderInput_Click(object sender, EventArgs e)
        {
            isFile=false; //Kiểm tra xem đg mở file hay folder
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                txtInput.Text = dialog.SelectedPath;
            }
                
        }

        private void btnSelectFolderOutput_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog1 = new FolderBrowserDialog();
            if (dialog1.ShowDialog() == DialogResult.OK)
            {
                txtOutput.Text = dialog1.SelectedPath;
            }
        }

        private void btnOpenFolderOutput_Click(object sender, EventArgs e)
        {
            string folderPath = txtOutput.Text.Trim();

            if (!string.IsNullOrEmpty(folderPath) && Directory.Exists(folderPath))
            {
                try
                {
                    System.Diagnostics.Process.Start(folderPath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể mở thư mục: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn đường dẫn hợp lệ!");
            }
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu không có đường dẫn đến thư mục Output hoặc Key File được nhập
            if (string.IsNullOrEmpty(txtOutput.Text) || string.IsNullOrEmpty(txtKeyFileXML.Text))
            {
                MessageBox.Show("Vui lòng chọn cả đường dẫn thư mục đầu ra và đường dẫn tệp chính!");
                return;
            }
            //mã hóa trong một luồng mới và không chặn luồng giao diện người dùng
            Task.Run(() => Encrypt());
        }
        private void Encrypt()
        {
            try
            {
                changeBtnState(false);
                if(string.IsNullOrEmpty(pathPublicKey)&&string.IsNullOrEmpty(pathKey))
                {
                    MessageBox.Show("Chưa có khóa công khai");
                    return;
                }
                if (string.IsNullOrEmpty(txtInput.Text))
                {
                    MessageBox.Show("Chưa đủ thông tin để mã hóa! Vui lòng kiểm tra lại thông tin.");
                    return;
                }

                Stopwatch sw = Stopwatch.StartNew();
                sw.Start();

                string inputFileName = txtInput.Text;
                string outputFileName = isFile ? txtOutput.Text + "\\" + Path.GetFileName(inputFileName) + ".nhom6" : string.Empty;

                //Lấy thông tin key
                RSA = new RSACryptoServiceProvider();
                RSA.FromXmlString(File.ReadAllText(string.IsNullOrEmpty(pathPublicKey) ? pathKey : pathPublicKey));

                if (isFile)
                {
                    if (!RSA_Algorithm(inputFileName, outputFileName, RSA.ExportParameters(false), true))
                    {
                        changeBtnState(true);
                        return;
                    }
                }
                else
                {
                    string[] filePaths = Directory.GetFiles(inputFileName, "*");

                    if (filePaths.Length == 0)
                    {
                        MessageBox.Show("Folder rỗng!");
                        changeBtnState(true);
                        return;
                    }

                    foreach (string filePath in filePaths)
                    {
                        outputFileName = txtOutput.Text + "\\" + Path.GetFileName(filePath) + ".nhom6";
                        if (!RSA_Algorithm(filePath, outputFileName, RSA.ExportParameters(false), true))
                        {
                            isValidated = false;
                            break; // Thoát vòng lặp nếu có lỗi xảy ra.
                        }
                    }
                }

                sw.Stop();
                double elapsedMs = sw.Elapsed.TotalMilliseconds / 1000;

                if (isValidated)
                {
                    MessageBox.Show("Thời gian mã hóa là: " + elapsedMs.ToString() + "s");
                    btnShowResult.Enabled = true;
                }

                changeBtnState(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                changeBtnState(true);
            }
        }
        private bool RSA_Algorithm(string inputFile, string outputFile, RSAParameters RSAKeyInfo, bool isEncrypt)
        {
            try
            {
                using (FileStream fsInput = new FileStream(inputFile, FileMode.Open, FileAccess.Read))//Đọc file
                using (FileStream fsCiperText = new FileStream(outputFile, FileMode.Create, FileAccess.Write))//Tạo file
                {
                    this.pgbProcess.Minimum = 0;
                    this.pgbProcess.Maximum = 100;

                    RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
                    RSA.ImportParameters(RSAKeyInfo);//Nhập thông tin khoá RSA

                    // Tính kích thước tối đa cho mỗi lần mã hóa hoặc giải mã
                    int maxBytesCanEncrypted = isEncrypt ? ((RSA.KeySize - 256) / 8) + 18 : (RSA.KeySize / 8);

                    byte[] bin, encryptedData;
                    long readLen = 0;
                    long totalLen = fsInput.Length;
                    int len;

                    // Vòng lặp xử lý mã hóa hoặc giải mã
                    while (readLen < totalLen)
                    {
                        int bufferSize = (int)Math.Min(maxBytesCanEncrypted, totalLen - readLen);
                        bin = new byte[bufferSize];
                        len = fsInput.Read(bin, 0, bufferSize);

                        if (isEncrypt) encryptedData = RSA.Encrypt(bin, false);//Mã hóa
                        else encryptedData = RSA.Decrypt(bin, false);//Giải mã

                        fsCiperText.Write(encryptedData, 0, encryptedData.Length);
                        readLen += len;

                        // Cập nhật thanh tiến trình và hiển thị tên tệp
                        int progress = (int)((readLen * 100) / totalLen);
                        this.lbProcess.Text = "Tệp xử lý : " + Path.GetFileName(inputFile) + "\t Thành công: " + progress.ToString() + "%";
                        this.lbProcess.Refresh();

                        this.pgbProcess.Value = progress;
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            return false;
        }
        private void changeBtnState(bool stateEn)
        {
            this.btnReset.Enabled = stateEn;
            this.btnShowResult.Enabled = stateEn;
            this.btnEncrypt.Enabled = stateEn;
            this.btnDecrypt.Enabled = stateEn;
            this.btnGenerate.Enabled = stateEn;
            this.btnOpenFolderOutput.Enabled = stateEn;
            this.btnOpenXML.Enabled = stateEn;
            this.btnSelectFileInput.Enabled = stateEn;
            this.btnSelectFolderInput.Enabled = stateEn;
            this.btnSelectFolderOutput.Enabled = stateEn;
            this.cbShow.Enabled = stateEn;
            this.txtOutput.Enabled = stateEn;
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu không có đường dẫn đến thư mục Output hoặc Key File được nhập
            if (string.IsNullOrEmpty(txtOutput.Text) || string.IsNullOrEmpty(txtKeyFileXML.Text))
            {
                MessageBox.Show("Vui lòng chọn cả đường dẫn thư mục đầu ra và đường dẫn tệp chính!");
                return;
            }
            //mã hóa trong một luồng mới và không chặn luồng giao diện người dùng
            Task.Run(() => Decrypt());
        }
        private void Decrypt()
        {
            try
            {
                changeBtnState(false);

                if (this.pathKey.Length == 0)
                {
                    MessageBox.Show("Không có khóa bí mật để giải mã!");
                    changeBtnState(true);
                    return;
                }

                if (string.IsNullOrEmpty(txtInput.Text))
                {
                    MessageBox.Show("Không đủ thông tin để giải mã. Vui lòng kiểm tra lại!!!");
                    changeBtnState(true);
                    return;
                }

                Stopwatch sw = Stopwatch.StartNew();
                sw.Start();

                string inputFileName = txtInput.Text;
                string outputFileName = "";

                if (isFile && Path.GetExtension(inputFileName) != ".nhom6")
                {
                    MessageBox.Show("File mở rộng không được hỗ trợ. Vui lòng kiểm trả lại phần đuôi mở rộng!!!");
                    changeBtnState(true);
                    return;
                }

                RSA = new RSACryptoServiceProvider();
                RSA.FromXmlString(File.ReadAllText(this.pathKey));

                if (isFile)
                {
                    outputFileName = txtOutput.Text + "\\" + Path.GetFileNameWithoutExtension(inputFileName);
                    DecryptedPath = outputFileName;

                    if (!RSA_Algorithm(inputFileName, outputFileName, RSA.ExportParameters(true), false))
                    {
                        MessageBox.Show(inputFileName+ " :File không thể được giải mã.");
                        changeBtnState(true);
                        return;
                    }
                }
                else
                {
                    //folder
                    string[] filePaths = Directory.GetFiles(inputFileName, "*.nhom6", SearchOption.AllDirectories);

                    if (filePaths.Length == 0)
                    {
                        MessageBox.Show("Thư mục trống hoặc không tìm thấy tập tin '.nhom6'!");
                        changeBtnState(true);
                        return;
                    }

                    foreach (string filePath in filePaths)
                    {
                        outputFileName = txtOutput.Text + "\\" + Path.GetFileNameWithoutExtension(filePath);
                        if (!RSA_Algorithm(filePath, outputFileName, RSA.ExportParameters(true), false))
                        {
                            MessageBox.Show(filePath + " :File không thể được giải mã.");
                            isValidated = false;
                        }
                    }
                }

                changeBtnState(true);
                sw.Stop();
                double Ms = sw.Elapsed.TotalMilliseconds / 1000;
                if (isValidated)
                {
                    MessageBox.Show("Thời gian giải mã là: " + Ms.ToString() + " s");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                changeBtnState(true);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Khởi tạo lại đối tượng RSA để sử dụng
            RSA = new RSACryptoServiceProvider();

            // Reset các giá trị và trạng thái 
            pathFolderKey = null;
            pathKey = null;
            pathPublicKey = null;
            isFile = true;
            isValidated = true;
            cbKeyLength.Text=null;
           
            txtKeyFileXML.Clear();
            txtInput.Clear();
            txtPublic.Clear();
            txtPrivate.Clear();
            txtOutput.Clear();

            btnShowResult.Enabled = false;
            txtInformation.Text = "";
            lbProcess.Text = "";
            pgbProcess.Value = 0;

            txtPrivate.Text = "";
            txtPublic.Text = "";
            txtN.Text = "";
            txtE.Text = "";
            storedExponent = "";
            storedModulus = "";
            storedPublic = "";
            storedPrivate = "";

            storedHexModulus = "";
            storedHexExponent = "";
            storedHexPrivate = "";

            storedByteArrayModulus = "";
            storedByteArrayExponent = "";
            storedByteArrayPrivate = "";

        }

        private void btnShowResult_Click(object sender, EventArgs e)
        {
            try
            {
                if (!isFile)
                {
                    Process.Start(txtOutput.Text);
                }
                else
                {
                    if (string.IsNullOrEmpty(DecryptedPath))
                    {
                        Process.Start("Notepad.exe", EncryptedPath);
                        string text = File.ReadAllText(EncryptedPath);
                        txtInformation.Text = text;
                    }
                    else
                    {
                        Process.Start(DecryptedPath);
                        string text = File.ReadAllText(DecryptedPath);
                        txtInformation.Text = text;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed: " + ex.Message);
            }
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void txtN_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
