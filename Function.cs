using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Nature_s_Green
{
   class Function
    {

        protected SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection
            {
                ConnectionString = "data source = DESKTOP-9VINEHP;database = NaturesGreen; integrated security = True"
            };
            return con;
        }

        public DataSet GetData(String query)
        {
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand
            {
                Connection = con,
                CommandText = query
            };
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public void SetData(String query)
        {
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand
            {
                Connection = con
            };
            con.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Data Processed successfuly.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
