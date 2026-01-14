namespace BloodBankMS
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.PicBxBlood = new System.Windows.Forms.PictureBox();
            this.TxtBxUsername = new System.Windows.Forms.TextBox();
            this.TxtBxPswrd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ChkBxTC = new System.Windows.Forms.CheckBox();
            this.BtnSignIn = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.LbSHPswrd = new System.Windows.Forms.Label();
            this.LbLoginHeading = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnSignUp = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.LbFrgtPswrd = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicBxBlood)).BeginInit();
            this.SuspendLayout();
            // 
            // PicBxBlood
            // 
            this.PicBxBlood.Image = ((System.Drawing.Image)(resources.GetObject("PicBxBlood.Image")));
            this.PicBxBlood.Location = new System.Drawing.Point(190, 10);
            this.PicBxBlood.Name = "PicBxBlood";
            this.PicBxBlood.Size = new System.Drawing.Size(400, 224);
            this.PicBxBlood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBxBlood.TabIndex = 0;
            this.PicBxBlood.TabStop = false;
            // 
            // TxtBxUsername
            // 
            this.TxtBxUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBxUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxUsername.Location = new System.Drawing.Point(299, 298);
            this.TxtBxUsername.Name = "TxtBxUsername";
            this.TxtBxUsername.Size = new System.Drawing.Size(300, 34);
            this.TxtBxUsername.TabIndex = 6;
            // 
            // TxtBxPswrd
            // 
            this.TxtBxPswrd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBxPswrd.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxPswrd.Location = new System.Drawing.Point(299, 350);
            this.TxtBxPswrd.Name = "TxtBxPswrd";
            this.TxtBxPswrd.Size = new System.Drawing.Size(300, 34);
            this.TxtBxPswrd.TabIndex = 7;
            this.TxtBxPswrd.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Faustina", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Faustina", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(179, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ChkBxTC
            // 
            this.ChkBxTC.AutoSize = true;
            this.ChkBxTC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChkBxTC.Font = new System.Drawing.Font("Faustina", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkBxTC.Location = new System.Drawing.Point(179, 401);
            this.ChkBxTC.Name = "ChkBxTC";
            this.ChkBxTC.Size = new System.Drawing.Size(125, 27);
            this.ChkBxTC.TabIndex = 4;
            this.ChkBxTC.Text = "Accept TnC";
            this.ChkBxTC.UseVisualStyleBackColor = true;
            this.ChkBxTC.CheckedChanged += new System.EventHandler(this.ChkBxTC_CheckedChanged);
            // 
            // BtnSignIn
            // 
            this.BtnSignIn.AutoSize = true;
            this.BtnSignIn.BackColor = System.Drawing.Color.Ivory;
            this.BtnSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSignIn.Enabled = false;
            this.BtnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSignIn.Font = new System.Drawing.Font("Faustina", 12F, System.Drawing.FontStyle.Bold);
            this.BtnSignIn.ForeColor = System.Drawing.Color.Sienna;
            this.BtnSignIn.Location = new System.Drawing.Point(207, 455);
            this.BtnSignIn.Name = "BtnSignIn";
            this.BtnSignIn.Size = new System.Drawing.Size(150, 42);
            this.BtnSignIn.TabIndex = 1;
            this.BtnSignIn.Text = "SignIn";
            this.BtnSignIn.UseVisualStyleBackColor = false;
            this.BtnSignIn.Click += new System.EventHandler(this.BtnSignIn_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.AutoSize = true;
            this.BtnClear.BackColor = System.Drawing.Color.Ivory;
            this.BtnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClear.Font = new System.Drawing.Font("Faustina", 12F, System.Drawing.FontStyle.Bold);
            this.BtnClear.ForeColor = System.Drawing.Color.Sienna;
            this.BtnClear.Location = new System.Drawing.Point(417, 455);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(150, 42);
            this.BtnClear.TabIndex = 2;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // LbSHPswrd
            // 
            this.LbSHPswrd.AutoSize = true;
            this.LbSHPswrd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LbSHPswrd.Font = new System.Drawing.Font("Faustina", 8.999999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbSHPswrd.Location = new System.Drawing.Point(464, 402);
            this.LbSHPswrd.Name = "LbSHPswrd";
            this.LbSHPswrd.Size = new System.Drawing.Size(134, 23);
            this.LbSHPswrd.TabIndex = 5;
            this.LbSHPswrd.Text = "Show Password";
            this.LbSHPswrd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LbSHPswrd.Click += new System.EventHandler(this.LbSHPswrd_Click);
            // 
            // LbLoginHeading
            // 
            this.LbLoginHeading.AutoSize = true;
            this.LbLoginHeading.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbLoginHeading.ForeColor = System.Drawing.Color.Ivory;
            this.LbLoginHeading.Location = new System.Drawing.Point(312, 250);
            this.LbLoginHeading.Name = "LbLoginHeading";
            this.LbLoginHeading.Size = new System.Drawing.Size(172, 27);
            this.LbLoginHeading.TabIndex = 10;
            this.LbLoginHeading.Text = "LOGIN FORM";
            this.LbLoginHeading.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Ivory;
            this.label5.Font = new System.Drawing.Font("Faustina SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(222, 512);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(336, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Accept our Terms and Conditions to Login";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Ivory;
            this.label6.Font = new System.Drawing.Font("Faustina SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(347, 545);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Read TnC";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnSignUp
            // 
            this.BtnSignUp.AutoSize = true;
            this.BtnSignUp.BackColor = System.Drawing.Color.Ivory;
            this.BtnSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSignUp.Font = new System.Drawing.Font("Faustina", 12F, System.Drawing.FontStyle.Bold);
            this.BtnSignUp.ForeColor = System.Drawing.Color.Sienna;
            this.BtnSignUp.Location = new System.Drawing.Point(394, 585);
            this.BtnSignUp.Name = "BtnSignUp";
            this.BtnSignUp.Size = new System.Drawing.Size(150, 42);
            this.BtnSignUp.TabIndex = 3;
            this.BtnSignUp.Text = "SignUp";
            this.BtnSignUp.UseVisualStyleBackColor = false;
            this.BtnSignUp.Click += new System.EventHandler(this.BtnSignUp_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Faustina", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(234, 594);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 25);
            this.label3.TabIndex = 24;
            this.label3.Text = "No Acc  Yet ? ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LbFrgtPswrd
            // 
            this.LbFrgtPswrd.AutoSize = true;
            this.LbFrgtPswrd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LbFrgtPswrd.Font = new System.Drawing.Font("Faustina", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbFrgtPswrd.ForeColor = System.Drawing.Color.Navy;
            this.LbFrgtPswrd.Location = new System.Drawing.Point(309, 401);
            this.LbFrgtPswrd.Name = "LbFrgtPswrd";
            this.LbFrgtPswrd.Size = new System.Drawing.Size(150, 23);
            this.LbFrgtPswrd.TabIndex = 26;
            this.LbFrgtPswrd.Text = "Forgot Password ?";
            this.LbFrgtPswrd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LbFrgtPswrd.Click += new System.EventHandler(this.LbFrgtPswrd_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(778, 644);
            this.Controls.Add(this.LbFrgtPswrd);
            this.Controls.Add(this.BtnSignUp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LbLoginHeading);
            this.Controls.Add(this.LbSHPswrd);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnSignIn);
            this.Controls.Add(this.ChkBxTC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtBxPswrd);
            this.Controls.Add(this.TxtBxUsername);
            this.Controls.Add(this.PicBxBlood);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormLogin";
            this.Text = "Blood Bank Management";
            ((System.ComponentModel.ISupportInitialize)(this.PicBxBlood)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicBxBlood;
        private System.Windows.Forms.TextBox TxtBxUsername;
        private System.Windows.Forms.TextBox TxtBxPswrd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ChkBxTC;
        private System.Windows.Forms.Button BtnSignIn;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Label LbSHPswrd;
        private System.Windows.Forms.Label LbLoginHeading;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnSignUp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LbFrgtPswrd;
    }
}

