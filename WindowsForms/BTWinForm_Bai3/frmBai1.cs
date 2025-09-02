using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTWinForm_Bai3
{
    public partial class frmBai1 : Form
    {
        private NhanVien nhanVien;
        public frmBai1()
        {
            InitializeComponent();
        }
        private void CreateNhanVienFromInput()
        {
            // Lấy dữ liệu giao diện
            string maNV = txtMaNV.Text.Trim();
            string hoTen = txtHoTen.Text.Trim();
            DateTime ngaySinh = dtpNgaySinh.Value.Date;
            double heSoLuong = double.Parse(txtHSLuong.Text);
            double heSoPhuCap = double.Parse(txtHSPhuCap.Text);

            // Khởi tạo/ghi đè đối tượng
            nhanVien = new NhanVien(maNV, hoTen, ngaySinh, heSoLuong, heSoPhuCap);
        }
        private void btnTinhLuong_Click(object sender, EventArgs e)
        {
            CreateNhanVienFromInput();
            lblKetQua.Text= $"Tổng lương: {nhanVien.TongLuong():N0} VNĐ";
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            CreateNhanVienFromInput();
            lblKetQua.Text = nhanVien.HienThi();
        }
    }
}
