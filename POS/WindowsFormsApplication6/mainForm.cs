using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication6
{
    public partial class MainForm : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBconnect dbcon = new DBconnect();
        SqlDataReader dr;
        public string _pass;
        public MainForm()
        {
            InitializeComponent();
            customizeDesing();
            con = new SqlConnection(dbcon.mycon());
            
        }
        #region panelslide

        private void customizeDesing()
        {
            panelsubProduct.Visible = false;
            panelsubstock.Visible = false;
            panelsubrecord.Visible = false;
            panelsubsetting.Visible = false;
        }

        private void hidesubmenu()
        {
            if (panelsubProduct.Visible == true)
                panelsubProduct.Visible = false;
            if (panelsubstock.Visible == true)
                panelsubstock.Visible = false;
            if (panelsubrecord.Visible == true)
                panelsubrecord.Visible = false;
            if (panelsubsetting.Visible == true)
                panelsubsetting.Visible = false;
        }

        private void showeSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hidesubmenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }
        #endregion panelslide

        private Form activeForm = null;
        public void openchiledform(Form chilledfrom)
        {
            if (activeForm != null)
                activeForm.Close();
            chilledfrom.TopLevel = false;
            chilledfrom.FormBorderStyle = FormBorderStyle.None;
            chilledfrom.Dock = DockStyle.Fill;
            labeltitle.Text = chilledfrom.Text; ;
            panelmain.Controls.Add(chilledfrom);
            panelmain.Tag = chilledfrom;
            chilledfrom.BringToFront();
            chilledfrom.Show();
        }

        private void Dashboard_Click(object sender, EventArgs e)
        {
            openchiledform(new Dashbord());
            hidesubmenu();
        }

        private void product_Click(object sender, EventArgs e)
        {
            showeSubmenu(panelsubProduct);
        }

        private void productlist_Click(object sender, EventArgs e)
        {
            openchiledform(new Product());
            hidesubmenu();
        }

        private void category_Click(object sender, EventArgs e)
        {
            openchiledform(new Category());
            hidesubmenu();
        }

        private void brand_Click(object sender, EventArgs e)
        {
            openchiledform(new Brand());
            hidesubmenu();
        }

        private void instock_Click(object sender, EventArgs e)
        {
            showeSubmenu(panelsubstock);
        }

        private void stock_entry_Click(object sender, EventArgs e)
        {
            openchiledform(new StockIn(this));
            hidesubmenu();
        }

        private void stock_adjustment_Click(object sender, EventArgs e)
        {
            openchiledform(new Adjustments(this));
            hidesubmenu();
        }

        private void supplier_Click(object sender, EventArgs e)
        {
            openchiledform(new Supplier());
            hidesubmenu();
        }

        private void record_Click(object sender, EventArgs e)
        {
            showeSubmenu(panelsubrecord);
        }

        private void sale_history_Click(object sender, EventArgs e)
        {
           
            openchiledform(new DailySale(this));
            hidesubmenu();
        }

        private void pos_record_Click(object sender, EventArgs e)
        {
            openchiledform(new Record());
            hidesubmenu();
        }

        private void setting_Click(object sender, EventArgs e)
        {
            showeSubmenu(panelsubsetting);
        }

        private void user_Click(object sender, EventArgs e)
        {
            openchiledform(new UserAccount(this));
            hidesubmenu();
        }

        private void store_Click(object sender, EventArgs e)
        {
            hidesubmenu();
            Store store = new Store();
            store.ShowDialog();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Logout Application", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                Login login = new Login();
                login.ShowDialog();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            btnDashboard.PerformClick();
            Noti();
        }

        //Noti Alert For critical items
        public void Noti()
        {
            int i = 0;
            con.Open();
            cmd = new SqlCommand("SELECT * FROM vwCriticalItems", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                Alert alert = new Alert(this);
                alert.lblPcode.Text = dr["pcode"].ToString();
                alert.btnReorder.Enabled = true;
                alert.showAlert(i + ". " + dr["pdesc"].ToString() + " - " + dr["qty"].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void btnBarcode_Click(object sender, EventArgs e)
        {
            openchiledform(new Barcode());
            hidesubmenu();
        }
    }
}
