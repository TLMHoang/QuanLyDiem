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
    public class LoaiDiemBAL : CInterface<LoaiDiem>
    {
        LoaiDiemDAL db = new LoaiDiemDAL();
        public async Task<int> CapNhap(LoaiDiem obj)
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

        public async Task<List<LoaiDiem>> LayLst()
        {
            List<LoaiDiem> lst = new List<LoaiDiem>();

            foreach (DataRow dr in (await LayDT()).Rows)
            {
                lst.Add(new LoaiDiem(dr));
            }

            return lst;
        }

        public async Task<int> Them(LoaiDiem obj)
        {
            return await db.Them(obj);
        }

        public async Task<int> Xoa(int ID)
        {
            return await db.Xoa(ID);
        }
    }
}
