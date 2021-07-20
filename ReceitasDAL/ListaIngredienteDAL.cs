using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceitasDAL
{
    public class ListaIngredienteDAL
    {
        public static void IncluirListaIngrediente(ListaIngrediente listaIngrediente)
        {
            using (var connection = new Connection2().Conection)
            {
                using (var command = new SqlCommand(
                cmdText: "CreateListaIngrediente",
                connection: connection))
                {

                    command.CommandType = CommandType.StoredProcedure;

                    command
                        .Parameters
                        .Add(new SqlParameter("@receitaid", SqlDbType.Int));

                    command
                        .Parameters["@receitaid"]
                        .Value = listaIngrediente.ReceitaID;

                    command
                        .Parameters
                        .Add(new SqlParameter("@igredienteid", SqlDbType.Int));

                    command
                        .Parameters["@igredienteid"]
                        .Value = listaIngrediente.IncredienteID;

                    command
                        .Parameters
                        .Add(new SqlParameter("@quantidade", SqlDbType.NVarChar));

                    command
                        .Parameters["@quantidade"]
                        .Value = listaIngrediente.Quantidade;
                   


                    connection.Open();

                    command.ExecuteNonQuery();
                }
            }
        }
        public DataTable ListarIngredientesPorReceitaID(int receitaID)
        {
            using (var connection =
                new Connection2().Conection)
            {
                var sql = "select " +
                    " r.ReceitaID, " +
                    " r.Nome [Nome da Receita], " +
                    " i.Nome [Ingrediente], " +
                    " Quantidade" +
                    " FROM ListaIngredientes li" +
                    " inner join Ingredientes i on i.IngredienteID=li.IngredienteID" +
                    " inner join Receitas r on r.ReceitaID=li.ReceitaID" +
                    " where r.ReceitaID = @ReceitaID"
                    ;

                using (var command = new SqlCommand(
                    cmdText: sql,
                    connection: connection))
                {
                    command
                    .Parameters
                    .Add(new SqlParameter("@ReceitaID", SqlDbType.Int, 0, "r.ReceitaID"));

                    command.Parameters["@ReceitaID"].Value = receitaID;
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

