using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace PrintLabel
{
    public class clQuerySQL
    {
        public static  DataTable getData(string sqlQuery)
        {
            using (SqlConnection con = new SqlConnection(clConnection.connectSQL))
            {
                using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, con))
                {
                    using (DataTable dt = new DataTable())
                    {
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }
     

        public static void ExecuteQuery(string query)
        {
            using (SqlConnection con = new SqlConnection(clConnection.connectSQL))
            {

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.CommandType = CommandType.Text;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }
    }
}
