using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace DTO
{
    public partial class HeDiem
    {
        public int ID { get; set; }

        public string Ten { get; set; }


        public HeDiem()
        {
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
