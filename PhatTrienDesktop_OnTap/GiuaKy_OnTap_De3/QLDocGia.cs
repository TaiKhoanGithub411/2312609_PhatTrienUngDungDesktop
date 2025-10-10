using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Data;
using ExcelDataReader;

namespace GiuaKy_OnTap_De3
{
    public class QLDocGia
    {
        private readonly IDataSource _dataSource;
        public List<DocGia> DSDG { get; private set; }
        public QLDocGia(IDataSource dataSource)
        {
            _dataSource = dataSource;
            DSDG = _dataSource.GetDocGias();
        }
        public void Them(DocGia dg)
        {
            DSDG.Add(dg);
            _dataSource.Save(DSDG);
        }
        public void Xoa(DocGia dg)
        {
            DSDG.Remove(dg);
            _dataSource.Save(DSDG);
        }
        public DocGia TimTheoMa(string ma)
        {
            return DSDG.FirstOrDefault(dg => dg.MaDocGia.Equals(ma));
        }
        public List<DocGia> TimTheoTen(string ten)
        {
            return DSDG.Where(dg => dg.TenDocGia.ToLower().Contains(ten.ToLower())).ToList();
        }
        public List<DocGia> TimTheoSDT(string sdt)
        {
            return DSDG.Where(dg => dg.SDT.Contains(sdt)).ToList();
        }
        public void LuuDuLieu()
        {
            _dataSource.Save(DSDG);
        }
        public bool KiemTraTonTai(string maDocGia)
        {
            return DSDG.Exists(dg => dg.MaDocGia == maDocGia);
        }
        public void CapNhat(DocGia dg)
        {
            DocGia canSua = TimTheoMa(dg.MaDocGia);
            if (canSua != null)
            {
                canSua.TenDocGia = dg.TenDocGia;
                canSua.DiaChi = dg.DiaChi;
                canSua.SDT = dg.SDT;
            }
            LuuDuLieu();
        }
    }
}
