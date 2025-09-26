using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuDe3_BT1
{
    public interface IDataSource
    {
        //Lớp này là cầu nối giúp lấy dữ liệu từ bất kỳ loại file dữ liệu nào
        //Dễ dàng thay đổi đinh dạng file lấy dữ liệu mà không cần thay đổi code
        List<SinhVien> GetSinhViens();//Khi các lớp kế thừa interface này thì phải viết hàm chuyển đổi dữ liệu từ loại file đó thành list
        void Save(List<SinhVien> sinhViens);//Giúp lưu dữ liệu vào file (csdl)
    }
}
