namespace BloodBankMS
{
    partial class FormFrgtPswrd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFrgtPswrd));
            this.PicBxFrgtPswrd = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBxUsername = new System.Windows.Forms.TextBox();
            this.LbCnfmPswrd = new System.Windows.Forms.Label();
            this.TxtBxPswrd = new System.Windows.Forms.TextBox();
            this.ChkBxPswrd = new System.Windows.Forms.CheckBox();
            this.BtnResetPswrd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.LbResponse = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicBxFrgtPswrd)).BeginInit();
            this.SuspendLayout();
            // 
            // PicBxFrgtPswrd
            // 
            this.PicBxFrgtPswrd.Image = ((System.Drawing.Image)(resources.GetObject("PicBxFrgtPswrd.Image")));
            this.PicBxFrgtPswrd.Location = new System.Drawing.Point(289, 75);
            this.PicBxFrgtPswrd.Name = "PicBxFrgtPswrd";
            this.PicBxFrgtPswrd.Size = new System.Drawing.Size(100, 100);
            this.PicBxFrgtPswrd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBxFrgtPswrd.TabIndex = 12;
            this.PicBxFrgtPswrd.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Faustina", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Username";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxtBxUsername
            // 
            this.TxtBxUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBxUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxUsername.Location = new System.Drawing.Point(215, 220);
            this.TxtBxUsername.Name = "TxtBxUsername";
            this.TxtBxUsername.Size = new System.Drawing.Size(300, 34);
            this.TxtBxUsername.TabIndex = 2;
            // 
            // LbCnfmPswrd
            // 
            this.LbCnfmPswrd.AutoSize = true;
            this.LbCnfmPswrd.Font = new System.Drawing.Font("Faustina", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbCnfmPswrd.Location = new System.Drawing.Point(43, 392);
            this.LbCnfmPswrd.Name = "LbCnfmPswrd";
            this.LbCnfmPswrd.Size = new System.Drawing.Size(193, 25);
            this.LbCnfmPswrd.TabIndex = 22;
            this.LbCnfmPswrd.Text = "Generated Password";
            this.LbCnfmPswrd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxtBxPswrd
            // 
            this.TxtBxPswrd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBxPswrd.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxPswrd.Location = new System.Drawing.Point(242, 388);
            this.TxtBxPswrd.Name = "TxtBxPswrd";
            this.TxtBxPswrd.Size = new System.Drawing.Size(300, 34);
            this.TxtBxPswrd.TabIndex = 21;
            this.TxtBxPswrd.UseSystemPasswordChar = true;
            // 
            // ChkBxPswrd
            // 
            this.ChkBxPswrd.AutoSize = true;
            this.ChkBxPswrd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChkBxPswrd.Font = new System.Drawing.Font("Faustina", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkBxPswrd.Location = new System.Drawing.Point(382, 437);
            this.ChkBxPswrd.Name = "ChkBxPswrd";
            this.ChkBxPswrd.Size = new System.Drawing.Size(160, 27);
            this.ChkBxPswrd.TabIndex = 3;
            this.ChkBxPswrd.Text = "Show Password";
            this.ChkBxPswrd.UseVisualStyleBackColor = true;
            this.ChkBxPswrd.CheckedChanged += new System.EventHandler(this.ChkBxPswrd_CheckedChanged);
            // 
            // BtnResetPswrd
            // 
            this.BtnResetPswrd.AutoSize = true;
            this.BtnResetPswrd.BackColor = System.Drawing.Color.Ivory;
            this.BtnResetPswrd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnResetPswrd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnResetPswrd.Font = new System.Drawing.Font("Faustina", 12F, System.Drawing.FontStyle.Bold);
            this.BtnResetPswrd.ForeColor = System.Drawing.Color.Sienna;
            this.BtnResetPswrd.Location = new System.Drawing.Point(215, 290);
            this.BtnResetPswrd.Name = "BtnResetPswrd";
            this.BtnResetPswrd.Size = new System.Drawing.Size(250, 42);
            this.BtnResetPswrd.TabIndex = 1;
            this.BtnResetPswrd.Text = "Reset Password";
            this.BtnResetPswrd.UseVisualStyleBackColor = false;
            this.BtnResetPswrd.Click += new System.EventHandler(this.BtnResetPswrd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Ivory;
            this.label2.Font = new System.Drawing.Font("Faustina", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Sienna;
            this.label2.Location = new System.Drawing.Point(201, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(277, 30);
            this.label2.TabIndex = 25;
            this.label2.Text = "Blood Bank Management";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LbResponse
            // 
            this.LbResponse.AutoSize = true;
            this.LbResponse.Font = new System.Drawing.Font("Faustina", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbResponse.ForeColor = System.Drawing.Color.Navy;
            this.LbResponse.Location = new System.Drawing.Point(43, 483);
            this.LbResponse.Name = "LbResponse";
            this.LbResponse.Size = new System.Drawing.Size(97, 25);
            this.LbResponse.TabIndex = 26;
            this.LbResponse.Text = "Response";
            this.LbResponse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LbResponse.Visible = false;
            // 
            // FormFrgtPswrd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(678, 544);
            this.Controls.Add(this.LbResponse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnResetPswrd);
            this.Controls.Add(this.ChkBxPswrd);
            this.Controls.Add(this.LbCnfmPswrd);
            this.Controls.Add(this.TxtBxPswrd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtBxUsername);
            this.Controls.Add(this.PicBxFrgtPswrd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormFrgtPswrd";
            this.Text = "ForgotPassword";
            ((System.ComponentModel.ISupportInitialize)(this.PicBxFrgtPswrd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicBxFrgtPswrd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBxUsername;
        private System.Windows.Forms.Label LbCnfmPswrd;
        private System.Windows.Forms.TextBox TxtBxPswrd;
        private System.Windows.Forms.CheckBox ChkBxPswrd;
        private System.Windows.Forms.Button BtnResetPswrd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LbResponse;
    }
}