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
    public partial class LookUpProduct : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBconnect dbcon = new DBconnect();
        SqlDataReader dr;
        Cashier cashier;
        public LookUpProduct(Cashier cash)
        {
            InitializeComponent();
            con = new SqlConnection(dbcon.mycon());
            cashier = cash;
            LoadProducts();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void LoadProducts()
        {
            int i = 0;
            dgvProduct.Rows.Clear();

            cmd = new SqlCommand("SELECT P.pcode,P.barcode,P.pdesc,b.brand,c.category,P.price,P.qty from tbproduct as P inner join tbbrand as b on b.id = P.bid inner join tbcategory as c on c.id = P.cid where concat(P.pdesc,b.brand,c.category) like '%" + txtSearch.Text + "%'", con);
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

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colname = dgvProduct.Columns[e.ColumnIndex].Name;
            if(colname == "Select")
            {
                Qty qty = new Qty(cashier);
                qty.ProductDetalis(dgvProduct.Rows[e.RowIndex].Cells[1].Value.ToString(),double.Parse(dgvProduct.Rows[e.RowIndex].Cells[6].Value.ToString()),cashier.lbTransNo.Text, int.Parse(dgvProduct.Rows[e.RowIndex].Cells[7].Value.ToString()));
                qty.ShowDialog();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LookUpProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
        }
    }
}
