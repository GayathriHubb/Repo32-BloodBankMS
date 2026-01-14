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
    public partial class FormDeleteDonors : Form
    {
        public FormDeleteDonors()
        {
            InitializeComponent();
        }

        readonly string constring = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSharp\WinFormsNetFmwk1\BloodBankMS\BloodBank.mdf;Integrated Security = True";

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

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show($"Are you Sure to Delete DonorId: {NUDDonorId.Value} ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                using (SqlConnection sqlcon = new SqlConnection(constring))
                {
                    try
                    {
                        sqlcon.Open();

                        string deldata = "Delete From Donors Where DonorId = @dnrid";
                        using (SqlCommand delcmd = new SqlCommand(deldata, sqlcon))
                        {
                            delcmd.Parameters.AddWithValue("@dnrid", NUDDonorId.Value);

                            delcmd.ExecuteNonQuery();
                            MessageBox.Show("Donor Record Deleted Successfully", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                            BtnClear_Click(this, null);
                        }
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message, "BtnDelete");
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

            NUDDonorId.Value = 0;
        }
    }
}
