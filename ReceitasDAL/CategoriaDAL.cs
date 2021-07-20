using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceitasDAL
{
    public class CategoriaDAL
    {
        public DataTable ListarTodasCategorias()
        {
            using (var connection =
                new Connection2().Conection)
            {
                var sql = "select " +
                    " CategoriaId, " +
                    " Nome" +
                    " from Categorias ";

                using (var command = new SqlCommand(
                    cmdText: sql,
                    connection: connection))
                {
                    connection.Open();

                    using (var reader = command.ExecuteReader())
                    {
                        var dataTable = new DataTable();

                        dataTable.Load(reader);

                        return dataTable;
                    }
                }

            }

        }
    }
}
