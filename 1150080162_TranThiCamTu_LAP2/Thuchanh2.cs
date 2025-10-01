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
    public partial class Thuchanh2 : Form
    {
        public Thuchanh2()
        {
            InitializeComponent();
        }

        private void btnNhapSo_Click(object sender, EventArgs e)
        {
            int so;
            if (int.TryParse(txtNhapSo.Text.Trim(), out so))
            {
                lsbDaySo.Items.Add(so);
                txtNhapSo.Clear();
                txtNhapSo.Focus();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNhapSo.Focus();
            }
        }

        private void btnTangLen2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lsbDaySo.Items.Count; i++)
            {
                int so = int.Parse(lsbDaySo.Items[i].ToString());
                lsbDaySo.Items[i] = so + 2;
            }
        }

        private void btnChonChanDau_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lsbDaySo.Items.Count; i++)
            {
                int so = int.Parse(lsbDaySo.Items[i].ToString());
                if (so % 2 == 0)
                {
                    lsbDaySo.SelectedIndex = i;
                    return;
                }
            }
            MessageBox.Show("Không có số chẵn nào!", "Thông báo");
        }

        private void btnChonLeCuoi_Click(object sender, EventArgs e)
        {
            for (int i = lsbDaySo.Items.Count - 1; i >= 0; i--)
            {
                int so = int.Parse(lsbDaySo.Items[i].ToString());
                if (so % 2 != 0)
                {
                    lsbDaySo.SelectedIndex = i;
                    return;
                }
            }
            MessageBox.Show("Không có số lẻ nào!", "Thông báo");
        }

        private void btnXoaDangChon_Click(object sender, EventArgs e)
        {
            while (lsbDaySo.SelectedItems.Count > 0)
            {
                lsbDaySo.Items.Remove(lsbDaySo.SelectedItem);
            }
        }

        private void btnXoaDau_Click(object sender, EventArgs e)
        {
            if (lsbDaySo.Items.Count > 0)
                lsbDaySo.Items.RemoveAt(0);
        }

        private void btnXoaCuoi_Click(object sender, EventArgs e)
        {
            if (lsbDaySo.Items.Count > 0)
                lsbDaySo.Items.RemoveAt(lsbDaySo.Items.Count - 1);
        }

        private void btnXoaDaySo_Click(object sender, EventArgs e)
        {
            lsbDaySo.Items.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
