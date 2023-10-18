using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EksipnosVoithos
{
    public partial class Feeder : Form
    {
        public static Feeder instance;
        public Feeder()
        {
            InitializeComponent();
            instance = this;
        }

        private void Feeder_Load(object sender, EventArgs e)
        {
            //Mpara Faghtou
            circularProgressBar1.Value = 68;
            circularProgressBar1.Minimum = 0;
            circularProgressBar1.Maximum = 100;
            //Mpara Nerou 
            circularProgressBar2.Value = 10;
            circularProgressBar2.Minimum = 0;
            circularProgressBar2.Maximum = 100;

            Random rnd = new Random();
            int not = rnd.Next(1, 4);
            
            if (not == 1)
            {
                showDialog( "Ο σκύλος έχει πετάξει το φαγητό του!");
            }
            else if (not == 2)
            {
                showDialog( "Έφαγε το φαγητό του!");
            }
            else if (not == 3)
            {
                showDialog("Ήπιε το νερό του !");
            }
            else if (not == 4)
            {

                showDialog( "Έριξε το φαγητό του !");
            }
        }
        //KOUMPI PREVIOUS
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Main frm = new Main();
            frm.Show();
        }
        //KOUMPI FAGHTOU
        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want this amount;", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //nothing
            }
            for (int i = 1; i <= 100; i++)
            {
                Thread.Sleep(5);
                circularProgressBar1.Value = i;
                circularProgressBar1.Update();

            }
        }
        //KOUMPI NEROU
        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 100; i++)
            {
                Thread.Sleep(5);
                circularProgressBar1.Value = i;
                circularProgressBar1.Update();
            }
            MessageBox.Show("Successful!");
        }
        private void showDialog(String message)
        {
            Notifications notification = new Notifications(message);
            notification.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
