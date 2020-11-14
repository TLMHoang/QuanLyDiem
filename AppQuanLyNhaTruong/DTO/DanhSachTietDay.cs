using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DanhSachTietDay
    {
        public int IDPhanCongDay { get; set; }
        public long? IDSV { get; set; }
        public DanhSachTietDay(int idphancongday, long idsv)
        {
            IDPhanCongDay = idphancongday;
            IDSV = idsv;
        }
        public DanhSachTietDay(DataRow dr)
        {
            IDPhanCongDay = Convert.IsDBNull(dr["IDPhanCongDay"]) ? -1 : Convert.ToInt32(dr["IDPhanCongDay"]);
            IDSV = Convert.IsDBNull(dr["IDSV"]) ? -1 : Convert.ToInt64(dr["IDSV"]);
        }
    }
}
