using MethodsFW;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBankMS
{
    public partial class FormEditDonors : Form
    {
        public FormEditDonors()
        {
            InitializeComponent();
        }

        readonly string constring = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSharp\WinFormsNetFmwk1\BloodBankMS\BloodBank.mdf;Integrated Security = True";

        private void NUDDonorId_ValueChanged(object sender, EventArgs e)
        {
            if (NUDDonorId.Value == 0)
            {
                TxtBxName.Clear();
                TxtBxEmail.Clear();
                TxtBxCity.Clear();
                TxtBxAddrss.Clear();
                MTBPhnNum.Clear();
                CmbBxGender.SelectedIndex = -1;
                CmbBxBloodGroup.SelectedIndex = -1;
                DTPDOB.ResetText();
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (NUDDonorId.Value > 0)
            {
                using (SqlConnection sqlcon = new SqlConnection(constring))
                {
                    try
                    {
                        sqlcon.Open();

                        string seldata = "Select * From Donors Where DonorId = @dnrid";
                        using (SqlCommand selcmd = new SqlCommand(seldata, sqlcon))
                        {
                            selcmd.Parameters.AddWithValue("@dnrid", NUDDonorId.Value);
                            SqlDataReader sdr = selcmd.ExecuteReader();
                            if (sdr.Read())
                            {
                                TxtBxName.Text = (string)sdr["FullName"];
                                CmbBxGender.Text = (string)sdr["Gender"];
                                MTBPhnNum.Text = Convert.ToInt64(sdr["PhnNum"]).ToString();
                                TxtBxEmail.Text = (string)sdr["Email"];
                                DTPDOB.Value = (DateTime)sdr["DateOfBirth"];
                                CmbBxBloodGroup.Text = (string)sdr["BloodGroup"];
                                TxtBxCity.Text = (string)sdr["City"];
                                TxtBxAddrss.Text = (string)sdr["Address"];
                            }
                            else
                            {
                                MessageBox.Show("DonorId Doesn't Exist", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                                BtnClear_Click(this, null);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message, "BtnSearch");
                    }
                }
            }
            else
            {
                BtnClear_Click(this, null);
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
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
                DialogResult dr = MessageBox.Show($"Are you Sure to Update DonorId: {NUDDonorId.Value} ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    using (SqlConnection sqlcon = new SqlConnection(constring))
                    {
                        try
                        {
                            sqlcon.Open();

                            string upddata = "Update Donors Set FullName = @fname, Gender = @gndr, PhnNum = @phnnum, Email = @email, DateOfBirth = @dob, BloodGroup = @bdgrp, City = @cty, Address = @addrss Where DonorId = @dnrid";
                            using (SqlCommand updcmd = new SqlCommand(upddata, sqlcon))
                            {
                                updcmd.Parameters.AddWithValue("@fname", TxtBxName.Text.Trim());
                                updcmd.Parameters.AddWithValue("@gndr", CmbBxGender.Text.Trim());
                                updcmd.Parameters.AddWithValue("@phnnum", MTBPhnNum.Text);
                                updcmd.Parameters.AddWithValue("@email", TxtBxEmail.Text.Trim());
                                updcmd.Parameters.AddWithValue("@dob", DTPDOB.Value);
                                updcmd.Parameters.AddWithValue("@bdgrp", CmbBxBloodGroup.Text.Trim());
                                updcmd.Parameters.AddWithValue("@cty", TxtBxCity.Text.Trim());
                                updcmd.Parameters.AddWithValue("@addrss", TxtBxAddrss.Text.Trim());
                                updcmd.Parameters.AddWithValue("@dnrid", NUDDonorId.Value);

                                updcmd.ExecuteNonQuery();

                                MessageBox.Show("Donor Info Updated Successfully", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                                BtnClear_Click(this, null);
                            }
                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine(ex.Message, "BtnEditDonors");
                        }
                    }
                }
                
            }
        }


        private void BtnClear_Click(object sender, EventArgs e)
        {
            NUDDonorId.Value = 0;
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

    }
}
