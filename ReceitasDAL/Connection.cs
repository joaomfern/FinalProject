using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceitasDAL
{
    public class Connection
    {
        public Connection()
        {
            Conection = new SqlConnection(@"Data Source=DESKTOP-0K55P8O; Initial Catalog=ReceitasDB; Integrated Security=True");
        }

        public SqlConnection Conection { get; }
    }

    public class Connection2
    {
        public Connection2()
        {
            Conection = new SqlConnection(@"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=aspnet-ReceitasWeb-20201124082510;Integrated Security=True");
        }

        public SqlConnection Conection { get; }
    }
}
