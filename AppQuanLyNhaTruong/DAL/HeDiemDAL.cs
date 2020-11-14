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
    public class HeDiemDAL : SQL.SQLHelper, CInterface<HeDiem>
    {
        public async Task<int> CapNhap(HeDiem obj)
        {
            return await ExecuteNonQuery(
                   "CapNhapHeDiem",
               new SqlParameter("@ID", SqlDbType.BigInt) { Value = obj.ID },
               new SqlParameter("@Ten", SqlDbType.Char) { Value = obj.Ten }
               );
        }

        public async Task<DataTable> Lay()
        {
            return await ExecuteQuery(
                "XemHeDiem",
                new SqlParameter("@ID", SqlDbType.BigInt) { Value = -1 }
                );
        }

        public async Task<DataTable> Lay(int ID)
        {
            return await ExecuteQuery(
                "XemHeDiem",
                new SqlParameter("@ID", SqlDbType.BigInt) { Value = ID }
                );
        }

        public async Task<int> Them(HeDiem obj)
        {
            return await ExecuteNonQuery(
                   "ThemHeDiem",
               new SqlParameter("@ID", SqlDbType.BigInt) { Value = obj.ID },
               new SqlParameter("@Ten", SqlDbType.Char) { Value = obj.Ten }
               );
        }

        public async Task<int> Xoa(int ID)
        {
            return await ExecuteNonQuery(
                "XoaHeDiem",
                new SqlParameter("@ID", SqlDbType.BigInt) { Value = ID }
                );
        }
    }
}
