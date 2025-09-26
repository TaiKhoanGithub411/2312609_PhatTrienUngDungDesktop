using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ChuDe3_BT1
{
    public class SinhVien
    {
        public string MSSV { get; set; }
        public string HoTenLot {  get; set; }
        public string Ten {  get; set; }
        [XmlIgnore]
        public bool GioiTinh { get; set; }
        //Bảo XmlSerializer bỏ qua thuộc tính DateTime thật
        [XmlIgnore]
        public DateTime NgaySinh { get; set; }
        public string Lop {  get; set; }
        public string SoCM {  get; set; }
        public string SDT { get; set; }
        public string DiaChi {  get; set; }
        public List<string> MonHocDangKy { get; set; }
        // Thuộc tính này sẽ đọc và ghi vào thẻ <NgaySinh> trong file XML
        [XmlElement("NgaySinh")]
        public string NgaySinhXML
        {
            get { return NgaySinh.ToString("dd/MM/yyyy"); }
            set { NgaySinh = DateTime.ParseExact(value, "dd/MM/yyyy", null); }
        }
        [XmlElement("GioiTinh")]
        public string GioiTinhXML
        {
            get { return GioiTinh ? "Nam" : "Nữ"; }
            set { GioiTinh = value != null && value.Equals("Nam", StringComparison.OrdinalIgnoreCase); }
        }
        public SinhVien()
        {

        }
        public SinhVien(string ms, string hotenlot, string ten, bool phai, DateTime ngay,
            string lop, string socm, string sdt, string diachi, List<string> monHoc)
        {
            this.MSSV = ms;
            this.HoTenLot = hotenlot;
            this.Ten = ten;
            this.NgaySinh = ngay; ;
            this.Lop = lop; 
            this.SoCM = socm;
            this.SDT = sdt;
            this.DiaChi = diachi;
            this.MonHocDangKy = monHoc;
            this.GioiTinh = phai;
        }
    }
}
