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
    public partial class Store : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBconnect dbcon = new DBconnect();
        SqlDataReader dr;
        bool havstoreinfo = false;
        public Store()
        {
            InitializeComponent();
            con = new SqlConnection(dbcon.mycon());
            LoadStore();
        }

        public void LoadStore()
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("select * from tbstore ",con);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    havstoreinfo = true;
                    txtStName.Text = dr["store"].ToString();
                    txtAddress.Text = dr["address"].ToString();
                }
                else
                {
                    txtStName.Clear();
                    txtAddress.Clear();
                }
                dr.Close();
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error");
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Save store details?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                    if (havstoreinfo)
                    {
                        dbcon.ExecuteQuery("update tbstore set store ='" + txtStName.Text + "', address ='" + txtAddress.Text + "'");
                    }
                    else
                    {
                        dbcon.ExecuteQuery("insert into tbstore (store,address) values ('" + txtStName.Text + "','" + txtAddress.Text + "')");
                    }
                MessageBox.Show("Store detail has been successfuly saved!", "Save Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Store_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
        }
    }
}
