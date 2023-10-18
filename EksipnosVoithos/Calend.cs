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

namespace EksipnosVoithos
{
    public partial class Calend : Form
    {
        int month, year;
        public static int static_month , static_year;

        public Calend()
        {
            InitializeComponent();
        }

        private void Calend_Load(object sender, EventArgs e)
        {
            displayDays();
        }
        private void daycontainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();
            month--;
            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = monthname + " " + year;
            static_month = month;
            static_year = year;
            //First day of the month
            DateTime startofthemonth = new DateTime(year, month, 1);
            //count the days of the month
            int days = DateTime.DaysInMonth(year, month);
            //convert the startofthemonth to integer
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }
            //Create UserControl for days
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Main frm = new Main();
            frm.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //Clear Container
            daycontainer.Controls.Clear();
            month++;
            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = monthname + " " + year;
            static_month = month;
            static_year = year;
            //First day of the month
            DateTime startofthemonth = new DateTime(year, month, 1);
            //count the days of the month
            int days = DateTime.DaysInMonth(year, month);
            //convert the startofthemonth to integer
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }
            //Create UserControl for days
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }

        private void displayDays()
        {

            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;
            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = monthname + " " + year;
            static_month = month;
            static_year = year;
            //First day of the month
            DateTime startofthemonth = new DateTime(year, month, 1);
            //count the days of the month
            int days = DateTime.DaysInMonth(year, month);
            //convert the startofthemonth to integer
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }
            //Create UserControl for days
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }
    }
}
