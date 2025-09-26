using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System;

namespace ChuDe3_BT1
{
    // Custom converter để chuyển đổi giữa string và bool cho GioiTinh
    public class GenderConverter : JsonConverter<bool>
    {
        public override bool ReadJson(JsonReader reader, Type objectType, bool existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            // Đọc từ JSON: "Nam" -> true, "Nữ" -> false
            var value = reader.Value?.ToString();
            return value != null && value.Equals("Nam", StringComparison.OrdinalIgnoreCase);
        }
        public override void WriteJson(JsonWriter writer, bool value, JsonSerializer serializer)
        {
            // Ghi vào JSON: true -> "Nam", false -> "Nữ"
            writer.WriteValue(value ? "Nam" : "Nữ");
        }
    }

    public class JsonData : IDataSource
    {
        private readonly string _filename;

        public JsonData(string filename)
        {
            _filename = filename;
        }

        public List<SinhVien> GetSinhViens()
        {
            if (!File.Exists(_filename)) return new List<SinhVien>(); // Kiểm tra file có tồn tại

            var json = File.ReadAllText(_filename); // Đọc dữ liệu của file

            // Tạo cài đặt để chỉ định định dạng ngày tháng và custom converter cho giới tính
            var settings = new JsonSerializerSettings
            {
                DateFormatString = "dd/MM/yyyy",
                Converters = new List<JsonConverter> { new GenderConverter() }
            };

            return JsonConvert.DeserializeObject<List<SinhVien>>(json, settings) ?? new List<SinhVien>();
            // Khởi tạo một List Sinh viên mới - Nếu JSON không hợp lệ trả về một List rỗng chứ không trả về null
        }

        public void Save(List<SinhVien> sinhViens)
        {
            // Tạo cài đặt với custom converter để lưu giới tính dưới dạng "Nam"/"Nữ"
            var settings = new JsonSerializerSettings
            {
                DateFormatString = "dd/MM/yyyy",
                Formatting = Formatting.Indented,
                Converters = new List<JsonConverter> { new GenderConverter() }
            };

            // Chuyển đổi list sang chuỗi JSON
            var json = JsonConvert.SerializeObject(sinhViens, settings);
            // Ghi đè dữ liệu trong file
            File.WriteAllText(_filename, json);
        }
    }
}
