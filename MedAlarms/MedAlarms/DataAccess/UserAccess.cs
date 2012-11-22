using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

namespace MedAlarms.DataAccess
{
    public class UserAccess
    {
        static SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["xiao198_capstone2012Context"].ToString());

        public static bool UserIsValid(string Email, string password)
        {
            bool authenticated = false;

            string query = string.Format("SELECT * FROM [user_info] WHERE user_email = '{0}' AND user_password = '{1}'", Email, password);

            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            authenticated = sdr.HasRows;
            conn.Close();
            return (authenticated);
        }
    }
}