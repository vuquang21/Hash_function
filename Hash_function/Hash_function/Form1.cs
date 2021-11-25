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
            var select = cbSelection.SelectedIndex;
            if (select == 0)
            {
                btnSelectFile.Enabled = false;
                rtbInputData.Text = "";
                
                tbMD5Value.Text = "";
                tbSHA1Value.Text = "";
                tbSHA2Value.Text = "";
            }
            else if (select == 1)
            {
                btnSelectFile.Enabled = false;
                rtbInputData.Text = "";
                
                tbMD5Value.Text = "";
                tbSHA1Value.Text = "";
                tbSHA2Value.Text = "";
            }
            else if (select == 2)
            {
                btnSelectFile.Enabled = true;
                
                tbMD5Value.Text = "";
                tbSHA1Value.Text = "";
                tbSHA2Value.Text = "";

            }
            

        }

        
        public void MD5Hash(StringBuilder MD5Value)
        {
            var data = rtbInputData.Text;
            //var dataByte = Convert.ToByte(data, 16).ToString();
           
            MD5 mh = MD5.Create();
            byte[] dataInput = Encoding.UTF8.GetBytes(data);
            byte[] hash = mh.ComputeHash(dataInput);
            

            for (int i = 0; i < hash.Length; i++)
            {
                MD5Value.Append(hash[i].ToString("x2"));
            }
            tbMD5Value.Text = MD5Value.ToString();
        }

        public void SHA1Hash(StringBuilder SHA1Value)
        {
            var data = rtbInputData.Text;
            SHA1 sHA1 = SHA1.Create();
            byte[] dataInput = Encoding.UTF8.GetBytes(data);
            
            byte[] hash = sHA1.ComputeHash(dataInput);

            for (int i = 0; i < hash.Length; i++)
            {
                SHA1Value.Append(hash[i].ToString("x2"));
            }
            tbSHA1Value.Text = SHA1Value.ToString();
        }

        public void SHA2Hash(StringBuilder SHA2Value)
        {
            var data = rtbInputData.Text;
            SHA256 sHA256 = SHA256.Create();
            byte[] dataInput = Encoding.UTF8.GetBytes(data);
            byte[] hash = sHA256.ComputeHash(dataInput);
            for (int i = 0; i < hash.Length; i++)
            {
                SHA2Value.Append(hash[i].ToString("x2"));
            }
            tbSHA2Value.Text = SHA2Value.ToString();
        }

        public bool Check(char[] dataInput, char[] word)
        {
            foreach (var item in word)
            {
                for (int j = 0; j < dataInput.Length; j++)
                {
                    if (dataInput[j] != word[j])
                        return true;
                }
            }
            return false;
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            StringBuilder MD5Value = new StringBuilder();
            StringBuilder SHA1Value = new StringBuilder();
            StringBuilder SHA2Value = new StringBuilder();
            
            var comboxValue = cbSelection.SelectedItem as string;

            if (comboxValue == "Hex string")
            {
                var dataInput = rtbInputData.Text;
                if (dataInput.Length % 2 != 0)
                {
                    MessageBox.Show("Warning: The Length hex string mush be even!!!");
                    tbMD5Value.Text = "";
                    tbSHA1Value.Text = "";
                    tbSHA2Value.Text = "";
                }
            }
            var selection = cbSelection.SelectedItem as String;
            var character = new char[12]
            {
                'A', 'B', 'C', 'D', 'E', 'F',
                'a', 'b', 'c', 'd', 'e', 'f'
            };
            if (selection == "Hex string")
            {
                var dataInput = rtbInputData.Text;
                var temp = new char[character.Length];
                for (int i = 0; i < temp.Length; i++)
                {
                    temp[i] = character[i];
                }
                int flag = 0;
                for (int i = 0; i < dataInput.Length; i++)
                {
                    if (Check(temp, character) == true)
                    {
                        MessageBox.Show("Warning: The hex string includes invalid symbols(s)!!!");
                        cbMD5.Checked = false;
                        cbSHA1.Checked = false;
                        cbSHA2.Checked = false;
                        tbMD5Value.Text = "";
                        tbSHA1Value.Text = "";
                        tbSHA2Value.Text = "";
                        flag = 1;
                    }
                }
                if (flag == 0)
                {
                    cbMD5.Checked = true;
                    cbSHA1.Checked = true;
                    cbSHA2.Checked = true;
                    MD5Hash(MD5Value);
                    SHA1Hash(SHA1Value);
                    SHA2Hash(SHA2Value);

                }

            }
            else if (selection == "Text string")
            {
                if (cbMD5.Checked == true)
                {
                    MD5Hash(MD5Value);
                    
                }
                else
                {
                    tbMD5Value.Text = "";
                }

                if (cbSHA1.Checked == true)
                {
                    SHA1Hash(SHA1Value);
                }
                else
                {
                    tbSHA1Value.Text = "";
                }
                if (cbSHA2.Checked == true)
                {
                    SHA2Hash(SHA2Value);

                }
                else
                {
                    tbSHA2Value.Text = "";
                }
            }
            else
            {
                MD5Hash(MD5Value);
                SHA1Hash(SHA1Value);
                SHA2Hash(SHA2Value);
            }
            

        }

        private void rtbInputData_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            string txtEditor;
            ofd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            //ofd.Filter = "Text files (*.txt)|*.txt";
            StreamReader reader;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtEditor = ofd.FileName.ToString();
                reader = new StreamReader(txtEditor);
                var filterReader = reader.ReadToEnd();
               
                rtbInputData.Text = filterReader.ToString();
            }
        }
    }
}
