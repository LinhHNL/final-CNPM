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
<<<<<<< HEAD
            string connectionString = "Data Source = LING; Initial Catalog = haidilao; Integrated Security = True";
=======
            string connectionString = "Data Source = LAPTOP-VERULPGO\\SQLEXPRESS; Initial Catalog = haidilao; Integrated Security = True";
>>>>>>> 8d249ced943f806d153ec3e35ac6189216f94312
            return new SqlConnection(connectionString);
        }
    }
}
