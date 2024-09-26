using System;
using System.Data.Common;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace BookingEnginePMS.Models
{
    public class DB
    {
        public static Func<DbConnection> ConnectionFactory = () => new SqlConnection(ConnectionString.Connection);
        public static class ConnectionString
        {
            public static string Connection = WebConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
        }
    }
}