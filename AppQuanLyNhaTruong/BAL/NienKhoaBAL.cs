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
    public class NienKhoaBAL : CInterface<NienKhoa>
    {
        NienKhoaDAL db = new NienKhoaDAL();
        public async Task<int> CapNhap(NienKhoa obj)
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

        public async Task<List<NienKhoa>> LayLst()
        {
            List<NienKhoa> lst = new List<NienKhoa>();

            foreach (DataRow dr in (await LayDT()).Rows)
            {
                lst.Add(new NienKhoa(dr));
            }

            return lst;
        }

        public async Task<int> Them(NienKhoa obj)
        {
            return await db.Them(obj);
        }

        public async Task<int> Xoa(int ID)
        {
            return await db.Xoa(ID);
        }
    }
}
