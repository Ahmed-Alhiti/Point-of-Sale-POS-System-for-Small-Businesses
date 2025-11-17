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
    public partial class StockIn : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBconnect dbcon = new DBconnect();
        SqlDataReader dr;
        MainForm main;
        string stitle = "Point Of Sale";
        public StockIn(MainForm mn)
        {
            InitializeComponent();
            con = new SqlConnection(dbcon.mycon());
            main = mn;
            LoadSupplier();
            GetRefNo();
        }
        public void GetRefNo()
        {
            Random rnd = new Random();
            txtRefNo.Clear();
            txtRefNo.Text += rnd.Next();
        }
        public void LoadSupplier()
        {
            cbSupplier.Items.Clear();
            cbSupplier.DataSource =dbcon.gettable("select * from tbsupplier");
            cbSupplier.DisplayMember = "supplier";
        }
        public void ProductForSupplier(string pcode)
        {
            string supplier = "";
            con.Open();
            cmd = new SqlCommand("SELECT * FROM vwStockIn1 WHERE pcode LIKE '" + pcode + "'", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                supplier = dr["supplier"].ToString();
            }
            dr.Close();
            con.Close();
            cbSupplier.Text = supplier;
        }
        public void LoadStockIn()
        {
            int i = 0;
            dgvStockIn.Rows.Clear();
            con.Open();
            cmd = new SqlCommand("select * from vwStockIn1 where refno like '" +txtRefNo.Text+ "' and status like 'Pending'",con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvStockIn.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr["supplier"].ToString());
            }
            dr.Close();
            con.Close();

        }

        private void cbSupplier_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void linkGenerate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GetRefNo();
        }

        private void LinkProduct_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProductStockIn productStockIn = new ProductStockIn(this);
            productStockIn.ShowDialog();
        }

        private void btnEntry_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (dgvStockIn.Rows.Count > 0)
                {
                    if(MessageBox.Show("Are you sure you want to save this records?", stitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        for (int i = 0; i < dgvStockIn.Rows.Count; i++)
                        {
                            //update product quantity

                            con.Open();
                            cmd = new SqlCommand("update tbproduct set qty = qty + "+int.Parse(dgvStockIn.Rows[i].Cells[5].Value.ToString())+" where pcode like '"+dgvStockIn.Rows[i].Cells[3].Value.ToString()+"' ", con);
                            cmd.ExecuteNonQuery();
                            con.Close();

                            // update stockin quantity 
                            con.Open();
                            cmd = new SqlCommand("update tbstockin set qty = qty + " + int.Parse(dgvStockIn.Rows[i].Cells[5].Value.ToString()) + ", status='Done' where id like '" + dgvStockIn.Rows[i].Cells[1].Value.ToString()+ "'", con);
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                       
                        clear();
                        LoadStockIn();
                    }
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,stitle,MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
        public void clear()
        {
            txtRefNo.Clear();
            txtStockInBy.Clear();
            dtStockIn.Value = DateTime.Now;
        }

        private void dgvStockIn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colname = dgvStockIn.Columns[e.ColumnIndex].Name;
            if (colname == "Delete")
            {
                if(MessageBox.Show("Remove this item?", stitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cmd = new SqlCommand("delete from tbstockin where id='"+dgvStockIn.Rows[e.RowIndex].Cells[1].Value.ToString()+"' ", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Item has been successfuly removed", stitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadStockIn();
                }
                
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                int i = 0;
                dgvInStockHistory.Rows.Clear();
                con.Open();
                cmd = new SqlCommand("select * from vwStockIn1 where cast(sdate as date) between '"+dtFrom.Value.ToShortDateString()+ "' and '" + dtTo.Value.ToShortDateString() + "' and status like 'Done' ", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dgvInStockHistory.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), DateTime.Parse(dr[5].ToString()).ToShortDateString(), dr[6].ToString(), dr["supplier"].ToString());
                }
                dr.Close();
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void cbSupplier_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("select*from tbsupplier where supplier like '" + cbSupplier.Text + "'", con);
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                lbid.Text = dr["id"].ToString();
                txtConPerson.Text = dr["contactperson"].ToString();
                txtAddress.Text = dr["address"].ToString();
            }
            dr.Close();
            con.Close();
        }
    }
}
