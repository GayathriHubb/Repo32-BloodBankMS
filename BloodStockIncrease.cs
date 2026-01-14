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

namespace BloodBankMS
{
    public partial class FormBldStckInc : Form
    {
        public FormBldStckInc()
        {
            InitializeComponent();
        }

        readonly string constring = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSharp\WinFormsNetFmwk1\BloodBankMS\BloodBank.mdf;Integrated Security = True";

        private void FormBldStckInc_Load(object sender, EventArgs e)
        {
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                try
                {
                    DispDGVBloodStock();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message, "BloodIncLoad");
                }
            }
        }

        private void BtnIncrease_Click(object sender, EventArgs e)
        {
            // Validate selection and input
            if (CmbBxBloodGroup.SelectedIndex != -1 && CmbBxUnits.SelectedIndex != -1)
            {
                string bloodgroup = CmbBxBloodGroup.Text.Trim();
                Int64 units = Convert.ToInt64(CmbBxUnits.Text.Trim());

                using (SqlConnection sqlcon = new SqlConnection(constring))
                {
                    try
                    {
                        sqlcon.Open();

                        // Check existence using ExecuteScalar (no open reader blocking the connection)
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
                                const string upddata = "UPDATE BloodStock SET Quantity = Quantity + @qty WHERE BloodGroup = @bg";
                                using (SqlCommand updcmd = new SqlCommand(upddata, sqlcon))
                                {
                                    updcmd.Parameters.AddWithValue("@qty", units);
                                    updcmd.Parameters.AddWithValue("@bg", bloodgroup);

                                    int iupd = updcmd.ExecuteNonQuery();
                                    DispDGVBloodStock();
                                    if (iupd > 0)
                                    {
                                        MessageBox.Show("Blood Stock Record Updated Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                    {
                                        MessageBox.Show("No rows were updated.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }
                            }
                            else
                            {
                                const string insdata = "INSERT INTO BloodStock (BloodGroup, Quantity) VALUES (@bg, @qty)";
                                using (SqlCommand inscmd = new SqlCommand(insdata, sqlcon))
                                {
                                    inscmd.Parameters.AddWithValue("@bg", bloodgroup);
                                    inscmd.Parameters.AddWithValue("@qty", units);

                                    int iins = inscmd.ExecuteNonQuery();
                                    DispDGVBloodStock();
                                    if (iins > 0)
                                    {
                                        MessageBox.Show("Blood Stock Record Saved Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Insert failed.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message, "BtnIncrease");
                        MessageBox.Show("An error occurred while updating the database. See Output for Details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            CmbBxBloodGroup.SelectedIndex = -1;
            CmbBxUnits.SelectedIndex = -1;
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
                        DGVBldStckInc.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message, "DispDGV");
                }
            }
        }

        
    }
}
