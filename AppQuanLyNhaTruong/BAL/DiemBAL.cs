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
    public class DiemBAL : CInterface<Diem>
    {
        DiemDAL db = new DiemDAL();
        public async Task<int> CapNhap(Diem obj)
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

        public async Task<List<Diem>> LayLst()
        {
            List<Diem> lst = new List<Diem>();

            foreach (DataRow dr in (await LayDT()).Rows)
            {
                lst.Add(new Diem(dr));
            }

            return lst;
        }

        public async Task<int> Them(Diem obj)
        {
            return await db.Them(obj);
        }

        public async Task<int> Xoa(int ID)
        {
            return await db.Xoa(ID);
        }
    }
}
