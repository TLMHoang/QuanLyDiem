namespace DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data;
    using System.Data.Entity.Spatial;

    [Table("nxtckedu_H.MonHoc")]
    public partial class MonHoc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MonHoc()
        {
            PhanCongMons = new HashSet<PhanCongMon>();
        }

        public int ID { get; set; }

        [StringLength(50)]
        public string Ten { get; set; }

        public int? IDHeDiem { get; set; }

        public virtual HeDiem HeDiem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhanCongMon> PhanCongMons { get; set; }
        public MonHoc(int iD, string ten)
        {
            ID = iD;
            Ten = ten;
            IDHeDiem = iD;
            HeDiem = HeDiem;
        }

        public MonHoc(DataRow dr)
        {
            ID = Convert.IsDBNull(dr["ID"]) ? -1 : Convert.ToInt32(dr["ID"]);
            Ten = dr["Ten"].ToString();

        }

    }
}
