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
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBconnect dbcon = new DBconnect();
        SqlDataReader dr;

        public string _pass = "";
        public bool _isactive;
        public Login()
        {
            InitializeComponent();
            con = new SqlConnection(dbcon.mycon());
            txtName.Focus();
        }

        private void picclose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit Application", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string _username = " ", _name = " ", _role = " ";
            try
            {
                bool found;
                con.Open();
                cmd = new SqlCommand("select * from tbuser where Username = @Username and password = @password ", con);
                cmd.Parameters.AddWithValue("@Username", txtName.Text);
                cmd.Parameters.AddWithValue("@password", txtpassword.Text);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    found = true;
                    _username = dr["Username"].ToString();
                    _name = dr["name"].ToString();
                    _role = dr["role"].ToString();
                    _pass = dr["password"].ToString();
                    _isactive =bool.Parse(dr["isactivate"].ToString());
                }
                else
                {
                    found = false;
                }
                dr.Close();
                con.Close();

                if (found)
                {
                    if (!_isactive)
                    {
                        MessageBox.Show("Account is deactivate . Unable to login ", "Inactive Account", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (_role == "Cashier")
                    {
                        MessageBox.Show("Wlcome " + _name + " | ", "ACCESS GRANTED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtName.Clear();
                        txtpassword.Clear();
                        this.Hide();
                        Cashier cashier = new Cashier();
                        cashier.lbusername.Text = _username;
                        cashier.lblname.Text = _name + " | " + _role;
                        cashier.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Wlcome " + _name + " | ", "ACCESS GRANTED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtName.Clear();
                        txtpassword.Clear();
                        this.Hide();
                        MainForm mainform = new MainForm();
                        mainform.labelusername.Text = _username;
                        mainform.labelname.Text = _name;
                        mainform._pass = _pass;
                        mainform.ShowDialog();
                    }
                   
                }
                else
                {
                   
                    MessageBox.Show("Invalid username and password!", "ACCESS DENIED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void btncancle_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Exit Application", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                Application.Exit();
            }
        }

        private void txtpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnlogin.PerformClick();
            }
        }
    }
}
       