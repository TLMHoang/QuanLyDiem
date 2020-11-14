using System;
using System.Data;

namespace DTO
{
    public partial class TaiKhoanSinhVien
    {
        public TaiKhoanSinhVien()
        {
        }

        public long ID { get; set; }

        public string UserName { get; set; }

        public string Pass { get; set; }

        public string TenSV { get; set; }

        public DateTime? NamSinh { get; set; }

        public bool? GioiTinh { get; set; }

        public int? IDLop { get; set; }

        public int? IDKhoa { get; set; }

        public int? IDNienKhoa { get; set; }

        public string SDT { get; set; }

        public string Mail { get; set; }

        public string DiaChi { get; set; }

        public string NoiSinh { get; set; }

        public string HoKhau { get; set; }

        public TaiKhoanSinhVien(int iD, string username,string pass,string tensv,bool gioitinh,int idLop,int idKhoa,int idNienKhoa,string sdt,string mail,string diachi,string noisinh,string hokhau)
        {
            ID = iD;
            UserName = username;
            Pass=pass;
            TenSV=tensv;
            GioiTinh=gioitinh;
            IDLop=idLop;
            IDKhoa=idKhoa;
            IDNienKhoa=idNienKhoa;
            SDT=sdt;
            Mail=mail;
            DiaChi=diachi;
            NoiSinh=noisinh;
            HoKhau=hokhau;
        }

        public TaiKhoanSinhVien(DataRow dr)
        {
            ID = Convert.IsDBNull(dr["ID"]) ? -1 : Convert.ToInt32(dr["ID"]);
            UserName = dr["UserName"].ToString();
            Pass = dr["Pass"].ToString();
            TenSV = dr["TenSinhVien"].ToString();
            GioiTinh = Convert.ToBoolean(dr["GioiTinh"]);
            IDLop = Convert.IsDBNull(dr["IDLop"]) ? -1 : Convert.ToInt32(dr["IDLop"]);
            IDKhoa = Convert.IsDBNull(dr["IDKhoa"]) ? -1 : Convert.ToInt32(dr["IDKhoa"]);
            IDNienKhoa = Convert.IsDBNull(dr["IDNienKhoa"]) ? -1 : Convert.ToInt32(dr["IDNienKhoa"]);       
            SDT=dr["SDT"].ToString();
            Mail=dr["Mail"].ToString();
            DiaChi=dr["DiaChi"].ToString();
            NoiSinh=dr["NoiSinh"].ToString();
            HoKhau=dr["HoKhau"].ToString();
        }
    }
}
