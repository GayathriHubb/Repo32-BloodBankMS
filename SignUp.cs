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
using MethodsFW;
using System.Data.SqlClient;

namespace BloodBankMS
{
    public partial class FormSignUp : Form
    {
        public FormSignUp()
        {
            InitializeComponent();
        }

        readonly string constring = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSharp\WinFormsNetFmwk1\BloodBankMS\BloodBank.mdf;Integrated Security = True";

        private void FormSignUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            if (Solutions.SignUpProcess(TxtBxUsername.Text, TxtBxPswrd.Text, TxtBxCnfmPswrd.Text))
            {
                using (SqlConnection sqlcon = new SqlConnection(constring))
                {
                    try
                    {
                        sqlcon.Open();

                        string chkun = "Select Count(*) From Users Where Username = @un";
                        using (SqlCommand chkcmd =  new SqlCommand(chkun, sqlcon))
                        {
                            chkcmd.Parameters.AddWithValue("@un", TxtBxUsername.Text.Trim());

                            int rc = (int)chkcmd.ExecuteScalar();
                            if (rc != 0)
                            {
                                string tempun = Solutions.CapitalizeFirstLetter1(TxtBxUsername.Text.Trim());
                                MessageBox.Show($"Username: {tempun} is Existing Already", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                                return;
                            }
                            string insdata = "Insert Into Users (Username, Password, DateCreate) Values (@un, @pswrd, @dtcrt)";
                            using (SqlCommand inscmd =  new SqlCommand(insdata, sqlcon))
                            {
                                inscmd.Parameters.AddWithValue("@un", TxtBxUsername.Text.Trim());
                                inscmd.Parameters.AddWithValue("@pswrd", TxtBxPswrd.Text.Trim());
                                inscmd.Parameters.AddWithValue("@dtcrt", DateTime.Today);

                                inscmd.ExecuteNonQuery();
                                MessageBox.Show("User Registration Successfull", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                                FormLogin frmlgn = new FormLogin();
                                frmlgn.Show();
                                Hide();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message, "BtnSignup");
                    }
                }
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtBxUsername.Clear();
            TxtBxPswrd.Clear();
            TxtBxCnfmPswrd.Clear();
        }

        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            FormLogin frmlgn = new FormLogin();
            frmlgn.Show();
            Hide();
        }

        private void LbSHPswrd_Click(object sender, EventArgs e)
        {
            if (LbSHPswrd.Text == "Show Password")
            {
                TxtBxPswrd.UseSystemPasswordChar = false;
                TxtBxCnfmPswrd.UseSystemPasswordChar = false;
                LbSHPswrd.Text = "Hide Password";
            }
            else
            {
                TxtBxPswrd.UseSystemPasswordChar = true;
                TxtBxCnfmPswrd.UseSystemPasswordChar = true;
                LbSHPswrd.Text = "Show Password";
            }
        }

        
    }
}
