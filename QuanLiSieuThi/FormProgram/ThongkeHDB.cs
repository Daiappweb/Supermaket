using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiSieuThi.FormProgram
{
    public partial class frmThongke : Form
    {
        public frmThongke()
        {
            InitializeComponent();
        }


        private void btnProducts_Click(object sender, EventArgs e)
        {
            frmProducts products = new frmProducts();
            this.Hide();
            products.Show();
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            frmCategories categories = new frmCategories();
            this.Hide();
            categories.Show();
        }

        private void btnSellers_Click(object sender, EventArgs e)
        {
            frmSellers sellers = new frmSellers();
            this.Hide();
            sellers.Show();
        }

        private void lbExit_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void lbExot_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            this.Hide();
            login.Show();
        }
    }
}
