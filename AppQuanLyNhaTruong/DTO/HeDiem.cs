using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace DTO
{
    [Table("nxtckedu_H.HeDiem")]
    public partial class HeDiem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        

        public int ID { get; set; }

        [StringLength(50)]
        public string Ten { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MonHoc> MonHocs { get; set; }


        public HeDiem()
        {
            MonHocs = new HashSet<MonHoc>();
        }

        public HeDiem(int iD, string ten)
        {
            ID = iD;
            Ten = ten;
        }

        public HeDiem(DataRow dr)
        {
            ID = Convert.IsDBNull(dr["ID"]) ? -1 : Convert.ToInt32(dr["ID"]);
            Ten = dr["Ten"].ToString();
        }
    }
}
