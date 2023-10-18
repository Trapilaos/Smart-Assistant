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
    public partial class HomeHelp : Form
    {
        bool on = true;
        public HomeHelp()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void HomeHelp_Load(object sender, EventArgs e)
        {
            button1.Text = "OFF";
            button2.Text = "OFF";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (on)
            {
                button1.Text = "ON";
                on = false;
                showDialog("ΑΝΟΙΞΑΤΕ ΤΑ ΦΩΤΑ!");
            }
            else
            {
                button1.Text = "OFF";
                on = true;
                showDialog("ΚΛΕΙΣΑΤΕ ΤΑ ΦΩΤΑ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (on)
            {
                button2.Text = "ON";
                on = false;
                showDialog("ΑΝΟΙΞΑΤΕ ΤΗ ΘΕΡΜΑΝΣΗ ");
            }
            else
            {
                button2.Text = "OFF";
                on = true;
                showDialog("ΚΛΕΙΣΑΤΕ ΤΗ ΘΕΡΜΑΝΣΗ");
            }
        }
        private void showDialog(String message)
        {
            Notifications notification = new Notifications(message);
            notification.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Main frm = new Main();
            frm.Show();
        }
    }
}
