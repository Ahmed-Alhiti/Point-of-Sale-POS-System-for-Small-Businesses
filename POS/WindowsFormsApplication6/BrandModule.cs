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


namespace WindowsFormsApplication6
{
    public partial class BrandModule : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBconnect dbcon = new DBconnect();
        Brand brand;
        public BrandModule(Brand br)
        {
            InitializeComponent();
            con = new SqlConnection(dbcon.mycon());
            brand = br;
        }

        private void picclose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            //insert data to branb table
            try
            {
                if (MessageBox.Show("Are you sure you want to save this brand ?","",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    con.Open();
                    cmd = new SqlCommand("insert into tbbrand (brand) values (@brand)",con);
                    cmd.Parameters.AddWithValue("@brand", textBoxBrand.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record has been saved successfuly .", "POS");
                    clear();
                    brand.LoadBrand();
                }
                
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            clear();
        }
        private void clear()
        {
            textBoxBrand.Clear();
            btnupdate.Enabled = false;
            btnsave.Enabled = true;
            textBoxBrand.Focus();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            //update brand name
            if (MessageBox.Show("Are you sure you want to update this brand ?", "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                con.Open();
                cmd = new SqlCommand("update tbbrand set brand = @brand where id LIKE '"+ labelid.Text +"'", con);
                cmd.Parameters.AddWithValue("@brand",textBoxBrand.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Brand has been successfuly updated.", "POS");
                clear();
                this.Dispose();// to close this form after update data
            }

        }

       
    }
}
