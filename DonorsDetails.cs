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
using System.Drawing.Printing;

namespace BloodBankMS
{
    public partial class FormDonorsDetails : Form
    {
        public FormDonorsDetails()
        {
            InitializeComponent();
        }

        readonly string constring = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSharp\WinFormsNetFmwk1\BloodBankMS\BloodBank.mdf;Integrated Security = True";

        private void DonorsDetails_Load(object sender, EventArgs e)
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
                    Debug.WriteLine(ex.Message, "DonorsDetailsLoad");
                }
            }
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
           
           PageSD1.ShowDialog();
           PPD1.ShowDialog();
           
        }

        private void PD1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(DGVDonors.Width, DGVDonors.Height);
            DGVDonors.DrawToBitmap(bmp, new Rectangle(0, 0, DGVDonors.Width, DGVDonors.Height));

            float centrex = (e.PageBounds.Width - e.Graphics.MeasureString("Donors Details", new Font("Segoe UI", 12, FontStyle.Bold)).Width) / 2;
            e.Graphics.DrawString("Donors Details", new Font("Segoe UI", 12, FontStyle.Bold), Brushes.Navy, centrex, 20);
            e.Graphics.DrawImage(bmp, (e.PageBounds.Width - DGVDonors.Width)/2, 80);    
        }

        private void FormDonorsDetails_SizeChanged(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                BtnPrint.Enabled = true;
            }
            else if (WindowState == FormWindowState.Normal)
            {
                BtnPrint.Enabled = false;
            }

        }

        private void DGVDonors_SelectionChanged(object sender, EventArgs e)
        {
            DGVDonors.ClearSelection();
        }
    }
}
