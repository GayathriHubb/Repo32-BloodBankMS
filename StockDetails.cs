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
    public partial class FormStockDetails : Form
    {
        public FormStockDetails()
        {
            InitializeComponent();
        }

        readonly string constring = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSharp\WinFormsNetFmwk1\BloodBankMS\BloodBank.mdf;Integrated Security = True";

        private void StockDetails_Load(object sender, EventArgs e)
        {
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                using (SqlConnection sqlcon = new SqlConnection(constring))
                {
                    try
                    {
                        sqlcon.Open();
                        string seldata = "Select * From BloodStock";
                        using (SqlCommand selcmd =  new SqlCommand(seldata, sqlcon))
                        {
                            SqlDataAdapter sda = new SqlDataAdapter(selcmd);
                            DataTable dt = new DataTable(); 
                            sda.Fill(dt);   
                            DGVBldStck.DataSource = dt; 
                                
                        }
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message, "BloodStockLoad");
                    }
                }
                
                
            }
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            PPD1.ShowDialog();
        }

        private void PD1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(DGVBldStck.Width, DGVBldStck.Height);
            DGVBldStck.DrawToBitmap(bmp, new Rectangle(0, 0, DGVBldStck.Width, DGVBldStck.Height));

            float centrex = (e.PageBounds.Width - e.Graphics.MeasureString("BloodStock Details", new Font("Segoe UI", 12, FontStyle.Bold)).Width) / 2;
            e.Graphics.DrawString("BloodStock Details", new Font("Segoe UI", 12, FontStyle.Bold), Brushes.Navy, centrex, 20);
            e.Graphics.DrawImage(bmp, (e.PageBounds.Width - DGVBldStck.Width)/2, 80);
        }
    }
}
