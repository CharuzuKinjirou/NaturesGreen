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

namespace Nature_s_Green
{
    public partial class CalendarEventFrm : Form
    {
        Function fn = new Function();
        String query;


        public CalendarEventFrm()
        {
            InitializeComponent();


        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\CalendarDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void CalendarEventFrm_Load(object sender, EventArgs e)
        {
            txtdate.Text = MainAppDB.static_month + "/" + UC_CalendarDays.static_day + "/" + MainAppDB.static_year;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (txtdate.Text == "" || txtevent.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into EventTbl values('" + txtdate.Text + "', '" + txtevent.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Event Saved Successfully");
                    Con.Close();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }

    }
}
