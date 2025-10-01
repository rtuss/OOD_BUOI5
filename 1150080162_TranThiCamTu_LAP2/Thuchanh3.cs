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
    public partial class Thuchanh3 : Form
    {
        public Thuchanh3()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.EnableAllowFocusChange;
            txtThanhTien.ReadOnly = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            double thanhTien = 0;
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (chkLayCaoRang.Checked)
                    thanhTien += 50000;
                if (chkTayTrangRang.Checked)
                    thanhTien += 100000;
                if (chkHanRang.Checked)
                    thanhTien += (int)nupHanRang.Value * 100000;
                if (chkBeRang.Checked)
                    thanhTien += (int)nupBeRang.Value * 10000;
                if (chkBocRang.Checked)
                    thanhTien += (int)nupBocRang.Value * 1000000;

                txtThanhTien.Text = thanhTien.ToString("N0"); // N0 = định dạng số có dấu phẩy
            }
        }

        private void txtTenKH_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenKH.Text))
            {
                e.Cancel = true;                         // chặn rời ô khi sai
                err.SetError(txtTenKH, "Dữ liệu không được để trống!");
            }
            else
            {
                e.Cancel = false;
                err.SetError(txtTenKH, null);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
