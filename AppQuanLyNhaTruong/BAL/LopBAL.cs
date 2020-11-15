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
    public class LopBAL : CInterface<Lop>
    {
        LopDAL db = new LopDAL();
        public async Task<int> CapNhap(Lop obj)
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

        public async Task<List<Lop>> LayLst()
        {
            List<Lop> lst = new List<Lop>();

            foreach (DataRow dr in (await LayDT()).Rows)
            {
                lst.Add(new Lop(dr));
            }

            return lst;
        }

        public async Task<int> Them(Lop obj)
        {
            return await db.Them(obj);
        }

        public async Task<int> Xoa(int ID)
        {
            return await db.Xoa(ID);
        }
    }
}
