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
   public class PhanCongMonBAL : CInterface<PhanCongMon>
    {
        PhanCongMonDAL db = new PhanCongMonDAL();
        public async Task<int> CapNhap(PhanCongMon obj)
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

        public async Task<List<PhanCongMon>> LayLst()
        {
            List<PhanCongMon> lst = new List<PhanCongMon>();

            foreach (DataRow dr in (await LayDT()).Rows)
            {
                lst.Add(new PhanCongMon(dr));
            }

            return lst;
        }

        public async Task<int> Them(PhanCongMon obj)
        {
            return await db.Them(obj);
        }

        public async Task<int> Xoa(int ID)
        {
            return await db.Xoa(ID);
        }
    }
}
