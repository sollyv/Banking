using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Banking
{
    public partial class frmForgot : Form
    {
        SqlConnection con = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable data = new DataTable();
        ConnectionDB db = new ConnectionDB();
        public frmForgot()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbEmail.Text == "" || tbUserId.Text == "")
            {
                MessageBox.Show("Please enter all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(db.GetConnection());
                    con.Open();
                    cmd = new SqlCommand("SELECT * FROM p_words$ WHERE UserName='" + tbUserId.Text + "' AND EmailAddress='" + tbEmail.Text + "'", con);
                    da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    int i = ds.Tables[0].Rows.Count;
                    SqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();

                    if (i == 1)
                    {
                        String user_name = "" + dr[0];
                        MessageBox.Show($"{user_name}, your new password has been sent to your email {tbEmail.Text}", "Email sent", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tbEmail.Text = string.Empty;
                        tbUserId.Text = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("Please check the User ID and Email address entered","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Please check");
                }
            }

        }
       
        private void frmForgot_HelpButtonClicked(object sender, CancelEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin fl=new frmLogin();
            fl.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHelp fh=new frmHelp();
            fh.Show();
        }

        private void frmForgot_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
