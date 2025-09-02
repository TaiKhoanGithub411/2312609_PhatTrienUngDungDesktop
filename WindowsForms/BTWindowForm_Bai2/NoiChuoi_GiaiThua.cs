using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTWindowForm_Bai2
{
    public class NoiChuoi_GiaiThua
    {
        public static void NoiChuoi(string h, string t, out string s)
        {
            if (string.IsNullOrEmpty(h) && string.IsNullOrEmpty(t))
                s = "";
            else if (string.IsNullOrEmpty(h))
                s = t;
            else if (string.IsNullOrEmpty(t))
                s = h;
            else
                s = h + " " + t;
        }
        public static long GiaiThuaDeQuy(int n)
        {
            if (n == 0 || n == 1)
                return 1;
            return n * GiaiThuaDeQuy(n - 1);
        }
    }
}
