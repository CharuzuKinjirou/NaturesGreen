using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nature_s_Green
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        int startpos = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            startpos += 1;
            Myprogess.Value = startpos;
            PercentageLbl.Text = startpos + "%";
            if (Myprogess.Value == 100)
            {
                Myprogess.Value = 0;
                timer1.Stop();
                frmLogin log = new frmLogin();
                log.Show();
                this.Hide();
            }
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
