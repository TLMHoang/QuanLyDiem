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
    public class LoaiDiemDAL : SQL.SQLHelper, CInterface<LoaiDiem>
    {
        public async Task<int> CapNhap(LoaiDiem obj)
        {
            return await ExecuteNonQuery(
                "CapNhapLoaiDiem",
                new SqlParameter("@ID", SqlDbType.BigInt) { Value = obj.ID },            
                new SqlParameter("@Ten", SqlDbType.NVarChar) { Value = obj.Ten },            
                new SqlParameter("@HeSo", SqlDbType.Float) { Value = obj.HeSo }
                );
        }

        public async Task<DataTable> Lay()
        {
            return await ExecuteQuery(
                "XemLoaiDiem",
                new SqlParameter("@ID", SqlDbType.BigInt) { Value = -1 }
                );
        }

        public async Task<DataTable> Lay(int ID)
        {
            return await ExecuteQuery(
                "XemDiem",
                new SqlParameter("@ID", SqlDbType.BigInt) { Value = ID }
                );
        }

        public async Task<int> Them(LoaiDiem obj)
        {
            return await ExecuteNonQuery(
                "ThemLoaiDiem",
                new SqlParameter("@ID", SqlDbType.BigInt) { Value = obj.ID },
                new SqlParameter("@Ten", SqlDbType.NVarChar) { Value = obj.Ten },
                new SqlParameter("@HeSo", SqlDbType.Float) { Value = obj.HeSo }
                );
        }

        public async Task<int> Xoa(int ID)
        {
            return await ExecuteNonQuery(
                "XoaLoaiDiem",
                new SqlParameter("@ID", SqlDbType.BigInt) { Value = ID }
                );
        }
    }
}
