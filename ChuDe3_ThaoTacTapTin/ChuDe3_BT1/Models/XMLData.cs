using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace ChuDe3_BT1.Models
{
    public class XMLData:IDataSource
    {
        private readonly string _filename;
        public XMLData(string filename)
        {
            _filename = filename;
        }        
        public List<SinhVien> GetSinhViens()
        {
            //Kiểm tra file có tồn tại -> có trả về 1 list<sinhvien>
            if (!File.Exists(_filename)) return new List<SinhVien>();
            //chuyển đổi XML thành List
            // Chỉ định rằng thẻ gốc của file XML có tên là "DanhSachSinhVien"
            var rootAttribute = new XmlRootAttribute("DanhSachSinhVien");
            var serializer = new XmlSerializer(typeof(List<SinhVien>), rootAttribute);

            //Mở và đọc file
            using (var reader = new StreamReader(_filename))
            {
                return (List<SinhVien>)serializer.Deserialize(reader);//chuyển xml thành đối tượng trong list
            }
        }
        public void Save(List<SinhVien> sinhViens)
        {
            //Biến chịu trách nhiệm chuyển đối tượng trong list thành xml
            var serializer = new XmlSerializer(typeof(List<SinhVien>));
            //CHuyển đổi thành xml và ghi vào file
            using (var writer = new StreamWriter(_filename))
            {
                serializer.Serialize(writer, sinhViens);
            }
        }
    }
}
