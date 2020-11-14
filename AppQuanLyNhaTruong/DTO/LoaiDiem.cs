using System;
using System.Data;

namespace DTO
{
    public partial class LoaiDiem
    {
        public LoaiDiem()
        {
        }

        public int ID { get; set; }

        public string Ten { get; set; }

        public double? HeSo { get; set; }

        
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
