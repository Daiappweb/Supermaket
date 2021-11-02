using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiSieuThi
{
    public partial class Input : Form
    {
        public Input()
        {
            InitializeComponent();
        }

        int startpoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            prbLoad.Value = startpoint;
            if (prbLoad.Value == 100)
            {
                prbLoad.Value = 0;
                timer1.Stop();
                frmLogin log = new frmLogin();
                this.Hide();
                log.Show();
            }
        }

        private void Input_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
