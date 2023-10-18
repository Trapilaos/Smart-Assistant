using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EksipnosVoithos
{
    public partial class EventForm : Form
    {
       
        public EventForm()
        {
            InitializeComponent();
        }

        private void EventForm_Load(object sender, EventArgs e)
        {
            label3.Text = UserControlDays.static_day + "/" + Calend.static_month + "/" + Calend.static_year;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string date = UserControlDays.static_day.ToString();
            string month = Calend.static_month.ToString();
            string year = Calend.static_year.ToString();
            showDialog("Προσθεσατε ενα Event για την ημερομηνια: "+ date + "/" + month + "/" + year);
        }
        private void showDialog(String message)
        {
            Notifications notification = new Notifications(message);
            notification.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.gym;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.walk;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.work;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.lessons;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.food;
        }
    }
}
