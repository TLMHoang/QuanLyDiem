namespace DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("nxtckedu_H.TaiKhoanTruong")]
    public partial class TaiKhoanTruong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TaiKhoanTruong()
        {
            PhanCongMons = new HashSet<PhanCongMon>();
        }

        public long ID { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        [StringLength(200)]
        public string Pass { get; set; }

        [StringLength(50)]
        public string TenGV { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NamSinh { get; set; }

        public bool? GioiTinh { get; set; }

        [StringLength(11)]
        public string SDT { get; set; }

        [StringLength(50)]
        public string Mail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhanCongMon> PhanCongMons { get; set; }
        public TaiKhoanTruong(int iD, string username,string tengv,string gioitinh,string sdt,string mail)
        {
            ID = iD;
            UserName=username;
            TenGV=tengv;
            GioiTinh=gioitinh;
            SDT=sdt;
            Mail=mail;
        }

        public TaiKhoanTruong(DataRow dr)
        {
            ID = Convert.IsDBNull(dr["ID"]) ? -1 : Convert.ToInt32(dr["ID"]);
            UserName = dr["UserName"].ToString();
            TenGV = dr["TenGV"].ToString();
            GioiTinh = dr["GioiTinh"].ToString();
            SDT = dr["SDT"].ToString();
            Mail = dr["Mail"].ToString();
        }
    }
}
