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
    public class TaiKhoanSinhVienDAL : SQL.SQLHelper, CInterface<TaiKhoanSinhVien>
    {
        public async Task<int> CapNhap(TaiKhoanSinhVien obj)
        {
            return await ExecuteNonQuery(
                "CapNhapTaiKhoanSinhVien",
                new SqlParameter("@ID", SqlDbType.BigInt) { Value = obj.ID },
                new SqlParameter("@UserName", SqlDbType.Char) { Value = obj.UserName },
                new SqlParameter("@Pass", SqlDbType.Char) { Value = obj.Pass },
                new SqlParameter("@TenSV", SqlDbType.Char) { Value = obj.TenSV },
                new SqlParameter("@NamSinh", SqlDbType.DateTime) { Value = obj.NamSinh },
                new SqlParameter("@GioiTinh", SqlDbType.Bit) { Value = obj.GioiTinh },
                new SqlParameter("@IDLop", SqlDbType.BigInt) { Value = obj.IDLop },
                new SqlParameter("@IDKhoa", SqlDbType.BigInt) { Value = obj.IDKhoa },
                new SqlParameter("@IDNienKhoa", SqlDbType.BigInt) { Value = obj.IDNienKhoa },
                new SqlParameter("@SDT", SqlDbType.Char) { Value = obj.SDT },
                new SqlParameter("@Mail", SqlDbType.Char) { Value = obj.Mail },
                new SqlParameter("@DiaChi", SqlDbType.NVarChar) { Value = obj.DiaChi },
                new SqlParameter("@NoiSinh", SqlDbType.NVarChar) { Value = obj.NoiSinh },
                new SqlParameter("@HoKhau", SqlDbType.NVarChar) { Value = obj.HoKhau }
                );
        }

        public async Task<DataTable> Lay()
        {
            return await ExecuteQuery(
                "XemTaiKhoanSinhVien",
                new SqlParameter("@ID", SqlDbType.BigInt) { Value = -1 }
                );
        }

        public async Task<DataTable> Lay(int ID)
        {
            return await ExecuteQuery(
                "XemTaiKhoanSinhVien",
                new SqlParameter("@ID", SqlDbType.BigInt) { Value = ID }
                );
        }

        public async Task<int> Them(TaiKhoanSinhVien obj)
        {
            return await ExecuteNonQuery(
                "ThemTaiKhoanSinhVien",
                new SqlParameter("@ID", SqlDbType.BigInt) { Value = obj.ID },
                new SqlParameter("@UserName", SqlDbType.Char) { Value = obj.UserName },
                new SqlParameter("@Pass", SqlDbType.Char) { Value = obj.Pass },
                new SqlParameter("@TenSV", SqlDbType.Char) { Value = obj.TenSV },
                new SqlParameter("@NamSinh", SqlDbType.DateTime) { Value = obj.NamSinh },
                new SqlParameter("@GioiTinh", SqlDbType.Bit) { Value = obj.GioiTinh },
                new SqlParameter("@IDLop", SqlDbType.BigInt) { Value = obj.IDLop },
                new SqlParameter("@IDKhoa", SqlDbType.BigInt) { Value = obj.IDKhoa },
                new SqlParameter("@IDNienKhoa", SqlDbType.BigInt) { Value = obj.IDNienKhoa },
                new SqlParameter("@SDT", SqlDbType.Char) { Value = obj.SDT },
                new SqlParameter("@Mail", SqlDbType.Char) { Value = obj.Mail },
                new SqlParameter("@DiaChi", SqlDbType.NVarChar) { Value = obj.DiaChi },
                new SqlParameter("@NoiSinh", SqlDbType.NVarChar) { Value = obj.NoiSinh },
                new SqlParameter("@HoKhau", SqlDbType.NVarChar) { Value = obj.HoKhau }
                );
        }

        public async Task<int> Xoa(int ID)
        {
            return await ExecuteNonQuery(
                "XoaTaiKhoanSinhVien",
                new SqlParameter("@ID", SqlDbType.BigInt) { Value = ID }
                );
        }
    }
}
