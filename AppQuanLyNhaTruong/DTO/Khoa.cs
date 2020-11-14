namespace DTO
{
    using System;
    using System.Data;

    public partial class Khoa
    {
        public Khoa()
        {
        }

        public int ID { get; set; }
        public string Ten { get; set; }
        public Khoa(int iD, string ten)
        {
            ID = iD;
            Ten = ten;
        }
        public Khoa(DataRow dr)
        {
            ID = Convert.IsDBNull(dr["ID"]) ? -1 : Convert.ToInt32(dr["ID"]);
            Ten = dr["Ten"].ToString();
        }
    }
}
