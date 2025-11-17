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
    public partial class settle : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBconnect dbcon = new DBconnect();
        SqlDataReader dr;
        Cashier cashier;
        public settle(Cashier cash)
        {
            InitializeComponent();
            con = new SqlConnection(dbcon.mycon());
            this.KeyPreview = true;
            cashier = cash;
        }

        private void btnone_Click(object sender, EventArgs e)
        {
            txtCash.Text += btnone.Text;
        }

        private void btntow_Click(object sender, EventArgs e)
        {
            txtCash.Text += btntow.Text;
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            txtCash.Text += btnThree.Text;
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            txtCash.Text += btnFour.Text;
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            txtCash.Text += btnFive.Text;
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            txtCash.Text += btnSix.Text;
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            txtCash.Text += btnSeven.Text;
        }

        private void btneight_Click(object sender, EventArgs e)
        {
            txtCash.Text += btneight.Text;
        }

        private void btnnine_Click(object sender, EventArgs e)
        {
            txtCash.Text += btnnine.Text;
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            txtCash.Text += btnZero.Text;
        }

        private void btnDZero_Click(object sender, EventArgs e)
        {
            txtCash.Text += btnDZero.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCash.Clear();
            txtCash.Focus();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                if((double.Parse(txtChange.Text)<0) || (txtCash.Text.Equals("")))
                {
                    MessageBox.Show("Insufficient amount , Please enter the correct amount !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    for(int i = 0; i < cashier.dgvCash.Rows.Count; i++)
                    {
                        con.Open();
                        cmd = new SqlCommand("update tbproduct set qty = qty -  " + int.Parse(cashier.dgvCash.Rows[i].Cells[5].Value.ToString()) + "where pcode =  '" + cashier.dgvCash.Rows[i].Cells[2].Value.ToString() + "'", con);
                        cmd.ExecuteNonQuery();
                        con.Close();

                        con.Open();
                        cmd = new SqlCommand("update tbcart set status = 'Sold'  where id =  '" + cashier.dgvCash.Rows[i].Cells[1].Value.ToString() + "'", con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    Recept recept = new Recept(cashier);
                    recept.LoadRecept(txtCash.Text, txtChange.Text);
                    recept.ShowDialog();

                    MessageBox.Show("Payment successfuly saved!", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cashier.GetTransNo();
                    cashier.LoadCart();
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtCash_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double sale = double.Parse(txtSale.Text);
                double cash = double.Parse(txtCash.Text);
                double change = cash - sale;
                txtChange.Text = change.ToString("#,###.00");
            }
            catch (Exception)
            {
                txtChange.Text = "0.00";
            }
        }

        private void settle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) this.Dispose();
            else if (e.KeyCode == Keys.Enter) btnEnter.PerformClick();
        }
    }
}
