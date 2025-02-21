using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Nature_s_Green
{
    public partial class UC_CalendarDays : UserControl
    {
        String connstring = "data source = DESKTOP-9VINEHP;database = NaturesGreen; integrated security = True";

        public static string static_day;

     

        public UC_CalendarDays()
        {
            InitializeComponent();
        }

        private void UC_CalendarDays_Load(object sender, EventArgs e)
        {

        }

        public void days(int numday)
        {
            LblDays.Text = numday + "";
        }

        private void UC_CalendarDays_Click(object sender, EventArgs e)
        {
            static_day = LblDays.Text;
        
            CalendarEventFrm eventfrm = new CalendarEventFrm();
            eventfrm.Show();
        }

        private void DisplayEvent()
        {
          SqlConnection con = new SqlConnection(connstring);
            con.Open();
            String sql = "Select * From calendar_event where date = ?";
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("date", MainAppDB.static_year + "-" + MainAppDB.static_month + "-" + LblDays.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                LblEvent.Text = dr["Event"].ToString();
            }
            dr.Dispose();
            cmd.Dispose();
            con.Close();

        }

      
    }
}
