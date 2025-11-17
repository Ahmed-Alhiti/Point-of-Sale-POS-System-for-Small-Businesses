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
    public partial class POSReport : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBconnect dbcon = new DBconnect();
        SqlDataReader dr;
        string store;
        string address;
        public POSReport()
        {
            InitializeComponent();
            con = new SqlConnection(dbcon.mycon());
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
        private void POSReport_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void LoadDailyReport(string sql, string param, string cashier)
        {
            try
            {
                ReportDataSource rptDS;
                this.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reports\rptSoldReport.rdlc";
                this.reportViewer1.LocalReport.DataSources.Clear();

                DataSet1 ds = new DataSet1();
                SqlDataAdapter da = new SqlDataAdapter();
                con.Open();
                da.SelectCommand = new SqlCommand(sql, con);
                da.Fill(ds.Tables["dtSoldReport"]);
                con.Close();

                ReportParameter pDate = new ReportParameter("pDate", param);
                ReportParameter pCashier = new ReportParameter("pCashier", cashier);
                ReportParameter pHeader = new ReportParameter("pHeader", "Daily Sales Report");
                ReportParameter pStore = new ReportParameter("pStore", store);
                ReportParameter pAddress = new ReportParameter("pAddress", address);

                reportViewer1.LocalReport.SetParameters(pDate);
                reportViewer1.LocalReport.SetParameters(pCashier);
                reportViewer1.LocalReport.SetParameters(pHeader);
                reportViewer1.LocalReport.SetParameters(pStore);
                reportViewer1.LocalReport.SetParameters(pAddress);

                rptDS = new ReportDataSource("DataSet1", ds.Tables["dtSoldReport"]);
                reportViewer1.LocalReport.DataSources.Add(rptDS);
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
        public void LoadTopSell(string sql,string param,string header)
        {
            try
            {
                ReportDataSource rptDS;
                this.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reports\rptTopSell.rdlc";
                this.reportViewer1.LocalReport.DataSources.Clear();

                DataSet1 ds = new DataSet1();
                SqlDataAdapter da = new SqlDataAdapter();
                con.Open();
                da.SelectCommand = new SqlCommand(sql, con);
                da.Fill(ds.Tables["dtTopSell"]);
                con.Close();

                ReportParameter pDate = new ReportParameter("pDate", param);
                ReportParameter pHeader = new ReportParameter("pHeader", header);

                reportViewer1.LocalReport.SetParameters(pDate);
                reportViewer1.LocalReport.SetParameters(pHeader);
                rptDS = new ReportDataSource("DataSet1", ds.Tables["dtTopSell"]);
                reportViewer1.LocalReport.DataSources.Add(rptDS);
                reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 30;
            }
            catch(Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }
        public void LoadSoldItems(string sql, string param)
        {
            try
            {
                ReportDataSource rptDS;
                this.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reports\rptSoldItemst.rdlc";
                this.reportViewer1.LocalReport.DataSources.Clear();

                DataSet1 ds = new DataSet1();
                SqlDataAdapter da = new SqlDataAdapter();
                con.Open();
                da.SelectCommand = new SqlCommand(sql, con);
                da.Fill(ds.Tables["dtSoldItems"]);
                con.Close();

                ReportParameter pDate = new ReportParameter("pDate", param);
                
                reportViewer1.LocalReport.SetParameters(pDate);
                rptDS = new ReportDataSource("DataSet1", ds.Tables["dtSoldItems"]);
                reportViewer1.LocalReport.DataSources.Add(rptDS);
                reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }

        public void LoadInventory(string sql)
        {
            try
            {
                ReportDataSource rptDS;
                this.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reports\rptInventory.rdlc";
                this.reportViewer1.LocalReport.DataSources.Clear();

                DataSet1 ds = new DataSet1();
                SqlDataAdapter da = new SqlDataAdapter();
                con.Open();
                da.SelectCommand = new SqlCommand(sql, con);
                da.Fill(ds.Tables["dtInventory"]);
                con.Close();
                                                
                rptDS = new ReportDataSource("DataSet1", ds.Tables["dtInventory"]);
                reportViewer1.LocalReport.DataSources.Add(rptDS);
                reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }

        public void LoadCancelled(string sql,string param)
        {
            try
            {
                ReportDataSource rptDS;
                this.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reports\rptCancelled.rdlc";
                this.reportViewer1.LocalReport.DataSources.Clear();

                DataSet1 ds = new DataSet1();
                SqlDataAdapter da = new SqlDataAdapter();
                con.Open();
                da.SelectCommand = new SqlCommand(sql, con);
                da.Fill(ds.Tables["dtCancelOrder"]);
                con.Close();

                ReportParameter pDate = new ReportParameter("pDate", param);

                reportViewer1.LocalReport.SetParameters(pDate);
                rptDS = new ReportDataSource("DataSet1", ds.Tables["dtCancelOrder"]);
                reportViewer1.LocalReport.DataSources.Add(rptDS);
                reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }

        public void LoadStockInHistory(string sql, string param)
        {
            try
            {
                ReportDataSource rptDS;
                this.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reports\rptStockInHistory.rdlc";
                this.reportViewer1.LocalReport.DataSources.Clear();

                DataSet1 ds = new DataSet1();
                SqlDataAdapter da = new SqlDataAdapter();
                con.Open();
                da.SelectCommand = new SqlCommand(sql, con);
                da.Fill(ds.Tables["dtStockInHist"]);
                con.Close();

                ReportParameter pDate = new ReportParameter("pDate", param);

                reportViewer1.LocalReport.SetParameters(pDate);
                rptDS = new ReportDataSource("DataSet1", ds.Tables["dtStockInHist"]);
                reportViewer1.LocalReport.DataSources.Add(rptDS);
                reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void POSReport_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
        }
    }
}
