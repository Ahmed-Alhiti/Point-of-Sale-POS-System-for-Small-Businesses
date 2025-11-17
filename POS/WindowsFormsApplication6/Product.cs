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
    public partial class Product : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBconnect dbcon = new DBconnect();
        SqlDataReader dr;
        public Product()
        {
            InitializeComponent();
            con = new SqlConnection(dbcon.mycon());
            LoadProducts();
        }
        public void LoadProducts()
        {
            int i = 0;
            dgvProduct.Rows.Clear();
            
            cmd = new SqlCommand("SELECT P.pcode,P.barcode,P.pdesc,b.brand,c.category,P.price,P.reorder from tbproduct as P inner join tbbrand as b on b.id = P.bid inner join tbcategory as c on c.id = P.cid where concat(P.pdesc,b.brand,c.category) like '%" + txtSearch.Text+"%'", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvProduct.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString());
            }
            dr.Close();
            con.Close();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ProductModule module = new ProductModule(this);
            module.ShowDialog();
        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colname = dgvProduct.Columns[e.ColumnIndex].Name;
            if(colname == "Edit")
            {
                ProductModule productmodule = new ProductModule(this);
                productmodule.textBoxPcode.Text = dgvProduct.Rows[e.RowIndex].Cells[1].Value.ToString();
                productmodule.textBoxBarcode.Text = dgvProduct.Rows[e.RowIndex].Cells[2].Value.ToString();
                productmodule.textBoxDescription.Text = dgvProduct.Rows[e.RowIndex].Cells[3].Value.ToString();
                productmodule.cboBoxBrand.Text = dgvProduct.Rows[e.RowIndex].Cells[4].Value.ToString();
                productmodule.cboBoxCategory.Text = dgvProduct.Rows[e.RowIndex].Cells[5].Value.ToString();
                productmodule.textBoxPrice.Text = dgvProduct.Rows[e.RowIndex].Cells[6].Value.ToString();
                productmodule.UDReorder.Value = int.Parse(dgvProduct.Rows[e.RowIndex].Cells[7].Value.ToString());

                productmodule.textBoxPcode.Enabled = false;
                productmodule.btnsave.Enabled = false;
                productmodule.btnupdate.Enabled = true;
                productmodule.ShowDialog();

            }
            else if (colname == "Delete")
            {
                if (MessageBox.Show("Are you sure want to delete this product ?", "Delete Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cmd = new SqlCommand("delete from tbproduct where pcode='"+dgvProduct.Rows[e.RowIndex].Cells[1].Value.ToString()+"'",con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Product has been deleted successfuly", "Point Of Sale", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                LoadProducts();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadProducts();
        }
    }
}
