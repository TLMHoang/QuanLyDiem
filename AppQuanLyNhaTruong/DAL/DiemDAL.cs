using DAL.SQL;
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
    public class DiemDAL : SQLHelper, CInterface<Diem>
    {
        public async Task<int> CapNhap(Diem obj)
        {
            return await ExecuteNonQuery(
                "CapNhapDiem",
                new SqlParameter("@ID", SqlDbType.BigInt) { Value = obj.ID },
                new SqlParameter("@IDLoaiDiem", SqlDbType.Int) { Value = obj.IDLoaiDiem },
                new SqlParameter("@IDPhanCongDay", SqlDbType.Int) { Value = obj.IDPhanCongDay},
                new SqlParameter("@IDSV", SqlDbType.BigInt) { Value = obj.IDSV},
                new SqlParameter("@Diem", SqlDbType.Decimal) { Value = obj.Diem1 }
                );
        }

        public async Task<DataTable> Lay()
        {
            return await ExecuteQuery(
                "XemDiem",
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

        public async Task<int> Them(Diem obj)
        {
            return await ExecuteNonQuery(
                "ThemDiem",
                new SqlParameter("@IDLoaiDiem", SqlDbType.Int) { Value = obj.IDLoaiDiem },
                new SqlParameter("@IDPhanCongDay", SqlDbType.Int) { Value = obj.IDPhanCongDay },
                new SqlParameter("@IDSV", SqlDbType.BigInt) { Value = obj.IDSV },
                new SqlParameter("@Diem", SqlDbType.Decimal) { Value = obj.Diem1 }
                );
        }

        public async Task<int> Xoa(int ID)
        {
            return await ExecuteNonQuery(
                "XoaDiem",
                new SqlParameter("@ID", SqlDbType.BigInt) { Value = ID }
                );
        }
    }
}
