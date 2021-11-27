using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace Hash_function
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.cbSelection.SelectedIndexChanged += new EventHandler(onSelectionChange);
            this.btnSelectFile.Enabled = false;

            cbMD5.Checked = true;
            cbSHA1.Checked = true;
            cbSHA2.Checked = true;
        }

        private void onSelectionChange(object sender, EventArgs e)
        {
            var index = cbSelection.SelectedIndex;
            if (index == 2)
            {
                btnSelectFile.Enabled = true;
                selected = index;
               cbSHA2.Checked = false;
                
            }
            else if (index == 0 )
            {
                rtbInputData.Text = "";
                selected = 0;

            }
            else
            {
                selected = 1;
            }


        }
        MD5 md = MD5.Create();
        SHA1 sha1 = SHA1.Create();
        SHA256 sha2 = SHA256.Create();
        int selected;
        string data;
        public static byte[] ToByteArray(String hexString)
        {
            byte[] retval = new byte[hexString.Length / 2];
            for (int n = 0; n < hexString.Length; n += 2)
                retval[n / 2] = Convert.ToByte(hexString.Substring(n, 2), 16);
            return retval;
        }

        public byte[] GetBytesFromBinaryString(String binary)
        {
            var list = new List<Byte>();
            for (int i = 0; i < binary.Length; i += 8)
            {
                String t = binary.Substring(i, 8);
                list.Add(Convert.ToByte(t, 2));
            }
            return list.ToArray();
        }

        private void MD5Hash()
        {
            byte[] hash;
            StringBuilder MD5Value = new StringBuilder();

            if (selected == 0)
            {
                byte[] inputstr = System.Text.Encoding.ASCII.GetBytes(rtbInputData.Text);
                hash = md.ComputeHash(inputstr);

                for (int h = 0; h < hash.Length; h++)
                {
                    MD5Value.Append(hash[h].ToString("x2"));
                }
                tbMD5Value.Text = MD5Value.ToString();
            }
            if (selected == 1)
            {
                byte[] inputHex = ToByteArray(rtbInputData.Text);
                hash = md.ComputeHash(inputHex);

                for (int k = 0; k < hash.Length; k++)
                {
                    MD5Value.Append(hash[k].ToString("x2"));
                }
                tbMD5Value.Text = MD5Value.ToString();
            }
            if (selected == 2)
            {
                
                byte[] inputBin = GetBytesFromBinaryString(data);
                hash = md.ComputeHash(inputBin);
                for (int i = 0; i < hash.Length; i++)
                {
                    MD5Value.Append(hash[i].ToString("x2"));
                }
                tbMD5Value.Text = MD5Value.ToString();
            }
        }
        private void SHA1Hash()
        {
            byte[] hash;
            StringBuilder SHA1Value = new StringBuilder();

            if (selected == 0)
            {
                byte[] inputstr = System.Text.Encoding.ASCII.GetBytes(rtbInputData.Text);
                hash = sha1.ComputeHash(inputstr);

                for (int h = 0; h < hash.Length; h++)
                {
                    SHA1Value.Append(hash[h].ToString("x2"));
                }
                tbSHA1Value.Text = SHA1Value.ToString();
            }
            if (selected == 1)
            {
                byte[] inputhex = ToByteArray(rtbInputData.Text);
                hash = sha1.ComputeHash(inputhex);

                for (int k = 0; k < hash.Length; k++)
                {
                    SHA1Value.Append(hash[k].ToString("x2"));
                }
                tbSHA1Value.Text = SHA1Value.ToString();
            }
            if (selected == 2)
            {

                byte[] inputBin = GetBytesFromBinaryString(data);
                hash = sha1.ComputeHash(inputBin);
                for (int i = 0; i < hash.Length; i++)
                {
                    SHA1Value.Append(hash[i].ToString("x2"));
                }
                tbSHA1Value.Text = SHA1Value.ToString();
            }
        }

        private void SHA2Hash()
        {
            byte[] hash;
            StringBuilder SHA2Value = new StringBuilder();

            if (selected == 0)
            {
                byte[] inputData = System.Text.Encoding.ASCII.GetBytes(rtbInputData.Text);
                hash = sha2.ComputeHash(inputData);

                for (int h = 0; h < hash.Length; h++)
                {
                    SHA2Value.Append(hash[h].ToString("x2"));
                }
                tbSHA2Value.Text = SHA2Value.ToString();
            }
            if (selected == 1)
            {
                byte[] inputHex = ToByteArray(rtbInputData.Text);
                hash = sha2.ComputeHash(inputHex);

                for (int k = 0; k < hash.Length; k++)
                {
                    SHA2Value.Append(hash[k].ToString("x2"));
                }
                tbSHA2Value.Text = SHA2Value.ToString();
            }
            if (selected == 2)
            {
                
                if (cbSHA2.Checked == true)
                {
                    byte[] inputBin = GetBytesFromBinaryString(data);
                    hash = sha1.ComputeHash(inputBin);
                    for (int i = 0; i < hash.Length; i++)
                    {
                        SHA2Value.Append(hash[i].ToString("x2"));
                    }
                    tbSHA2Value.Text = SHA2Value.ToString();
                }
                else
                {
                    tbSHA2Value.Text = "";
                }
            }
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {

          

            MD5Hash();
            SHA1Hash();
            SHA2Hash();
            

        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                StreamReader streamReader = new StreamReader(ofd.FileName);
                data = streamReader.ReadToEnd();
                rtbInputData.Text = ofd.FileName.ToString();
                
            }
            
            tbSHA2Value.Text = "";
        }
    }
}
