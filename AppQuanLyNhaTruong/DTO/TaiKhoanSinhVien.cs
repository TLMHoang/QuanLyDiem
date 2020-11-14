namespace DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("nxtckedu_H.TaiKhoanSinhVien")]
    public partial class TaiKhoanSinhVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TaiKhoanSinhVien()
        {
            Diems = new HashSet<Diem>();
        }

        public long ID { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        [StringLength(200)]
        public string Pass { get; set; }

        [StringLength(50)]
        public string TenSV { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NamSinh { get; set; }

        public bool? GioiTinh { get; set; }

        public int? IDLop { get; set; }

        public int? IDKhoa { get; set; }

        public int? IDNienKhoa { get; set; }

        [StringLength(11)]
        public string SDT { get; set; }

        [StringLength(50)]
        public string Mail { get; set; }

        [StringLength(100)]
        public string DiaChi { get; set; }

        [StringLength(100)]
        public string NoiSinh { get; set; }

        [StringLength(100)]
        public string HoKhau { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Diem> Diems { get; set; }

        public virtual Khoa Khoa { get; set; }

        public virtual Lop Lop { get; set; }

        public virtual NienKhoa NienKhoa { get; set; }
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
            TenGV = dr["TenGiaoVien"].ToString();
            GioiTinh = Convert.IsDBNull(dr["GioiTinh"]) ? -1 : Convert.ToBoolean(dr["GioiTinh"]);
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
