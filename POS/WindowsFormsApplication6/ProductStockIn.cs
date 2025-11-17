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
    public partial class ProductStockIn : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBconnect dbcon = new DBconnect();
        SqlDataReader dr;
        string stitle = "Point Of Sale";
        StockIn stockIn;
        public ProductStockIn(StockIn stk)
        {
            InitializeComponent();
            con = new SqlConnection(dbcon.mycon());
            stockIn = stk;
            LoadProduct();
           
            
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void LoadProduct()
        {
            int i = 0;
            dgvProduct.Rows.Clear();
            
            cmd = new SqlCommand("SELECT pcode,pdesc,qty from tbproduct where pdesc like '%" + txtSearch.Text + "%' ", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvProduct.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvProduct.Columns[e.ColumnIndex].Name;
            if (colName == "Select")
            {
                if (stockIn.txtStockInBy.Text == string.Empty)
                {
                    MessageBox.Show("Please enter stock in by name", stitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    stockIn.txtStockInBy.Focus();
                    this.Dispose();
                    
                }
                if (MessageBox.Show("Add this item ?", stitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    addStockIn(dgvProduct.Rows[e.RowIndex].Cells[1].Value.ToString());
                    MessageBox.Show("Successfully added", stitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        public void addStockIn(string pcode)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("INSERT INTO tbStockIn (refno, pcode, sdate, stockinby, supplierid)VALUES (@refno, @pcode, @sdate, @stockinby, @supplierid)", con);
                cmd.Parameters.AddWithValue("@refno", stockIn.txtRefNo.Text);
                cmd.Parameters.AddWithValue("@pcode", pcode);
                cmd.Parameters.AddWithValue("@sdate", stockIn.dtStockIn.Value);
                cmd.Parameters.AddWithValue("@stockinby", stockIn.txtStockInBy.Text);
                cmd.Parameters.AddWithValue("@supplierid", stockIn.lbid.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                stockIn.LoadStockIn();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, stitle);
            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadProduct();
        }

        private void ProductStockIn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
        }
    }
}
