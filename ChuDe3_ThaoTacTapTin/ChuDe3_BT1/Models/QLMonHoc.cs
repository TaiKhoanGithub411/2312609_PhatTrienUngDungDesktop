using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ChuDe3_BT1.Models
{
    public class QLMonHoc
    {
        private static readonly string filePath = Path.Combine(Application.StartupPath, @"..\..\Data\MonHoc.txt");
        public static List<string> LoadMonHoc()
        {
            try
            {
                if (File.Exists(filePath))
                {
                    return File.ReadAllLines(filePath)
                              .Where(line => !string.IsNullOrWhiteSpace(line))
                              .ToList();
                }
                return new List<string>();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách môn học: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<string>();
            }
        }
        public static void SaveMonHoc(List<string> danhSachMonHoc)
        {
            try
            {
                Directory.CreateDirectory(Path.GetDirectoryName(filePath));
                File.WriteAllLines(filePath, danhSachMonHoc.Where(mon => !string.IsNullOrWhiteSpace(mon)));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu danh sách môn học: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
