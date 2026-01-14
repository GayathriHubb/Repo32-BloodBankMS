using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;
using MethodsFW;

namespace BloodBankMS
{
    public partial class FormFrgtPswrd : Form
    {
        public FormFrgtPswrd()
        {
            InitializeComponent();
        }

        readonly string constring = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSharp\WinFormsNetFmwk1\BloodBankMS\BloodBank.mdf;Integrated Security = True";

        private void BtnResetPswrd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtBxUsername.Text))
            {
                LbResponse.Visible = true;
                LbResponse.Text = "Pls Enter Username First";
                return; 
            }
            using (SqlConnection sqlcon = new SqlConnection(constring))
            {
                try
                {
                    sqlcon.Open();

                    string chkun = "Select Count(*) From Users Where Username = @un";
                    using (SqlCommand chkcmd = new SqlCommand(chkun, sqlcon))
                    {
                        chkcmd.Parameters.AddWithValue("@un", TxtBxUsername.Text.Trim());
                        int rc = (int)chkcmd.ExecuteScalar();
                        if (rc != 0)
                        {
                            TxtBxPswrd.Text = Solutions.SetPassword();

                            string upddata = "Update Users Set Password = @pswrd Where Username = @un";
                            using (SqlCommand updcmd = new SqlCommand(upddata, sqlcon))
                            {
                                updcmd.Parameters.AddWithValue("@un", TxtBxUsername.Text.Trim());
                                updcmd.Parameters.AddWithValue("@pswrd", TxtBxPswrd.Text.Trim());

                                updcmd.ExecuteNonQuery();
                            }
                        }
                    }
                    
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message, "ResetPswrd");
                }
            }
        }

        private void ChkBxPswrd_CheckedChanged(object sender, EventArgs e)
        {
            TxtBxPswrd.UseSystemPasswordChar = !ChkBxPswrd.Checked;
        }
    }
}
