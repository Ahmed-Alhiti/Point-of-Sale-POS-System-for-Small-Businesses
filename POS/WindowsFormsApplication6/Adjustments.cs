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
    public partial class Adjustments : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBconnect dbcon = new DBconnect();
        SqlDataReader dr;
        MainForm main;
        int _qty;
        public Adjustments(MainForm mn)
        {
            InitializeComponent();
            con = new SqlConnection(dbcon.mycon());
            main = mn;
            ReferencNo();
            LoadStock();
            lblusername.Text = main.labelusername.Text;
        }
        public void ReferencNo()
        {
            Random random = new Random();
            lbRefno.Text = random.Next().ToString();
        }
        public void LoadStock()
        {
            int i = 0;
            dgvAdjustment.Rows.Clear();

            cmd = new SqlCommand("SELECT P.pcode,P.barcode,P.pdesc,b.brand,c.category,P.price,P.qty from tbproduct as P inner join tbbrand as b on b.id = P.bid inner join tbcategory as c on c.id = P.cid where concat(P.pdesc ,b.brand , c.category) like '%" + txtSearch.Text + "%'", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvAdjustment.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void dgvAdjustment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvAdjustment.Columns[e.ColumnIndex].Name;
            if (colName == "Select")
            {
                lbPcode.Text = dgvAdjustment.Rows[e.RowIndex].Cells[1].Value.ToString();
                lbDesc.Text = dgvAdjustment.Rows[e.RowIndex].Cells[3].Value.ToString() + " " + dgvAdjustment.Rows[e.RowIndex].Cells[4].Value.ToString() + " " + dgvAdjustment.Rows[e.RowIndex].Cells[5].Value.ToString();
                _qty = int.Parse(dgvAdjustment.Rows[e.RowIndex].Cells[7].Value.ToString());
                btnsave.Enabled = true;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadStock();
        }
        public void Clear()
        {
            lbDesc.Text = "";
            lbPcode.Text = "";
            txtQty.Clear();
            txtRemarks.Clear();
            cbaction.Text = "";
            ReferencNo();
            
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                //validation for empty felid
                if (cbaction.Text == "")
                {
                    MessageBox.Show("Please select action for add or remove", "Warining", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbaction.Focus();
                    return;
                }
                if (txtQty.Text == "")
                {

                    MessageBox.Show("Please input quantity for add or remove", "Warining", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtQty.Focus();
                    return;
                }    
                if (txtRemarks.Text == "")
                {
                    
                   MessageBox.Show("Need reason for adjustment", "Warining", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                   txtRemarks.Focus();
                   return;
                    
                }
                //update stock
                if (int.Parse(txtQty.Text) > _qty)
                {
                    MessageBox.Show("Stock On Hand quantity sould be grater than adjustment quantity ", "Warining", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if(cbaction.Text=="Remove From Inventory")
                {
                    dbcon.ExecuteQuery("update tbproduct set qty = (qty - " + int.Parse(txtQty.Text) + ") where pcode like '" + lbPcode.Text + "'");
                }
                else if(cbaction.Text=="Add To Inventory")
                {
                    dbcon.ExecuteQuery("update tbproduct set qty = (qty + " + int.Parse(txtQty.Text) + ") where pcode like '" + lbPcode.Text + "'");
                }
                dbcon.ExecuteQuery("insert into tbAdjustment ( referencno, pcode, qty, action, remarks, sdate, [user]) values ('"+lbRefno.Text+ "','" + lbPcode.Text + "','" +int.Parse(txtQty.Text) + "','" + cbaction.Text + "','" + txtRemarks.Text + "','" + DateTime.Now.ToShortDateString() + "','" + lblusername.Text + "')");
                MessageBox.Show("Stock has been successfully adjusted.", "Process completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadStock();
                Clear();
                btnsave.Enabled = false;
            } 
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Warining", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
