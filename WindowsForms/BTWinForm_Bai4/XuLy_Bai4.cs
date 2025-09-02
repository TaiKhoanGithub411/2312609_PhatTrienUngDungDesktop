using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTWinForm_Bai4
{
    public class XuLy_Bai4
    {
        public static void ChaoHoi(string hoTen, bool gioiTinhNam)
        {
            string danhXung = gioiTinhNam ? "Ông " : "Bà ";
            MessageBox.Show($"Chào {danhXung}{hoTen}",
                            "Chào hỏi",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }
        public static int USCLN(int m, int n)
        {
            while (n != 0)
            {
                int r = m % n;
                m = n;
                n = r;
            }
            return Math.Abs(m);
        }
    }
}
