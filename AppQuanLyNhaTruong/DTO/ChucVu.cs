using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChucVu
    {
        
        public int ID { get; set; }
        public string Ten { get; set; }

        public ChucVu()
        {
        }
        public ChucVu(int iD, string ten)
        {
            ID = iD;
            Ten = ten;
        }
        public ChucVu(DataRow dr)
        {
            ID = Convert.IsDBNull(dr["ID"]) ? -1 : Convert.ToInt32(dr["ID"]); ;
            Ten = dr["Ten"].ToString();
        }
    }
}
