using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BAL
{
    public class HocKyBAL : CInterface<HocKy>
    {
        HocKyDAL db = new HocKyDAL();
        public async Task<int> CapNhap(HocKy obj)
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

        public async Task<List<HocKy>> LayLst()
        {
            List<HocKy> lst = new List<HocKy>();

            foreach (DataRow dr in (await LayDT()).Rows)
            {
                lst.Add(new HocKy(dr));
            }

            return lst;
        }

        public async Task<int> Them(HocKy obj)
        {
            return await db.Them(obj);
        }

        public async Task<int> Xoa(int ID)
        {
            return await db.Xoa(ID);
        }
    }
}
