using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1150080162_TranThiCamTu_LAP2
{
    public partial class ApDung1Form : Form
    {
        public ApDung1Form()
        {
            InitializeComponent();
            txtKetQua.ReadOnly = true; // Kết quả chỉ hiển thị, không nhập
            rdoUSCLN.Checked = true;   // Mặc định chọn USCLN
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(txtA.Text.Trim());
                int b = int.Parse(txtB.Text.Trim());

                int uscln = Gcd(Math.Abs(a), Math.Abs(b));
                long bcnn = (uscln == 0) ? 0 : (long)Math.Abs((long)a * b) / uscln;

                if (rdoUSCLN.Checked)
                {
                    txtKetQua.Text = uscln.ToString();
                }
                else if (rdoBCNN.Checked)
                {
                    txtKetQua.Text = bcnn.ToString();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn USCLN hoặc BCNN!",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dữ liệu nhập không hợp lệ!\n" + ex.Message,
                                "Lỗi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
        


        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Hàm tính USCLN (Euclid)
        private int Gcd(int x, int y)
        {
            while (y != 0)
            {
                int r = x % y;
                x = y;
                y = r;
            }
            return x;
        }
    }
}
