using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTWindowForm_Bai3
{
    public class NhanVien
    {
        public string MaNV { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public double HeSoLuong { get; set; }
        public double HeSoPhuCap { get; set; }
        public NhanVien()
        {
            NgaySinh = DateTime.Now;
            HeSoLuong = 0;
            HeSoPhuCap = 0;
        }
        public NhanVien(string maNV, string hoTen, DateTime ngaySinh, double heSoLuong, double heSoPhuCap)
        {
            this.MaNV = maNV;
            this.HoTen = hoTen;
            this.NgaySinh = ngaySinh;
            this.HeSoLuong = heSoLuong;
            this.HeSoPhuCap = heSoPhuCap;
        }
        public double TongLuong()
        {
            return (HeSoLuong + HeSoPhuCap) * 1150000;
        }
        public string HienThi()
        {
            return $"Mã NV: {MaNV}\n" +
               $"Họ tên: {HoTen}\n" +
               $"Ngày sinh: {NgaySinh.ToString("dd/MM/yyyy")}\n" +
               $"Hệ số lương: {HeSoLuong}\n" +
               $"Hệ số phụ cấp: {HeSoPhuCap}\n" +
               $"Tổng lương: {TongLuong():N0} VNĐ";
        }
    }
}
