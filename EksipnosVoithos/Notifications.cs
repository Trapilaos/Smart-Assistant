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
    public partial class Notifications : Form
    {
        public Notifications(String message)
        {
            InitializeComponent();
            lbMessage.Text = message;
        }

        private void Notifications_Load(object sender, EventArgs e)
        {
            timerClose.Start();
        }

        private void timerClose_Tick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
