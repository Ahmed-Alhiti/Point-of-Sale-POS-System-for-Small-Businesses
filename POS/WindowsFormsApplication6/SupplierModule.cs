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
    public partial class SupplierModule : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBconnect dbcon = new DBconnect();
        Supplier supplier;
        public SupplierModule(Supplier sp)
        {
            con = new SqlConnection(dbcon.mycon());
            InitializeComponent();
            supplier = sp;
        }

        private void picclose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        void clear()
        {
            txtsuppliername.Clear();
            txtphoneNumber.Clear();
            txtfaxnumber.Clear();
            txtemailaddress.Clear();
            txtcontactperson.Clear();
            btnsave.Enabled = true;
            btnupdate.Enabled = false;
            txtsuppliername.Focus();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Save this record?Click yes to confirm", "CONFIRM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cmd = new SqlCommand("insert into tbsupplier (supplier,address,contactperson,phone,email,fax)values(@supplier,@address,@contactperson,@phone,@email,@fax)",con);
                    cmd.Parameters.AddWithValue("@supplier",txtsuppliername.Text);
                    cmd.Parameters.AddWithValue("@address", txtaddress.Text);
                    cmd.Parameters.AddWithValue("@contactperson", txtcontactperson.Text);
                    cmd.Parameters.AddWithValue("@phone",txtphoneNumber.Text );
                    cmd.Parameters.AddWithValue("@email",txtemailaddress.Text );
                    cmd.Parameters.AddWithValue("@fax", txtfaxnumber.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record has been saved successfuly", "Save Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                    supplier.LoadSupplier();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Point Of Sale");
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure want to update this record ?", "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new SqlCommand("update tbsupplier set supplier = @supplier, address = @address, contactperson = @contactperson , phone = @phone , email = @email , fax= @fax where id like '"+labelid.Text+"'", con);
                    cmd.Parameters.AddWithValue("@supplier", txtsuppliername.Text);
                    cmd.Parameters.AddWithValue("@address", txtaddress.Text);
                    cmd.Parameters.AddWithValue("@contactperson", txtcontactperson.Text);
                    cmd.Parameters.AddWithValue("@phone", txtphoneNumber.Text);
                    cmd.Parameters.AddWithValue("@email", txtemailaddress.Text);
                    cmd.Parameters.AddWithValue("@fax",  txtfaxnumber.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record has been updated successfly", "Update Record",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    clear();
                    supplier.LoadSupplier();
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void SupplierModule_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
        }
    }
}
