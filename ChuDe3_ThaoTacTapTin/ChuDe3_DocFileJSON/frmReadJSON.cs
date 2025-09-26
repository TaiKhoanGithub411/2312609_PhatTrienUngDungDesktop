using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuDe3_DocFileJSON
{
    public partial class frmReadJSON : Form
    {
        public frmReadJSON()
        {
            InitializeComponent();
        }

        private void btnReadJson_Click(object sender, EventArgs e)
        {
            string Str = ""; // chuoi luu tru
            string Path = "../../students.json"; // Duong dan tap tin
            List<StudentInfo> List = LoadJSON(Path); // Goi phuong thuc
            for (int i = 0; i < List.Count; i++) // Doc danh sach
            {
                StudentInfo info = List[i];
                Str += string.Format("Sinh vien {0} có MSSV: {1}, Họ tên: {2}, " +
                    "Điểm TB: {3}\r\n", (i + 1), info.MSSV, info.HoTen, info.Diem);
            }
            MessageBox.Show(Str);
        }
        private List<StudentInfo> LoadJSON(string Path)
        {
            // Khai bao danh sach luu tru
            List<StudentInfo> List = new List<StudentInfo>();
            // Doi tuong doc tap tin
            StreamReader r = new StreamReader(Path);
            string json = r.ReadToEnd(); // Doc het

            // Chuyen ve thanh mang cac doi tuong
            var array = (JObject)JsonConvert.DeserializeObject(json);
            // Lay doi tuong sinh vien
            var students = array["sinhvien"].Children();
            foreach (var item in students) // Duyet mang
            {
                // Lay cac thanh phan
                string mssv = item["MSSV"].Value<string>();
                string hoten = item["hoten"].Value<string>();
                int tuoi = item["tuoi"].Value<int>();
                double diem = item["diem"].Value<double>();
                bool tongiao = item["tongiao"].Value<bool>();
                // Chuyen vao doi tuong StudentInfo
                StudentInfo info = new StudentInfo(mssv, hoten, tuoi, diem, tongiao);
                List.Add(info); // Them vao danh sach
            }
            return List;
        }
    }
}
