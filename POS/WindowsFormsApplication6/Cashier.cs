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
using ZXing;
using DarrenLee.Media;

namespace WindowsFormsApplication6
{
    public partial class Cashier : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBconnect dbcon = new DBconnect();
        SqlDataReader dr;
        int qty;
        string id;
        string price;
        string stitle = "Point Of Sale";

        Camera captureDevice = new Camera();
        public Cashier()
        {
            InitializeComponent();
            con = new SqlConnection(dbcon.mycon());
            GetTransNo();
            lbDate.Text = DateTime.Now.ToShortDateString();
        }

        private void picclose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit Application?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        public void slide(Button button)
        {
            panelSlide.BackColor = Color.White;
            panelSlide.Height = button.Height;
            panelSlide.Top = button.Top;
        }
        #region button
        private void btnNtransaction_Click(object sender, EventArgs e)
        {
            slide(btnNtransaction);
            GetTransNo();
        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            slide(btnSearchProduct);
            LookUpProduct lookUp = new LookUpProduct(this);
            lookUp.LoadProducts();
            lookUp.ShowDialog();
        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {
            slide(btnDiscount);
            Discount discount = new Discount(this);
            discount.lbid.Text = id;
            discount.txtTotalPrice.Text = price;
            discount.ShowDialog();
        }

        private void btnSettilePayment_Click(object sender, EventArgs e)
        {
            slide(btnSettilePayment);
            settle sett = new settle(this);
            sett.txtSale.Text = lbDisplayTotal.Text;
            sett.ShowDialog();
        }

        private void btnClearCart_Click(object sender, EventArgs e)
        {
            slide(btnClearCart);
            if (MessageBox.Show("Remove all items from cart?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                con.Open();
                cmd = new SqlCommand("Delete from tbcart where transno like '" + lbTransNo.Text + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("All items has been successfuly removed", "Remove Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCart();
            }
        }

        private void btnDailySales_Click(object sender, EventArgs e)
        {
            slide(btnDailySales);
            DailySale dailySale = new DailySale(new MainForm());
            dailySale.solduser = lbusername.Text;
            dailySale.dtFrom.Enabled = false;
            dailySale.dtTo.Enabled = false;
            dailySale.cboCashier.Enabled = false;
            dailySale.cboCashier.Text = lbusername.Text;
            dailySale.picClose.Visible = true;
            dailySale.lblTitle.Visible = true;
            dailySale.ShowDialog(); 
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            slide(btnChangePassword);
            ChangePassword change = new ChangePassword(this);
            change.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            slide(btnLogout);
            if(dgvCash.Rows.Count > 0)
            {
                MessageBox.Show("Unable to logout. Please cancle the transaction", "Warining", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Logout Application", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                Login login = new Login();
                login.ShowDialog();
            }
        }

        
        #endregion button
        public void LoadCart()
        {
            try
            {
                Boolean hascart = false;
                int i = 0;
                double total = 0;
                double discount = 0;
                dgvCash.Rows.Clear();
                con.Open();
                cmd = new SqlCommand("select c.id, c.pcode , p.pdesc , c.price ,c.qty,c.disc ,c.total from tbcart AS c INNER JOIN tbproduct AS p ON c.pcode=p.pcode WHERE c.transno LIKE  @transno and c.status LIKE 'Pending' ", con);
                cmd.Parameters.AddWithValue("@transno", lbTransNo.Text);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    total += Convert.ToDouble(dr["total"].ToString());
                    discount += Convert.ToDouble(dr["disc"].ToString());
                    dgvCash.Rows.Add(i, dr["id"].ToString(), dr["pcode"].ToString(), dr["pdesc"].ToString(), dr["price"].ToString(), dr["qty"].ToString(), dr["disc"].ToString(), double.Parse(dr["total"].ToString()));
                    hascart = true;
                }
                dr.Close();
                con.Close();
                lbSaleTotal.Text = total.ToString("#,##0.00");
                lbDiscount.Text = discount.ToString("#,##0.00");
                GetCartTotal();
                if (hascart) { btnClearCart.Enabled = true; btnSettilePayment.Enabled = true;btnDiscount.Enabled = true; }
                else { btnClearCart.Enabled = false; btnSettilePayment.Enabled = false; btnDiscount.Enabled = false; }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,stitle);
            }
           
        }
        public void GetCartTotal()
        {
            double discount = double.Parse(lbDiscount.Text);
            double sales = double.Parse(lbSaleTotal.Text) - discount;
            double vat = sales * 0.12;//VAT: 12% of VAT Payable (Output Tax less input Tax)
            double vatable = sales - vat;
            lbvat.Text = vat.ToString("#,##0.00");
            lbvatable.Text = vatable.ToString("#,##0.00");
            lbDisplayTotal.Text=sales.ToString("#,##0.00");

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbTimer.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }
        public void GetTransNo()
        {
            try
            {
                string sdate = DateTime.Now.ToString("yyyyMMdd");
                int count;
                string transno ;
                con.Open();
                cmd = new SqlCommand("select top 1 transno from tbcart where transno like '" + sdate + "%' order by id desc ", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    transno = dr[0].ToString();
                    count = int.Parse(transno.Substring(8, 4));
                    lbTransNo.Text = sdate + (count + 1);
                }
                else
                {
                    transno = sdate + "1001";
                    lbTransNo.Text = transno;
                }
                dr.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message,stitle);
            }
            
        }

        private void txtBarcode_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtBarcode.Text == string.Empty) return;
                else
                {
                    string _pcode;
                    double _price;
                    int _qty;
                    con.Open();
                    cmd = new SqlCommand("select * from tbproduct where barcode like '" + txtBarcode.Text + "'", con);
                    dr = cmd.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        qty = int.Parse(dr["qty"].ToString());
                        _pcode = dr["pcode"].ToString();
                        _price=double.Parse(dr["price"].ToString());
                        _qty = int.Parse(txtQty.Text);
                       
                        dr.Close();
                        con.Close();
                        //insert to tbcart
                        Addtocart(_pcode, _price, _qty);
                    }
                }
                
                
            }
            catch(Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }
        public void Addtocart(string _pcode,double _price,int _qty)
        {
            try
            {
                string id = "";
                int cart_qty = 0;
                bool found = false;
                con.Open();
                cmd = new SqlCommand("select * from tbcart where transno = @transno and pcode = @pcode",con);
                cmd.Parameters.AddWithValue("@transno", lbTransNo.Text);
                cmd.Parameters.AddWithValue("@pcode", _pcode);
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
                        MessageBox.Show("Unable to procced .Ramining quantity on hand is " + qty, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    con.Open();
                    cmd = new SqlCommand("update tbcart set qty = (qty+"+_qty+")where id= '"+id+"'",con);
                    cmd.ExecuteReader();
                    con.Close();
                    txtBarcode.SelectionStart = 0;
                    txtBarcode.SelectionLength = txtBarcode.Text.Length;
                    LoadCart();
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
                    cmd.Parameters.AddWithValue("@transno", lbTransNo.Text);
                    cmd.Parameters.AddWithValue("@pcode", _pcode);
                    cmd.Parameters.AddWithValue("@price", _price);
                    cmd.Parameters.AddWithValue("@qty", _qty);
                    cmd.Parameters.AddWithValue("@sdate", DateTime.Now);
                    cmd.Parameters.AddWithValue("@cashier", lbusername.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    LoadCart();
                }



                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,stitle);
            }
        }

        private void dgvCash_SelectionChanged(object sender, EventArgs e)
        {
            int i = dgvCash.CurrentRow.Index;
            id = dgvCash[1, i].Value.ToString();
            price = dgvCash[7, i].Value.ToString();
        }

        private void dgvCash_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colname = dgvCash.Columns[e.ColumnIndex].Name;
           

            if (colname == "Delete")
            {
                if (MessageBox.Show("Remove this item ?", "Remove item", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dbcon.ExecuteQuery("Delete from tbcart where id like '" + dgvCash.Rows[e.RowIndex].Cells[1].Value.ToString() + "'");
                    MessageBox.Show("Item has been successfuly removed", "Remove Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCart();
                }
            }
            else if (colname == "colAdd")
            {
                int i = 0;
                con.Open();
                cmd = new SqlCommand("select sum(qty) as qty from tbproduct where pcode like '" + dgvCash.Rows[e.RowIndex].Cells[2].Value.ToString() + "'group by pcode", con);
                i = int.Parse(cmd.ExecuteScalar().ToString());
                con.Close();

                if (int.Parse(dgvCash.Rows[e.RowIndex].Cells[5].Value.ToString()) < i)
                {
                    dbcon.ExecuteQuery("update tbcart set qty = qty + " + int.Parse(txtQty.Text) + " where transno like '" + lbTransNo.Text + "' and pcode like '" + dgvCash.Rows[e.RowIndex].Cells[2].Value.ToString() + "' ");
                    LoadCart();
                }
                else
                {
                    MessageBox.Show("Remaining qty on hand is " + i + "!", "Out of stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else if (colname == "colReduce")
            {
                int i = 0;
                con.Open();
                cmd = new SqlCommand("select sum(qty) as qty from tbcart where pcode like '" + dgvCash.Rows[e.RowIndex].Cells[2].Value.ToString() + "'group by pcode", con);
                i = int.Parse(cmd.ExecuteScalar().ToString());
                con.Close();

                if (i > 1)
                {
                   
                    dbcon.ExecuteQuery("update tbcart set qty = qty - " + int.Parse(txtQty.Text) + " where transno like '" + lbTransNo.Text + "' and pcode like '" + dgvCash.Rows[e.RowIndex].Cells[2].Value.ToString() + "'");
                    LoadCart();
                }
                else
                {
                    MessageBox.Show("Remaining qty on hand is " + i + "!", "Out of stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LoadCart();
                }
            }
        }
        public void Noti()
        {
            int i = 0;
            con.Open();
            cmd = new SqlCommand("SELECT * FROM vwCriticalItems", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                Alert alert = new Alert(new MainForm());
                alert.lblPcode.Text = dr["pcode"].ToString();
                alert.showAlert(i + ". " + dr["pdesc"].ToString() + " - " + dr["qty"].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void Cashier_Load(object sender, EventArgs e)
        {
            Noti();
        }

        private void Cashier_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode== Keys.F8)
            {
                captureDevice.OnFrameArrived += captureDevice_OnFrameArrived;
                captureDevice.Start();
            }
        }

        private void captureDevice_OnFrameArrived(object source, FrameArrivedEventArgs e)
        {
            Bitmap bitmap = (Bitmap)e.GetFrame();
            BarcodeReader barcodeReader = new BarcodeReader();
            var result = barcodeReader.Decode(bitmap);
            if(result != null)
            {
                txtBarcode.Invoke(new MethodInvoker(delegate ()
                { txtBarcode.Text = result.ToString(); }));
            }
        }

        private void Cashier_FormClosing(object sender, FormClosingEventArgs e)
        {
            captureDevice.Stop();
        }
    }
}
