namespace DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("nxtckedu_H.NienKhoa")]
    public partial class NienKhoa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NienKhoa()
        {
            TaiKhoanSinhViens = new HashSet<TaiKhoanSinhVien>();
        }

        public int ID { get; set; }

        [StringLength(50)]
        public string Ten { get; set; }

        [StringLength(10)]
        public string ThoiGian { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TaiKhoanSinhVien> TaiKhoanSinhViens { get; set; }
         public NienKhoa(int iD, string ten)
        {
            ID = iD;
            Ten = ten;
            ThoiGian=ThoiGian;
        }

        public NienKhoa(DataRow dr)
        {
            ID = Convert.IsDBNull(dr["ID"]) ? -1 : Convert.ToInt32(dr["ID"]);
            Ten = dr["Ten"].ToString();
            ThoiGian=dr["ThoiGian"].ToString();
        }
    }
}
