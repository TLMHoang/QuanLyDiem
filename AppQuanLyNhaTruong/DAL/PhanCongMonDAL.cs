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
    public class PhanCongMonDAL : SQL.SQLHelper, CInterface<PhanCongMon>
    {
        public async Task<int> CapNhap(PhanCongMon obj)
        {
            return await ExecuteNonQuery(
                   "CapNhapPhanCongMon",
               new SqlParameter("@ID", SqlDbType.BigInt) { Value = obj.ID },
               new SqlParameter("@IDGV", SqlDbType.BigInt) { Value = obj.IDGV },
               new SqlParameter("@IDMon", SqlDbType.BigInt) { Value = obj.IDMon }
               );
        }

        public async Task<DataTable> Lay()
        {
            return await ExecuteQuery(
                "XemPhanCongMon",
                new SqlParameter("@ID", SqlDbType.BigInt) { Value = -1 }
                );
        }

        public async Task<DataTable> Lay(int ID)
        {
            return await ExecuteQuery(
                "XemPhanCongMon",
                new SqlParameter("@ID", SqlDbType.BigInt) { Value = ID }
                );
        }

        public async Task<int> Them(PhanCongMon obj)
        {
            return await ExecuteNonQuery(
                   "ThemPhanCongMon",
               new SqlParameter("@ID", SqlDbType.BigInt) { Value = obj.ID },
               new SqlParameter("@IDGV", SqlDbType.BigInt) { Value = obj.IDGV },
               new SqlParameter("@IDMon", SqlDbType.BigInt) { Value = obj.IDMon }
               );
        }

        public async Task<int> Xoa(int ID)
        {
            return await ExecuteNonQuery(
                "XemPhanCongMon",
                new SqlParameter("@ID", SqlDbType.BigInt) { Value = ID }
                );
        }
    }
}
