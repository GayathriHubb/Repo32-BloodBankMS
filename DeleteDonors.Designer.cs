namespace BloodBankMS
{
    partial class FormDeleteDonors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDeleteDonors));
            this.NUDDonorId = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.LbLine3 = new System.Windows.Forms.Label();
            this.BtnClear = new System.Windows.Forms.Button();
            this.DTPDOB = new System.Windows.Forms.DateTimePicker();
            this.CmbBxBloodGroup = new System.Windows.Forms.ComboBox();
            this.CmbBxGender = new System.Windows.Forms.ComboBox();
            this.TxtBxAddrss = new System.Windows.Forms.TextBox();
            this.TxtBxCity = new System.Windows.Forms.TextBox();
            this.TxtBxEmail = new System.Windows.Forms.TextBox();
            this.TxtBxName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.MTBPhnNum = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LbLine2 = new System.Windows.Forms.Label();
            this.LbLine1 = new System.Windows.Forms.Label();
            this.LbLoginHeading = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NUDDonorId)).BeginInit();
            this.SuspendLayout();
            // 
            // NUDDonorId
            // 
            this.NUDDonorId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NUDDonorId.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUDDonorId.ForeColor = System.Drawing.Color.Navy;
            this.NUDDonorId.Location = new System.Drawing.Point(332, 95);
            this.NUDDonorId.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NUDDonorId.Name = "NUDDonorId";
            this.NUDDonorId.Size = new System.Drawing.Size(200, 39);
            this.NUDDonorId.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Faustina", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(228, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 82;
            this.label1.Text = "Donor Id";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnSearch
            // 
            this.BtnSearch.AutoSize = true;
            this.BtnSearch.BackColor = System.Drawing.Color.Ivory;
            this.BtnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearch.Font = new System.Drawing.Font("Faustina", 12F, System.Drawing.FontStyle.Bold);
            this.BtnSearch.ForeColor = System.Drawing.Color.Sienna;
            this.BtnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSearch.ImageIndex = 2;
            this.BtnSearch.ImageList = this.ImageList1;
            this.BtnSearch.Location = new System.Drawing.Point(561, 93);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(140, 42);
            this.BtnSearch.TabIndex = 1;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSearch.UseVisualStyleBackColor = false;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // ImageList1
            // 
            this.ImageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList1.ImageStream")));
            this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList1.Images.SetKeyName(0, "save.png");
            this.ImageList1.Images.SetKeyName(1, "ResetW11Color.png");
            this.ImageList1.Images.SetKeyName(2, "search.png");
            // 
            // LbLine3
            // 
            this.LbLine3.BackColor = System.Drawing.SystemColors.Desktop;
            this.LbLine3.Location = new System.Drawing.Point(-2, 152);
            this.LbLine3.Name = "LbLine3";
            this.LbLine3.Size = new System.Drawing.Size(938, 4);
            this.LbLine3.TabIndex = 81;
            this.LbLine3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.BtnClear.Location = new System.Drawing.Point(494, 576);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(150, 47);
            this.BtnClear.TabIndex = 4;
            this.BtnClear.Text = "Reset";
            this.BtnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // DTPDOB
            // 
            this.DTPDOB.Enabled = false;
            this.DTPDOB.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPDOB.Location = new System.Drawing.Point(582, 197);
            this.DTPDOB.Name = "DTPDOB";
            this.DTPDOB.Size = new System.Drawing.Size(250, 34);
            this.DTPDOB.TabIndex = 64;
            // 
            // CmbBxBloodGroup
            // 
            this.CmbBxBloodGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CmbBxBloodGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBxBloodGroup.Enabled = false;
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
            this.CmbBxBloodGroup.Location = new System.Drawing.Point(582, 257);
            this.CmbBxBloodGroup.Name = "CmbBxBloodGroup";
            this.CmbBxBloodGroup.Size = new System.Drawing.Size(220, 36);
            this.CmbBxBloodGroup.TabIndex = 65;
            // 
            // CmbBxGender
            // 
            this.CmbBxGender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CmbBxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBxGender.Enabled = false;
            this.CmbBxGender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmbBxGender.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbBxGender.FormattingEnabled = true;
            this.CmbBxGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.CmbBxGender.Location = new System.Drawing.Point(122, 257);
            this.CmbBxGender.Name = "CmbBxGender";
            this.CmbBxGender.Size = new System.Drawing.Size(220, 36);
            this.CmbBxGender.TabIndex = 61;
            // 
            // TxtBxAddrss
            // 
            this.TxtBxAddrss.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBxAddrss.Enabled = false;
            this.TxtBxAddrss.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxAddrss.Location = new System.Drawing.Point(582, 376);
            this.TxtBxAddrss.Multiline = true;
            this.TxtBxAddrss.Name = "TxtBxAddrss";
            this.TxtBxAddrss.Size = new System.Drawing.Size(300, 140);
            this.TxtBxAddrss.TabIndex = 67;
            // 
            // TxtBxCity
            // 
            this.TxtBxCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBxCity.Enabled = false;
            this.TxtBxCity.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxCity.Location = new System.Drawing.Point(582, 313);
            this.TxtBxCity.Name = "TxtBxCity";
            this.TxtBxCity.Size = new System.Drawing.Size(300, 34);
            this.TxtBxCity.TabIndex = 66;
            // 
            // TxtBxEmail
            // 
            this.TxtBxEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBxEmail.Enabled = false;
            this.TxtBxEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxEmail.Location = new System.Drawing.Point(122, 372);
            this.TxtBxEmail.Name = "TxtBxEmail";
            this.TxtBxEmail.Size = new System.Drawing.Size(300, 34);
            this.TxtBxEmail.TabIndex = 63;
            // 
            // TxtBxName
            // 
            this.TxtBxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBxName.Enabled = false;
            this.TxtBxName.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxName.Location = new System.Drawing.Point(122, 200);
            this.TxtBxName.Name = "TxtBxName";
            this.TxtBxName.Size = new System.Drawing.Size(300, 34);
            this.TxtBxName.TabIndex = 60;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Faustina", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(454, 376);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 25);
            this.label9.TabIndex = 80;
            this.label9.Text = "Address";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnDelete
            // 
            this.BtnDelete.AutoSize = true;
            this.BtnDelete.BackColor = System.Drawing.Color.Ivory;
            this.BtnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.Font = new System.Drawing.Font("Faustina", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.ForeColor = System.Drawing.Color.Sienna;
            this.BtnDelete.Image = ((System.Drawing.Image)(resources.GetObject("BtnDelete.Image")));
            this.BtnDelete.Location = new System.Drawing.Point(284, 576);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(150, 47);
            this.BtnDelete.TabIndex = 3;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // MTBPhnNum
            // 
            this.MTBPhnNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MTBPhnNum.Enabled = false;
            this.MTBPhnNum.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MTBPhnNum.Location = new System.Drawing.Point(122, 313);
            this.MTBPhnNum.Mask = "0000000000";
            this.MTBPhnNum.Name = "MTBPhnNum";
            this.MTBPhnNum.Size = new System.Drawing.Size(220, 34);
            this.MTBPhnNum.TabIndex = 62;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Faustina", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(454, 318);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 25);
            this.label8.TabIndex = 79;
            this.label8.Text = "City";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Faustina", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 377);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 25);
            this.label7.TabIndex = 78;
            this.label7.Text = "Email";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Faustina", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 25);
            this.label6.TabIndex = 77;
            this.label6.Text = "PhnNum";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Faustina", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 25);
            this.label5.TabIndex = 76;
            this.label5.Text = "Gender";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Faustina", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 25);
            this.label4.TabIndex = 75;
            this.label4.Text = "FullName";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Faustina", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(454, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 25);
            this.label3.TabIndex = 74;
            this.label3.Text = "DateOfBirth";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Faustina", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(454, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 73;
            this.label2.Text = "BloodGroup";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LbLine2
            // 
            this.LbLine2.BackColor = System.Drawing.SystemColors.Desktop;
            this.LbLine2.Location = new System.Drawing.Point(-7, 556);
            this.LbLine2.Name = "LbLine2";
            this.LbLine2.Size = new System.Drawing.Size(938, 4);
            this.LbLine2.TabIndex = 72;
            this.LbLine2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LbLine1
            // 
            this.LbLine1.BackColor = System.Drawing.SystemColors.Desktop;
            this.LbLine1.Location = new System.Drawing.Point(-2, 72);
            this.LbLine1.Name = "LbLine1";
            this.LbLine1.Size = new System.Drawing.Size(938, 4);
            this.LbLine1.TabIndex = 71;
            this.LbLine1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LbLoginHeading
            // 
            this.LbLoginHeading.AutoSize = true;
            this.LbLoginHeading.BackColor = System.Drawing.Color.Transparent;
            this.LbLoginHeading.Font = new System.Drawing.Font("Leelawadee", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbLoginHeading.ForeColor = System.Drawing.Color.Sienna;
            this.LbLoginHeading.Location = new System.Drawing.Point(328, 22);
            this.LbLoginHeading.Name = "LbLoginHeading";
            this.LbLoginHeading.Size = new System.Drawing.Size(272, 39);
            this.LbLoginHeading.TabIndex = 70;
            this.LbLoginHeading.Text = "DELETE DONORS";
            this.LbLoginHeading.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormDeleteDonors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::BloodBankMS.Properties.Resources.AllPageBgImg;
            this.ClientSize = new System.Drawing.Size(928, 644);
            this.Controls.Add(this.NUDDonorId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.LbLine3);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.DTPDOB);
            this.Controls.Add(this.CmbBxBloodGroup);
            this.Controls.Add(this.CmbBxGender);
            this.Controls.Add(this.TxtBxAddrss);
            this.Controls.Add(this.TxtBxCity);
            this.Controls.Add(this.TxtBxEmail);
            this.Controls.Add(this.TxtBxName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.MTBPhnNum);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LbLine2);
            this.Controls.Add(this.LbLine1);
            this.Controls.Add(this.LbLoginHeading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormDeleteDonors";
            this.Text = "BloodBank Management";
            ((System.ComponentModel.ISupportInitialize)(this.NUDDonorId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown NUDDonorId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.ImageList ImageList1;
        private System.Windows.Forms.Label LbLine3;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.DateTimePicker DTPDOB;
        private System.Windows.Forms.ComboBox CmbBxBloodGroup;
        private System.Windows.Forms.ComboBox CmbBxGender;
        private System.Windows.Forms.TextBox TxtBxAddrss;
        private System.Windows.Forms.TextBox TxtBxCity;
        private System.Windows.Forms.TextBox TxtBxEmail;
        private System.Windows.Forms.TextBox TxtBxName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.MaskedTextBox MTBPhnNum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LbLine2;
        private System.Windows.Forms.Label LbLine1;
        private System.Windows.Forms.Label LbLoginHeading;
    }
}