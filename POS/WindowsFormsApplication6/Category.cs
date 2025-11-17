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
    public partial class Category : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBconnect dbcon = new DBconnect();
        SqlDataReader dr;
        public Category()
        {
            InitializeComponent();
            con = new SqlConnection(dbcon.mycon());
            LoadCategory();
        }
        //data refrence from tbcategory to dgvcategory on category form

        public void LoadCategory()
        {
            int i = 0;
            dgvCategory.Rows.Clear();
            con.Open();
            cmd = new SqlCommand("SELECT * FROM tbcategory ORDER BY category", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvCategory.Rows.Add(i, dr["id"].ToString(), dr["category"].ToString());
            }
            dr.Close();
            con.Close();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CategoryModule moduleform = new CategoryModule(this);
            moduleform.ShowDialog();
        }

        private void dgvCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //update and delete brand by cell click from tbbrand
            string colname = dgvCategory.Columns[e.ColumnIndex].Name;
            if (colname == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this record ?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cmd = new SqlCommand("delete from tbcategory where id like '" + dgvCategory[1, e.RowIndex].Value.ToString() + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Category has been successfuly deleted.", "Point Of Sale", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else if (colname == "Edit")
            {
                CategoryModule categorymodule = new CategoryModule(this);
                categorymodule.labelid.Text = dgvCategory[1, e.RowIndex].Value.ToString();
                categorymodule.textBoxCategory.Text = dgvCategory[2, e.RowIndex].Value.ToString();
                categorymodule.btnsave.Enabled = false;
                categorymodule.btnupdate.Enabled = true;
                categorymodule.ShowDialog();
            }
            LoadCategory();
        }
    }
}
