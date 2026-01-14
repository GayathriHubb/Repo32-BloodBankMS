namespace BloodBankMS
{
    partial class FormBBMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBBMain));
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TSMArrow = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMDonors = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMAddDonors = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMEditDonors = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMDeleteDonors = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMDonorsDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMSearchDonors = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMByBG = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMByLoc = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMBloodStock = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIncUnits = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMDecUnits = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMStockDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMExit = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMExitApp = new System.Windows.Forms.ToolStripMenuItem();
            this.Lb1 = new System.Windows.Forms.Label();
            this.LbUser = new System.Windows.Forms.Label();
            this.MenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.MenuStrip1.Font = new System.Drawing.Font("Faustina", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.MenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMArrow,
            this.TSMDonors,
            this.TSMSearchDonors,
            this.TSMBloodStock,
            this.TSMExit});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(1078, 102);
            this.MenuStrip1.TabIndex = 0;
            // 
            // TSMArrow
            // 
            this.TSMArrow.BackColor = System.Drawing.Color.BurlyWood;
            this.TSMArrow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSMArrow.Image = ((System.Drawing.Image)(resources.GetObject("TSMArrow.Image")));
            this.TSMArrow.Name = "TSMArrow";
            this.TSMArrow.Size = new System.Drawing.Size(40, 98);
            this.TSMArrow.Click += new System.EventHandler(this.TSMArrow_Click);
            // 
            // TSMDonors
            // 
            this.TSMDonors.BackColor = System.Drawing.Color.Wheat;
            this.TSMDonors.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMAddDonors,
            this.TSMEditDonors,
            this.TSMDeleteDonors,
            this.TSMDonorsDetails});
            this.TSMDonors.Font = new System.Drawing.Font("Faustina", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TSMDonors.Image = ((System.Drawing.Image)(resources.GetObject("TSMDonors.Image")));
            this.TSMDonors.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSMDonors.Name = "TSMDonors";
            this.TSMDonors.Size = new System.Drawing.Size(172, 98);
            this.TSMDonors.Text = "Blood Donors";
            this.TSMDonors.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // TSMAddDonors
            // 
            this.TSMAddDonors.Font = new System.Drawing.Font("Faustina", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TSMAddDonors.Image = ((System.Drawing.Image)(resources.GetObject("TSMAddDonors.Image")));
            this.TSMAddDonors.Name = "TSMAddDonors";
            this.TSMAddDonors.Size = new System.Drawing.Size(274, 34);
            this.TSMAddDonors.Text = "Add Donors";
            this.TSMAddDonors.Click += new System.EventHandler(this.TSMDonorsDDItems_Click);
            // 
            // TSMEditDonors
            // 
            this.TSMEditDonors.Font = new System.Drawing.Font("Faustina", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TSMEditDonors.Image = ((System.Drawing.Image)(resources.GetObject("TSMEditDonors.Image")));
            this.TSMEditDonors.Name = "TSMEditDonors";
            this.TSMEditDonors.Size = new System.Drawing.Size(274, 34);
            this.TSMEditDonors.Text = "Edit Donors";
            this.TSMEditDonors.Click += new System.EventHandler(this.TSMDonorsDDItems_Click);
            // 
            // TSMDeleteDonors
            // 
            this.TSMDeleteDonors.Font = new System.Drawing.Font("Faustina", 10F, System.Drawing.FontStyle.Bold);
            this.TSMDeleteDonors.Image = ((System.Drawing.Image)(resources.GetObject("TSMDeleteDonors.Image")));
            this.TSMDeleteDonors.Name = "TSMDeleteDonors";
            this.TSMDeleteDonors.Size = new System.Drawing.Size(274, 34);
            this.TSMDeleteDonors.Text = "Delete Donors";
            this.TSMDeleteDonors.Click += new System.EventHandler(this.TSMDonorsDDItems_Click);
            // 
            // TSMDonorsDetails
            // 
            this.TSMDonorsDetails.Font = new System.Drawing.Font("Faustina", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TSMDonorsDetails.Image = ((System.Drawing.Image)(resources.GetObject("TSMDonorsDetails.Image")));
            this.TSMDonorsDetails.Name = "TSMDonorsDetails";
            this.TSMDonorsDetails.Size = new System.Drawing.Size(274, 34);
            this.TSMDonorsDetails.Text = "All Donors Details";
            this.TSMDonorsDetails.Click += new System.EventHandler(this.TSMDonorsDDItems_Click);
            // 
            // TSMSearchDonors
            // 
            this.TSMSearchDonors.BackColor = System.Drawing.Color.BurlyWood;
            this.TSMSearchDonors.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMByBG,
            this.TSMByLoc});
            this.TSMSearchDonors.Image = ((System.Drawing.Image)(resources.GetObject("TSMSearchDonors.Image")));
            this.TSMSearchDonors.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSMSearchDonors.Name = "TSMSearchDonors";
            this.TSMSearchDonors.Size = new System.Drawing.Size(183, 98);
            this.TSMSearchDonors.Text = "Search Donors";
            this.TSMSearchDonors.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // TSMByBG
            // 
            this.TSMByBG.Font = new System.Drawing.Font("Faustina", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TSMByBG.Image = ((System.Drawing.Image)(resources.GetObject("TSMByBG.Image")));
            this.TSMByBG.Name = "TSMByBG";
            this.TSMByBG.Size = new System.Drawing.Size(251, 34);
            this.TSMByBG.Text = "By Blood Group";
            this.TSMByBG.Click += new System.EventHandler(this.TSMSearchDonorsDDItems_Click);
            // 
            // TSMByLoc
            // 
            this.TSMByLoc.Font = new System.Drawing.Font("Faustina", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TSMByLoc.Image = ((System.Drawing.Image)(resources.GetObject("TSMByLoc.Image")));
            this.TSMByLoc.Name = "TSMByLoc";
            this.TSMByLoc.Size = new System.Drawing.Size(251, 34);
            this.TSMByLoc.Text = "By Location";
            this.TSMByLoc.Click += new System.EventHandler(this.TSMSearchDonorsDDItems_Click);
            // 
            // TSMBloodStock
            // 
            this.TSMBloodStock.BackColor = System.Drawing.Color.Wheat;
            this.TSMBloodStock.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMIncUnits,
            this.TSMDecUnits,
            this.TSMStockDetails});
            this.TSMBloodStock.Image = ((System.Drawing.Image)(resources.GetObject("TSMBloodStock.Image")));
            this.TSMBloodStock.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSMBloodStock.Name = "TSMBloodStock";
            this.TSMBloodStock.Size = new System.Drawing.Size(154, 98);
            this.TSMBloodStock.Text = "Blood Stock";
            this.TSMBloodStock.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // TSMIncUnits
            // 
            this.TSMIncUnits.Font = new System.Drawing.Font("Faustina", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TSMIncUnits.Image = ((System.Drawing.Image)(resources.GetObject("TSMIncUnits.Image")));
            this.TSMIncUnits.Name = "TSMIncUnits";
            this.TSMIncUnits.Size = new System.Drawing.Size(247, 34);
            this.TSMIncUnits.Text = "Increase Units";
            this.TSMIncUnits.Click += new System.EventHandler(this.BloodStockDDItems_Click);
            // 
            // TSMDecUnits
            // 
            this.TSMDecUnits.Font = new System.Drawing.Font("Faustina", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TSMDecUnits.Image = ((System.Drawing.Image)(resources.GetObject("TSMDecUnits.Image")));
            this.TSMDecUnits.Name = "TSMDecUnits";
            this.TSMDecUnits.Size = new System.Drawing.Size(247, 34);
            this.TSMDecUnits.Text = "Decrease Units";
            this.TSMDecUnits.Click += new System.EventHandler(this.BloodStockDDItems_Click);
            // 
            // TSMStockDetails
            // 
            this.TSMStockDetails.Font = new System.Drawing.Font("Faustina", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TSMStockDetails.Image = ((System.Drawing.Image)(resources.GetObject("TSMStockDetails.Image")));
            this.TSMStockDetails.Name = "TSMStockDetails";
            this.TSMStockDetails.Size = new System.Drawing.Size(247, 34);
            this.TSMStockDetails.Text = "Stock Details";
            this.TSMStockDetails.Click += new System.EventHandler(this.BloodStockDDItems_Click);
            // 
            // TSMExit
            // 
            this.TSMExit.BackColor = System.Drawing.Color.BurlyWood;
            this.TSMExit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMLogout,
            this.TSMExitApp});
            this.TSMExit.Image = ((System.Drawing.Image)(resources.GetObject("TSMExit.Image")));
            this.TSMExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSMExit.Name = "TSMExit";
            this.TSMExit.Size = new System.Drawing.Size(80, 98);
            this.TSMExit.Text = "Exit";
            this.TSMExit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // TSMLogout
            // 
            this.TSMLogout.Font = new System.Drawing.Font("Faustina", 10F, System.Drawing.FontStyle.Bold);
            this.TSMLogout.Name = "TSMLogout";
            this.TSMLogout.Size = new System.Drawing.Size(189, 34);
            this.TSMLogout.Text = "Logout";
            this.TSMLogout.Click += new System.EventHandler(this.TSMExitDDItems_Click);
            // 
            // TSMExitApp
            // 
            this.TSMExitApp.Font = new System.Drawing.Font("Faustina", 10F, System.Drawing.FontStyle.Bold);
            this.TSMExitApp.Name = "TSMExitApp";
            this.TSMExitApp.Size = new System.Drawing.Size(189, 34);
            this.TSMExitApp.Text = "Exit App";
            this.TSMExitApp.Click += new System.EventHandler(this.TSMExitDDItems_Click);
            // 
            // Lb1
            // 
            this.Lb1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Lb1.AutoSize = true;
            this.Lb1.BackColor = System.Drawing.Color.Sienna;
            this.Lb1.Font = new System.Drawing.Font("Faustina", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb1.ForeColor = System.Drawing.Color.Ivory;
            this.Lb1.Location = new System.Drawing.Point(523, 580);
            this.Lb1.Name = "Lb1";
            this.Lb1.Size = new System.Drawing.Size(57, 25);
            this.Lb1.TabIndex = 4;
            this.Lb1.Text = "User:";
            this.Lb1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LbUser
            // 
            this.LbUser.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LbUser.AutoSize = true;
            this.LbUser.BackColor = System.Drawing.Color.Sienna;
            this.LbUser.Font = new System.Drawing.Font("Faustina", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbUser.ForeColor = System.Drawing.Color.Ivory;
            this.LbUser.Location = new System.Drawing.Point(585, 580);
            this.LbUser.Name = "LbUser";
            this.LbUser.Size = new System.Drawing.Size(29, 25);
            this.LbUser.TabIndex = 5;
            this.LbUser.Text = "{?}";
            this.LbUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormBBMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1078, 644);
            this.Controls.Add(this.LbUser);
            this.Controls.Add(this.Lb1);
            this.Controls.Add(this.MenuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip1;
            this.MinimumSize = new System.Drawing.Size(1100, 700);
            this.Name = "FormBBMain";
            this.Text = "BloodBank Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormBBMain_FormClosing);
            this.Load += new System.EventHandler(this.FormBBMain_Load);
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSMDonors;
        private System.Windows.Forms.ToolStripMenuItem TSMSearchDonors;
        private System.Windows.Forms.ToolStripMenuItem TSMBloodStock;
        private System.Windows.Forms.ToolStripMenuItem TSMExit;
        private System.Windows.Forms.Label Lb1;
        private System.Windows.Forms.Label LbUser;
        private System.Windows.Forms.ToolStripMenuItem TSMByLoc;
        private System.Windows.Forms.ToolStripMenuItem TSMByBG;
        private System.Windows.Forms.ToolStripMenuItem TSMIncUnits;
        private System.Windows.Forms.ToolStripMenuItem TSMDecUnits;
        private System.Windows.Forms.ToolStripMenuItem TSMStockDetails;
        private System.Windows.Forms.ToolStripMenuItem TSMAddDonors;
        private System.Windows.Forms.ToolStripMenuItem TSMEditDonors;
        private System.Windows.Forms.ToolStripMenuItem TSMDonorsDetails;
        private System.Windows.Forms.ToolStripMenuItem TSMDeleteDonors;
        private System.Windows.Forms.ToolStripMenuItem TSMArrow;
        private System.Windows.Forms.ToolStripMenuItem TSMLogout;
        private System.Windows.Forms.ToolStripMenuItem TSMExitApp;
    }
}