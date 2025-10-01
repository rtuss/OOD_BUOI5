using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1150080162_TranThiCamTu_LAP2
{
    public partial class Apdung3dangnhap : Form
    {

        public Apdung3dangnhap()
        {
            InitializeComponent();
            // cấu hình cơ bản
            txtUser.MaxLength = 50;
            txtPass.MaxLength = 50;
            txtPass.UseSystemPasswordChar = true;

            // sự kiện
            chkShowPass.CheckedChanged += (s, e) =>
            {
                txtPass.UseSystemPasswordChar = !chkShowPass.Checked;
            };
            btnLogin.Click += btnLogin_Click;
            btnExit.Click += (s, e) => this.Close();

            // optional: font to hơn xíu cho dễ đọc
            txtUser.Font = txtPass.Font = new Font("Segoe UI", 11f);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtUser, "");
            errorProvider1.SetError(txtPass, "");

            bool hasError = false;

            if (string.IsNullOrWhiteSpace(txtUser.Text))
            {
                errorProvider1.SetError(txtUser, "Vui lòng nhập username");
                hasError = true;
            }
            if (string.IsNullOrWhiteSpace(txtPass.Text))
            {
                errorProvider1.SetError(txtPass, "Vui lòng nhập password");
                hasError = true;
            }

            if (hasError) return;

            // Thiết lập tài khoản chuẩn trong code
            string correctUser = "Camtu";
            string correctPass = "123456";

            if (txtUser.Text == correctUser && txtPass.Text == correctPass)
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Sai username hoặc password!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPass.SelectAll();
                txtPass.Focus();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
