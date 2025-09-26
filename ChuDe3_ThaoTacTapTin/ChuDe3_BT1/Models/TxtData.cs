using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Globalization;

namespace ChuDe3_BT1
{
    public class TxtData : IDataSource
    {
        private readonly string _filename;

        public TxtData(string filename)
        {
            _filename = filename;
        }

        // Phương thức chuyển đổi giới tính từ string sang bool
        private bool ConvertGenderToBool(string gender)
        {
            return gender.Trim().Equals("Nam", StringComparison.OrdinalIgnoreCase);
            // "Nam" -> true, "Nữ" -> false
        }

        // Phương thức chuyển đổi giới tính từ bool sang string
        private string ConvertBoolToGender(bool gender)
        {
            return gender ? "Nam" : "Nữ";
            // true -> "Nam", false -> "Nữ"
        }

        public List<SinhVien> GetSinhViens()
        {
            var list = new List<SinhVien>();
            if (!File.Exists(_filename)) return list;

            var lines = File.ReadAllLines(_filename);
            foreach (var line in lines)
            {
                var parts = line.Split('*');
                var sv = new SinhVien(
                    parts[0],                                                           
                    parts[1],                                                           
                    parts[2],                                                           
                    ConvertGenderToBool(parts[3]),                                     
                    DateTime.ParseExact(parts[4], "dd/MM/yyyy", CultureInfo.InvariantCulture), // NgaySinh
                    parts[5],                                                           
                    parts[6],                                                           
                    parts[7],                                                           
                    parts[8],                                                           
                    parts[9].Split(',').ToList()                                       
                );
                list.Add(sv);
            }
            return list;
        }

        public void Save(List<SinhVien> sinhViens)
        {
            var lines = sinhViens.Select(sv =>
                string.Join("*",
                    sv.MSSV,
                    sv.HoTenLot,
                    sv.Ten,
                    ConvertBoolToGender(sv.GioiTinh),// GioiTinh: true/false -> "Nam"/"Nữ"
                    sv.NgaySinh.ToString("dd/MM/yyyy"),
                    sv.Lop,
                    sv.SoCM,
                    sv.SDT,
                    sv.DiaChi,
                    string.Join(",", sv.MonHocDangKy))
            );
            File.WriteAllLines(_filename, lines);
        }
    }
}
