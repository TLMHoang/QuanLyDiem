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
    public class ChucVuBAL : CInterface<ChucVu>
    {

        ChucVuDAL db = new ChucVuDAL();
        public async Task<int> CapNhap(ChucVu obj)
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

        public async Task<List<ChucVu>> LayLst()
        {
            List<ChucVu> lst = new List<ChucVu>();

            foreach (DataRow dr in (await LayDT()).Rows)
            {
                lst.Add(new ChucVu(dr));
            }

            return lst;
        }

        public async Task<int> Them(ChucVu obj)
        {
            return await db.Them(obj);
        }

        public async Task<int> Xoa(int ID)
        {
            return await db.Xoa(ID);
        }

        public async Task<bool> CheckAdmin(int IDChucVu)
        {
            List<ChucVu> lst = await LayLst();

            ChucVu res = lst.FirstOrDefault(p => p.Ten.Contains("admin"));

            return (res == null) ? false : true;
        }
    }
}
