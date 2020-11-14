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
    public class NienKhoaDAL : SQL.SQLHelper, CInterface<NienKhoa>
    {
        public async Task<int> CapNhap(NienKhoa obj)
        {
            return await ExecuteNonQuery(
                  "CapNhapNienKhoa",
              new SqlParameter("@ID", SqlDbType.BigInt) { Value = obj.ID },
              new SqlParameter("@Ten", SqlDbType.Char) { Value = obj.Ten },
              new SqlParameter("@ThoiGian", SqlDbType.DateTime) { Value = obj.ThoiGian }

              );
        }

        public async Task<DataTable> Lay()
        {
            return await ExecuteQuery(
               "XemNienKhoa",
               new SqlParameter("@ID", SqlDbType.BigInt) { Value = -1 }
               );
        }

        public async Task<DataTable> Lay(int ID)
        {
            return await ExecuteQuery(
               "XemNienKhoa",
               new SqlParameter("@ID", SqlDbType.BigInt) { Value = ID }
               );
        }

        public async Task<int> Them(NienKhoa obj)
        {
            return await ExecuteNonQuery(
                  "ThemNienKhoa",
              new SqlParameter("@ID", SqlDbType.BigInt) { Value = obj.ID },
              new SqlParameter("@Ten", SqlDbType.Char) { Value = obj.Ten },
              new SqlParameter("@ThoiGian", SqlDbType.DateTime) { Value = obj.ThoiGian }

              );
        }

        public async Task<int> Xoa(int ID)
        {
            return await ExecuteNonQuery(
                "XoaLop",
                new SqlParameter("@ID", SqlDbType.BigInt) { Value = ID }
                );
        }
    }
}
