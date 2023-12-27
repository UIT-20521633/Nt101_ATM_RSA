using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSA
{
    public partial class HaskCheck : Form
    {
        public HaskCheck()
        {
            InitializeComponent();
        }
        private bool isCheck=false;
        private void btResetCheck_Click(object sender, EventArgs e)
        {
            txtFileRootCheck.Text = null;
            txtFileDECheck.Text = null;
            txtMD5.Text = null;
            txtSHA1.Text = null;
            txtSHA256.Text = null;
            txtCheck1.Text = null;
            txtCheck2.Text = null;
            txtCheck3.Text = null;
            txtMD5DE.Text = null;
            txtSHADE.Text = null;
            txtSHA256DE.Text = null;
        }

        private void btCheck_Click(object sender, EventArgs e)
        {
            // Kiểm tra đường dẫn có tồn tại không
            if (string.IsNullOrEmpty(txtFileRootCheck.Text))
            {
                MessageBox.Show("Vui lòng chọn đường dẫn gốc đến tệp!!!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtFileDECheck.Text))
            {
                MessageBox.Show("Vui lòng chọn đường dẫn đến tệp đã giải mã để kiểm tra!!!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string rootFileMD5 = MD5(txtFileRootCheck.Text);
            string decryptedFileMD5 = MD5(txtFileDECheck.Text);
            string rootFileSHA = SHA1(txtFileRootCheck.Text);
            string decryptedFileSHA = SHA1(txtFileDECheck.Text);
            string rootFileSHA256 = SHA256(txtFileRootCheck.Text);
            string decryptedFileSHA256 = SHA256(txtFileDECheck.Text);

            txtMD5.Text= rootFileMD5;
            txtMD5DE.Text= decryptedFileMD5;
            txtSHA1.Text = rootFileSHA;
            txtSHADE.Text= decryptedFileSHA;
            txtSHA256.Text = rootFileSHA256;
            txtSHA256DE.Text = decryptedFileSHA256;
           

            // Lưu trạng thái so sánh hàm băm vào một Dictionary
            Dictionary<string, bool> hashComparison = new Dictionary<string, bool>
            {
                { "MD5", rootFileMD5 == decryptedFileMD5 },
                { "SHA1", rootFileSHA == decryptedFileSHA },
                { "SHA256", rootFileSHA256 == decryptedFileSHA256 }
            };
            // Thiết lập màu cho  "An Toàn" và "Không An Toàn" 
            txtCheck1.BackColor = hashComparison["MD5"] ? Color.LightGreen : Color.LightPink;
            txtCheck2.BackColor = hashComparison["SHA1"] ? Color.LightGreen : Color.LightPink;
            txtCheck3.BackColor = hashComparison["SHA256"] ? Color.LightGreen : Color.LightPink;

            txtCheck1.Text = hashComparison["MD5"] ? "An Toàn" : "Không An Toàn";
            txtCheck2.Text = hashComparison["SHA1"] ? "An Toàn" : "Không An Toàn";
            txtCheck3.Text = hashComparison["SHA256"] ? "An Toàn" : "Không An Toàn";

            // Hiển thị thông báo kết quả
            if (hashComparison.ContainsValue(false))
            {
                MessageBox.Show("Hàm băm của hai tệp không trùng nhau.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Hàm băm của hai tệp trùng nhau.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txtCheck1.ReadOnly = true;
            txtCheck2.ReadOnly = true;
            txtCheck3.ReadOnly = true;

        }
        public static string MD5(string path)
        {
            try
            {
                using (var md5 = System.Security.Cryptography.MD5.Create())
                {
                    using (var stream = File.OpenRead(path))
                    {
                        return BitConverter.ToString(md5.ComputeHash(stream)).Replace("-", string.Empty).ToLower();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return null;
            }
        }

        public static string SHA1(string path)
        {
            try
            {
                using (var cryptoProvider = new SHA1CryptoServiceProvider())
                {
                    var stream = File.OpenRead(path);
                    string hash = BitConverter
                        .ToString(cryptoProvider.ComputeHash(stream)).Replace("-", "");
                    return hash.ToLower();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return null;
            }
        }

        public static string SHA256(string path)
        {
            try
            {
                using (FileStream stream = File.OpenRead(path))
                {
                    SHA256Managed sha = new SHA256Managed();
                    byte[] hash = sha.ComputeHash(stream);
                    return BitConverter.ToString(hash).Replace("-", String.Empty);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return null;
            }

        }

        private void HaskCheck_Load(object sender, EventArgs e)
        {
            txtMD5.ReadOnly = true;
            txtSHA1.ReadOnly = true;
            txtSHA256.ReadOnly = true;
            txtMD5DE.ReadOnly = true;
            txtSHADE.ReadOnly = true;
            txtSHA256DE.ReadOnly = true;
        }

        private void btOpenFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    txtFileRootCheck.Text = dialog.FileName;
                }
            }
        }

        private void btOpenFileDE_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    txtFileDECheck.Text = dialog.FileName;
                }
            }
        }
    }
}
