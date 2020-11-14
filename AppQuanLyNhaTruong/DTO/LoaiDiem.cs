namespace DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data;
    using System.Data.Entity.Spatial;

    [Table("nxtckedu_H.LoaiDiem")]
    public partial class LoaiDiem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LoaiDiem()
        {
            Diems = new HashSet<Diem>();
        }

        public int ID { get; set; }

        [StringLength(50)]
        public string Ten { get; set; }

        public double? HeSo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Diem> Diems { get; set; }
        
        public LoaiDiem(int iD, string ten)
        {
            ID = iD;
            Ten = ten;
            HeSo = HeSo;
        }
        public LoaiDiem(DataRow dr)
        {
            ID = Convert.IsDBNull(dr["ID"]) ? -1 : Convert.ToInt32(dr["ID"]);
            Ten = dr["Ten"].ToString();
            HeSo = Convert.IsDBNull(dr["ID"]) ? -1 : Convert.ToDouble(dr["ID"]);
        }
       
    }
}
