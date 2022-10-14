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
    public partial class frmHomeHelp : Form
    {
        public frmHomeHelp()
        {
            InitializeComponent();
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin fl=new frmLogin();
            fl.Show();
        }
    }
}
