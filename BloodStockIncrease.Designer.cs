namespace BloodBankMS
{
    partial class FormBldStckInc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBldStckInc));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LbHeading = new System.Windows.Forms.Label();
            this.LbLine1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbBxBloodGroup = new System.Windows.Forms.ComboBox();
            this.LbBloodGroup = new System.Windows.Forms.Label();
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.CmbBxUnits = new System.Windows.Forms.ComboBox();
            this.BtnIncrease = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.DGVBldStckInc = new System.Windows.Forms.DataGridView();
            this.BtnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVBldStckInc)).BeginInit();
            this.SuspendLayout();
            // 
            // LbHeading
            // 
            this.LbHeading.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LbHeading.AutoSize = true;
            this.LbHeading.BackColor = System.Drawing.Color.Transparent;
            this.LbHeading.Font = new System.Drawing.Font("Leelawadee", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbHeading.ForeColor = System.Drawing.Color.Sienna;
            this.LbHeading.Location = new System.Drawing.Point(230, 10);
            this.LbHeading.Name = "LbHeading";
            this.LbHeading.Size = new System.Drawing.Size(419, 39);
            this.LbHeading.TabIndex = 90;
            this.LbHeading.Text = "BLOOD STOCK - INCREASE";
            this.LbHeading.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LbLine1
            // 
            this.LbLine1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LbLine1.BackColor = System.Drawing.SystemColors.Desktop;
            this.LbLine1.Location = new System.Drawing.Point(0, 60);
            this.LbLine1.Name = "LbLine1";
            this.LbLine1.Size = new System.Drawing.Size(878, 4);
            this.LbLine1.TabIndex = 91;
            this.LbLine1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(0, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(878, 4);
            this.label1.TabIndex = 92;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.CmbBxBloodGroup.Location = new System.Drawing.Point(299, 79);
            this.CmbBxBloodGroup.Name = "CmbBxBloodGroup";
            this.CmbBxBloodGroup.Size = new System.Drawing.Size(150, 36);
            this.CmbBxBloodGroup.TabIndex = 93;
            // 
            // LbBloodGroup
            // 
            this.LbBloodGroup.BackColor = System.Drawing.Color.Transparent;
            this.LbBloodGroup.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LbBloodGroup.Font = new System.Drawing.Font("Faustina", 11F, System.Drawing.FontStyle.Bold);
            this.LbBloodGroup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LbBloodGroup.ImageIndex = 3;
            this.LbBloodGroup.ImageList = this.ImageList1;
            this.LbBloodGroup.Location = new System.Drawing.Point(117, 79);
            this.LbBloodGroup.Name = "LbBloodGroup";
            this.LbBloodGroup.Size = new System.Drawing.Size(170, 36);
            this.LbBloodGroup.TabIndex = 94;
            this.LbBloodGroup.Text = "BloodGroup";
            this.LbBloodGroup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ImageList1
            // 
            this.ImageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList1.ImageStream")));
            this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList1.Images.SetKeyName(0, "save.png");
            this.ImageList1.Images.SetKeyName(1, "ResetW11Color.png");
            this.ImageList1.Images.SetKeyName(2, "search.png");
            this.ImageList1.Images.SetKeyName(3, "Blood group.png");
            this.ImageList1.Images.SetKeyName(4, "Inc.png");
            // 
            // CmbBxUnits
            // 
            this.CmbBxUnits.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CmbBxUnits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBxUnits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmbBxUnits.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbBxUnits.FormattingEnabled = true;
            this.CmbBxUnits.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.CmbBxUnits.Location = new System.Drawing.Point(611, 79);
            this.CmbBxUnits.Name = "CmbBxUnits";
            this.CmbBxUnits.Size = new System.Drawing.Size(150, 36);
            this.CmbBxUnits.TabIndex = 95;
            // 
            // BtnIncrease
            // 
            this.BtnIncrease.AutoSize = true;
            this.BtnIncrease.BackColor = System.Drawing.Color.Ivory;
            this.BtnIncrease.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnIncrease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIncrease.Font = new System.Drawing.Font("Faustina", 12F, System.Drawing.FontStyle.Bold);
            this.BtnIncrease.ForeColor = System.Drawing.Color.Sienna;
            this.BtnIncrease.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnIncrease.ImageIndex = 4;
            this.BtnIncrease.ImageList = this.ImageList1;
            this.BtnIncrease.Location = new System.Drawing.Point(281, 132);
            this.BtnIncrease.Name = "BtnIncrease";
            this.BtnIncrease.Size = new System.Drawing.Size(140, 42);
            this.BtnIncrease.TabIndex = 96;
            this.BtnIncrease.Text = "Increase";
            this.BtnIncrease.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnIncrease.UseVisualStyleBackColor = false;
            this.BtnIncrease.Click += new System.EventHandler(this.BtnIncrease_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Faustina", 11F, System.Drawing.FontStyle.Bold);
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.ImageIndex = 3;
            this.label2.Location = new System.Drawing.Point(467, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 30);
            this.label2.TabIndex = 97;
            this.label2.Text = "Units (In ml)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DGVBldStckInc
            // 
            this.DGVBldStckInc.AllowUserToAddRows = false;
            this.DGVBldStckInc.AllowUserToDeleteRows = false;
            this.DGVBldStckInc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVBldStckInc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVBldStckInc.BackgroundColor = System.Drawing.Color.Gray;
            this.DGVBldStckInc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Sienna;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVBldStckInc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DGVBldStckInc.ColumnHeadersHeight = 34;
            this.DGVBldStckInc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DGVBldStckInc.EnableHeadersVisualStyles = false;
            this.DGVBldStckInc.Location = new System.Drawing.Point(9, 210);
            this.DGVBldStckInc.Name = "DGVBldStckInc";
            this.DGVBldStckInc.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVBldStckInc.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DGVBldStckInc.RowHeadersWidth = 40;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            this.DGVBldStckInc.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.DGVBldStckInc.RowTemplate.Height = 28;
            this.DGVBldStckInc.Size = new System.Drawing.Size(860, 420);
            this.DGVBldStckInc.TabIndex = 98;
            // 
            // BtnClear
            // 
            this.BtnClear.AutoSize = true;
            this.BtnClear.BackColor = System.Drawing.Color.Ivory;
            this.BtnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClear.Font = new System.Drawing.Font("Faustina", 12F, System.Drawing.FontStyle.Bold);
            this.BtnClear.ForeColor = System.Drawing.Color.Sienna;
            this.BtnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnClear.ImageIndex = 1;
            this.BtnClear.ImageList = this.ImageList1;
            this.BtnClear.Location = new System.Drawing.Point(457, 132);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(120, 42);
            this.BtnClear.TabIndex = 99;
            this.BtnClear.Text = "Clear";
            this.BtnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // FormBldStckInc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::BloodBankMS.Properties.Resources.AllPageBgImg;
            this.ClientSize = new System.Drawing.Size(878, 644);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.DGVBldStckInc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnIncrease);
            this.Controls.Add(this.CmbBxUnits);
            this.Controls.Add(this.CmbBxBloodGroup);
            this.Controls.Add(this.LbBloodGroup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LbLine1);
            this.Controls.Add(this.LbHeading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormBldStckInc";
            this.Text = "BloodBank Management";
            this.Load += new System.EventHandler(this.FormBldStckInc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVBldStckInc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbHeading;
        private System.Windows.Forms.Label LbLine1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbBxBloodGroup;
        private System.Windows.Forms.Label LbBloodGroup;
        private System.Windows.Forms.ImageList ImageList1;
        private System.Windows.Forms.ComboBox CmbBxUnits;
        private System.Windows.Forms.Button BtnIncrease;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DGVBldStckInc;
        private System.Windows.Forms.Button BtnClear;
    }
}