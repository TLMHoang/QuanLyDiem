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
    public class MonHocDAL : SQL.SQLHelper, CInterface<MonHoc>
    {
        public async Task<int> CapNhap(MonHoc obj)
        {
            return await ExecuteNonQuery(
                   "CapNhapMonHoc",
               new SqlParameter("@ID", SqlDbType.BigInt) { Value = obj.ID },
               new SqlParameter("@Ten", SqlDbType.Char) { Value = obj.Ten },
               new SqlParameter("@IDHeDiem", SqlDbType.BigInt) { Value = obj.IDHeDiem }

               );
        }

        public async Task<DataTable> Lay()
        {
            return await ExecuteQuery(
                "XemMonHoc",
                new SqlParameter("@ID", SqlDbType.BigInt) { Value = -1 }
                );
        }

        public async Task<DataTable> Lay(int ID)
        {
            return await ExecuteQuery(
                "XemMonHoc",
                new SqlParameter("@ID", SqlDbType.BigInt) { Value = ID }
                );
        }

        public async Task<int> Them(MonHoc obj)
        {
            return await ExecuteNonQuery(
                   "ThemMonHoc",
               new SqlParameter("@ID", SqlDbType.BigInt) { Value = obj.ID },
               new SqlParameter("@Ten", SqlDbType.Char) { Value = obj.Ten },
               new SqlParameter("@IDHeDiem", SqlDbType.BigInt) { Value = obj.IDHeDiem }

               );
        }

        public async Task<int> Xoa(int ID)
        {
            return await ExecuteNonQuery(
                "XemMonHoc",
                new SqlParameter("@ID", SqlDbType.BigInt) { Value = ID }
                );
        }
    }
}
