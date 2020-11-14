using System;
using System.Data;

namespace DTO
{
    public partial class Lop
    {
        public Lop()
        {
        }

        public int ID { get; set; }

        public string Ten { get; set; }

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
