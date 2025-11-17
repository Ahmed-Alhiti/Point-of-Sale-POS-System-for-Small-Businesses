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
    public partial class UserProperties : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBconnect dbcon = new DBconnect();
        UserAccount userAccount;
        public string username;
        public UserProperties(UserAccount user)
        {
            InitializeComponent();
            con = new SqlConnection(dbcon.mycon());
            userAccount = user; 
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("Are you sure you want to change this account properties?","Change Prpoerties", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cmd = new SqlCommand("update tbuser set name=@name ,role=@role,isactivate=@isactivate where Username = '" + username + "'",con);
                    cmd.Parameters.AddWithValue("@name", txtFullname.Text);
                    cmd.Parameters.AddWithValue("@role", cbRole.Text);
                    cmd.Parameters.AddWithValue("@isactivate", cbActivate.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    userAccount.LoadUser();
                    MessageBox.Show("Account properties has been successfuly changed!", "Update Properties", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                con.Close();
            }
           

        }

        private void UserProperties_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
        }
    }
}
