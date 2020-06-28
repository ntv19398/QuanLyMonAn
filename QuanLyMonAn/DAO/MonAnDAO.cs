using System;
using QuanLyMonAn.DTO;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyMonAn.DAO
{

    class MonAnDAO
    {
        SqlConnection cn = ConnectionDataSQL.ConnectionData();
        SqlCommand cmd = new SqlCommand();
        public List<MonAnDTO> getAllMonAn()
        {
            string str = "select * from MONAN";
            List<MonAnDTO> list = new List<MonAnDTO>();
            //DataTable db = ConnectionDataSQL.GetData(str);
            cmd.Connection = cn;
            //cmd.Connection.Open();
            cmd.CommandText= str;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                MonAnDTO monan = new MonAnDTO();
                monan.MaMonAn = int.Parse(dr.GetValue(0).ToString());
                monan.TenMonAn = dr.GetValue(1).ToString();
                monan.NguyenLieu = dr.GetValue(2).ToString();
                monan.LinkYoutube = dr.GetValue(3).ToString();
                monan.LuotXem = int.Parse(dr.GetValue(4).ToString());
                monan.HinhAnh = dr.GetValue(5).ToString();

                list.Add(monan);
            }

            return list;
        }
    }
}
