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
    public partial class FormBldStckDec : Form
    {
        public FormBldStckDec()
        {
            InitializeComponent();
        }

        readonly string constring = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSharp\WinFormsNetFmwk1\BloodBankMS\BloodBank.mdf;Integrated Security = True";

        private void FormBldStckDec_Load(object sender, EventArgs e)
        {
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                try
                {
                    DispDGVBloodStock();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message, "BloodDecLoad");
                }
            }
        }

        private void BtnDecrease_Click(object sender, EventArgs e)
        {
            if (CmbBxBloodGroup.SelectedIndex != -1 && CmbBxUnits.SelectedIndex != -1)
            {
                string bloodgroup = CmbBxBloodGroup.Text.Trim();
                Int64 units = Convert.ToInt64(CmbBxUnits.Text.Trim());

                using (SqlConnection sqlcon = new SqlConnection(constring))
                {
                    try
                    {
                        sqlcon.Open();

                        const string existsquery = "SELECT COUNT(1) FROM BloodStock WHERE BloodGroup = @bg";
                        using (SqlCommand existscmd = new SqlCommand(existsquery, sqlcon))
                        {
                            existscmd.Parameters.AddWithValue("@bg", bloodgroup);
                            object result = existscmd.ExecuteScalar();
                            int count = 0;
                            if (result != null && result != DBNull.Value)
                            {
                                count = Convert.ToInt32(result);
                            }

                            if (count > 0)
                            {
                                string upddata = "Update BloodStock Set Quantity = Quantity - @qty Where BloodGroup = @bg";
                                using (SqlCommand updcmd = new SqlCommand(upddata, sqlcon))
                                {
                                    updcmd.Parameters.AddWithValue("@qty", CmbBxUnits.Text.Trim());
                                    updcmd.Parameters.AddWithValue("@bg", CmbBxBloodGroup.Text.Trim());

                                    int i = updcmd.ExecuteNonQuery();
                                    DispDGVBloodStock();
                                    if (i > 0)
                                    {
                                        MessageBox.Show("Blood Stock Updated Successfully", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                                    }
                                    
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid Blood Stock to Decrease", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                            }

                        }
                        
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message, "BtnDecrease");
                    }
                }

            }
        }

        private void DispDGVBloodStock()
        {
            using (SqlConnection sqlcon = new SqlConnection(constring))
            {
                try
                {
                    sqlcon.Open();

                    string seldata = "Select BloodGroup, Quantity From BloodStock";
                    using (SqlCommand selcmd = new SqlCommand(seldata, sqlcon))
                    {
                        SqlDataAdapter sda = new SqlDataAdapter(selcmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        DGVBldStckDec.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message, "DispDGV");
                }
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            CmbBxBloodGroup.SelectedIndex = -1;
            CmbBxUnits.SelectedIndex = -1;
        }
    }
}
