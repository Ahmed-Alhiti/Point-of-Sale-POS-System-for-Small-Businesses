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
    public partial class ProductModule : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBconnect dbcon = new DBconnect();
        Product product;
        string stitle = "Point Of Sale";
        public ProductModule(Product pd)
        {
            InitializeComponent();
            con = new SqlConnection(dbcon.mycon());
            LoadBrand();
            LoadCategory();
            product = pd;
        }
        private void LoadCategory()
        {
            cboBoxCategory.Items.Clear();
            cboBoxCategory.DataSource = dbcon.gettable("select*from tbcategory");
            cboBoxCategory.DisplayMember = "category";
            cboBoxCategory.ValueMember = "id";
        }

        private void LoadBrand()
        {
            cboBoxBrand.Items.Clear();
            cboBoxBrand.DataSource = dbcon.gettable("select*from tbbrand");
            cboBoxBrand.DisplayMember = "brand";
            cboBoxBrand.ValueMember = "id";
        }

        private void picclose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void clear()
        {
            textBoxPcode.Clear();
            textBoxBarcode.Clear();
            textBoxDescription.Clear();
            cboBoxBrand.SelectedIndex = 0;
            cboBoxCategory.SelectedIndex = 0;
            textBoxPrice.Clear();
            UDReorder.Value = 1;
            btnsave.Enabled = true;
            btnupdate.Enabled = false;
            textBoxPcode.Enabled = true;
            textBoxPcode.Focus();

        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure want to save this product ?", "Save Products", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    
                    cmd = new SqlCommand("insert into tbproduct(pcode,barcode,pdesc,bid,cid,price,reorder)values(@pcode,@barcode,@pdesc,@bid,@cid,@price,@reorder)", con);
                    cmd.Parameters.AddWithValue("@pcode", textBoxPcode.Text);
                    cmd.Parameters.AddWithValue("@barcode", textBoxBarcode.Text);
                    cmd.Parameters.AddWithValue("@pdesc", textBoxDescription.Text);
                    cmd.Parameters.AddWithValue("@bid", cboBoxBrand.SelectedValue);
                    cmd.Parameters.AddWithValue("@cid", cboBoxCategory.SelectedValue);
                    cmd.Parameters.AddWithValue("@price",double.Parse(textBoxPrice.Text));
                    cmd.Parameters.AddWithValue("@reorder", UDReorder.Value);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Product has been saved successfly",stitle);
                    clear();
                    product.LoadProducts();
                }

            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();

            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure want to update this product ?", "Update Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new SqlCommand("update tbproduct set barcode = @barcode, pdesc = @pdesc, bid = @bid , cid = @cid , price = @price , reorder = @reorder where pcode like @pcode",con);
                    cmd.Parameters.AddWithValue("@pcode", textBoxPcode.Text);
                    cmd.Parameters.AddWithValue("@barcode", textBoxBarcode.Text);
                    cmd.Parameters.AddWithValue("@pdesc", textBoxDescription.Text);
                    cmd.Parameters.AddWithValue("@bid", cboBoxBrand.SelectedValue);
                    cmd.Parameters.AddWithValue("@cid", cboBoxCategory.SelectedValue);
                    cmd.Parameters.AddWithValue("@price", double.Parse(textBoxPrice.Text));
                    cmd.Parameters.AddWithValue("@reorder", UDReorder.Value);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Product has been updated successfly", "Point Of Sale");
                    clear();
                    product.LoadProducts();
                    this.Dispose();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void ProductModule_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
        }
    }
}
