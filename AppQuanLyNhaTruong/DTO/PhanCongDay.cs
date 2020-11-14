namespace DTO
{
    using System;
    using System.Data;


    public partial class PhanCongDay
    {
        public PhanCongDay()
        {
        }

        public int ID { get; set; }

        public int? IDPhanCongMon { get; set; }

        public int? IDHK { get; set; }

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
