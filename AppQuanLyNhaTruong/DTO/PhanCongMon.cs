namespace DTO
{
    using System;
    using System.Data;

    public partial class PhanCongMon
    {
        public PhanCongMon()
        {
        }

        public int ID { get; set; }

        public long? IDGV { get; set; }

        public int? IDMon { get; set; }


        public PhanCongMon(int iD)
        {
            ID = iD;
            IDGV=iD;
            IDMon=iD;
        }

        public PhanCongMon(DataRow dr)
        {
            ID = Convert.IsDBNull(dr["ID"]) ? -1 : Convert.ToInt32(dr["ID"]);
            IDGV = Convert.IsDBNull(dr["ID"]) ? -1 : Convert.ToInt32(dr["ID"]);
            IDMon = Convert.IsDBNull(dr["ID"]) ? -1 : Convert.ToInt32(dr["ID"]);
        }
    }
}
