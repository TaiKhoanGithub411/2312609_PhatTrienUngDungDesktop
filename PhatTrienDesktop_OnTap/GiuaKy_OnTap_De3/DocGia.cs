using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiuaKy_OnTap_De3
{
    public class DocGia
    {
        public string MaDocGia { get; set; }
        public string TenDocGia { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
        public DocGia() { }
        public DocGia(string ma, string ten, string sdt, string diachi)
        {
            this.MaDocGia = ma;
            this.TenDocGia = ten;
            this.SDT = sdt;
            this.DiaChi = diachi;
        }
    }
}
