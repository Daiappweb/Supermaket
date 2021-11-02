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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void lbExit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát chương trình không?","Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
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
            lbExit.ForeColor = Color.White;
        }

        private void btnLogin_MouseHover(object sender, EventArgs e)
        {
            btnLogin.BackColor= Color.FromArgb(246, 64, 45);
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.BackColor= Color.White;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (cbLoaiTaiKhoan.SelectedIndex == 0)
            {
                frmProducts products = new frmProducts();
                this.Hide();
                products.Show();
            }
            else if (cbLoaiTaiKhoan.SelectedIndex == 1)
            {
                frmSelling selling = new frmSelling();
                this.Hide();
                selling.Show();
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn loại tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {
            txtUser.Text = "";
            txtPassword.Text = "";
            cbLoaiTaiKhoan.SelectedIndex = -1;
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Red;

        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor=Color.DarkOrange;
        }
    }
}
