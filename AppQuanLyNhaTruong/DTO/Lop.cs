using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace DTO
{
    [Table("nxtckedu_H.Lop")]
    public partial class Lop
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Lop()
        {
            TaiKhoanSinhViens = new HashSet<TaiKhoanSinhVien>();
        }

        public int ID { get; set; }

        [StringLength(50)]
        public string Ten { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TaiKhoanSinhVien> TaiKhoanSinhViens { get; set; }
        public Lop(int iD, string ten)
        {
            ID = iD;
            Ten = ten;
        }

        public Lop(DataRow dr)
        {
            ID = Convert.IsDBNull(dr["ID"]) ? -1 : Convert.ToInt32(dr["ID"]);
            Ten = dr["Ten"].ToString();
        }
    }
}
