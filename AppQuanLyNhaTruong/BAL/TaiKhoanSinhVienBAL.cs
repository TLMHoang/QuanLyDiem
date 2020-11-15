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
    public class TaiKhoanSinhVienBAL : CInterface<TaiKhoanSinhVien>
    {
        TaiKhoanSinhVienDAL db = new TaiKhoanSinhVienDAL();
        public async Task<int> CapNhap(TaiKhoanSinhVien obj)
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

        public async Task<List<TaiKhoanSinhVien>> LayLst()
        {
            List<TaiKhoanSinhVien> lst = new List<TaiKhoanSinhVien>();

            foreach (DataRow dr in (await LayDT()).Rows)
            {
                lst.Add(new TaiKhoanSinhVien(dr));
            }

            return lst;
        }

        public async Task<int> Them(TaiKhoanSinhVien obj)
        {
            return await db.Them(obj);
        }

        public async Task<int> Xoa(int ID)
        {
            return await db.Xoa(ID);
        }
    }
}
