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
    public partial class Record : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBconnect dbcon = new DBconnect();
        SqlDataReader dr;
        public Record()
        {
            InitializeComponent();
            con = new SqlConnection(dbcon.mycon());
            LoadCrititcalItems();
            LoadInventoryList();
        }

        public void LoadTopSelling()
        {
            int i = 0;
            dgvTopsling.Rows.Clear();
            con.Open();

            try
            {
                if (cbTopsell.Text == "Sort By Qty")
                {
                    cmd = new SqlCommand("SELECT TOP 10 pcode, pdesc, isnull(sum(qty),0) AS qty, ISNULL(SUM(total),0) AS total FROM vwTopSelling WHERE sdate BETWEEN '" + dtFromTopsell.Value.ToString() + "' AND '" + dtToTopsell.Value.ToString() + "' AND status LIKE 'Sold' GROUP BY pcode, pdesc ORDER BY qty DESC", con);
                }
                else if (cbTopsell.Text == "Sort By Total Amount")
                {
                    cmd = new SqlCommand("SELECT TOP 10 pcode , pdesc , isnull(sum(qty),0) AS qty, ISNULL(SUM(total),0) AS total FROM vwTopSelling WHERE sdate BETWEEN '" + dtFromTopsell.Value.ToString() + "' AND '" + dtToTopsell.Value.ToString() + "' AND status LIKE 'Sold' GROUP BY pcode, pdesc ORDER BY total DESC", con);
                }
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dgvTopsling.Rows.Add(i, dr["pcode"].ToString(), dr["pdesc"].ToString(), dr["qty"].ToString(), double.Parse(dr["total"].ToString()).ToString("#,##0.00"));
                }
                dr.Close();
                con.Close();
            }
            catch(Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnLoadTopsell_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbTopsell.Text == "Select Sort Type")
                {
                    MessageBox.Show("Please select sort type from dropdown list.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbTopsell.Focus();
                    return;
                }
                LoadTopSelling();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public void LoadCrititcalItems()
        {
            int i = 0;
            dgvCriticalItems.Rows.Clear();
            con.Open();
            try
            {
                
                
                cmd = new SqlCommand("select * from vwCriticalItems ", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dgvCriticalItems.Rows.Add(i , dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString()); 
                }
                dr.Close();
                con.Close();
            }
            catch(Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }

        public void LoadInventoryList()
        {
            dgvInvertoryList.Rows.Clear();
            try
            {
                int i = 0;
                con.Open();
                cmd = new SqlCommand("select * from vwInvertoryList", con);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    i++;
                    dgvInvertoryList.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString());
                }
                dr.Close();
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void LoadSoldItems()
        {
            try
            {
                dgvSolditems.Rows.Clear();
                int i = 0;
                con.Open();
                cmd = new SqlCommand("select c.pcode,p.pdesc,c.price, sum(c.qty) as qty , sum(c.disc) as disc, sum(c.total) as total from tbcart as c inner join tbproduct as p on c.pcode = p.pcode where status like 'Sold' and sdate between '" + dtFromSolditems.Value.ToString() + "' and '" + dtToSolditems.Value.ToString() + "' group by c.pcode ,p.pdesc, c.price ", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dgvSolditems.Rows.Add(i, dr["pcode"].ToString(), dr["pdesc"].ToString(), double.Parse(dr["price"].ToString()).ToString("#,##0.00"), dr["qty"].ToString(), dr["disc"].ToString(), double.Parse(dr["total"].ToString()).ToString("#,##0.00"));

                }
                dr.Close();
                con.Close();

                con.Open();
                cmd = new SqlCommand("select isnull(sum(total),0) from tbcart where status like 'Sold' and sdate between '" + dtFromSolditems.Value.ToString() + "' and '" + dtToSolditems.Value.ToString() + "'", con);
                lbTotal.Text = double.Parse(cmd.ExecuteScalar().ToString()).ToString("#,##0.00");
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private void btnLoadSolditems_Click(object sender, EventArgs e)
        {
            LoadSoldItems();
        }
        public void LoadCancelledItems()
        {
            int i = 0;
            dgvCancell.Rows.Clear();
            try
            {
                con.Open();
                cmd = new SqlCommand("select * from vwCancellItems where sdate between '" + dtFromCancell.Value.ToString() + "' and '" + dtToCancell.Value.ToString() + "'", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dgvCancell.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(),dr[5].ToString(), DateTime.Parse(dr[6].ToString()).ToShortDateString(), dr[7].ToString(), dr[8].ToString(), dr[9].ToString(), dr[10].ToString());
                }
                dr.Close();
                con.Close();
            }
            catch(Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }

        public void LoadStockin()
        {
            int i = 0;
            dgvStockin.Rows.Clear();
            try
            {
                con.Open();
                cmd = new SqlCommand("select * from vwStockIn1 where cast(sdate as date) between '" + dtFromStockIn.Value.ToString() + "' and '" + dtToStockIn.Value.ToString() + "'", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dgvStockin.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), DateTime.Parse(dr[5].ToString()).ToShortDateString(), dr[6].ToString());
                }
                dr.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLoadDataCancell_Click(object sender, EventArgs e)
        {
            LoadCancelledItems();
        }

        private void btnLoadDataStockin_Click(object sender, EventArgs e)
        {
            LoadStockin();
        }

        private void btnPrintTopsell_Click(object sender, EventArgs e)
        {
            POSReport report = new POSReport();
            string param = "From :" + dtFromTopsell.Value.ToString() + " To :" + dtToTopsell.Value.ToString();
            if(cbTopsell.Text== "Sort By Qty")
            {
                report.LoadTopSell("SELECT TOP 10 pcode, pdesc, isnull(sum(qty),0) AS qty, ISNULL(SUM(total),0) AS total FROM vwTopSelling WHERE sdate BETWEEN '" + dtFromTopsell.Value.ToString() + "' AND '" + dtToTopsell.Value.ToString() + "' AND status LIKE 'Sold' GROUP BY pcode, pdesc ORDER BY qty DESC", param, "TOP SELLING ITEMS SORT BY QTY");
            }
            else if(cbTopsell.Text== "Sort By Total Amount")
            {
                report.LoadTopSell("SELECT TOP 10 pcode, pdesc, isnull(sum(qty),0) AS qty, ISNULL(SUM(total),0) AS total FROM vwTopSelling WHERE sdate BETWEEN '" + dtFromTopsell.Value.ToString() + "' AND '" + dtToTopsell.Value.ToString() + "' AND status LIKE 'Sold' GROUP BY pcode, pdesc ORDER BY total DESC", param, "TOP SELLING ITEMS SORT BY TOTAL");
            }
            report.ShowDialog();
        }

        private void btnPtintSolditems_Click(object sender, EventArgs e)
        {
            POSReport report = new POSReport();
            string param = "From :" + dtFromSolditems.Value.ToString() + " To :" + dtToSolditems.Value.ToString();
            report.LoadSoldItems("select c.pcode,p.pdesc,c.price, sum(c.qty) as qty , sum(c.disc) as disc, sum(c.total) as total from tbcart as c inner join tbproduct as p on c.pcode = p.pcode where status like 'Sold' and sdate between '" + dtFromSolditems.Value.ToString() + "' and '" + dtToSolditems.Value.ToString() + "' group by c.pcode ,p.pdesc, c.price ", param);
            report.ShowDialog();
        }

        private void btnPrintIn_Click(object sender, EventArgs e)
        {
            POSReport report = new POSReport();
            report.LoadInventory("select * from vwInvertoryList");
            report.ShowDialog();
        }

        private void btnPrintCancell_Click(object sender, EventArgs e)
        {
            POSReport report = new POSReport();
            string param = "From :" + dtFromCancell.Value.ToString() + " To :" + dtToCancell.Value.ToString();
            report.LoadCancelled("select * from vwCancellItems where sdate between '" + dtFromCancell.Value.ToString() + "' and '" + dtToCancell.Value.ToString() + "'", param);
            report.ShowDialog();
        }

        private void btnPrintStockin_Click(object sender, EventArgs e)
        {
            POSReport report = new POSReport();
            string param = "From :" + dtFromStockIn.Value.ToString() + " To :" + dtToStockIn.Value.ToString();
            report.LoadStockInHistory("select * from vwStockIn1 where cast(sdate as date) between '" + dtFromStockIn.Value.ToString() + "' and '" + dtToStockIn.Value.ToString() + "'", param);
            report.ShowDialog();
        }

        private void btnLoadDataCancell_Click_1(object sender, EventArgs e)
        {
            LoadCancelledItems();
        }
    }
}
