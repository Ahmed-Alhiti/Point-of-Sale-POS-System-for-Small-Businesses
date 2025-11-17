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
    public partial class ResetPassword : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBconnect dbcon = new DBconnect();
        SqlDataReader dr;
        UserAccount user;
        public ResetPassword(UserAccount userAccount)
        {
            InitializeComponent();
            con = new SqlConnection(dbcon.mycon());
            user = userAccount;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if(txtNewPassword.Text != txtConfirmNewPass.Text)
            {
                MessageBox.Show("The pssword ypu typed does not match. typ the password for this account in both text boxes", "Add user wizard", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if(MessageBox.Show("Reset password?","Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes)
                {
                    dbcon.ExecuteQuery("update tbuser set password = '" + txtNewPassword.Text + "'where username = '" + user.username + "'");
                    MessageBox.Show("Password has been successfuly updated", "Rest password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
                
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ResetPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
        }
    }
}
