using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    class DBconnect
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        private string connection;
        public string mycon()
        {
            connection = @"Data Source=DESKTOP-Q7MK7VS;Initial Catalog=supermarket;Integrated Security=True";
            return connection;
        }
        public DataTable gettable(string query)
        {
            con.ConnectionString = mycon();
            cmd = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table; ;
        }
        public void ExecuteQuery(string sql)
        {
            try
            {
                con.ConnectionString = mycon();
                con.Open();
                cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        public String getPassword(string username)
        {
            string Password = "";

            con.ConnectionString = mycon();
            con.Open();
            cmd = new SqlCommand("select password from tbuser where Username='"+username+"'", con);
            dr=cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                Password = dr["password"].ToString();
            }
            dr.Close();
            con.Close();
            return Password;
        }
        public double ExtractData(string sql)
        {

            con = new SqlConnection();
            con.ConnectionString = mycon();
            con.Open();
            cmd = new SqlCommand(sql, con);
            double data = double.Parse(cmd.ExecuteScalar().ToString());
            con.Close();
            return data;

        }
    }
}
