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
    public partial class Dashbord : Form
    {
        SqlConnection con = new SqlConnection();
        DBconnect dbcon = new DBconnect();
        public Dashbord()
        {
            InitializeComponent();
            con = new SqlConnection(dbcon.mycon());
        }

        private void Dashbord_Load(object sender, EventArgs e)
        {
            string sdate = DateTime.Now.ToShortDateString();
            lblDalySale.Text = dbcon.ExtractData("select ISNULL(SUM(total),0) AS total From tbcart where status like 'Sold' and sdate between '" + sdate + "' and '" + sdate + "'").ToString("#,##0.00");
            lbTotalProduct.Text = dbcon.ExtractData("select COUNT(*) from tbproduct").ToString("##,#0");
            lbStockOnHand.Text = dbcon.ExtractData("select ISNULL(SUM(qty), 0) AS qty from tbproduct").ToString("#,##0");
            lbCriticalItems.Text = dbcon.ExtractData("select COUNT(*) from vwCriticalItems").ToString("#,##0");
        }
    }
}
