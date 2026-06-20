namespace BloodBankMS
{
    partial class FormBldStckDec
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBldStckDec));
            this.DGVBldStckDec = new System.Windows.Forms.DataGridView();
            this.CmbBxBloodGroup = new System.Windows.Forms.ComboBox();
            this.LbBloodGroup = new System.Windows.Forms.Label();
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.LbLine1 = new System.Windows.Forms.Label();
            this.LbHeading = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnDecrease = new System.Windows.Forms.Button();
            this.CmbBxUnits = new System.Windows.Forms.ComboBox();
            this.BtnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVBldStckDec)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVBldStckDec
            // 
            this.DGVBldStckDec.AllowUserToAddRows = false;
            this.DGVBldStckDec.AllowUserToDeleteRows = false;
            this.DGVBldStckDec.AllowUserToResizeRows = false;
            this.DGVBldStckDec.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVBldStckDec.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVBldStckDec.BackgroundColor = System.Drawing.Color.Gray;
            this.DGVBldStckDec.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Sienna;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVBldStckDec.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVBldStckDec.ColumnHeadersHeight = 34;
            this.DGVBldStckDec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVBldStckDec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DGVBldStckDec.EnableHeadersVisualStyles = false;
            this.DGVBldStckDec.Location = new System.Drawing.Point(9, 210);
            this.DGVBldStckDec.Name = "DGVBldStckDec";
            this.DGVBldStckDec.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVBldStckDec.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVBldStckDec.RowHeadersWidth = 40;
            this.DGVBldStckDec.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.DGVBldStckDec.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DGVBldStckDec.RowTemplate.Height = 28;
            this.DGVBldStckDec.Size = new System.Drawing.Size(860, 420);
            this.DGVBldStckDec.TabIndex = 10;
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
            this.CmbBxBloodGroup.Location = new System.Drawing.Point(299, 82);
            this.CmbBxBloodGroup.Name = "CmbBxBloodGroup";
            this.CmbBxBloodGroup.Size = new System.Drawing.Size(150, 36);
            this.CmbBxBloodGroup.TabIndex = 104;
            // 
            // LbBloodGroup
            // 
            this.LbBloodGroup.BackColor = System.Drawing.Color.Transparent;
            this.LbBloodGroup.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LbBloodGroup.Font = new System.Drawing.Font("Faustina", 11F, System.Drawing.FontStyle.Bold);
            this.LbBloodGroup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LbBloodGroup.ImageIndex = 3;
            this.LbBloodGroup.ImageList = this.ImageList1;
            this.LbBloodGroup.Location = new System.Drawing.Point(117, 82);
            this.LbBloodGroup.Name = "LbBloodGroup";
            this.LbBloodGroup.Size = new System.Drawing.Size(170, 36);
            this.LbBloodGroup.TabIndex = 105;
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
            this.ImageList1.Images.SetKeyName(5, "Dec.png");
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(0, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(878, 4);
            this.label1.TabIndex = 103;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LbLine1
            // 
            this.LbLine1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LbLine1.BackColor = System.Drawing.SystemColors.Desktop;
            this.LbLine1.Location = new System.Drawing.Point(0, 59);
            this.LbLine1.Name = "LbLine1";
            this.LbLine1.Size = new System.Drawing.Size(878, 4);
            this.LbLine1.TabIndex = 102;
            this.LbLine1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LbHeading
            // 
            this.LbHeading.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LbHeading.AutoSize = true;
            this.LbHeading.BackColor = System.Drawing.Color.Transparent;
            this.LbHeading.Font = new System.Drawing.Font("Leelawadee", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbHeading.ForeColor = System.Drawing.Color.Sienna;
            this.LbHeading.Location = new System.Drawing.Point(227, 9);
            this.LbHeading.Name = "LbHeading";
            this.LbHeading.Size = new System.Drawing.Size(425, 39);
            this.LbHeading.TabIndex = 101;
            this.LbHeading.Text = "BLOOD STOCK - DECREASE";
            this.LbHeading.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Faustina", 11F, System.Drawing.FontStyle.Bold);
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.ImageIndex = 3;
            this.label2.Location = new System.Drawing.Point(463, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 30);
            this.label2.TabIndex = 108;
            this.label2.Text = "Units (In ml)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BtnDecrease
            // 
            this.BtnDecrease.AutoSize = true;
            this.BtnDecrease.BackColor = System.Drawing.Color.Ivory;
            this.BtnDecrease.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDecrease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDecrease.Font = new System.Drawing.Font("Faustina", 12F, System.Drawing.FontStyle.Bold);
            this.BtnDecrease.ForeColor = System.Drawing.Color.Sienna;
            this.BtnDecrease.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDecrease.ImageIndex = 5;
            this.BtnDecrease.ImageList = this.ImageList1;
            this.BtnDecrease.Location = new System.Drawing.Point(267, 132);
            this.BtnDecrease.Name = "BtnDecrease";
            this.BtnDecrease.Size = new System.Drawing.Size(150, 42);
            this.BtnDecrease.TabIndex = 107;
            this.BtnDecrease.Text = "Decrease";
            this.BtnDecrease.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnDecrease.UseVisualStyleBackColor = false;
            this.BtnDecrease.Click += new System.EventHandler(this.BtnDecrease_Click);
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
            this.CmbBxUnits.Location = new System.Drawing.Point(611, 82);
            this.CmbBxUnits.Name = "CmbBxUnits";
            this.CmbBxUnits.Size = new System.Drawing.Size(150, 36);
            this.CmbBxUnits.TabIndex = 106;
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
            this.BtnClear.Location = new System.Drawing.Point(491, 132);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(120, 42);
            this.BtnClear.TabIndex = 110;
            this.BtnClear.Text = "Clear";
            this.BtnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // FormBldStckDec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::BloodBankMS.Properties.Resources.AllPageBgImg;
            this.ClientSize = new System.Drawing.Size(878, 644);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.DGVBldStckDec);
            this.Controls.Add(this.CmbBxBloodGroup);
            this.Controls.Add(this.LbBloodGroup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LbLine1);
            this.Controls.Add(this.LbHeading);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnDecrease);
            this.Controls.Add(this.CmbBxUnits);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormBldStckDec";
            this.Text = "BloodBank Management";
            this.Load += new System.EventHandler(this.FormBldStckDec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVBldStckDec)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVBldStckDec;
        private System.Windows.Forms.ComboBox CmbBxBloodGroup;
        private System.Windows.Forms.Label LbBloodGroup;
        private System.Windows.Forms.ImageList ImageList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LbLine1;
        private System.Windows.Forms.Label LbHeading;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnDecrease;
        private System.Windows.Forms.ComboBox CmbBxUnits;
        private System.Windows.Forms.Button BtnClear;
    }
}