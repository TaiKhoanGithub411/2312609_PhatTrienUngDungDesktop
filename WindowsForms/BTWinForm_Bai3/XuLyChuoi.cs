using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTWinForm_Bai3
{
    public class XuLyChuoi
    {
        public void TachChuoi(string hoten, out string s1, out string s2)
        {
            // Loại bỏ khoảng trắng thừa
            hoten = hoten.Trim();
            // Tìm vị trí khoảng trắng cuối cùng
            int viTriCuoi = hoten.LastIndexOf(' ');
            if (viTriCuoi != -1)
            {
                s1 = hoten.Substring(0, viTriCuoi).Trim(); // Họ
                s2 = hoten.Substring(viTriCuoi + 1).Trim(); // Tên
            }
            else
            {
                s1 = ""; // Không có họ
                s2 = hoten; // Chỉ có tên
            }
        }
        public bool ThuTu(int n1, int n2)
        {
            return (n2 == n1 + 1);
        }
    }
}
