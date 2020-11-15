using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
   public class PhanCongDayBAL : CInterface<PhanCongDay>
    {
        PhanCongDayDAL db = new PhanCongDayDAL();
        public async Task<int> CapNhap(PhanCongDay obj)
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

        public async Task<List<PhanCongDay>> LayLst()
        {
            List<PhanCongDay> lst = new List<PhanCongDay>();

            foreach (DataRow dr in (await LayDT()).Rows)
            {
                lst.Add(new PhanCongDay(dr));
            }

            return lst;
        }

        public async Task<int> Them(PhanCongDay obj)
        {
            return await db.Them(obj);
        }

        public async Task<int> Xoa(int ID)
        {
            return await db.Xoa(ID);
        }
    }
}
