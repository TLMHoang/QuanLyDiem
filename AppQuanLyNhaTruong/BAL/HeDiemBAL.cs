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
    public class HeDiemBAL : CInterface<HeDiem>
    {
        HeDiemDAL db = new HeDiemDAL();
        public async Task<int> CapNhap(HeDiem obj)
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

        public async Task<List<HeDiem>> LayLst()
        {
            List<HeDiem> lst = new List<HeDiem>();

            foreach (DataRow dr in (await LayDT()).Rows)
            {
                lst.Add(new HeDiem(dr));
            }

            return lst;
        }

        public async Task<int> Them(HeDiem obj)
        {
            return await db.Them(obj);
        }

        public async Task<int> Xoa(int ID)
        {
            return await db.Xoa(ID);
        }
    }
}
