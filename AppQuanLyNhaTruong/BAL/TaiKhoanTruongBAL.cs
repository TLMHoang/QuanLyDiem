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
    public class TaiKhoanTruongBAL : CInterface<TaiKhoanTruong>
    {
        TaiKhoanTruongDAL db = new TaiKhoanTruongDAL();
        public async Task<int> CapNhap(TaiKhoanTruong obj)
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

        public async Task<List<TaiKhoanTruong>> LayLst()
        {
            List<TaiKhoanTruong> lst = new List<TaiKhoanTruong>();

            foreach (DataRow dr in (await LayDT()).Rows)
            {
                lst.Add(new TaiKhoanTruong(dr));
            }

            return lst;
        }

        public async Task<int> Them(TaiKhoanTruong obj)
        {
            return await db.Them(obj);
        }

        public async Task<int> Xoa(int ID)
        {
            return await db.Xoa(ID);
        }
    }
}
