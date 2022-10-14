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
    public partial class frmForgotHelp : Form
    {
        public frmForgotHelp()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            this.Close();
            frmForgot ff=new frmForgot();
            ff.Show();
        }
    }
}
