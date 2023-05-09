using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DatabaseConnection
    {
        public static SqlConnection connectDBFunc()
        {
            string connectionString = "Data Source = LAPTOP-VERULPGO\\SQLEXPRESS; Initial Catalog = haidilao; Integrated Security = True";
            return new SqlConnection(connectionString);
        }
    }
}
