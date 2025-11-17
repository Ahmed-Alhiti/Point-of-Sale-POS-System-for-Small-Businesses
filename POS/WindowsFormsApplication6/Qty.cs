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
    public partial class Qty : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBconnect dbcon = new DBconnect();
        SqlDataReader dr;
        string stitle = "Point Of Sale";
        private string pcode;
        private double price;
        private string transno;
        private int qty;
        Cashier cashier;
        public Qty(Cashier cash)
        {
            InitializeComponent();
            con = new SqlConnection(dbcon.mycon());
            cashier = cash;
        }
        public void ProductDetalis (string pcode, double price, string transno, int qty)
        {
            this.pcode = pcode;
            this.price = price;
            this.transno = transno;
            this.qty = qty;
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar==13) && (txtQty.Text != string.Empty))
            {
                try
                {
                    string id = "";
                    int cart_qty = 0;
                    bool found = false;
                    con.Open();
                    cmd = new SqlCommand("select * from tbcart where transno  = @transno and pcode = @pcode", con);
                    cmd.Parameters.AddWithValue("@transno", transno);
                    cmd.Parameters.AddWithValue("@pcode", pcode);
                    dr = cmd.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        id = dr["id"].ToString();
                        cart_qty = int.Parse(dr["qty"].ToString());
                        found = true;
                    }
                    else found = false;
                    dr.Close();
                    con.Close();

                    if (found)
                    {
                        if (qty < (int.Parse(txtQty.Text) + cart_qty))
                        {
                            MessageBox.Show("Unable to procced .Ramining qty on hand is " + qty, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        con.Open();
                        cmd = new SqlCommand("update tbcart set qty = (qty + " + int.Parse(txtQty.Text) + ") where id = '" + id + "'", con);
                        cmd.ExecuteReader();
                        con.Close();
                        cashier.txtBarcode.Clear();
                        cashier.txtBarcode.Focus();
                        cashier.LoadCart();
                        this.Dispose();
                    }
                    else
                    {
                        if (qty < (int.Parse(txtQty.Text) + cart_qty))
                        {
                            MessageBox.Show("Unable to procced .Ramining qty on hand is " + qty, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        con.Open();
                        cmd = new SqlCommand("insert into tbcart(transno,pcode,price,qty,sdate,cashier) values (@transno,@pcode,@price,@qty,@sdate,@cashier)", con);
                        cmd.Parameters.AddWithValue("@transno", transno);
                        cmd.Parameters.AddWithValue("@pcode", pcode);
                        cmd.Parameters.AddWithValue("@price", price);
                        cmd.Parameters.AddWithValue("@qty", int.Parse(txtQty.Text));
                        cmd.Parameters.AddWithValue("@sdate", DateTime.Now);
                        cmd.Parameters.AddWithValue("@cashier", cashier.lbusername.Text);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        cashier.txtBarcode.Clear();
                        cashier.txtBarcode.Focus();
                        cashier.LoadCart();
                        this.Dispose();
                    }




                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, stitle);
                }
            }
           
        }

        private void Qty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
        }
    }
}
