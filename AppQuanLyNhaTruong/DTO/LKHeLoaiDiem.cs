using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LKHeLoaiDiem
    {
        public int IDHe { get; set; }
        public int IDLoai { get; set; }
        public LKHeLoaiDiem(int idhe, int idloai)
        {
            IDHe = idhe;
            IDLoai = idloai;
        }
        public LKHeLoaiDiem(DataRow dr)
        {
            IDHe = Convert.IsDBNull(dr["IDHe"]) ? -1 : Convert.ToInt32(dr["IDHe"]);
            IDLoai = Convert.IsDBNull(dr["IDLoai"]) ? -1 : Convert.ToInt32(dr["IDLoai"]);

        }
    }
}
