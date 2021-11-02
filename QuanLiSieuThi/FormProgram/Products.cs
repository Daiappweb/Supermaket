using QuanLiSieuThi.FormProgram;
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
    public partial class frmProducts : Form
    {
        public frmProducts()
        {
            InitializeComponent();
        }

        private void btnSellers_MouseHover(object sender, EventArgs e)
        {
            this.ForeColor = Color.Yellow;
        }

        private void lbExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void lbExit_MouseHover(object sender, EventArgs e)
        {
            lbExit.ForeColor = Color.FromArgb(246, 64, 45);
        }

        private void lbExit_MouseLeave(object sender, EventArgs e)
        {
            lbExit.ForeColor = Color.DarkOrange;
        }

        private void btnSellers_Click(object sender, EventArgs e)
        {
            frmSellers sellers = new frmSellers();
            this.Hide();
            sellers.Show();
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            frmCategories categories = new frmCategories();
            this.Hide();
            categories.Show();
        }

        private void lbLogout_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            this.Hide();
            login.Show();
        }

        private void btnStatistical_Click(object sender, EventArgs e)
        {
            frmThongke thongke = new frmThongke();
            this.Hide();
            thongke.Show();
        }
    }
}
