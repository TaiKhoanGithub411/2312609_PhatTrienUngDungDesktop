using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiuaKy_OnTap_De3
{
    public interface IDataSource
    {
        List<DocGia> GetDocGias();
        void Save(List<DocGia> docGias);
    }
}
