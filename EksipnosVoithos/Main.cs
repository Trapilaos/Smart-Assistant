using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace EksipnosVoithos
{
    public partial class Main : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        public static Main instance;
        public Main()
        {
            InitializeComponent();
            instance = this;
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
        private void feedbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Feeder form = new Feeder();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PopupNotifier popup = new PopupNotifier();
            popup.TitleText = "Need water!";
            popup.ContentText = "Thank ";
            popup.Popup();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Exit application", "You want to exit from application ;", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (DialogResult == DialogResult.No)
            {
                //nothing
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Calend cal = new Calend();
            cal.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeHelp home = new HomeHelp();
            home.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Feeder form = new Feeder();
            form.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void userManualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "file://D:\\PapeiProjects\\MetaXeniaHelp.chm");
        }
    }
}
