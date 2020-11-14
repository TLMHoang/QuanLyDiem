namespace DTO
{
    using System;
    using System.Data;

    public partial class NienKhoa
    {
        public NienKhoa()
        {
        }

        public int ID { get; set; }
        public string Ten { get; set; }

        public string ThoiGian { get; set; }

         public NienKhoa(int iD, string ten)
        {
            ID = iD;
            Ten = ten;
            ThoiGian=ThoiGian;
        }

        public NienKhoa(DataRow dr)
        {
            ID = Convert.IsDBNull(dr["ID"]) ? -1 : Convert.ToInt32(dr["ID"]);
            Ten = dr["Ten"].ToString();
            ThoiGian=dr["ThoiGian"].ToString();
        }
    }
}
