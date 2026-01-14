using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using MethodsFW;

namespace BloodBankMS
{
    public partial class FormAddDonor : Form
    {
        public FormAddDonor()
        {
            InitializeComponent();
        }

        readonly string constring = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSharp\WinFormsNetFmwk1\BloodBankMS\BloodBank.mdf;Integrated Security = True";

        private void FormAddDonor_Load(object sender, EventArgs e)
        {
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                try
                {
                    DispDonorId();
                }
                catch (Exception ex)
                {
                    Debug.Write(ex.Message, "AddDonorsLoad");
                }
            }
        }

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            if (CheckEmptyFields())
            {
                MessageBox.Show("Pls Fill All Fields..", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return; 
            }
            if (!Solutions.ValdEmail(TxtBxEmail.Text))
            {
                MessageBox.Show("Invalid Email.. Pls Enter Valid Email", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            if (DTPDOB.Value > DateTime.Today)
            {
                MessageBox.Show("DateOfBirth Cannot be Greater than Current Date..", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                using (SqlConnection sqlcon = new SqlConnection(constring))
                {
                    try
                    {
                        sqlcon.Open();

                        string insdata = "Insert Into Donors (FullName, Gender, PhnNum, Email, DateOfBirth, BloodGroup, City, Address, DateInsert) Values (@name, @gndr, @phnnum, @email, @dob, @bdgrp, @city, @addrss, @dtins)";

                        using (SqlCommand inscmd = new SqlCommand(insdata, sqlcon))
                        {
                            inscmd.Parameters.AddWithValue("@name", TxtBxName.Text.Trim());
                            inscmd.Parameters.AddWithValue("@gndr", CmbBxGender.Text.Trim());
                            inscmd.Parameters.AddWithValue("@phnnum", MTBPhnNum.Text);
                            inscmd.Parameters.AddWithValue("@email", TxtBxEmail.Text.Trim());
                            inscmd.Parameters.AddWithValue("@dob", DTPDOB.Value);
                            inscmd.Parameters.AddWithValue("@bdgrp", CmbBxBloodGroup.Text.Trim());
                            inscmd.Parameters.AddWithValue("@city", TxtBxCity.Text.Trim());
                            inscmd.Parameters.AddWithValue("@addrss", TxtBxAddrss.Text.Trim());
                            inscmd.Parameters.AddWithValue("@dtins", DateTime.Today);

                            inscmd.ExecuteNonQuery();
                            MessageBox.Show("Donor Info Saved Successfully", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                            BtnClear_Click(this, null);

                        }
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message, "BtnSave");
                    }
                }
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtBxName.Clear();
            TxtBxEmail.Clear();
            TxtBxCity.Clear();  
            TxtBxAddrss.Clear();
            MTBPhnNum.Clear();
            CmbBxGender.SelectedIndex = -1;
            CmbBxBloodGroup.SelectedIndex = -1;
            DTPDOB.ResetText();
            LbDonorId.Text = string.Empty;  
        }

        private bool CheckEmptyFields()
        {
            if (string.IsNullOrEmpty(TxtBxName.Text) || string.IsNullOrEmpty(TxtBxEmail.Text) || string.IsNullOrEmpty(TxtBxCity.Text) || string.IsNullOrEmpty(TxtBxAddrss.Text) || 
            CmbBxGender.SelectedIndex == -1 || CmbBxBloodGroup.SelectedIndex == -1 || !MTBPhnNum.MaskCompleted)
            {
                return true;
            }
            return false;
        }

       private void DispDonorId()
       {
            using (SqlConnection sqlcon = new SqlConnection(constring))
            {
                try
                {
                    sqlcon.Open();

                    string seldata = "Select Count(*) From Donors";
                    using (SqlCommand selcmd = new SqlCommand(seldata, sqlcon))
                    {
                        int dnrid = (int) selcmd.ExecuteScalar();
                        LbDonorId.Text = $"{dnrid + 1}";
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message, "DispDonorId");
                }
            }
       }
    }
}
