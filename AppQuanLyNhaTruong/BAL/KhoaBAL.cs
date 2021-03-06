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
    public class KhoaBAL : CInterface<Khoa>
    {
        KhoaDAL db = new KhoaDAL();
        public async Task<int> CapNhap(Khoa obj)
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

        public async Task<List<Khoa>> LayLst()
        {
            List<Khoa> lst = new List<Khoa>();

            foreach (DataRow dr in (await LayDT()).Rows)
            {
                lst.Add(new Khoa(dr));
            }

            return lst;
        }

        public async Task<int> Them(Khoa obj)
        {
            return await db.Them(obj);
        }

        public async Task<int> Xoa(int ID)
        {
            return await db.Xoa(ID);
        }
    }
}
