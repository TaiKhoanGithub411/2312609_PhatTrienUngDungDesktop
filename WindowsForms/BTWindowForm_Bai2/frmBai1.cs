using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTWindowForm_Bai2
{
    public partial class frmBai1 : Form
    {
        private ThietBi tb;
        public frmBai1()
        {
            InitializeComponent();
        }
        private void TaoDoiTuong()
        {
            tb = new ThietBi(
                int.Parse(txtMa.Text),
                txtTen.Text,
                txtNuoc.Text,
                int.Parse(txtDonGia.Text),
                int.Parse(txtSoLuong.Text));
        }
        private void btnTinh_Click(object sender, EventArgs e)
        {
            TaoDoiTuong();
            lblKQ.Text = $"Thành tiền: {tb.ThanhTien():N0} VNĐ";
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            TaoDoiTuong();
            lblKQ.Text = tb.HienThi();
        }
    }
}
