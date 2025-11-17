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
    public partial class Supplier : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBconnect dbcon = new DBconnect();
        SqlDataReader dr;

        public Supplier()
        {
            
            InitializeComponent();
            con = new SqlConnection(dbcon.mycon());
            LoadSupplier();
        }
        public void LoadSupplier()
        {
            dgvSupplier.Rows.Clear();
            int i = 0;
            con.Open();
            cmd = new SqlCommand("select * from tbsupplier",con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvSupplier.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString());

            }
            dr.Close();
            con.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SupplierModule suppliermodule = new SupplierModule(this);
            suppliermodule.ShowDialog();
        }

        private void dgvSupplier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colname = dgvSupplier.Columns[e.ColumnIndex].Name;
            if (colname == "Edit")
            {
                SupplierModule suppliermodule = new SupplierModule(this);
                suppliermodule.labelid.Text = dgvSupplier.Rows[e.RowIndex].Cells[1].Value.ToString();
                suppliermodule.txtsuppliername.Text = dgvSupplier.Rows[e.RowIndex].Cells[2].Value.ToString();
                suppliermodule.txtaddress.Text = dgvSupplier.Rows[e.RowIndex].Cells[3].Value.ToString();
                suppliermodule.txtcontactperson.Text = dgvSupplier.Rows[e.RowIndex].Cells[4].Value.ToString();
                suppliermodule.txtphoneNumber.Text = dgvSupplier.Rows[e.RowIndex].Cells[5].Value.ToString();
                suppliermodule.txtemailaddress.Text = dgvSupplier.Rows[e.RowIndex].Cells[6].Value.ToString();
                suppliermodule.txtfaxnumber.Text = dgvSupplier.Rows[e.RowIndex].Cells[7].Value.ToString();



                suppliermodule.btnsave.Enabled = false;
                suppliermodule.btnupdate.Enabled = true;
                suppliermodule.ShowDialog();

            }
            else if (colname == "Delete")
            {
                if (MessageBox.Show("Are you sure want to delete this record ?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cmd = new SqlCommand("delete from tbsupplier where id='" + dgvSupplier.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record has been deleted successfuly", "Point Of Sale", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                LoadSupplier();
            }
        }
    }
}
