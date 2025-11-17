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
    public partial class Brand : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBconnect dbcon = new DBconnect();
        SqlDataReader dr;
        public Brand()
        {
            InitializeComponent();
            con = new SqlConnection(dbcon.mycon());
            LoadBrand();
        }

        //data refrence from tbbrand to dgvbrand on brand form

        public void LoadBrand()
        {
            int i = 0;
            dgvBrand.Rows.Clear();
            con.Open(); 
            cmd = new SqlCommand("SELECT * FROM tbbrand ORDER BY brand",con);
            dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                i++;
                dgvBrand.Rows.Add(i, dr["id"].ToString(), dr["brand"].ToString());
            }
            dr.Close();
            con.Close();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            BrandModule moduleform = new BrandModule(this);
            moduleform.ShowDialog();
        }

        private void dgvBrand_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //update and delete brand by cell click from tbbrand
            string colname = dgvBrand.Columns[e.ColumnIndex].Name;
            if (colname == "Delete")
            {
                if(MessageBox.Show("Are you sure you want to delete this record ?","Delete Record",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    con.Open();
                    cmd = new SqlCommand("delete from tbbrand where id like '" + dgvBrand[1,e.RowIndex].Value.ToString()+ "'",con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Brand has been successfuly deleted.", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else if (colname == "Edit")
            {
                BrandModule brandmodule = new BrandModule(this);
                brandmodule.labelid.Text = dgvBrand[1, e.RowIndex].Value.ToString();
                brandmodule.textBoxBrand.Text = dgvBrand[2, e.RowIndex].Value.ToString();
                brandmodule.btnsave.Enabled = false;
                brandmodule.btnupdate.Enabled = true;
                brandmodule.ShowDialog();
            }
            LoadBrand();
        }
    }
}
