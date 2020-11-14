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
    public class KhoaDAL : SQL.SQLHelper, CInterface<Khoa>
    {
        public async Task<int> CapNhap(Khoa obj)
        {
            return await ExecuteNonQuery(
                   "CapNhapKhoa",
               new SqlParameter("@ID", SqlDbType.BigInt) { Value = obj.ID },
               new SqlParameter("@Ten", SqlDbType.Char) { Value = obj.Ten }
               );
        }

        public async Task<DataTable> Lay()
        {
            return await ExecuteQuery(
                "XemKhoa",
                new SqlParameter("@ID", SqlDbType.BigInt) { Value = -1 }
                );
        }

        public async Task<DataTable> Lay(int ID)
        {
            return await ExecuteQuery(
                "XemKhoa",
                new SqlParameter("@ID", SqlDbType.BigInt) { Value = ID }
                );
        }

        public async Task<int> Them(Khoa obj)
        {
            return await ExecuteNonQuery(
                   "ThemKhoa",
               new SqlParameter("@ID", SqlDbType.BigInt) { Value = obj.ID },
               new SqlParameter("@Ten", SqlDbType.Char) { Value = obj.Ten }
               );
        }

        public async Task<int> Xoa(int ID)
        {
            return await ExecuteNonQuery(
                "XoaKhoa",
                new SqlParameter("@ID", SqlDbType.BigInt) { Value = ID }
                );
        }
    }
}
