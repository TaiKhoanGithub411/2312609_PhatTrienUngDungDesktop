using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcelDataReader;
using OfficeOpenXml;
using System.IO;
using System.Data;

namespace ChuDe3_BT1.Models
{
    public class ExcelData:IDataSource
    {
        private readonly string _filename;
        public ExcelData(string filename)
        {
            _filename = filename;
            
        }
        public List<SinhVien> GetSinhViens()
        {
            var sinhViens = new List<SinhVien>();

            var fileInfo = new FileInfo(_filename);
            if (!fileInfo.Exists)
            {
                return sinhViens; // Trả về danh sách rỗng nếu file không tồn tại
            }

            using (var package = new ExcelPackage(fileInfo))
            {
                // Giả sử dữ liệu nằm ở worksheet đầu tiên
                var worksheet = package.Workbook.Worksheets.FirstOrDefault();
                if (worksheet == null)
                {
                    return sinhViens;
                }
                // Bắt đầu đọc từ hàng thứ 2 (bỏ qua hàng tiêu đề)
                for (int row = 2; row <= worksheet.Dimension.End.Row; row++)
                {
                    try
                    {
                        var sv = new SinhVien
                        {
                            MSSV = worksheet.Cells[row, 1].Text.Trim(),
                            HoTenLot = worksheet.Cells[row, 2].Text.Trim(),
                            Ten = worksheet.Cells[row, 3].Text.Trim(),
                            // Chuyển đổi từ chuỗi "Nam"/"Nữ" sang boolean
                            GioiTinh = worksheet.Cells[row, 4].Text.Trim().Equals("Nam", StringComparison.OrdinalIgnoreCase),
                            // Chuyển đổi từ chuỗi ngày tháng sang DateTime
                            NgaySinh = DateTime.ParseExact(worksheet.Cells[row, 5].Text.Trim(), "dd/MM/yyyy", null),
                            Lop = worksheet.Cells[row, 6].Text.Trim(),
                            SoCM = worksheet.Cells[row, 7].Text.Trim(),
                            SDT = worksheet.Cells[row, 8].Text.Trim(),
                            DiaChi = worksheet.Cells[row, 9].Text.Trim()
                        };

                        // Xử lý danh sách môn học đăng ký (được lưu dưới dạng chuỗi, phân tách bởi dấu phẩy)
                        var monHocStr = worksheet.Cells[row, 10].Text.Trim();
                        sv.MonHocDangKy = string.IsNullOrEmpty(monHocStr)
                            ? new List<string>()
                            : monHocStr.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(m => m.Trim()).ToList();

                        sinhViens.Add(sv);
                    }
                    catch (Exception ex)
                    {
                        // Có thể thêm log để ghi lại lỗi khi đọc một hàng cụ thể
                        Console.WriteLine($"Lỗi khi đọc dữ liệu ở hàng {row}: {ex.Message}");
                    }
                }
            }
            return sinhViens;
        }
        public void Save(List<SinhVien> sinhViens)
        {
            var fileInfo = new FileInfo(_filename);
            using (var package = new ExcelPackage(fileInfo))
            {
                // Xóa worksheet cũ nếu tồn tại và tạo mới
                var worksheet = package.Workbook.Worksheets.FirstOrDefault(ws => ws.Name == "DanhSachSinhVien");
                if (worksheet != null)
                {
                    package.Workbook.Worksheets.Delete(worksheet);
                }
                worksheet = package.Workbook.Worksheets.Add("DanhSachSinhVien");

                // Ghi hàng tiêu đề
                var headers = new string[]
                {
                    "MSSV", "HoTenLot", "Ten", "GioiTinh", "NgaySinh", "Lop", "SoCMND", "SĐT", "DiaChi", "MonHocDangKy"
                };
                for (int i = 0; i < headers.Length; i++)
                {
                    worksheet.Cells[1, i + 1].Value = headers[i];
                }

                // Ghi dữ liệu từng sinh viên
                for (int i = 0; i < sinhViens.Count; i++)
                {
                    var sv = sinhViens[i];
                    int row = i + 2;
                    worksheet.Cells[row, 1].Value = sv.MSSV;
                    worksheet.Cells[row, 2].Value = sv.HoTenLot;
                    worksheet.Cells[row, 3].Value = sv.Ten;
                    worksheet.Cells[row, 4].Value = sv.GioiTinh ? "Nam" : "Nữ"; // Dùng thuộc tính GioiTinh
                    worksheet.Cells[row, 5].Value = sv.NgaySinh.ToString("dd/MM/yyyy"); // Dùng thuộc tính NgaySinh
                    worksheet.Cells[row, 6].Value = sv.Lop;
                    worksheet.Cells[row, 7].Value = sv.SoCM;
                    worksheet.Cells[row, 8].Value = sv.SDT;
                    worksheet.Cells[row, 9].Value = sv.DiaChi;
                    // Nối danh sách môn học thành một chuỗi
                    worksheet.Cells[row, 10].Value = string.Join(", ", sv.MonHocDangKy ?? new List<string>());
                }
                // Tự động điều chỉnh độ rộng các cột
                worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();
                package.Save();
            }
        }
    }
}
