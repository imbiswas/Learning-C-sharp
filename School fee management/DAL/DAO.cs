using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class DAO
    {
        public static string connectionstr = "Data Source=SOFTECH;Initial Catalog=FeeManagementSystem; User ID=sa; Password=123;";
        public static SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection(connectionstr);
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            return con;
        }
        public static int IUD(string sql, SqlParameter[] param, CommandType cmdtype)
        {
            using (SqlConnection con = GetConnection())
            {
                using(SqlCommand cmd=new SqlCommand(sql, con))
                {
                    cmd.CommandType = cmdtype;
                    if (param != null)
                    {
                        cmd.Parameters.AddRange(param);
                    }
                    return cmd.ExecuteNonQuery();
                }
            }
        }
        public static DataTable GetDatatable(string sql, SqlParameter[] param)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    if (param != null)
                    {
                        cmd.Parameters.AddRange(param);
                    
                    }
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    return dt;
                }
            }
        }
    }
}
