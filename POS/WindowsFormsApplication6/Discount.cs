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
    public partial class Discount : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBconnect dbcon = new DBconnect();
        SqlDataReader dr;
        string stitle = "Point Of Sale";
        Cashier cashier;
        public Discount(Cashier cash)
        {
            InitializeComponent();
            con = new SqlConnection(dbcon.mycon());
            cashier = cash;
            txtDiscount.Focus();
            this.KeyPreview = true;
        }
        private void picclose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Discount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) this.Dispose();
            else if (e.KeyCode == Keys.Enter) btnsave.PerformClick();
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double disc = double.Parse(txtTotalPrice.Text) * double.Parse(txtDiscount.Text)*0.01;
                txtDiscountAmount.Text = disc.ToString("#,##0.00");

            }
            catch (Exception )
            {
                txtDiscountAmount.Text = "0.00";
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("Add Discount ? Click Yes To Confirm", stitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cmd = new SqlCommand("update tbcart set disc_percent=@disc_percent where id = @id",con);
                    cmd.Parameters.AddWithValue("@disc_percent", double.Parse(txtDiscount.Text));
                    cmd.Parameters.AddWithValue("@id", int.Parse(lbid.Text));
                    cmd.ExecuteNonQuery();
                    con.Close();
                    cashier.LoadCart();
                    this.Dispose();
                }
                
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message,stitle);
            }
        }
    }
}
