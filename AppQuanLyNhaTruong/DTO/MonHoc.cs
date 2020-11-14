namespace DTO
{
    using System;
    using System.Data;

    public partial class MonHoc
    {
        public MonHoc()
        {
        }

        public int ID { get; set; }

        public string Ten { get; set; }

        public int? IDHeDiem { get; set; }

        public MonHoc(int iD, string ten)
        {
            ID = iD;
            Ten = ten;
            IDHeDiem = iD;
        }

        public MonHoc(DataRow dr)
        {
            ID = Convert.IsDBNull(dr["ID"]) ? -1 : Convert.ToInt32(dr["ID"]);
            Ten = dr["Ten"].ToString();
            IDHeDiem=Convert.IsDBNull(dr["ID"]) ? -1 : Convert.ToInt32(dr["ID"]);
        }

    }
}
