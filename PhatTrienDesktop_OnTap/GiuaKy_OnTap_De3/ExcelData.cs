using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcelDataReader;
using OfficeOpenXml;
using System.IO;
using System.Data;

namespace GiuaKy_OnTap_De3
{
    public class ExcelData:IDataSource
    {
        private readonly string _filename;
        public ExcelData(string filename)
        {
            _filename = filename;
        }
        public List<DocGia> GetDocGias()
        {
            var docGia = new List<DocGia>();
            var fileInfo = new FileInfo(_filename);
            if(!fileInfo.Exists)
            {
                return docGia;
            }
            using(var package = new ExcelPackage(fileInfo))
            {
                var worksheet = package.Workbook.Worksheets.FirstOrDefault();
                if(worksheet==null)
                {
                    return docGia;
                }
                for(int row=2;row<=worksheet.Dimension.End.Row; row++)
                {
                    try
                    {
                        var dg = new DocGia
                        {
                            MaDocGia = worksheet.Cells[row, 1].Text.Trim(),
                            TenDocGia = worksheet.Cells[row, 2].Text.Trim(),
                            SDT = worksheet.Cells[row, 3].Text.Trim(),
                            DiaChi = worksheet.Cells[row, 4].Text.Trim()
                        };
                        docGia.Add(dg);
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine($"Lỗi ở hàng {row}: {e.Message}");
                    }
                }
            }
            return docGia;
        }
        public void Save(List<DocGia> docGia)
        {
            var fileinfo = new FileInfo(_filename);
            using(var package=new ExcelPackage(fileinfo))
            {
                var worksheet = package.Workbook.Worksheets.FirstOrDefault(ws => ws.Name == "DSSV_Excel");
                if (worksheet == null)
                {
                    // Tạo mới nếu chưa có
                    worksheet = package.Workbook.Worksheets.Add("DSSV_Excel");
                }
                else
                {
                    // Clear toàn bộ nội dung thay vì delete
                    worksheet.Cells.Clear();
                }
                var headers = new string[]
                {
                    "MaDocGia", "TenDocGia", "SDT", "DiaChi"
                };
                for (int i = 0; i < headers.Length; i++)
                {
                    worksheet.Cells[1, i + 1].Value = headers[i];
                }
                for(int i=0; i<docGia.Count; i++)
                {
                    var dg = docGia[i];
                    int row = i + 2;
                    worksheet.Cells[row, 1].Value = dg.MaDocGia;
                    worksheet.Cells[row, 2].Value = dg.TenDocGia;
                    worksheet.Cells[row, 3].Value = dg.SDT;
                    worksheet.Cells[row, 4].Value = dg.DiaChi;
                }
                worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();
                package.Save();
            }
        }
    }
}
