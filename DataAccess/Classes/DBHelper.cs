using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAccess
{
    public class DBHelper
    {
        public DBHelper()
        {
            connection = new SqlConnection();
        }
        public SqlConnection connection { get; set; }
        public SqlDataReader DataReader { get; set; }
    }
}
