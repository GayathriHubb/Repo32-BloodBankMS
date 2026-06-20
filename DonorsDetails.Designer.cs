namespace BloodBankMS
{
    partial class FormDonorsDetails
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDonorsDetails));
            this.LbLine1 = new System.Windows.Forms.Label();
            this.LbHeading = new System.Windows.Forms.Label();
            this.LbLine2 = new System.Windows.Forms.Label();
            this.DGVDonors = new System.Windows.Forms.DataGridView();
            this.BtnPrint = new System.Windows.Forms.Button();
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.PD1 = new System.Drawing.Printing.PrintDocument();
            this.LbTotal = new System.Windows.Forms.Label();
            this.LbTRC = new System.Windows.Forms.Label();
            this.PPD1 = new System.Windows.Forms.PrintPreviewDialog();
            this.PageSD1 = new System.Windows.Forms.PageSetupDialog();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDonors)).BeginInit();
            this.SuspendLayout();
            // 
            // LbLine1
            // 
            this.LbLine1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LbLine1.BackColor = System.Drawing.SystemColors.Desktop;
            this.LbLine1.Location = new System.Drawing.Point(0, 60);
            this.LbLine1.Name = "LbLine1";
            this.LbLine1.Size = new System.Drawing.Size(938, 4);
            this.LbLine1.TabIndex = 73;
            this.LbLine1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LbHeading
            // 
            this.LbHeading.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LbHeading.AutoSize = true;
            this.LbHeading.BackColor = System.Drawing.Color.Transparent;
            this.LbHeading.Font = new System.Drawing.Font("Leelawadee", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbHeading.ForeColor = System.Drawing.Color.Sienna;
            this.LbHeading.Location = new System.Drawing.Point(329, 12);
            this.LbHeading.Name = "LbHeading";
            this.LbHeading.Size = new System.Drawing.Size(289, 39);
            this.LbHeading.TabIndex = 72;
            this.LbHeading.Text = "DONORS DETAILS";
            this.LbHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LbLine2
            // 
            this.LbLine2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LbLine2.BackColor = System.Drawing.SystemColors.Desktop;
            this.LbLine2.Location = new System.Drawing.Point(0, 580);
            this.LbLine2.Name = "LbLine2";
            this.LbLine2.Size = new System.Drawing.Size(938, 4);
            this.LbLine2.TabIndex = 74;
            this.LbLine2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DGVDonors
            // 
            this.DGVDonors.AllowUserToAddRows = false;
            this.DGVDonors.AllowUserToDeleteRows = false;
            this.DGVDonors.AllowUserToResizeRows = false;
            this.DGVDonors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVDonors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
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
            this.DGVDonors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVDonors.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVDonors.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGVDonors.EnableHeadersVisualStyles = false;
            this.DGVDonors.Location = new System.Drawing.Point(9, 80);
            this.DGVDonors.Name = "DGVDonors";
            this.DGVDonors.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVDonors.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGVDonors.RowHeadersWidth = 40;
            this.DGVDonors.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.DGVDonors.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVDonors.RowTemplate.Height = 28;
            this.DGVDonors.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DGVDonors.Size = new System.Drawing.Size(910, 450);
            this.DGVDonors.TabIndex = 5;
            this.DGVDonors.SelectionChanged += new System.EventHandler(this.DGVDonors_SelectionChanged);
            // 
            // BtnPrint
            // 
            this.BtnPrint.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnPrint.AutoSize = true;
            this.BtnPrint.BackColor = System.Drawing.Color.Ivory;
            this.BtnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPrint.Font = new System.Drawing.Font("Faustina", 11F, System.Drawing.FontStyle.Bold);
            this.BtnPrint.ForeColor = System.Drawing.Color.Sienna;
            this.BtnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPrint.ImageIndex = 1;
            this.BtnPrint.ImageList = this.ImageList1;
            this.BtnPrint.Location = new System.Drawing.Point(404, 595);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Size = new System.Drawing.Size(120, 40);
            this.BtnPrint.TabIndex = 76;
            this.BtnPrint.Text = "Print";
            this.BtnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnPrint.UseVisualStyleBackColor = false;
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // ImageList1
            // 
            this.ImageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList1.ImageStream")));
            this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList1.Images.SetKeyName(0, "search.png");
            this.ImageList1.Images.SetKeyName(1, "print.png");
            // 
            // PD1
            // 
            this.PD1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PD1_PrintPage);
            // 
            // LbTotal
            // 
            this.LbTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LbTotal.AutoSize = true;
            this.LbTotal.BackColor = System.Drawing.Color.Transparent;
            this.LbTotal.Font = new System.Drawing.Font("Faustina", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTotal.Location = new System.Drawing.Point(12, 545);
            this.LbTotal.Name = "LbTotal";
            this.LbTotal.Size = new System.Drawing.Size(114, 25);
            this.LbTotal.TabIndex = 2;
            this.LbTotal.Text = "Total Rows:";
            this.LbTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LbTRC
            // 
            this.LbTRC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LbTRC.AutoSize = true;
            this.LbTRC.BackColor = System.Drawing.Color.Transparent;
            this.LbTRC.Font = new System.Drawing.Font("Faustina", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTRC.ForeColor = System.Drawing.Color.Navy;
            this.LbTRC.Location = new System.Drawing.Point(128, 542);
            this.LbTRC.Name = "LbTRC";
            this.LbTRC.Size = new System.Drawing.Size(34, 30);
            this.LbTRC.TabIndex = 2;
            this.LbTRC.Text = "{?}";
            this.LbTRC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PPD1
            // 
            this.PPD1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.PPD1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.PPD1.ClientSize = new System.Drawing.Size(400, 300);
            this.PPD1.Document = this.PD1;
            this.PPD1.Enabled = true;
            this.PPD1.Icon = ((System.Drawing.Icon)(resources.GetObject("PPD1.Icon")));
            this.PPD1.Name = "PPD1";
            this.PPD1.Visible = false;
            // 
            // PageSD1
            // 
            this.PageSD1.Document = this.PD1;
            // 
            // FormDonorsDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::BloodBankMS.Properties.Resources.AllPageBgImg;
            this.ClientSize = new System.Drawing.Size(928, 644);
            this.Controls.Add(this.LbTRC);
            this.Controls.Add(this.LbTotal);
            this.Controls.Add(this.BtnPrint);
            this.Controls.Add(this.DGVDonors);
            this.Controls.Add(this.LbLine2);
            this.Controls.Add(this.LbLine1);
            this.Controls.Add(this.LbHeading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormDonorsDetails";
            this.Text = "BloodBank Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DonorsDetails_Load);
            this.SizeChanged += new System.EventHandler(this.FormDonorsDetails_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.DGVDonors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbLine1;
        private System.Windows.Forms.Label LbHeading;
        private System.Windows.Forms.Label LbLine2;
        private System.Windows.Forms.DataGridView DGVDonors;
        private System.Windows.Forms.Button BtnPrint;
        private System.Windows.Forms.ImageList ImageList1;
        private System.Drawing.Printing.PrintDocument PD1;
        private System.Windows.Forms.Label LbTotal;
        private System.Windows.Forms.Label LbTRC;
        private System.Windows.Forms.PrintPreviewDialog PPD1;
        private System.Windows.Forms.PageSetupDialog PageSD1;
    }
}