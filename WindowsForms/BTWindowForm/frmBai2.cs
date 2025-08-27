using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTWindowForm
{
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void cboTenHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            var stt = cboTenHang.SelectedIndex;
            switch(stt)
            {
                case 0:
                    txtDonGia.Text = "100000";
                    break;
                case 1:
                    txtDonGia.Text = "2000000";
                    break;
                case 2:
                    txtDonGia.Text = "150000";
                    break;
            }
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            int dongia = int.Parse(txtDonGia.Text);
            int sl = int.Parse(txtSoLuong.Text);
            double thanhtien = dongia * sl;
            if (rdChuyenKhoan.Checked)
                thanhtien = dongia * sl * 0.95;
            lblSoTien.Text = thanhtien.ToString();
        }
    }
}
