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
    class TaiKhoanTruongDAL : SQL.SQLHelper, CInterface<TaiKhoanTruong>
    {
        public async Task<int> CapNhap(TaiKhoanTruong obj)
        {
            return await ExecuteNonQuery(
                   "CapNhapTaiKhoanTruong",
               new SqlParameter("@ID", SqlDbType.BigInt) { Value = obj.ID },
               new SqlParameter("@UserName", SqlDbType.Char) { Value = obj.UserName },
               new SqlParameter("@Pass", SqlDbType.Char) { Value = obj.Pass },
               new SqlParameter("@TenGV", SqlDbType.Char) { Value = obj.TenGV },
               new SqlParameter("@NamSinh", SqlDbType.DateTime) { Value = obj.NamSinh },
               new SqlParameter("@GioiTinh", SqlDbType.Bit) { Value = obj.GioiTinh },
               new SqlParameter("@SDT", SqlDbType.Char) { Value = obj.SDT },
               new SqlParameter("@Mail", SqlDbType.Char) { Value = obj.Mail }
               );
        }

        public async Task<DataTable> Lay()
        {
            return await ExecuteQuery(
                "XemTaiKhoanTruongDAL",
                new SqlParameter("@ID", SqlDbType.BigInt) { Value = -1 }
                );
        }

        public async Task<DataTable> Lay(int ID)
        {
            return await ExecuteQuery(
                "XemTaiKhoanTruongDAL",
                new SqlParameter("@ID", SqlDbType.BigInt) { Value = ID }
                );
        }

        public async Task<int> Them(TaiKhoanTruong obj)
        {
            return await ExecuteNonQuery(
                   "ThemTaiKhoanTruong",
               new SqlParameter("@ID", SqlDbType.BigInt) { Value = obj.ID },
               new SqlParameter("@UserName", SqlDbType.Char) { Value = obj.UserName },
               new SqlParameter("@Pass", SqlDbType.Char) { Value = obj.Pass },
               new SqlParameter("@TenGV", SqlDbType.Char) { Value = obj.TenGV },
               new SqlParameter("@NamSinh", SqlDbType.DateTime) { Value = obj.NamSinh },
               new SqlParameter("@GioiTinh", SqlDbType.Bit) { Value = obj.GioiTinh },
               new SqlParameter("@SDT", SqlDbType.Char) { Value = obj.SDT },
               new SqlParameter("@Mail", SqlDbType.Char) { Value = obj.Mail }
               );
        }

        public async Task<int> Xoa(int ID)
        {
            return await ExecuteNonQuery(
                "XoaTaiKhoanTruongDAL",
                new SqlParameter("@ID", SqlDbType.BigInt) { Value = ID }
                );
        }
    }
}
