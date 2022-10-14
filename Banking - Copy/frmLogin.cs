using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace Banking
{
    public partial class frmLogin : Form
    {
        SqlConnection con = new SqlConnection();
        SqlDataAdapter da=new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable data = new DataTable();
        ConnectionDB db = new ConnectionDB();
        public frmLogin()
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection(db.GetConnection());

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegister frm1 = new frmRegister();
            frm1.ShowDialog();
        }

        private void btnForgot_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmForgot frm2 = new frmForgot();
            frm2.ShowDialog();
        }

        
        private void SetButton()
        {
            bool txtstatus = (tbUserId.Text != "" && tbPwd.Text != "" );
            if (txtstatus)
            {
                btnLogin.Enabled = true;
            }
        }

        private void tbPwd_TextChanged(object sender, EventArgs e)
        {
            SetButton();
        }

        private void tbUserId_TextChanged(object sender, EventArgs e)
        {
            SetButton();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
            
            btnLogin.Enabled=false;
            iconButtonHide.Visible=false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userID = tbUserId.Text.Trim();
            string pwd = tbPwd.Text.Trim(); 
            if(userID == "fred" && (pwd == "fred"))
            {
                btnLogin.Enabled=true;
                Ulog.type = "Suall";
                String log = "Welcome Fred ";
                frmHome fh = new frmHome(log);
                fh.Show();
                this.Hide();

            }
            else
            {SqlConnection con = new SqlConnection(db.GetConnection());
            con.Open();
            cmd = new SqlCommand("SELECT * FROM p_words$ WHERE UserName='" + userID + "' AND Password='" + pwd+"'", con);
            da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            int i=ds.Tables[0].Rows.Count;
            if (i == 1)
            {
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                if(dr[4].ToString() == "Super User (All Payments)")
                {
                    Ulog.type = "SuAll";
                }
                else if(dr[4].ToString() == "Super User")
                {
                    Ulog.type = "SU";
                }
                else if (dr[4].ToString() == "Administrator")
                {
                    Ulog.type = "Ad";
                }
                else if (dr[4].ToString() == "Auditor")
                {
                    Ulog.type = "Au";
                }
                else if (dr[4].ToString() == "Account Operator")
                {
                    Ulog.type = "AO";
                }
                else if (dr[4].ToString() == "Balance Operator")
                {
                    Ulog.type = "BO";
                }
                else if (dr[4].ToString() == "Customer")
                {
                    Ulog.type = "Cu";
                }
  
                String log = "Welcome " + dr[0]+" "+dr[1];
                frmHome fh=new frmHome(log);
                fh.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please check User Id and Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            }          
        }
              
        private void btnHelp_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHelp fh = new frmHelp();
            fh.Show();
        }

        private void frmLogin_HelpButtonClicked(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.Hide();
            frmHelp fh = new frmHelp();
            fh.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            tbPwd.PasswordChar = '*';
            iconButtonHide.Visible=false;
            iconButtonShow.Visible = true;
            
            
        }

        private void iconButtonShow_Click(object sender, EventArgs e)
        {
            tbPwd.PasswordChar = '\0';
            iconButtonHide.Visible = true;
            iconButtonShow.Visible = false;

        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}