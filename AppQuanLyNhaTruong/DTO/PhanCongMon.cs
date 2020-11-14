namespace DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("nxtckedu_H.PhanCongMon")]
    public partial class PhanCongMon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PhanCongMon()
        {
            PhanCongDays = new HashSet<PhanCongDay>();
        }

        public int ID { get; set; }

        public long? IDGV { get; set; }

        public int? IDMon { get; set; }

        public virtual MonHoc MonHoc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhanCongDay> PhanCongDays { get; set; }

        public virtual TaiKhoanTruong TaiKhoanTruong { get; set; }
        public HeDiem(int iD)
        {
            ID = iD;
            IDGV=iD;
            IDMon=iD;
        }

        public HeDiem(DataRow dr)
        {
            ID = Convert.IsDBNull(dr["ID"]) ? -1 : Convert.ToInt32(dr["ID"]);
            IDGV = Convert.IsDBNull(dr["ID"]) ? -1 : Convert.ToInt32(dr["ID"]);
            IDMon = Convert.IsDBNull(dr["ID"]) ? -1 : Convert.ToInt32(dr["ID"]);
        }
    }
}
