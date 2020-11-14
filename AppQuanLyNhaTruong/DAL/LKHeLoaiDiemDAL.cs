using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAL
{
    public class LKHeLoaiDiemDAL : SQL.SQLHelper, CInterface<LKHeLoaiDiem>
    {
        DBQuanLyDiem db = new DBQuanLyDiem();
        public Task<int> CapNhap(LKHeLoaiDiem obj)
        {
            db.TaiKhoanSinhViens.
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

        public Task<int> Them(LKHeLoaiDiem obj)
        {
            throw new NotImplementedException();
        }

        public Task<int> Xoa(int ID)
        {
            throw new NotImplementedException();
        }
    }
}
