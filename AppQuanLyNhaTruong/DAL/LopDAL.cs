﻿using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LopDAL : SQL.SQLHelper, CInterface<Lop>
    {
        public async Task<int> CapNhap(Lop obj)
        {
               return await ExecuteNonQuery(
                   "CapNhapLop",
               new SqlParameter("@ID", SqlDbType.BigInt) { Value = obj.ID },
               new SqlParameter("@Ten", SqlDbType.Char) { Value = obj.Ten }
               );
        }

        public async Task<DataTable> Lay()
        {
            return await ExecuteQuery(
                "XemLop",
                new SqlParameter("@ID", SqlDbType.BigInt) { Value = -1 }
                );
        }

        public async Task<DataTable> Lay(int ID)
        {
            return await ExecuteQuery(
                "XemLop",
                new SqlParameter("@ID", SqlDbType.BigInt) { Value = ID }
                );
        }

        public async Task<int> Them(Lop obj)
        {
            return await ExecuteNonQuery(
                   "ThemLop",
               new SqlParameter("@ID", SqlDbType.BigInt) { Value = obj.ID },
               new SqlParameter("@Ten", SqlDbType.Char) { Value = obj.Ten }
               );
        }

        public async Task<int> Xoa(int ID)
        {
            return await ExecuteNonQuery(
                "XoaLop",
                new SqlParameter("@ID", SqlDbType.BigInt) { Value = ID }
                );
        }
    }
}
