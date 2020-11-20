namespace DTO
{
    using System;
    using System.Data;

    public partial class TaiKhoanTruong
    {
        public TaiKhoanTruong()
        {
        }

        public long ID { get; set; }

        public string UserName { get; set; }

        public string Pass { get; set; }

        public string TenGV { get; set; }

        public DateTime? NamSinh { get; set; }

        public bool? GioiTinh { get; set; }

        public string SDT { get; set; }

        public string Mail { get; set; }

        public int IDChucVu { get; set; }
        public object Rows { get; set; }

        public TaiKhoanTruong(int iD, string username,string tengv,bool gioitinh,string sdt,string mail, int iDChucVu)
        {
            ID = iD;
            UserName=username;
            TenGV=tengv;
            GioiTinh=gioitinh;
            SDT=sdt;
            Mail=mail;
            IDChucVu = iDChucVu;

        }

        public TaiKhoanTruong(DataRow dr)
        {
                ID = Convert.IsDBNull(dr["ID"]) ? -1 : Convert.ToInt32(dr["ID"]);
            UserName = dr["UserName"].ToString();
            TenGV = dr["TenGV"].ToString();
            GioiTinh = Convert.ToBoolean(dr["GioiTinh"]);
            SDT = dr["SDT"].ToString();
            Mail = dr["Mail"].ToString();
            IDChucVu = Convert.IsDBNull(dr["IDChucVu"]) ? -1 : Convert.ToInt32(dr["IDChucVu"]);
        }
    }
}
