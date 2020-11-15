﻿using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class MonHocBAL : CInterface<MonHoc>
    {
        MonHocDAL db = new MonHocDAL();
        public async Task<int> CapNhap(MonHoc obj)
        {
            return await db.CapNhap(obj);
        }

        public async Task<DataTable> LayDT()
        {
            return await db.Lay();
        }

        public async Task<DataTable> LayID(int ID)
        {
            return await db.Lay(ID);
        }

        public async Task<List<MonHoc>> LayLst()
        {
            List<MonHoc> lst = new List<MonHoc>();

            foreach (DataRow dr in (await LayDT()).Rows)
            {
                lst.Add(new MonHoc(dr));
            }

            return lst;
        }

        public async Task<int> Them(MonHoc obj)
        {
            return await db.Them(obj);
        }

        public async Task<int> Xoa(int ID)
        {
            return await db.Xoa(ID);
        }
    }
}
