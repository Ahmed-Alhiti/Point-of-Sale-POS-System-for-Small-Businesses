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
    public partial class CategoryModule : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBconnect dbcon = new DBconnect();
        Category catagory;
        public CategoryModule(Category ca)
        {
            InitializeComponent();
            con = new SqlConnection(dbcon.mycon());
            catagory = ca;
        }
        public void clear()
        {
            textBoxCategory.Clear();
            btnsave.Enabled = true;
            btnupdate.Enabled = false;
            textBoxCategory.Focus();

        }
        private void picclose_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to save this category ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cmd = new SqlCommand("insert into tbcategory (category) values (@category)", con);
                    cmd.Parameters.AddWithValue("@category", textBoxCategory.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record has been saved successfuly .", "Point Of Sale");
                    clear();
                    catagory.LoadCategory();
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            //update category name
            if (MessageBox.Show("Are you sure you want to update this category ?", "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                con.Open();
                cmd = new SqlCommand("update tbcategory set category = @category where id LIKE '" + labelid.Text + "'", con);
                cmd.Parameters.AddWithValue("@category", textBoxCategory.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Category has been successfuly updated.", "Ponit Of Sale");
                clear();
                this.Dispose();// to close this form after update data
            }

        }

        private void CategoryModule_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
        }
    }
}
