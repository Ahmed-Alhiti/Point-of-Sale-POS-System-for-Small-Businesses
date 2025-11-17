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
using Microsoft.Reporting.WinForms;

namespace WindowsFormsApplication6
{
    public partial class Recept : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBconnect dbcon = new DBconnect();
        SqlDataReader dr;
        Cashier cashier;
        string store;
        string address;
        public Recept(Cashier cash)
        {
            InitializeComponent();
            con = new SqlConnection(dbcon.mycon());
            cashier = cash;
            LoadStore();
        }

        public void LoadStore()
        {
            con.Open();
            cmd = new SqlCommand("select*from tbstore", con);
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                store = dr["store"].ToString();
                address = dr["address"].ToString();
            }
            dr.Close();
            con.Close();
        }
        private void Recept_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
        public void LoadRecept(string pcash , string pchange)
        {
            ReportDataSource rptDataSource;
            try
            {
                this.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reports\rptRecept.rdlc";
                this.reportViewer1.LocalReport.DataSources.Clear();

                DataSet1 ds = new DataSet1();
                SqlDataAdapter da = new SqlDataAdapter();

                con.Open();
                da.SelectCommand = new SqlCommand("select c.id , c.transno, c.pcode, c.price, c.qty, c.disc, c.total, c.sdate, c.status, p.pdesc from tbcart as c inner join tbproduct as p on p.pcode=c.pcode where c.transno like '" + cashier.lbTransNo.Text + "'",con);
                da.Fill(ds.Tables["dtRecept"]);
                con.Close();

                ReportParameter pVatable = new ReportParameter("pVatable", cashier.lbvatable.Text);
                ReportParameter pVat = new ReportParameter("pVat", cashier.lbvat.Text);
                ReportParameter pDiscount = new ReportParameter("pDiscount", cashier.lbDiscount.Text);
                ReportParameter pTotal = new ReportParameter("pTotal", cashier.lbDisplayTotal.Text);
                ReportParameter pCash = new ReportParameter("pCash", pcash);
                ReportParameter pChange = new ReportParameter("pChange",pchange);
                ReportParameter pStore = new ReportParameter("pStore", store);
                ReportParameter pAddress = new ReportParameter("pAddress", address);
                ReportParameter pTransaction = new ReportParameter("pTransaction","Invoice #: " + cashier.lbTransNo.Text);
                ReportParameter pCashier = new ReportParameter("pCashier", cashier.lbusername.Text);

                reportViewer1.LocalReport.SetParameters(pVatable);
                reportViewer1.LocalReport.SetParameters(pVat);
                reportViewer1.LocalReport.SetParameters(pDiscount);
                reportViewer1.LocalReport.SetParameters(pTotal);
                reportViewer1.LocalReport.SetParameters(pCash);
                reportViewer1.LocalReport.SetParameters(pChange);
                reportViewer1.LocalReport.SetParameters(pStore);
                reportViewer1.LocalReport.SetParameters(pAddress);
                reportViewer1.LocalReport.SetParameters(pTransaction);
                reportViewer1.LocalReport.SetParameters(pCashier);

                rptDataSource = new ReportDataSource("DataSet1", ds.Tables["dtRecept"]);
                reportViewer1.LocalReport.DataSources.Add(rptDataSource);
                reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 30;


            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void Recept_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
        }
    }
}
