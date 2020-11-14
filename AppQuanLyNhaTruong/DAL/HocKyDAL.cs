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
    class HocKyDAL : SQL.SQLHelper, CInterface<HocKy>
    {
        public async Task<int> CapNhap(HocKy obj)
        {
            return await ExecuteNonQuery(
                   "CapNhapHocKy",
               new SqlParameter("@ID", SqlDbType.BigInt) { Value = obj.ID },
               new SqlParameter("@Ten", SqlDbType.Char) { Value = obj.Ten }
               );
        }

        public async Task<DataTable> Lay()
        {
            return await ExecuteQuery(
                "XemHocKy",
                new SqlParameter("@ID", SqlDbType.BigInt) { Value = -1 }
                );
        }

        public async Task<DataTable> Lay(int ID)
        {
            return await ExecuteQuery(
                "XemHocKy",
                new SqlParameter("@ID", SqlDbType.BigInt) { Value = ID }
                );
        }

        public async Task<int> Them(HocKy obj)
        {
            return await ExecuteNonQuery(
                   "ThemHocKy",
               new SqlParameter("@ID", SqlDbType.BigInt) { Value = obj.ID },
               new SqlParameter("@Ten", SqlDbType.Char) { Value = obj.Ten }
               );
        }

        public async Task<int> Xoa(int ID)
        {
            return await ExecuteNonQuery(
                "XemHocKy",
                new SqlParameter("@ID", SqlDbType.BigInt) { Value = ID }
                );
        }
    }
}
