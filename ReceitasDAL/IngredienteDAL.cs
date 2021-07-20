using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceitasDAL
{
    public class IngredienteDAL
    {
        public static void IncluirIngrediente(Ingrediente ingrediente)
        {
            using (var connection = new Connection2().Conection)
            {
                using (var command = new SqlCommand(
                cmdText: "AddIngrediente",
                connection: connection))
                {

                    command.CommandType = CommandType.StoredProcedure;

                    command
                        .Parameters
                        .Add(new SqlParameter("@nome", SqlDbType.VarChar));

                    command
                        .Parameters["@nome"]
                        .Value = ingrediente.Nome;

                    command
                        .Parameters
                        .Add(new SqlParameter("@userid", SqlDbType.NVarChar));

                    command
                        .Parameters["@userid"]
                        .Value = ingrediente.UserID;

                    command
                        .Parameters
                        .Add(new SqlParameter("@descricao", SqlDbType.VarChar));

                    command
                        .Parameters["@descricao"]
                        .Value = ingrediente.Descricao;


                    connection.Open();

                    command.ExecuteNonQuery();
                }
            }
        }


        public DataTable ListarTodosIngredientes()
        {
            using (var connection =
                new Connection2().Conection)
            {
                var sql = "select " +
                    " IngredienteId, " +
                    " Nome," +
                    " Descricao Descrição" +
                    " from Ingredientes ";

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
