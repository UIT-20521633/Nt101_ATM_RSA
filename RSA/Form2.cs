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

        private void btResetCheck_Click(object sender, EventArgs e)
        {
            txtFileCheck.Text = null;
            txtMD5.Text = null;
            txtSHA1.Text = null;
            txtSHA256.Text = null;
            txtCheck1.Text = null;
            txtCheck2.Text = null;
            txtCheck3.Text = null;
        }

        private void btCheck_Click(object sender, EventArgs e)
        {
            if (txtFileCheck.Text.Length == 0)
            {
                MessageBox.Show("Please select path to folder Output");
                return;
            }

            if (txtMD5.Text == txtFileCheck.Text)
            {
                MessageBox.Show("Thuật toán MD5 không an toàn", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCheck1.Text = "Không an toàn";
            }
            else if (txtSHA1.Text == txtFileCheck.Text)
            {
                MessageBox.Show("Thuật toán SHA1 không an toàn", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCheck2.Text = "Không an toàn";
            }
            else if (txtSHA256.Text == txtFileCheck.Text)
            {
                MessageBox.Show("Thuật toán SHA256 không an toàn", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCheck3.Text = "Không an toàn";
            }
            else
            {
                txtMD5.Text = MD5(txtFileCheck.Text);
                txtSHA1.Text = SHA1(txtFileCheck.Text);
                txtSHA256.Text = SHA256(txtFileCheck.Text);
                txtMD5.Enabled = true;
                txtSHA256.Enabled = true;
                txtSHA1.Enabled = true;
                txtFileCheck.Clear();
                txtCheck1.Text = "An Toàn";
                txtCheck2.Text = "An Toàn";
                txtCheck3.Text = "An Toàn";
                txtCheck1.ReadOnly = true;
                txtCheck2.ReadOnly = true;
                txtCheck3.ReadOnly = true;  
            }    
            
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
            txtFileCheck.Clear();
        }

        private void btOpenFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    txtFileCheck.Text = dialog.FileName;
                }
            }
        }
    }
}
