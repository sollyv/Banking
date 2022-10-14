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
    public partial class frmHelp : Form
    {
        public frmHelp()
        {
            InitializeComponent();
            
        }

      

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin fl= new frmLogin();
            fl.Show();
        }

        

        private void frmHelp_Load_1(object sender, EventArgs e)
        {
            pBHelp1.Visible = false;
            pBHelp2.Visible = false;
            pBHelp3.Visible = false;
            this.Size = new System.Drawing.Size(420, 453);
            lblHelp4.Visible = false;
            btnClose.Location = new System.Drawing.Point(380,37);
            lblHelp1.Visible = false;
            lblHelp2.Visible = false;
            lblHelp3.Visible = false;
            lblfig1.Visible = false;
            lblfig2.Visible=false;
            lblfig3.Visible=false;
            
        }

        private void lblHelp2_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rBHelp1_CheckedChanged(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(750, 490);
            //this.ResumeLayout(false);
            pBHelp1.Visible = true;
            pBHelp2.Visible = false;
            pBHelp3.Visible = false;
            btnClose.Location = new System.Drawing.Point(716, 30);
            lblHelp4.Visible = false;
            lblHelp1.Visible = true;
            lblfig1.Visible = true;
            lblHelp2.Visible = false;
            lblHelp3.Visible = false;
            lblfig2.Visible = false;
            lblfig3.Visible = false;

        }

        private void rBHelp2_CheckedChanged(object sender, EventArgs e)
        {
            pBHelp2.Visible = true;
            pBHelp1.Visible = false;
            pBHelp3.Visible = false;
            this.Size = new System.Drawing.Size(750, 490);
            lblHelp4.Visible = false;
            btnClose.Location = new System.Drawing.Point(716, 30);
            lblHelp2.Visible = true;
            lblfig2.Visible = true;
            lblHelp1.Visible = false;
            lblHelp3.Visible = false;
            lblfig1.Visible = false;
            lblfig3.Visible = false;

        }

        private void rBHelp3_CheckedChanged(object sender, EventArgs e)
        {
            pBHelp2.Visible = false;
            pBHelp1.Visible = false;
            pBHelp3.Visible = true;
            this.Size = new System.Drawing.Size(750, 490);
            lblHelp4.Visible = false;
            btnClose.Location = new System.Drawing.Point(716, 30);
            lblHelp1.Visible = false;
            lblHelp2.Visible = false;
            lblHelp3.Visible = true;
            lblfig1.Visible = false;
            lblfig2.Visible = false;
            lblfig3.Visible = true;

        }

        private void rbHelp4_CheckedChanged(object sender, EventArgs e)
        {
            pBHelp2.Visible = false;
            pBHelp1.Visible = true;
            pBHelp3.Visible = false;
            lblHelp4.Visible = true;
            this.Size = new System.Drawing.Size(750, 490);
            btnClose.Location = new System.Drawing.Point(716, 30);
            lblHelp1.Visible = false;
            lblHelp2.Visible = false;
            lblHelp3.Visible = false;
            lblfig1.Visible = true;
            lblfig2.Visible = false;
            lblfig3.Visible = false;
        }
    }
}
