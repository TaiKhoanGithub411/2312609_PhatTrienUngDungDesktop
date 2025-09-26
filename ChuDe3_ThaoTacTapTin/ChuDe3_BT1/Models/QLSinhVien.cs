using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ChuDe3_BT1
{
    public class QLSinhVien
    {
        private IDataSource _dataSource;
        public List<SinhVien> DSSV { get; private set; }

        public QLSinhVien(IDataSource dataSource)
        {
            _dataSource = dataSource;
            DSSV = _dataSource.GetSinhViens();
        }
        public void Them(SinhVien sv)
        {
            DSSV.Add(sv);
            _dataSource.Save(DSSV);
        }
        public void CapNhat(SinhVien sv)
        {
            var index = DSSV.FindIndex(s => s.MSSV == sv.MSSV);//tìm vị trí sinh viên có MSSV cần cấp nhật trong DSSV (không có thì trả về -1)
            if(index!=-1)
            {
                DSSV[index] = sv;
                _dataSource.Save(DSSV);
            }
        }
        public void LuuDuLieu()
        {
            _dataSource.Save(DSSV);
        }
        public void Xoa(List<string> mssvList) //list mssv vì có thể áp dụng cho xóa nhiều sinh viên
        {
            DSSV.RemoveAll(sv => mssvList.Contains(sv.MSSV));//Xóa tất cả sinh viên có mssv có trong list được truyền vào
            _dataSource.Save(DSSV);
        }
        public SinhVien this[int index]
        {
            get { return DSSV[index]; }
            set { DSSV[index] = value; }
        }
        public List<SinhVien> TimKiem(string mssv, string ten, string lop)
        {
            mssv = mssv?.ToLower() ?? "";
            ten = ten?.ToLower() ?? "";
            lop = lop?.ToLower() ?? "";
            return DSSV.Where(sv =>
            (string.IsNullOrEmpty(mssv) || (sv.MSSV != null && sv.MSSV.ToLower().Contains(mssv))) &&
            (string.IsNullOrEmpty(ten) || (sv.Ten != null && sv.Ten.ToLower().Contains(ten))) &&
            (string.IsNullOrEmpty(lop) || (sv.Lop != null && sv.Lop.ToLower().Contains(lop)))
            ).ToList();
        }
        public bool KiemTraTonTai(string mssv)
        {
            return DSSV.Exists(sv => sv.MSSV == mssv);//Có tồn tại sinh viên hay không
        }
    }
}
