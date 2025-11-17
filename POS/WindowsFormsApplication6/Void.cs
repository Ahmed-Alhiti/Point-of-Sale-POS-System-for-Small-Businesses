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
    public partial class Void : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBconnect dbcon = new DBconnect();
        SqlDataReader dr;
        CancelOrder cancelOrder;
        public Void(CancelOrder cancel)
        {
            InitializeComponent();
            con = new SqlConnection(dbcon.mycon());
            txtusername.Focus();
            cancelOrder = cancel;
        }

        private void btnvoid_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtusername.Text.ToLower() == cancelOrder.txtCancelBy.Text.ToLower())
                {
                    MessageBox.Show("void by name and cancelled by name are same!.Please void by another person.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string user;
                con.Open();
                cmd = new SqlCommand("select * from tbuser where Username = @Username and password = @password ", con);
                cmd.Parameters.AddWithValue("@Username", txtusername.Text);
                cmd.Parameters.AddWithValue("@password", txtpass.Text);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    user = dr["Username"].ToString();
                    dr.Close();
                    con.Close();
                    SaveCancelOrder(user);
                    if (cancelOrder.cbInventory.Text == "yes")
                    {
                        dbcon.ExecuteQuery("UPDATE tbproduct SET qty = qty +" + cancelOrder.udCancelQty.Value + " where pcode= '" + cancelOrder.txtPcode.Text + "'");
                    }
                    dbcon.ExecuteQuery("UPDATE tbcart SET qty = qty -" + cancelOrder.udCancelQty.Value + " where id LIKE '" + cancelOrder.txtid.Text + "'");
                    MessageBox.Show("Order transaction successfully cancelled!", "Cancel Order", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                    cancelOrder.ReloadSoldList();
                    cancelOrder.Dispose();
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

        public void SaveCancelOrder(string user)
        {
            try
            {
                
                con.Open();
                cmd = new SqlCommand("insert into tbcancel (transno,pcode,price,qty,total,sdate,voidBy,cancelledby,reason,action)values(@transno,@pcode,@price,@qty,@total,@sdate,@voidBy,@cancelledby,@reason,@action)", con);
                cmd.Parameters.AddWithValue("@transno", cancelOrder.txtTranasNo.Text);
                cmd.Parameters.AddWithValue("@pcode", cancelOrder.txtPcode.Text);
                cmd.Parameters.AddWithValue("@price",double.Parse(cancelOrder.txtPrice.Text));
                cmd.Parameters.AddWithValue("@qty",int.Parse(cancelOrder.txtQty.Text));
                cmd.Parameters.AddWithValue("@total", double.Parse(cancelOrder.txtTotal.Text));
                cmd.Parameters.AddWithValue("@sdate", DateTime.Now);
                cmd.Parameters.AddWithValue("@voidBy", user);
                cmd.Parameters.AddWithValue("@cancelledby", cancelOrder.txtCancelBy.Text);
                cmd.Parameters.AddWithValue("@reason", cancelOrder.txtReason.Text);
                cmd.Parameters.AddWithValue("@action", cancelOrder.cbInventory.Text);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void picclose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Void_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
        }
    }
}
