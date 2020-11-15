using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ChucVuDAL : SQL.SQLHelper, CInterface<ChucVu>
    {
        public Task<int> CapNhap(ChucVu obj)
        {
            throw new NotImplementedException();
        }

        public async Task<DataTable> Lay()
        {
            return await ExecuteQuery("XemChucVu",
                new SqlParameter("@ID", SqlDbType.Int) { Value = -1 });
        }

        public Task<DataTable> Lay(int ID)
        {
            throw new NotImplementedException();
        }

        public Task<int> Them(ChucVu obj)
        {
            throw new NotImplementedException();
        }

        public Task<int> Xoa(int ID)
        {
            throw new NotImplementedException();
        }
    }
}
