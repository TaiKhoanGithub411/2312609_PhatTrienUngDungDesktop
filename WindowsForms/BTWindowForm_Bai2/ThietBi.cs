using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTWindowForm_Bai2
{
    public class ThietBi
    {
        public int MaThietBi { get; set; }
        public string TenThietBi { get; set; }
        public string NuocSanXuat { get; set; }
        public int DonGia { get; set; }
        public int SoLuong { get; set; }
        public ThietBi(int ma, string ten, string sx, int dongia, int sl)
        {
            this.MaThietBi = ma;
            this.TenThietBi = ten;
            this.NuocSanXuat = sx;
            this.SoLuong = sl;
            this.DonGia = dongia;
        }
        public int ThanhTien()
        {
            return DonGia * SoLuong;
        }
        public string HienThi()
        {
            return string.Format($"Mã thiết bị: {MaThietBi}, Tên thiết bị: {TenThietBi}, Nước sản xuất: {NuocSanXuat}, " +
                $"\nSố lượng: {SoLuong}, Đơn giá: {DonGia}");
        }
    }
}
