using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class ChangePassword : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBconnect dbcon = new DBconnect();
        SqlDataReader dr;
        Cashier cashier;
        public ChangePassword(Cashier cash)
        {
            InitializeComponent();
            cashier = cash;
            lblUsername.Text = cashier.lbusername.Text;
        }

        private void picclose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                string oldpass = dbcon.getPassword(lblUsername.Text);
                if(oldpass != txtPass.Text)
                {
                    MessageBox.Show("Wrong password please try again!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    txtPass.Visible = false;
                    btnNext.Visible = false;

                    txtNewPass.Visible = true;
                    txtConPass.Visible = true;
                    btnsave.Visible = true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtNewPass.Text != txtConPass.Text)
                {
                    MessageBox.Show("New password and comfirm password did not matched!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if(MessageBox.Show("Change Password ?", "Cnfirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        dbcon.ExecuteQuery("update tbuser set password = '" + txtNewPass.Text + "'where Username='" + lblUsername.Text + "'");
                        MessageBox.Show("Password has been successfuly update!", "Save Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Dispose();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error");
            }
        }

        private void ChangePassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
        }
    }
}
