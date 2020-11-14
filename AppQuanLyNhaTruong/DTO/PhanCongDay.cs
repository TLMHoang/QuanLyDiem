namespace DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("nxtckedu_H.PhanCongDay")]
    public partial class PhanCongDay
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PhanCongDay()
        {
            Diems = new HashSet<Diem>();
        }

        public int ID { get; set; }

        public int? IDPhanCongMon { get; set; }

        public int? IDHK { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Diem> Diems { get; set; }

        public virtual HocKy HocKy { get; set; }

        public virtual PhanCongMon PhanCongMon { get; set; }
         public PhanCongDay(int iD)
        {
            ID = iD;
            IDPhanCongMon=iD;
            IDHK=iD;
        }

        public PhanCongDay(DataRow dr)
        {
            ID = Convert.IsDBNull(dr["ID"]) ? -1 : Convert.ToInt32(dr["ID"]);
            IDPhanCongMon= Convert.IsDBNull(dr["ID"]) ? -1 : Convert.ToInt32(dr["ID"]);
            IDHK= Convert.IsDBNull(dr["ID"]) ? -1 : Convert.ToInt32(dr["ID"]);
        }
    }
}
