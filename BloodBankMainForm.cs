using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BloodBankMS.Properties;
using MethodsFW;

namespace BloodBankMS
{
    public partial class FormBBMain : Form
    {
        public FormBBMain()
        {
            InitializeComponent();

            MaximumSize = new Size(SystemInformation.WorkingArea.Width, SystemInformation.WorkingArea.Height);
        }


        public static string usrnm;
        private void FormBBMain_Load(object sender, EventArgs e)
        {
            LbUser.Text = Solutions.CapitalizeFirstLetter1(usrnm);
        }

        private void FormBBMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }

        bool arrowdown = true;
        private void TSMArrow_Click(object sender, EventArgs e)
        {
            if (arrowdown)
            {
                MenuStrip1.Dock = DockStyle.Left;
                TSMArrow.Image = Resources.Right;
                arrowdown = false;
            }
            else
            {
                MenuStrip1.Dock = DockStyle.Top;
                TSMArrow.Image = Resources.Down;
                arrowdown = true;
            }
        }

        private void TSMDonorsDDItems_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem tsm = (ToolStripMenuItem)sender;

            switch (tsm.Name)
            {
                case "TSMAddDonors":
                    FormAddDonor frmadddonr = new FormAddDonor();
                    frmadddonr.Show();
                    break;

                case "TSMEditDonors":
                    FormEditDonors frmedtdnrs = new FormEditDonors();
                    frmedtdnrs.Show();
                    break;

                case "TSMDeleteDonors":
                    FormDeleteDonors frmdlrdnrs = new FormDeleteDonors();
                    frmdlrdnrs.Show();
                    break;

                case "TSMDonorsDetails":
                    FormDonorsDetails frmdetails = new FormDonorsDetails();
                    frmdetails.Show();
                    break;


            }
        }

        private void TSMSearchDonorsDDItems_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem tsm = (ToolStripMenuItem)sender;

            switch(tsm.Name)
            {
                case "TSMByBG":
                    FormSearchByBG frmsrchbybg = new FormSearchByBG();
                    frmsrchbybg.Show();
                    break;

                case "TSMByLoc":
                    FormSearchByLoc frmsrchbyloc = new FormSearchByLoc();
                    frmsrchbyloc.Show();
                    break;
            }
        }

        private void BloodStockDDItems_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem tsm = (ToolStripMenuItem)sender;

            switch(tsm.Name)
            {
                case "TSMIncUnits":
                    FormBldStckInc frmbldinc = new FormBldStckInc();
                    frmbldinc.Show();
                    break;

                case "TSMDecUnits":
                    FormBldStckDec frmblddec = new FormBldStckDec();
                    frmblddec.Show();
                    break;

                case "TSMStockDetails":
                    FormStockDetails stckdets = new FormStockDetails();
                    stckdets.Show();
                    break;
            }

        }

        private void TSMExitDDItems_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem tsm = (ToolStripMenuItem)sender;

            switch (tsm.Name)
            {
                case "TSMLogout":
                    DialogResult dr1 = MessageBox.Show("Are you Sure to Logout ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (dr1 == DialogResult.Yes)
                    {
                        FormLogin frmlgn = new FormLogin();
                        frmlgn.Show();
                        Hide();
                    }
                    break;

                case "TSMExitApp":
                    DialogResult dr2 = MessageBox.Show("Are you Sure to Exit App ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (dr2 == DialogResult.Yes)
                    {
                        Application.ExitThread();
                    }
                    break;
            }
        }
    }
}
