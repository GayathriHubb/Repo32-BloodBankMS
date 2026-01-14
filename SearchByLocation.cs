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
    public partial class FormSearchByLoc : Form
    {
        public FormSearchByLoc()
        {
            InitializeComponent();
        }

        readonly string constring = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSharp\WinFormsNetFmwk1\BloodBankMS\BloodBank.mdf;Integrated Security = True";

        private void FormSearchByLoc_Load(object sender, EventArgs e)
        {
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                try
                {
                    using (SqlConnection sqlcon = new SqlConnection(constring))
                    {
                        sqlcon.Open();

                        string seldata = "Select * From Donors";
                        using (SqlCommand selcmd = new SqlCommand(seldata, sqlcon))
                        {
                            SqlDataAdapter sda = new SqlDataAdapter(selcmd);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            DGVDonors.DataSource = dt;
                            LbTRC.Text = DGVDonors.Rows.Count.ToString();
                        }

                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message, "SearchDonorsLoad");
                }
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtBxLocation.Text))
            {
                using (SqlConnection sqlcon = new SqlConnection(constring))
                {
                    try
                    {
                        sqlcon.Open();

                        string seldata = $"Select * From Donors Where City Like '{TxtBxLocation.Text}%'";
                        using (SqlCommand selcmd = new SqlCommand(seldata, sqlcon))
                        {
                            SqlDataAdapter sda = new SqlDataAdapter(selcmd);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            DGVDonors.DataSource = dt;
                            LbTRC.Text = DGVDonors.Rows.Count.ToString();
                        }
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message, "BtnSearchByLoc");
                    }
                }
            }
            
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            FormSearchByLoc_Load(this, null);
            TxtBxLocation.Clear();
        }

        private void TxtBxLocation_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtBxLocation.Text))
            {
                FormSearchByLoc_Load(this, null);
            }
        }
    }
}
