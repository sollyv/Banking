using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banking
{
    public partial class frmHome : Form
    {
        public frmHome(string log)
        {
            InitializeComponent();
            lblName.Text = log;
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            if(Ulog.type == "SuAll")
            {
                btnAdminFull.Visible = false;
                btnAdminReport.Visible = false;
                btnViewAccBal.Visible = false;
                btnAccInfo.Visible = false;
                btnManageAcc.Location = new Point(70,147);
                btnGenerateAudit.Location = new Point(70,187);
                btnAuthAcc.Location = new Point(70,226);
                btnInputAcc.Location = new Point(70,264);
                btnViewAudit.Location = new Point(70,303);
            }
            else if(Ulog.type == "SU")
            {
                btnGenerateAudit.Visible = false;
                btnInputAcc.Visible = false;
                btnAuthAcc.Visible = false;
                btnManageAcc.Visible = false;

                btnViewAudit.Location = new Point(70,147);
                btnAdminFull.Location = new Point(70,187);
                btnAdminReport.Location = new Point(70,226);
                btnViewAccBal.Location=new Point(70,264);
                btnAccInfo.Location=new Point(70,303);
            }
            else if(Ulog.type== "Ad")
            {
                btnGenerateAudit.Visible= false;
                btnViewAudit.Visible= false;
                btnInputAcc.Visible= false;
                btnAuthAcc.Visible= false;
                btnManageAcc.Visible= false;
                btnViewAccBal.Visible= false;
                btnAccInfo.Visible= false;

                btnAdminReport.Location = new Point(70,187);
                btnAdminFull.Location = new Point(70,251);
            }
            else if (Ulog.type == "Au")
            {
                btnAdminFull.Visible=false;
                btnGenerateAudit.Visible=false;
                btnInputAcc.Visible= false;
                btnAuthAcc.Visible=false;
                btnManageAcc.Visible = false;
                btnAccInfo.Visible=false;
                btnViewAccBal.Visible = false;
                btnAdminReport.Location = new Point(70,187);
                btnViewAudit.Location = new Point(70,251);
            }
            else if (Ulog.type == "AO")
            {
                btnAdminFull.Visible = false;
                btnAdminReport.Visible = false;
                btnGenerateAudit.Visible = false;
                btnViewAudit.Visible = false;
                btnInputAcc.Visible = false;
                btnAuthAcc.Visible = false;

                btnManageAcc.Location = new Point(70,161);
                btnViewAccBal.Location = new Point(70,218);
                btnAccInfo.Location = new Point(70,276);
             
            }
            else if (Ulog.type == "BO")
            {
                btnAdminFull.Visible = false;
                btnAdminReport.Visible = false;
                btnGenerateAudit.Visible = false;
                btnViewAudit.Visible = false;
                btnInputAcc.Visible = false;
                btnAuthAcc.Visible = false;
                btnManageAcc.Visible = false;
                btnAccInfo.Visible = false;

                btnViewAccBal.Location = new Point(70,218);

               
            }
            else if (Ulog.type == "Cu")
            {
                btnAdminFull.Visible = false;
                btnAdminReport.Visible = false;
                btnGenerateAudit.Visible = false;
                btnViewAudit.Visible = false;
                btnInputAcc.Visible = false;
                btnAuthAcc.Visible = false;
                btnManageAcc.Visible = false;
                btnAccInfo.Visible = false;

                btnViewAccBal.Location = new Point(70,218);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin fl = new frmLogin();
            fl.Show();
        }

        private void btnViewAccBal_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You can view Account Balance here","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnAdminFull_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have access to Administrative privileges ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnViewAudit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You can view Aduit Records here", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnManageAcc_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You can Manage Accoutn here", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnInputAcc_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You can input account payments here", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGenerateAudit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You can generate audit records here", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAccInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You can view account inforrmation here", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAuthAcc_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You can authorize account payments here", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAdminReport_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have Administration report privileges", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHelp fHelp = new frmHelp();
            fHelp.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
