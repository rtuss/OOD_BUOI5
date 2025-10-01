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
    public partial class Apdung4 : Form
    {
        public Apdung4()
        {
            InitializeComponent();
        }

        private void btnChuyen1_Click(object sender, EventArgs e)
        {
            if (lstMatHang.SelectedItem != null)
            {
                lstDaChon.Items.Add(lstMatHang.SelectedItem);
                lstMatHang.Items.Remove(lstMatHang.SelectedItem);
            }
        }

        private void lstDaChon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnChuyenHet1_Click(object sender, EventArgs e)
        {
            foreach (var item in lstMatHang.Items)
            {
                lstDaChon.Items.Add(item);
            }
            lstMatHang.Items.Clear();
        }

        private void btnChuyen1Nguoc_Click(object sender, EventArgs e)
        {
            if (lstDaChon.SelectedItem != null)
            {
                lstMatHang.Items.Add(lstDaChon.SelectedItem);
                lstDaChon.Items.Remove(lstDaChon.SelectedItem);
            }
        }

        private void btnChuyenHet1Nguoc_Click(object sender, EventArgs e)
        {
            foreach (var item in lstDaChon.Items)
            {
                lstMatHang.Items.Add(item);
            }
            lstDaChon.Items.Clear();
        }
    }
}
