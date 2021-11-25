namespace Hash_function
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSelection = new System.Windows.Forms.ComboBox();
            this.cbMD5 = new System.Windows.Forms.CheckBox();
            this.cbSHA1 = new System.Windows.Forms.CheckBox();
            this.cbSHA2 = new System.Windows.Forms.CheckBox();
            this.tbMD5Value = new System.Windows.Forms.TextBox();
            this.tbSHA1Value = new System.Windows.Forms.TextBox();
            this.tbSHA2Value = new System.Windows.Forms.TextBox();
            this.rtbInputData = new System.Windows.Forms.RichTextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Fomat:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data:";
            // 
            // cbSelection
            // 
            this.cbSelection.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbSelection.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSelection.FormattingEnabled = true;
            this.cbSelection.Items.AddRange(new object[] {
            "Text string",
            "Hex string",
            "Binary file"});
            this.cbSelection.Location = new System.Drawing.Point(19, 61);
            this.cbSelection.Name = "cbSelection";
            this.cbSelection.Size = new System.Drawing.Size(94, 24);
            this.cbSelection.TabIndex = 0;
            // 
            // cbMD5
            // 
            this.cbMD5.AutoSize = true;
            this.cbMD5.Location = new System.Drawing.Point(36, 143);
            this.cbMD5.Name = "cbMD5";
            this.cbMD5.Size = new System.Drawing.Size(57, 20);
            this.cbMD5.TabIndex = 2;
            this.cbMD5.Text = "MD5";
            this.cbMD5.UseVisualStyleBackColor = true;
            // 
            // cbSHA1
            // 
            this.cbSHA1.AutoSize = true;
            this.cbSHA1.Location = new System.Drawing.Point(36, 203);
            this.cbSHA1.Name = "cbSHA1";
            this.cbSHA1.Size = new System.Drawing.Size(68, 20);
            this.cbSHA1.TabIndex = 3;
            this.cbSHA1.Text = "SHA-1";
            this.cbSHA1.UseVisualStyleBackColor = true;
            // 
            // cbSHA2
            // 
            this.cbSHA2.AutoSize = true;
            this.cbSHA2.Location = new System.Drawing.Point(36, 268);
            this.cbSHA2.Name = "cbSHA2";
            this.cbSHA2.Size = new System.Drawing.Size(68, 20);
            this.cbSHA2.TabIndex = 4;
            this.cbSHA2.Text = "SHA-2";
            this.cbSHA2.UseVisualStyleBackColor = true;
            // 
            // tbMD5Value
            // 
            this.tbMD5Value.Location = new System.Drawing.Point(132, 143);
            this.tbMD5Value.Name = "tbMD5Value";
            this.tbMD5Value.ReadOnly = true;
            this.tbMD5Value.Size = new System.Drawing.Size(523, 22);
            this.tbMD5Value.TabIndex = 7;
            this.tbMD5Value.TabStop = false;
            // 
            // tbSHA1Value
            // 
            this.tbSHA1Value.Location = new System.Drawing.Point(132, 201);
            this.tbSHA1Value.Name = "tbSHA1Value";
            this.tbSHA1Value.ReadOnly = true;
            this.tbSHA1Value.Size = new System.Drawing.Size(523, 22);
            this.tbSHA1Value.TabIndex = 8;
            this.tbSHA1Value.TabStop = false;
            // 
            // tbSHA2Value
            // 
            this.tbSHA2Value.Location = new System.Drawing.Point(132, 266);
            this.tbSHA2Value.Name = "tbSHA2Value";
            this.tbSHA2Value.ReadOnly = true;
            this.tbSHA2Value.Size = new System.Drawing.Size(523, 22);
            this.tbSHA2Value.TabIndex = 9;
            this.tbSHA2Value.TabStop = false;
            // 
            // rtbInputData
            // 
            this.rtbInputData.Location = new System.Drawing.Point(132, 61);
            this.rtbInputData.Name = "rtbInputData";
            this.rtbInputData.Size = new System.Drawing.Size(523, 24);
            this.rtbInputData.TabIndex = 1;
            this.rtbInputData.Text = "";
            this.rtbInputData.TextChanged += new System.EventHandler(this.rtbInputData_TextChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(552, 332);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(103, 40);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(552, 91);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(103, 30);
            this.btnSelectFile.TabIndex = 11;
            this.btnSelectFile.Text = "Browse";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 420);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.rtbInputData);
            this.Controls.Add(this.tbSHA2Value);
            this.Controls.Add(this.tbSHA1Value);
            this.Controls.Add(this.tbMD5Value);
            this.Controls.Add(this.cbSHA2);
            this.Controls.Add(this.cbSHA1);
            this.Controls.Add(this.cbMD5);
            this.Controls.Add(this.cbSelection);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSelection;
        private System.Windows.Forms.CheckBox cbMD5;
        private System.Windows.Forms.CheckBox cbSHA1;
        private System.Windows.Forms.CheckBox cbSHA2;
        private System.Windows.Forms.TextBox tbMD5Value;
        private System.Windows.Forms.TextBox tbSHA1Value;
        private System.Windows.Forms.TextBox tbSHA2Value;
        private System.Windows.Forms.RichTextBox rtbInputData;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnSelectFile;
    }
}

