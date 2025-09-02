using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTWinForm_Bai4
{
    public partial class frmBai1 : Form
    {
        private SanPham sp = new SanPham();
        public frmBai1()
        {
            InitializeComponent();
        }
        private void CreateSanPhamFromInput()
        {
            sp.MaSanPham = txtMa.Text;
            sp.TenSanPham = txtTen.Text;
            sp.LoaiSanPham = txtLoai.Text;
            sp.NgaySanXuat = dtpNgaySX.Value.Date;
        }
        private void btnTinhHSD_Click(object sender, EventArgs e)
        {
            CreateSanPhamFromInput();
            lblKQ.Text = $"Năm hết hạn: {sp.NamHetHan()}";
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            CreateSanPhamFromInput();
            lblKQ.Text = sp.HienThi();
        }
    }
}
