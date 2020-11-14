namespace DTO
{
    using System;
    using System.Data;

    public partial class HocKy
    {
        public HocKy()
        {
        }

        public int ID { get; set; }

        public string Ten { get; set; }

        public HocKy(int iD, string ten)
        {
            ID = iD;
            Ten = ten;
        }
        public HocKy(DataRow dr)
        {
            ID = Convert.IsDBNull(dr["ID"]) ? -1 : Convert.ToInt32(dr["ID"]);
            Ten = dr["Ten"].ToString();
        }
    }
}
