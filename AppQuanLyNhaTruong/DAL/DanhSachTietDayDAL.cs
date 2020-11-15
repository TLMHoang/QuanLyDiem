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
    public class DanhSachTietDayDAL : SQL.SQLHelper, CInterface<DanhSachTietDay>
    {
        public async Task<int> CapNhap(DanhSachTietDay obj)
        {
            return await ExecuteNonQuery(
                "CapNhapDanhSachTietDay",
                new SqlParameter("@IDPhanCongDay", SqlDbType.BigInt) { Value = obj.IDPhanCongDay },
                new SqlParameter("@IDSV", SqlDbType.Int) { Value = obj.IDSV }
                );
        }

        public async Task<DataTable> Lay()
        {
            return await ExecuteQuery(
                "XemDanhSachTietDay",
                new SqlParameter("@ID", SqlDbType.BigInt) { Value = -1 }
                );
        }

        public async Task<DataTable> Lay(int ID)
        {
            return await ExecuteQuery(
                "XemDanhSachTietDay",
                new SqlParameter("@ID", SqlDbType.BigInt) { Value = ID }
                );
        }

        public async Task<int> Them(DanhSachTietDay obj)
        {
            return await ExecuteNonQuery(
                "ThemDanhSachTietDay",
                new SqlParameter("@IDPhanCongDay", SqlDbType.BigInt) { Value = obj.IDPhanCongDay },
                new SqlParameter("@IDSV", SqlDbType.Int) { Value = obj.IDSV }
                );
        }

        public async Task<int> Xoa(int ID)
        {
            return await ExecuteNonQuery(
                "XoaDanhSachTietDay",
                new SqlParameter("@ID", SqlDbType.BigInt) { Value = ID }
                );
        }
    }
}
