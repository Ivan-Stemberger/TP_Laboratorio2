using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace TPFinal.ClassLibrary
{
    public static class Extension
    {
        public static SqlConnection connection(this SqlConnection connection)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Database=Games;Trusted_Connection=True;");
                       
            return conn;
        }
    }
}
