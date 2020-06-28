using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyMonAn.DAO
{
   public class ConnectionDataSQL
    {
        static string cnStr = "Server=DESKTOP-PAON0QI;Database=QuanLyMonAn;Trusted_Connection=True";
        public static SqlConnection ConnectionData()
        {
            //string cnStr = "Server=DESKTOP-PAON0QI;Database=QLTV;User Id =sa;Password=98vinhdz";
            SqlConnection cn = new SqlConnection(cnStr);
            cn.Open();
            return cn;
        }
        public static DataTable GetData(string sql)
        {
            //Tao ket noi
            SqlConnection conn = new SqlConnection(cnStr);

            //Bo chuyen doi du lieu
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, conn);
            //Bang chua du lieu
            DataTable dataTable = new DataTable();

            sqlDataAdapter.Fill(dataTable);

            return dataTable;
        }

        public static object ExecScalar(string sql)
        {
            SqlConnection con = new SqlConnection(cnStr);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = sql;
            object o = cmd.ExecuteScalar();
            con.Close();
            return o;
        }
    }
}
