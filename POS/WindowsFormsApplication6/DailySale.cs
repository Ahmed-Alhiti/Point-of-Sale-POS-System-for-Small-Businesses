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
    public partial class DailySale : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBconnect dbcon = new DBconnect();
        SqlDataReader dr;
        public string solduser;
        MainForm main;
        public DailySale( MainForm form)
        {
            InitializeComponent();
            con = new SqlConnection(dbcon.mycon());
            main = form;
            LoadCashier();
        }

        private void picClose_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void LoadCashier()
        {
            cboCashier.Items.Clear();
            cboCashier.Items.Add("All Cashier");
            con.Open();
            cmd = new SqlCommand("SELECT * FROM tbuser WHERE role LIKE 'Cashier'", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cboCashier.Items.Add(dr["Username"].ToString());
            }
            dr.Close();
            con.Close();
        }
        public void LoadSold()
        {
            int i = 0;
            double total = 0;
            dgvSold.Rows.Clear();
            con.Open();
            if (cboCashier.Text == "All Cashier")
            {
                cmd = new SqlCommand("select c.id, c.transno, c.pcode, p.pdesc, c.price, c.qty, c.disc, c.total from tbCart as c inner join tbProduct as p on c.pcode = p.pcode where status like 'Sold' and sdate between '" + dtFrom.Value + "' and '" + dtTo.Value + "'", con);
            }
            else
            {
                cmd = new SqlCommand("select c.id, c.transno, c.pcode, p.pdesc, c.price, c.qty, c.disc, c.total from tbCart as c inner join tbProduct as p on c.pcode = p.pcode where status like 'Sold' and sdate between '" + dtFrom.Value + "' and '" + dtTo.Value + "' and cashier like '" + cboCashier.Text + "'", con);
            }
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                total += double.Parse(dr["total"].ToString());
                dgvSold.Rows.Add(i, dr["id"].ToString(), dr["transno"].ToString(), dr["pcode"].ToString(), dr["pdesc"].ToString(), dr["price"].ToString(), dr["qty"].ToString(), dr["disc"].ToString(), dr["total"].ToString());
            }
            dr.Close();
            con.Close();
            lblTotal.Text = total.ToString("#,##0.00");
        }





        private void DailySale_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
        }
        private void cboCashier_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSold();
        }

        private void dtFrom_ValueChanged(object sender, EventArgs e)
        {
            LoadSold();
        }
        private void dtTo_ValueChanged(object sender, EventArgs e)
        {
            LoadSold();
        }

        private void dgvSold_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvSold.Columns[e.ColumnIndex].Name;
            if (colName == "Cancel")
            {
                try
                {
                    CancelOrder cancelOrder = new CancelOrder(this);
                    cancelOrder.txtid.Text = dgvSold.Rows[e.RowIndex].Cells[1].Value.ToString();
                    cancelOrder.txtTranasNo.Text = dgvSold.Rows[e.RowIndex].Cells[2].Value.ToString();
                    cancelOrder.txtPcode.Text = dgvSold.Rows[e.RowIndex].Cells[3].Value.ToString();
                    cancelOrder.txtDesc.Text = dgvSold.Rows[e.RowIndex].Cells[4].Value.ToString();
                    cancelOrder.txtPrice.Text = dgvSold.Rows[e.RowIndex].Cells[5].Value.ToString();
                    cancelOrder.txtQty.Text = dgvSold.Rows[e.RowIndex].Cells[6].Value.ToString();
                    cancelOrder.txtDisc.Text = dgvSold.Rows[e.RowIndex].Cells[7].Value.ToString();
                    cancelOrder.txtTotal.Text = dgvSold.Rows[e.RowIndex].Cells[8].Value.ToString();
                    cancelOrder.txtCancelBy.Text = solduser;
                    cancelOrder.ShowDialog();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            POSReport pOSReport = new POSReport();
            string param = "Date From:" + dtFrom.Value.ToShortDateString() + "' To: '" + dtTo.Value.ToShortDateString();
            if (cboCashier.Text == "All Cashier")
            {
                pOSReport.LoadDailyReport("select c.id, c.transno, c.pcode, p.pdesc, c.price, c.qty, c.disc as discount, c.total from tbCart as c inner join tbProduct as p on c.pcode = p.pcode where status like 'Sold' and sdate between '" + dtFrom.Value + "' and '" + dtTo.Value + "'", param,cboCashier.Text);
            }
            else
            {
                pOSReport.LoadDailyReport("select c.id, c.transno, c.pcode, p.pdesc, c.price, c.qty, c.disc as discount, c.total from tbCart as c inner join tbProduct as p on c.pcode = p.pcode where status like 'Sold' and sdate between '" + dtFrom.Value + "' and '" + dtTo.Value + "' and cashier like '" + cboCashier.Text + "'", param, cboCashier.Text);
            }
            pOSReport.ShowDialog();
        }

        private void dgvSold_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            string colname = dgvSold.Columns[e.ColumnIndex].Name;
            if (colname == "Cancel")
            {
                CancelOrder cancel = new CancelOrder(this);
                cancel.txtid.Text = dgvSold.Rows[e.RowIndex].Cells[1].Value.ToString();
                cancel.txtTranasNo.Text= dgvSold.Rows[e.RowIndex].Cells[2].Value.ToString();
                cancel.txtPcode.Text = dgvSold.Rows[e.RowIndex].Cells[3].Value.ToString();
                cancel.txtDesc.Text = dgvSold.Rows[e.RowIndex].Cells[4].Value.ToString();
                cancel.txtPrice.Text = dgvSold.Rows[e.RowIndex].Cells[5].Value.ToString();
                cancel.txtQty.Text = dgvSold.Rows[e.RowIndex].Cells[6].Value.ToString();
                cancel.txtDisc.Text = dgvSold.Rows[e.RowIndex].Cells[7].Value.ToString();
                cancel.txtTotal.Text = dgvSold.Rows[e.RowIndex].Cells[8].Value.ToString();
                if (lblTitle.Visible == false)
                {
                    cancel.txtCancelBy.Text = main.labelusername.Text;
                }
                else
                cancel.txtCancelBy.Text = solduser;
                cancel.ShowDialog();
            }
        }
    }
}
