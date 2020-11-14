namespace DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data;
    using System.Data.Entity.Spatial;

    [Table("nxtckedu_H.Diem")]
    public partial class Diem
    {
        
        public long ID { get; set; }

        public long? IDSV { get; set; }

        public int? IDLoaiDiem { get; set; }

        public int? IDPhanCongDay { get; set; }

        [Column("Diem")]
        public double Diem1 { get; set; }

        public virtual LoaiDiem LoaiDiem { get; set; }

        public virtual PhanCongDay PhanCongDay { get; set; }

        public virtual TaiKhoanSinhVien TaiKhoanSinhVien { get; set; }

        public Diem()
        {
        }


        public Diem(long iD, long? iDSV, int? iDLoaiDiem, int? iDPhanCongDay, double diem1)
        {
            ID = iD;
            IDSV = iDSV;
            IDLoaiDiem = iDLoaiDiem;
            IDPhanCongDay = iDPhanCongDay;
            Diem1 = diem1;
        }

        public Diem(DataRow dr)
        {
            ID = Convert.IsDBNull(dr["ID"]) ? -1 : Convert.ToInt32(dr["ID"]);
            IDSV = Convert.IsDBNull(dr["IDSV"]) ? -1 : Convert.ToInt32(dr["IDSV"]);
            IDLoaiDiem = Convert.IsDBNull(dr["IDSV"]) ? -1 : Convert.ToInt32(dr["IDSV"]);
            IDPhanCongDay = Convert.IsDBNull(dr["IDSV"]) ? -1 : Convert.ToInt32(dr["IDSV"]);
            Diem1 = Convert.ToDouble(dr["Diem1"]);
        }
    }
}
