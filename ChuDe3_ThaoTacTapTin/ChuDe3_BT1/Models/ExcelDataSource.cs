using System.Collections.Generic;
using System.Data;
using System.IO;
using ExcelDataReader;
using OfficeOpenXml;

namespace GiuaKy_OnTap_De3
{
    public class ExcelDataSource:IDataSource
    {
        private readonly string _filename;
        public ExcelDataSource(string filename)
        {
            _filename = filename;
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        }
        public List<DocGia> GetDocGias()
        {
            if (!File.Exists(_filename))
            {
                return new List<DocGia>(); // Nếu file không tồn tại, trả về danh sách rỗng
            }

            var danhSach = new List<DocGia>();
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

            using (var stream = File.Open(_filename, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    var result = reader.AsDataSet(new ExcelDataSetConfiguration()
                    {
                        ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                    });

                    DataTable dataTable = result.Tables[0];
                    foreach (DataRow row in dataTable.Rows)
                    {
                        if (row["MaDocGia"] == null || string.IsNullOrWhiteSpace(row["MaDocGia"].ToString()))
                            continue;

                        danhSach.Add(new DocGia
                        {
                            MaDocGia = row["MaDocGia"].ToString(),
                            TenDocGia = row["TenDocGia"].ToString(),
                            SDT = row["SoDienThoai"].ToString(),
                            DiaChi = row["DiaChi"].ToString()
                        });
                    }
                }
            }
            return danhSach;
        }
        public void Save(List<DocGia> docGia)
        {
            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("DSDocGia");
                // Ghi header
                worksheet.Cells[1, 1].Value = "MaDocGia";
                worksheet.Cells[1, 2].Value = "TenDocGia";
                worksheet.Cells[1, 3].Value = "SoDienThoai";
                worksheet.Cells[1, 4].Value = "DiaChi";
                // Ghi dữ liệu
                for (int i = 0; i < docGia.Count; i++)
                {
                    worksheet.Cells[i + 2, 1].Value = docGia[i].MaDocGia;
                    worksheet.Cells[i + 2, 2].Value = docGia[i].TenDocGia;
                    worksheet.Cells[i + 2, 3].Value = docGia[i].SDT;
                    worksheet.Cells[i + 2, 4].Value = docGia[i].DiaChi;
                }
                // Lưu file
                File.WriteAllBytes(_filename, package.GetAsByteArray());
            }
        }
    }
}
