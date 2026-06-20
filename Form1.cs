using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.SqlClient;
using MethodsFW;

namespace BloodBankMS
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        readonly string constring = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSharp\WinFormsNetFmwk1\BloodBankMS\BloodBank.mdf;Integrated Security = True";

        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtBxUsername.Text) || string.IsNullOrEmpty(TxtBxPswrd.Text))
            {
                MessageBox.Show("Pls Fill Both Username And Password", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return; 
            }
            else
            {
                using (SqlConnection sqlcon = new SqlConnection(constring))
                {
                    try
                    {
                        sqlcon.Open();

                        string seldata = "Select Count(*) From Users Where Username = @un And Password = @pswrd";
                        using (SqlCommand selcmd =  new SqlCommand(seldata, sqlcon))
                        {
                            selcmd.Parameters.AddWithValue("@un", TxtBxUsername.Text.Trim());
                            selcmd.Parameters.AddWithValue("@pswrd", TxtBxPswrd.Text.Trim());

                            int rc = (int)selcmd.ExecuteScalar();
                            if (rc != 0)
                            {
                                FormBBMain.usrnm = TxtBxUsername.Text.Trim();
                                MessageBox.Show("Login Successfull", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                                FormBBMain frmbbmn = new FormBBMain();
                                frmbbmn.Show();
                                Hide();
                            }
                            else
                            {
                                MessageBox.Show("Incorrect Username/Password", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message, "BtnSignIn");
                    }
                }
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtBxUsername.Clear();
            TxtBxPswrd.Clear();
        }

        private void ChkBxTC_CheckedChanged(object sender, EventArgs e)
        {
            BtnSignIn.Enabled = ChkBxTC.Checked;    
        }

        private void LbSHPswrd_Click(object sender, EventArgs e)
        {
            if (LbSHPswrd.Text == "Show Password")
            {
                TxtBxPswrd.UseSystemPasswordChar = false;
                LbSHPswrd.Text = "Hide Password";
            }
            else
            {
                TxtBxPswrd.UseSystemPasswordChar = true;
                LbSHPswrd.Text = "Show Password";
            }
        }

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            FormSignUp frmsignup = new FormSignUp();
            frmsignup.Show();
            Hide();
        }

        private void LbFrgtPswrd_Click(object sender, EventArgs e)
        {
            FormFrgtPswrd frgtpswrd = new FormFrgtPswrd();
            frgtpswrd.ShowDialog();
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }
    }
}
