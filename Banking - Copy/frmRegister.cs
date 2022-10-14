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
    public partial class frmRegister : Form
    {
        SqlConnection con = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable data = new DataTable();
        ConnectionDB db = new ConnectionDB();
        public frmRegister()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbuserIdreg.Text = "";
            tbNewPwd.Text = "";
            tbpwdreg.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if(tbpwdreg.Text == "" || tbNewPwd.Text =="" || tbuserIdreg.Text=="")
                {
                    MessageBox.Show("Please enter all the fields","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                {
                    
                    SqlConnection con = new SqlConnection(db.GetConnection());
                    con.Open();
                    cmd = new SqlCommand("SELECT * FROM p_words$ WHERE UserName='" + tbuserIdreg.Text + "' AND Password='" + tbpwdreg.Text + "'", con);
                    da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    int i = ds.Tables[0].Rows.Count;             

                    if (i == 1)
                    {
                        if (tbNewPwd.Text.Equals(tbpwdreg.Text))
                        {
                            MessageBox.Show("New password cannot be same as old password","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                            tbNewPwd.Text = "";
                            tbNewPwd.Focus();

                        }
                        else
                        { 
                            if (PasswordValidation.isPassword(tbNewPwd.Text))
                            { 
                                SqlDataReader dr = cmd.ExecuteReader();
                                dr.Read();
                                String user_name="Congrats! "+dr[0];
                                string u_pwd=tbpwdreg.Text;
                                string new_pwd = tbNewPwd.Text;
                                MessageBox.Show($"{user_name},your new password has been saved!\nYour new password is:{new_pwd}","Saved", MessageBoxButtons.OK,MessageBoxIcon.Information);
                                tbNewPwd.Text = "";
                                tbuserIdreg.Text = "";
                                tbpwdreg.Text = "";
                            }
                            else
                            {
                                string error=PasswordValidation.getLastErrorMessage();
                                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                       
                       
                    }
                    else
                    {
                    MessageBox.Show("Please check your UserId and Password","Check input",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
            }
             
            catch (Exception)
            {
                MessageBox.Show("Please make sure you have entered the corect UserId and Password");
            }
           
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
             
        }

        private void frmRegister_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            this.Hide();
            frmRegHelp fh=new frmRegHelp();

            fh.Show();
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHelp rh=new frmHelp();
            rh.Show();
        }
       
        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin fl=new frmLogin();
            fl.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
