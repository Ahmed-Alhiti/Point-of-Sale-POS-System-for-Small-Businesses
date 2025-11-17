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
    public partial class UserAccount : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBconnect dbcon = new DBconnect();
        SqlDataReader dr;
        MainForm mainForm;
        public string username;
        string name;
        string role;
        string accstastus;
        public UserAccount(MainForm main)
        {
            InitializeComponent();
            con = new SqlConnection(dbcon.mycon());
            mainForm = main;
            LoadUser();
        }
        public void LoadUser()
        {
            int i = 0;
            dgvUser.Rows.Clear();

            cmd = new SqlCommand("SELECT * from tbuser", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvUser.Rows.Add(i, dr[0].ToString(), dr[3].ToString(), dr[4].ToString(), dr[2].ToString());
            }
            dr.Close();
            con.Close();

        }

        public void clear()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtName.Clear();
            txtRePass.Clear();
            cbRole.Text = "";
            txtUsername.Focus();
        }

       

        private void btnAccCancel_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnAccsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPassword.Text != txtRePass.Text)
                {
                    MessageBox.Show("Password did not march", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                con.Open();
                cmd = new SqlCommand("insert into tbuser(Username,password,role,name) values (@Username,@password,@role,@name)",con);
                cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                cmd.Parameters.AddWithValue("@role", cbRole.Text);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("New account has been ctreated successfuly", "Save accouent", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
                LoadUser();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void btnPassSave_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtCurPassword.Text != mainForm._pass)
                {
                    MessageBox.Show("Current password did not matched!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txtNewPass.Text!=txtRePass2.Text)
                {
                    MessageBox.Show("Confirm new password did not matched!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                dbcon.ExecuteQuery("update tbuser set password='" + txtNewPass.Text + "'where username = '"+lblUsername.Text+"'"); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error");
                con.Close();
            }
        }

        private void UserAccount_Load(object sender, EventArgs e)
        {
            lblUsername.Text = mainForm.labelusername.Text;
        }

        private void btnPassCancel_Click(object sender, EventArgs e)
        {
            clearcb();
        }
        public void clearcb()
        {
            txtCurPassword.Clear();
            txtNewPass.Clear();
            txtRePass2.Clear();
        }

        private void dgvUser_SelectionChanged(object sender, EventArgs e)
        {
            int i = dgvUser.CurrentRow.Index;
            username = dgvUser[1, i].Value.ToString();
            name = dgvUser[2, i].Value.ToString();
            role=  dgvUser[4, i].Value.ToString();
            accstastus = dgvUser[3, i].Value.ToString();
            if(lblUsername.Text == username)
            {
                btnRestPass.Enabled = false;
                btnReomve.Enabled = false;
                lblAccountnote.Text = "To change your password, go to change password tag.";
            }
            else
            {
                btnRestPass.Enabled = true;
                btnReomve.Enabled = true;
                lblAccountnote.Text = "To change the password for " + username + " . click Reset Password";
            }
            gbuser.Text = "Password for " +username;
           
        }

        private void btnReomve_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("You choose to remove this account from this Point Of Sale System's user list.\n Are you sure you want to remove '"+username+ "'\\ '" + role + "'","User Account",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)== DialogResult.Yes)
            {
                dbcon.ExecuteQuery("delete from tbuser where username = '" + username + "'");
                MessageBox.Show("Account has been successfuly deleted");
                LoadUser();
            }
        }

        private void btnRestPass_Click(object sender, EventArgs e)
        {
            ResetPassword resetPassword = new ResetPassword(this);
            resetPassword.ShowDialog();
        }

        private void btnProperties_Click(object sender, EventArgs e)
        {
            UserProperties properties = new UserProperties(this);
            properties.Text = role + "\\" + username + " Properties";
            properties.txtFullname.Text = name;
            properties.cbRole.Text = role;
            properties.cbActivate.Text = accstastus;
            properties.username = username;
            properties.ShowDialog();
        }
    }
    
}
