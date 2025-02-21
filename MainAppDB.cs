using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nature_s_Green
{
    public partial class MainAppDB : Form
    {
        int month, year;
        public MainAppDB()
        {
            InitializeComponent();
            CustomizeDesign();
            DisplayDays();

        }

        // Hiding and unhiding the side buttons
        private void CustomizeDesign()
        {
            PlantsSubPnl.Visible = false;
            PersonalizationPnl.Visible = false;
        }

        private void HideSubMenu()
        {
            if (PlantsSubPnl.Visible == true)
                PlantsSubPnl.Visible = false;
            if (PersonalizationPnl.Visible == true)
                PersonalizationPnl.Visible = false;
        }

        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;

            }
            else
                subMenu.Visible = false;
        }

        //Side Panel buttons
        private void PlantsBtn_Click(object sender, EventArgs e)
        {
            uC_Pictures1.Visible = true;
            uC_Pictures1.BringToFront();
            ShowSubMenu(PlantsSubPnl);
        }

        private void PicturesBtn_Click(object sender, EventArgs e)
        {
            PlantListMenustrip.Visible = true;

            uC_Pictures1.Visible = true;
            uC_Pictures1.BringToFront();

            HideSubMenu();
        }

        private void PersonalizationBtn_Click(object sender, EventArgs e)
        {
            PersonalizatinPnl.Visible = true;
            PersonalizatinPnl.BringToFront();
            PlantListMenustrip.Visible = false;
            CalendarPnl.Visible = false;
            //gallarypannel.Visible = false;
           // gallarylist1.Visible = false;
           // gallary12.Visible = false;
            ShowSubMenu(PersonalizationPnl);
        }

        private void GalleryBtn_Click(object sender, EventArgs e)
        {

            HideSubMenu();
        }

        private void NotesBtn_Click(object sender, EventArgs e)
        {

            HideSubMenu();
        }

        private void CalendarBtn_Click(object sender, EventArgs e)
        {
            PlantListMenustrip.Visible = false;
            CalendarPnl.Visible = true;
            CalendarPnl.BringToFront();

            HideSubMenu();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            frmLogin Flg = new frmLogin();
            Flg.Show();
            this.Hide();
        }

        private void AppLogo_Click(object sender, EventArgs e)
        {
            PlantListMenustrip.Visible = false;
            mainFeatureBG.Visible = true;
            mainFeatureBG.BringToFront();
            HideSubMenu();
        }

        //For smooth loading of the Dashboard
        private void MainAppDB_Load(object sender, EventArgs e)
        {
            PlantListMenustrip.Visible = false;
            uC_Aglaonema1.Visible = false;
            uC_AloeVera1.Visible = false;
            uC_Azalae1.Visible = false;
            uC_Cactus1.Visible = false;
            uC_DwarfUmbrella1.Visible = false;
            uC_EnglishIvy1.Visible = false;
            uC_GerberaDaisy1.Visible = false;
            uC_JadePlant1.Visible = false;
            uC_LuckyBamboo1.Visible = false;
            uC_Marginata1.Visible = false;
            uC_Pachira1.Visible = false;
            uC_PeaceLily1.Visible = false;
            uC_PothosMarbleQueen1.Visible = false;
            uC_SnakePlant1.Visible = false;
            uC_SpiderPlant1.Visible = false;
            uC_Zamioculas1.Visible = false;
            uC_Pictures1.Visible = false;
            //gallarypannel.Visible = false;
           // gallarylist1.Visible = false;
          //  gallary11.Visible = false;
            mainFeatureBG.Visible = true;
        
            mainFeatureBG.BringToFront();
            
        }

        //Menustrip button clicks
        private void cactusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uC_Cactus1.Visible = true;
            uC_Cactus1.BringToFront();
        }

        private void alzaeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uC_Azalae1.Visible = true;
            uC_Azalae1.BringToFront();
        }

        private void jadePlantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uC_JadePlant1.Visible = true;
            uC_JadePlant1.BringToFront();
        }

        private void englishIvyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uC_EnglishIvy1.Visible = true;
            uC_EnglishIvy1.BringToFront();
        }

        private void dwarfUmbrellaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uC_DwarfUmbrella1.Visible = true;
            uC_DwarfUmbrella1.BringToFront();
        }

        private void spiderPlantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uC_SpiderPlant1.Visible = true;
            uC_SpiderPlant1.BringToFront();

        }

        private void aloeVeraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uC_AloeVera1.Visible = true;
            uC_AloeVera1.BringToFront();
        }

        private void marginataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uC_Marginata1.Visible = true;
            uC_Marginata1.BringToFront();
        }

        private void snakePlantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uC_SnakePlant1.Visible = true;
            uC_SnakePlant1.BringToFront();

        }

        private void zamioculasZamifoliaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uC_Zamioculas1.Visible = true;
            uC_Zamioculas1.BringToFront();
        }

        private void pachiraMoneyTreeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uC_Pachira1.Visible = true;
            uC_Pachira1.BringToFront();
        }

        private void luckyBambooToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uC_LuckyBamboo1.Visible = true;
            uC_LuckyBamboo1.BringToFront();
        }

        private void aglaonemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uC_Aglaonema1.Visible = true;
            uC_Aglaonema1.BringToFront();
        }

        private void peaceLilyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uC_PeaceLily1.Visible = true;
            uC_PeaceLily1.BringToFront();
        }

        private void pothosMarbleQueenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uC_PothosMarbleQueen1.Visible = true;
            uC_PothosMarbleQueen1.BringToFront();
        }

        private void gerberaDaisyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uC_GerberaDaisy1.Visible = true;
            uC_GerberaDaisy1.BringToFront();
        }
        //End of Menustrip button clicks

        //Displaying Calendar

        public static int static_month, static_year;

        private void DisplayDays()
        {
            DateTime now = DateTime.Now;
            //getting first day of the month

            month = now.Month;
            year = now.Year;


            static_month = month;
            static_year = year;


            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LblDate.Text = monthname + " " + year;
                
            DateTime startofthemonth = new DateTime(year, month, 1);
            //counting days of the month

            int days = DateTime.DaysInMonth(year, month);
            //converting startofthemonth to integer

            int dayofweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            //blank user control for the prev days of the month
            for(int i = 1;  i < dayofweek; i++)
            {
                UC_CalendarControlBlank ucblank = new UC_CalendarControlBlank();
                CalendarDaysContainer.Controls.Add(ucblank);
            }

            //control for days input
            for(int i = 1; i < days; i++)
            {
                UC_CalendarDays ucdays = new UC_CalendarDays();
                ucdays.days(i);
                CalendarDaysContainer.Controls.Add(ucdays);

            }
        }

       

        private void Gallarybtn_Click_1(object sender, EventArgs e)
        {
            //PlantListMenustrip.Visible = false;
          //  gallarylist1.Visible = true;
          // gallarylist1.BringToFront();

           // gallary11.Visible = true;
        //    gallary11.BringToFront(); 
            HideSubMenu();

         //   gallary12.Visible=true;
         //   gallary12.Show();
            //gallarypannel.Visible = true;
            //gallarypannel.BringToFront();

           // PlantListMenustrip.Visible = false;

           // HideSubMenu();
        }

        private void gallarylist1_Load(object sender, EventArgs e)
        {

        }

        private void CalendarDaysContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            gallarylist1.Visible = true;
            gallarylist1.BringToFront();

            // gallary11.Visible = true;
            //    gallary11.BringToFront(); 
            HideSubMenu();

            //   gallary12.Visible=true;
            //   gallary12.Show();
            //gallarypannel.Visible = true;
            //gallarypannel.BringToFront();

            PlantListMenustrip.Visible = false;

            HideSubMenu();
        }

        private void PreviousBtn_Click(object sender, EventArgs e)
        {
            CalendarDaysContainer.Controls.Clear();//clear previous month

            month--;
            //decrement month

            static_month = month;
            static_year = year;

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LblDate.Text = monthname + " " + year;

            DateTime startofthemonth = new DateTime(year, month, 1);
            //counting days of the month

            int days = DateTime.DaysInMonth(year, month);
            //converting startofthemonth to integer

            int dayofweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            //blank user control for the prev days of the month
            for (int i = 1; i < dayofweek; i++)
            {
                UC_CalendarControlBlank ucblank = new UC_CalendarControlBlank();
                CalendarDaysContainer.Controls.Add(ucblank);
            }

            //control for days input
            for (int i = 1; i < days; i++)
            {
                UC_CalendarDays ucdays = new UC_CalendarDays();
                ucdays.days(i);
                CalendarDaysContainer.Controls.Add(ucdays);

            }
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            CalendarDaysContainer.Controls.Clear();//clear previous month

            month++;
            //increment month

            static_month = month;
            static_year = year;

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LblDate.Text = monthname + " " + year;

            DateTime startofthemonth = new DateTime(year, month, 1);
            //counting days of the month

            int days = DateTime.DaysInMonth(year, month);
            //converting startofthemonth to integer

            int dayofweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            //blank user control for the prev days of the month
            for (int i = 1; i < dayofweek; i++)
            {
                UC_CalendarControlBlank ucblank = new UC_CalendarControlBlank();
                CalendarDaysContainer.Controls.Add(ucblank);
            }

            //control for days input
            for (int i = 1; i < days; i++)
            {
                UC_CalendarDays ucdays = new UC_CalendarDays();
                ucdays.days(i);
                CalendarDaysContainer.Controls.Add(ucdays);

            }
        }








    }
}
