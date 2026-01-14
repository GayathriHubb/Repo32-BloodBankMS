namespace BloodBankMS
{
    partial class FormSearchByBG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSearchByBG));
            this.LbTRC = new System.Windows.Forms.Label();
            this.LbTotal = new System.Windows.Forms.Label();
            this.DGVDonors = new System.Windows.Forms.DataGridView();
            this.LbLine2 = new System.Windows.Forms.Label();
            this.LbLine1 = new System.Windows.Forms.Label();
            this.LbHeading = new System.Windows.Forms.Label();
            this.LbBloodGroup = new System.Windows.Forms.Label();
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.BtnSearch = new System.Windows.Forms.Button();
            this.CmbBxBloodGroup = new System.Windows.Forms.ComboBox();
            this.BtnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDonors)).BeginInit();
            this.SuspendLayout();
            // 
            // LbTRC
            // 
            this.LbTRC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LbTRC.AutoSize = true;
            this.LbTRC.BackColor = System.Drawing.Color.Transparent;
            this.LbTRC.Font = new System.Drawing.Font("Faustina", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTRC.ForeColor = System.Drawing.Color.Navy;
            this.LbTRC.Location = new System.Drawing.Point(125, 607);
            this.LbTRC.Name = "LbTRC";
            this.LbTRC.Size = new System.Drawing.Size(34, 30);
            this.LbTRC.TabIndex = 75;
            this.LbTRC.Text = "{?}";
            this.LbTRC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LbTotal
            // 
            this.LbTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LbTotal.AutoSize = true;
            this.LbTotal.BackColor = System.Drawing.Color.Transparent;
            this.LbTotal.Font = new System.Drawing.Font("Faustina", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTotal.Location = new System.Drawing.Point(9, 610);
            this.LbTotal.Name = "LbTotal";
            this.LbTotal.Size = new System.Drawing.Size(114, 25);
            this.LbTotal.TabIndex = 76;
            this.LbTotal.Text = "Total Rows:";
            this.LbTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DGVDonors
            // 
            this.DGVDonors.AllowUserToAddRows = false;
            this.DGVDonors.AllowUserToDeleteRows = false;
            this.DGVDonors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVDonors.BackgroundColor = System.Drawing.Color.Gray;
            this.DGVDonors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Sienna;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVDonors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVDonors.ColumnHeadersHeight = 34;
            this.DGVDonors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DGVDonors.EnableHeadersVisualStyles = false;
            this.DGVDonors.Location = new System.Drawing.Point(9, 155);
            this.DGVDonors.Name = "DGVDonors";
            this.DGVDonors.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVDonors.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVDonors.RowHeadersWidth = 40;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.DGVDonors.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DGVDonors.RowTemplate.Height = 28;
            this.DGVDonors.Size = new System.Drawing.Size(910, 450);
            this.DGVDonors.TabIndex = 77;
            // 
            // LbLine2
            // 
            this.LbLine2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LbLine2.BackColor = System.Drawing.SystemColors.Desktop;
            this.LbLine2.Location = new System.Drawing.Point(0, 130);
            this.LbLine2.Name = "LbLine2";
            this.LbLine2.Size = new System.Drawing.Size(938, 4);
            this.LbLine2.TabIndex = 80;
            this.LbLine2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LbLine1
            // 
            this.LbLine1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LbLine1.BackColor = System.Drawing.SystemColors.Desktop;
            this.LbLine1.Location = new System.Drawing.Point(0, 60);
            this.LbLine1.Name = "LbLine1";
            this.LbLine1.Size = new System.Drawing.Size(938, 4);
            this.LbLine1.TabIndex = 79;
            this.LbLine1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LbHeading
            // 
            this.LbHeading.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LbHeading.AutoSize = true;
            this.LbHeading.BackColor = System.Drawing.Color.Transparent;
            this.LbHeading.Font = new System.Drawing.Font("Leelawadee", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbHeading.ForeColor = System.Drawing.Color.Sienna;
            this.LbHeading.Location = new System.Drawing.Point(178, 15);
            this.LbHeading.Name = "LbHeading";
            this.LbHeading.Size = new System.Drawing.Size(573, 39);
            this.LbHeading.TabIndex = 78;
            this.LbHeading.Text = "SEARCH DONORS BY BLOOD GROUP";
            this.LbHeading.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LbBloodGroup
            // 
            this.LbBloodGroup.BackColor = System.Drawing.Color.Transparent;
            this.LbBloodGroup.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LbBloodGroup.Font = new System.Drawing.Font("Faustina", 11F, System.Drawing.FontStyle.Bold);
            this.LbBloodGroup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LbBloodGroup.ImageIndex = 3;
            this.LbBloodGroup.ImageList = this.ImageList1;
            this.LbBloodGroup.Location = new System.Drawing.Point(97, 77);
            this.LbBloodGroup.Name = "LbBloodGroup";
            this.LbBloodGroup.Size = new System.Drawing.Size(170, 36);
            this.LbBloodGroup.TabIndex = 82;
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
            this.BtnSearch.Location = new System.Drawing.Point(538, 74);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(140, 42);
            this.BtnSearch.TabIndex = 1;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSearch.UseVisualStyleBackColor = false;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
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
            this.CmbBxBloodGroup.Location = new System.Drawing.Point(279, 77);
            this.CmbBxBloodGroup.Name = "CmbBxBloodGroup";
            this.CmbBxBloodGroup.Size = new System.Drawing.Size(220, 36);
            this.CmbBxBloodGroup.TabIndex = 2;
            this.CmbBxBloodGroup.SelectedIndexChanged += new System.EventHandler(this.CmbBxBloodGroup_SelectedIndexChanged);
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.AutoSize = true;
            this.BtnRefresh.BackColor = System.Drawing.Color.Ivory;
            this.BtnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRefresh.Font = new System.Drawing.Font("Faustina", 12F, System.Drawing.FontStyle.Bold);
            this.BtnRefresh.ForeColor = System.Drawing.Color.Sienna;
            this.BtnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRefresh.ImageIndex = 1;
            this.BtnRefresh.ImageList = this.ImageList1;
            this.BtnRefresh.Location = new System.Drawing.Point(692, 74);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(140, 42);
            this.BtnRefresh.TabIndex = 83;
            this.BtnRefresh.Text = "Refresh";
            this.BtnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnRefresh.UseVisualStyleBackColor = false;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // FormSearchByBG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::BloodBankMS.Properties.Resources.AllPageBgImg;
            this.ClientSize = new System.Drawing.Size(928, 644);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.CmbBxBloodGroup);
            this.Controls.Add(this.LbBloodGroup);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.LbTRC);
            this.Controls.Add(this.LbTotal);
            this.Controls.Add(this.DGVDonors);
            this.Controls.Add(this.LbLine2);
            this.Controls.Add(this.LbLine1);
            this.Controls.Add(this.LbHeading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormSearchByBG";
            this.Text = "BloodBank Management";
            this.Load += new System.EventHandler(this.FormSearchByBG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVDonors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbTRC;
        private System.Windows.Forms.Label LbTotal;
        private System.Windows.Forms.DataGridView DGVDonors;
        private System.Windows.Forms.Label LbLine2;
        private System.Windows.Forms.Label LbLine1;
        private System.Windows.Forms.Label LbHeading;
        private System.Windows.Forms.Label LbBloodGroup;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.ComboBox CmbBxBloodGroup;
        private System.Windows.Forms.ImageList ImageList1;
        private System.Windows.Forms.Button BtnRefresh;
    }
}