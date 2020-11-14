using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DanhSachTietDayDAL : SQL.SQLHelper, CInterface<DanhSachTietDay>

    {
        Task<int> CInterface<DanhSachTietDay>.CapNhap(DanhSachTietDay obj)
        {
            throw new NotImplementedException();
        }

        public Task<DataTable> Lay()
        {
            throw new NotImplementedException();
        }

        public Task<DataTable> Lay(int ID)
        {
            throw new NotImplementedException();
        }

        Task<int> CInterface<DanhSachTietDay>.Them(DanhSachTietDay obj)
        {
            throw new NotImplementedException();
        }

        public Task<int> Xoa(int ID)
        {
            throw new NotImplementedException();
        }
    }
}
