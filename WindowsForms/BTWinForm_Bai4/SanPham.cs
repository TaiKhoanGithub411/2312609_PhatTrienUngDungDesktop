using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTWinForm_Bai4
{
    public class SanPham
    {
        public string MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public string LoaiSanPham { get; set; }
        public DateTime NgaySanXuat { get; set; }
        public SanPham() 
        {

        }
        public int NamHetHan()
        {
            int namSX = NgaySanXuat.Year;
            int namHetHan = namSX + 3;
            return namHetHan;
        }
        public string HienThi()
        {
            return "Mã SP: " + MaSanPham + "\n"
                          + "Tên SP: " + TenSanPham + "\n"
                          + "Loại SP: " + LoaiSanPham + "\n"
                          + "Ngày SX: " + NgaySanXuat.ToString("dd/MM/yyyy") + "\n"
                          + "Năm hết hạn: " + NamHetHan();
        }

    }
}
