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
    public partial class Apdung2 : Form
    {
        // Danh sách password hợp lệ theo nhóm
        Dictionary<string, List<string>> passwords = new Dictionary<string, List<string>>()
        {
            { "Phát triển công nghệ", new List<string>{ "1496", "2673" } },
            { "Nghiên cứu viên", new List<string>{ "7462" } },
            { "Thiết kế mô hình", new List<string>{ "8884", "3842", "3383" } }
        };
        public Apdung2()
        {
            InitializeComponent();
        }

        private void Apdung2_Load(object sender, EventArgs e)
        {
            // Tạo cột cho DataGridView
            dgvLog.Columns.Add("colTime", "Ngày giờ");
            dgvLog.Columns.Add("colGroup", "Nhóm");
            dgvLog.Columns.Add("colResult", "Kết quả");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string input = txtPassword.Text.Trim();
            string groupName = "Không có";
            string result = "Từ chối!";

            foreach (var kvp in passwords)
            {
                if (kvp.Value.Contains(input))
                {
                    groupName = kvp.Key;
                    result = "Chấp nhận!";
                    break;
                }
            }

            // Ghi log vào DataGridView
            dgvLog.Rows.Add(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"), groupName, result);

            // Xóa mật khẩu sau khi Enter
            txtPassword.Clear();
        }

        private void btnRing_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Báo động! Có truy cập trái phép!", "Security Alert",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            txtPassword.Text += btn.Text;

        }
    }
}
