using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using System.Data.SqlClient;

namespace DAL
{
    public class LKHeLoaiDiemDAL : SQL.SQLHelper, CInterface<LKHeLoaiDiem>
    {
        public async Task<int> CapNhap(LKHeLoaiDiem obj)
        {
            return await ExecuteNonQuery(
                "CapNhapHeLoaiDiem",
                new SqlParameter("@ID", SqlDbType.BigInt) { Value = obj.IDHe },
                new SqlParameter("@IDLoaiDiem", SqlDbType.Int) { Value = obj.IDLoai }           
                );
        }

        public async Task<DataTable> Lay()
        {
            return await ExecuteQuery(
                "XemHeLoaiDiem",
                new SqlParameter("@ID", SqlDbType.BigInt) { Value = -1 }
                );
        }

        public async Task<DataTable> Lay(int ID)
        {
            return await ExecuteQuery(
                "XemHeLoaiDiem",
                new SqlParameter("@ID", SqlDbType.BigInt) { Value =ID  }
                );
        }

        public async Task<int> Them(LKHeLoaiDiem obj)
        {
            return await ExecuteNonQuery(
                "ThemHeLoaiDiem",
                new SqlParameter("@ID", SqlDbType.BigInt) { Value = obj.IDHe },
                new SqlParameter("@IDLoaiDiem", SqlDbType.Int) { Value = obj.IDLoai }
                );
        }

        public async Task<int> Xoa(int ID)
        {
            return await ExecuteNonQuery(
                "XoaHeLoaDiem",
                new SqlParameter("@ID", SqlDbType.BigInt) { Value = ID }
                );
        }
    }
}
