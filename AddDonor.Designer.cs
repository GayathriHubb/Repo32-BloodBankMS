namespace BloodBankMS
{
    partial class FormAddDonor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddDonor));
            this.LbLoginHeading = new System.Windows.Forms.Label();
            this.LbLine1 = new System.Windows.Forms.Label();
            this.LbLine2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LbDonorId = new System.Windows.Forms.Label();
            this.TxtBxName = new System.Windows.Forms.TextBox();
            this.TxtBxEmail = new System.Windows.Forms.TextBox();
            this.TxtBxCity = new System.Windows.Forms.TextBox();
            this.TxtBxAddrss = new System.Windows.Forms.TextBox();
            this.CmbBxGender = new System.Windows.Forms.ComboBox();
            this.CmbBxBloodGroup = new System.Windows.Forms.ComboBox();
            this.MTBPhnNum = new System.Windows.Forms.MaskedTextBox();
            this.DTPDOB = new System.Windows.Forms.DateTimePicker();
            this.BtnClear = new System.Windows.Forms.Button();
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.BtnSignUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LbLoginHeading
            // 
            this.LbLoginHeading.AutoSize = true;
            this.LbLoginHeading.BackColor = System.Drawing.Color.Transparent;
            this.LbLoginHeading.Font = new System.Drawing.Font("Leelawadee", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbLoginHeading.ForeColor = System.Drawing.Color.Sienna;
            this.LbLoginHeading.Location = new System.Drawing.Point(361, 20);
            this.LbLoginHeading.Name = "LbLoginHeading";
            this.LbLoginHeading.Size = new System.Drawing.Size(233, 39);
            this.LbLoginHeading.TabIndex = 19;
            this.LbLoginHeading.Text = "ADD DONORS";
            this.LbLoginHeading.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LbLine1
            // 
            this.LbLine1.BackColor = System.Drawing.SystemColors.Desktop;
            this.LbLine1.Location = new System.Drawing.Point(0, 65);
            this.LbLine1.Name = "LbLine1";
            this.LbLine1.Size = new System.Drawing.Size(938, 4);
            this.LbLine1.TabIndex = 20;
            this.LbLine1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LbLine2
            // 
            this.LbLine2.BackColor = System.Drawing.SystemColors.Desktop;
            this.LbLine2.Location = new System.Drawing.Point(0, 550);
            this.LbLine2.Name = "LbLine2";
            this.LbLine2.Size = new System.Drawing.Size(938, 4);
            this.LbLine2.TabIndex = 21;
            this.LbLine2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Faustina", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "Donor Id";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Faustina", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(458, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "BloodGroup";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Faustina", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(458, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 25);
            this.label3.TabIndex = 24;
            this.label3.Text = "DateOfBirth";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Faustina", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 25);
            this.label4.TabIndex = 25;
            this.label4.Text = "FullName";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Faustina", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 25);
            this.label5.TabIndex = 26;
            this.label5.Text = "Gender";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Faustina", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 25);
            this.label6.TabIndex = 27;
            this.label6.Text = "PhnNum";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Faustina", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 364);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 25);
            this.label7.TabIndex = 28;
            this.label7.Text = "Email";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Faustina", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(458, 248);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 25);
            this.label8.TabIndex = 29;
            this.label8.Text = "City";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Faustina", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(458, 297);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 25);
            this.label9.TabIndex = 30;
            this.label9.Text = "Address";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LbDonorId
            // 
            this.LbDonorId.AutoSize = true;
            this.LbDonorId.BackColor = System.Drawing.Color.Transparent;
            this.LbDonorId.Font = new System.Drawing.Font("Faustina ExtraBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbDonorId.ForeColor = System.Drawing.Color.Sienna;
            this.LbDonorId.Location = new System.Drawing.Point(129, 120);
            this.LbDonorId.Name = "LbDonorId";
            this.LbDonorId.Size = new System.Drawing.Size(39, 35);
            this.LbDonorId.TabIndex = 31;
            this.LbDonorId.Text = "{?}";
            this.LbDonorId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxtBxName
            // 
            this.TxtBxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBxName.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxName.Location = new System.Drawing.Point(129, 187);
            this.TxtBxName.Name = "TxtBxName";
            this.TxtBxName.Size = new System.Drawing.Size(300, 34);
            this.TxtBxName.TabIndex = 3;
            // 
            // TxtBxEmail
            // 
            this.TxtBxEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBxEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxEmail.Location = new System.Drawing.Point(129, 359);
            this.TxtBxEmail.Name = "TxtBxEmail";
            this.TxtBxEmail.Size = new System.Drawing.Size(300, 34);
            this.TxtBxEmail.TabIndex = 6;
            // 
            // TxtBxCity
            // 
            this.TxtBxCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBxCity.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxCity.Location = new System.Drawing.Point(586, 243);
            this.TxtBxCity.Name = "TxtBxCity";
            this.TxtBxCity.Size = new System.Drawing.Size(300, 34);
            this.TxtBxCity.TabIndex = 9;
            // 
            // TxtBxAddrss
            // 
            this.TxtBxAddrss.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBxAddrss.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxAddrss.Location = new System.Drawing.Point(586, 297);
            this.TxtBxAddrss.Multiline = true;
            this.TxtBxAddrss.Name = "TxtBxAddrss";
            this.TxtBxAddrss.Size = new System.Drawing.Size(300, 140);
            this.TxtBxAddrss.TabIndex = 10;
            // 
            // CmbBxGender
            // 
            this.CmbBxGender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CmbBxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBxGender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmbBxGender.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbBxGender.FormattingEnabled = true;
            this.CmbBxGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.CmbBxGender.Location = new System.Drawing.Point(129, 242);
            this.CmbBxGender.Name = "CmbBxGender";
            this.CmbBxGender.Size = new System.Drawing.Size(220, 36);
            this.CmbBxGender.TabIndex = 4;
            // 
            // CmbBxBloodGroup
            // 
            this.CmbBxBloodGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CmbBxBloodGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBxBloodGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmbBxBloodGroup.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbBxBloodGroup.FormattingEnabled = true;
            this.CmbBxBloodGroup.Items.AddRange(new object[] {
            "A+",
            "B+",
            "O+",
            "AB+",
            "A-",
            "B-",
            "O-",
            "AB-"});
            this.CmbBxBloodGroup.Location = new System.Drawing.Point(586, 186);
            this.CmbBxBloodGroup.Name = "CmbBxBloodGroup";
            this.CmbBxBloodGroup.Size = new System.Drawing.Size(220, 36);
            this.CmbBxBloodGroup.TabIndex = 8;
            // 
            // MTBPhnNum
            // 
            this.MTBPhnNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MTBPhnNum.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MTBPhnNum.Location = new System.Drawing.Point(129, 300);
            this.MTBPhnNum.Mask = "0000000000";
            this.MTBPhnNum.Name = "MTBPhnNum";
            this.MTBPhnNum.Size = new System.Drawing.Size(220, 34);
            this.MTBPhnNum.TabIndex = 5;
            // 
            // DTPDOB
            // 
            this.DTPDOB.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPDOB.Location = new System.Drawing.Point(586, 118);
            this.DTPDOB.Name = "DTPDOB";
            this.DTPDOB.Size = new System.Drawing.Size(250, 34);
            this.DTPDOB.TabIndex = 7;
            // 
            // BtnClear
            // 
            this.BtnClear.AutoSize = true;
            this.BtnClear.BackColor = System.Drawing.Color.Ivory;
            this.BtnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClear.Font = new System.Drawing.Font("Faustina", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.ForeColor = System.Drawing.Color.Sienna;
            this.BtnClear.ImageIndex = 1;
            this.BtnClear.ImageList = this.ImageList1;
            this.BtnClear.Location = new System.Drawing.Point(489, 570);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(150, 47);
            this.BtnClear.TabIndex = 2;
            this.BtnClear.Text = "Reset";
            this.BtnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // ImageList1
            // 
            this.ImageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList1.ImageStream")));
            this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList1.Images.SetKeyName(0, "save.png");
            this.ImageList1.Images.SetKeyName(1, "ResetW11Color.png");
            // 
            // BtnSignUp
            // 
            this.BtnSignUp.AutoSize = true;
            this.BtnSignUp.BackColor = System.Drawing.Color.Ivory;
            this.BtnSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSignUp.Font = new System.Drawing.Font("Faustina", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSignUp.ForeColor = System.Drawing.Color.Sienna;
            this.BtnSignUp.ImageIndex = 0;
            this.BtnSignUp.ImageList = this.ImageList1;
            this.BtnSignUp.Location = new System.Drawing.Point(279, 570);
            this.BtnSignUp.Name = "BtnSignUp";
            this.BtnSignUp.Size = new System.Drawing.Size(150, 47);
            this.BtnSignUp.TabIndex = 1;
            this.BtnSignUp.Text = "Save";
            this.BtnSignUp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSignUp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSignUp.UseVisualStyleBackColor = false;
            this.BtnSignUp.Click += new System.EventHandler(this.BtnSignUp_Click);
            // 
            // FormAddDonor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::BloodBankMS.Properties.Resources.AllPageBgImg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(928, 644);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnSignUp);
            this.Controls.Add(this.DTPDOB);
            this.Controls.Add(this.MTBPhnNum);
            this.Controls.Add(this.CmbBxBloodGroup);
            this.Controls.Add(this.CmbBxGender);
            this.Controls.Add(this.TxtBxAddrss);
            this.Controls.Add(this.TxtBxCity);
            this.Controls.Add(this.TxtBxEmail);
            this.Controls.Add(this.TxtBxName);
            this.Controls.Add(this.LbDonorId);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LbLine2);
            this.Controls.Add(this.LbLine1);
            this.Controls.Add(this.LbLoginHeading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormAddDonor";
            this.Text = "BloodBank Management";
            this.Load += new System.EventHandler(this.FormAddDonor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbLoginHeading;
        private System.Windows.Forms.Label LbLine1;
        private System.Windows.Forms.Label LbLine2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LbDonorId;
        private System.Windows.Forms.TextBox TxtBxName;
        private System.Windows.Forms.TextBox TxtBxEmail;
        private System.Windows.Forms.TextBox TxtBxCity;
        private System.Windows.Forms.TextBox TxtBxAddrss;
        private System.Windows.Forms.ComboBox CmbBxGender;
        private System.Windows.Forms.ComboBox CmbBxBloodGroup;
        private System.Windows.Forms.MaskedTextBox MTBPhnNum;
        private System.Windows.Forms.DateTimePicker DTPDOB;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnSignUp;
        private System.Windows.Forms.ImageList ImageList1;
    }
}