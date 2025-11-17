using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zen.Barcode;

namespace WindowsFormsApplication6
{
    public partial class Barcode : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBconnect dbcon = new DBconnect();
        SqlDataReader dr;
        string fname;
        public Barcode()
        {
            InitializeComponent();
            con = new SqlConnection(dbcon.mycon());
            LoadProducts();
        }
        public void LoadProducts()
        {
            int i = 0;
            dgvBarcode.Rows.Clear();

            cmd = new SqlCommand("SELECT P.pcode,P.barcode,P.pdesc,b.brand,c.category,P.price,P.reorder from tbproduct as P inner join tbbrand as b on b.id = P.bid inner join tbcategory as c on c.id = P.cid where concat(P.pdesc,b.brand,c.category) like '%" + txtSearch.Text + "%'", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvBarcode.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString());
            }
            dr.Close();
            con.Close();

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void dgvBarcode_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colname = dgvBarcode.Columns[e.ColumnIndex].Name;
            if (colname == "Select")
            {
                Code128BarcodeDraw barcode = BarcodeDrawFactory.Code128WithChecksum;
                picBarcode.Image = barcode.Draw(dgvBarcode.Rows[e.RowIndex].Cells[2].Value.ToString(), 60, 2);
                fname = dgvBarcode.Rows[e.RowIndex].Cells[1].Value.ToString();

            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Title = "Save Barcode Image As";
            saveFile.FileName = fname;
            saveFile.Filter = "Image File(*.jpg,*.png) | *.jpg,*.png";
            ImageFormat image = ImageFormat.Png;
            if(saveFile.ShowDialog() == DialogResult.OK)
            {
                string ftyp = System.IO.Path.GetExtension(saveFile.FileName);
                switch (ftyp)
                {
                    case ".jpg":
                        image = ImageFormat.Jpeg;
                        break;

                    case ".png":
                        image = ImageFormat.Png;
                        break;

                }
                picBarcode.Image.Save(saveFile.FileName, image);
            }
            picBarcode.Image = null;
        }
    }
}
