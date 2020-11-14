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
    class PhanCongDayDAL : SQL.SQLHelper, CInterface<PhanCongDay>
    {
        public async Task<int> CapNhap(PhanCongDay obj)
        {
            return await ExecuteNonQuery(
                   "CapNhapPhanCongDay",
               new SqlParameter("@ID", SqlDbType.BigInt) { Value = obj.ID },
               new SqlParameter("@IDPhanCongMon", SqlDbType.BigInt) { Value = obj.IDPhanCongMon },
               new SqlParameter("@IDHK", SqlDbType.BigInt) { Value = obj.IDHK }
               );
        }

        public async Task<DataTable> Lay()
        {
            return await ExecuteQuery(
                "XemPhanCongDay",
                new SqlParameter("@ID", SqlDbType.BigInt) { Value = -1 }
                );
        }

        public async Task<DataTable> Lay(int ID)
        {
            return await ExecuteQuery(
                "XemPhanCongDay",
                new SqlParameter("@ID", SqlDbType.BigInt) { Value = ID }
                );
        }

        public async Task<int> Them(PhanCongDay obj)
        {
            return await ExecuteNonQuery(
                    "ThemNhapPhanCongDay",
                new SqlParameter("@ID", SqlDbType.BigInt) { Value = obj.ID },
                new SqlParameter("@IDPhanCongMon", SqlDbType.BigInt) { Value = obj.IDPhanCongMon },
                new SqlParameter("@IDHK", SqlDbType.BigInt) { Value = obj.IDHK }
                );
        }

        public async Task<int> Xoa(int ID)
        {
            return await ExecuteNonQuery(
                "XoaPhanCongMon",
                new SqlParameter("@ID", SqlDbType.BigInt) { Value = ID }
                );
        }
    }
}
