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
    public class LKHeLoaiDiemBAL : CInterface<LKHeLoaiDiem>
    {
        LKHeLoaiDiemDAL db = new LKHeLoaiDiemDAL();
        public async Task<int> CapNhap(LKHeLoaiDiem obj)
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

        public async Task<List<LKHeLoaiDiem>> LayLst()
        {
            List<LKHeLoaiDiem> lst = new List<LKHeLoaiDiem>();

            foreach (DataRow dr in (await LayDT()).Rows)
            {
                lst.Add(new LKHeLoaiDiem(dr));
            }

            return lst;
        }

        public async Task<int> Them(LKHeLoaiDiem obj)
        {
            return await db.Them(obj);
        }

        public async Task<int> Xoa(int ID)
        {
            return await db.Xoa(ID);
        }
    }
}
