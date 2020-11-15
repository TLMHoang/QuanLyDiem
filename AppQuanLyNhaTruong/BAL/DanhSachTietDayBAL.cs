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
    public class DanhSachTietDayBAL : CInterface<DanhSachTietDay>
    {
        DanhSachTietDayDAL db = new DanhSachTietDayDAL();
        public async Task<int> CapNhap(DanhSachTietDay obj)
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

        public async Task<List<DanhSachTietDay>> LayLst()
        {
            List<DanhSachTietDay> lst = new List<DanhSachTietDay>();

            foreach (DataRow dr in (await LayDT()).Rows)
            {
                lst.Add(new DanhSachTietDay(dr));
            }

            return lst;
        }

        public async Task<int> Them(DanhSachTietDay obj)
        {
            return await db.Them(obj);
        }

        public async Task<int> Xoa(int ID)
        {
            return await db.Xoa(ID);
        }
    }
}
