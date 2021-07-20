using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceitasDAL
{
    public class ReceitaDAL
    {
        public static void IncluirReceita(Receita receita)
        {
            using (var connection = new Connection2().Conection)
            {
                using (var command = new SqlCommand(
                cmdText: "AddReceita",
                connection: connection))
                {

                    command.CommandType = CommandType.StoredProcedure;

                    command
                        .Parameters
                        .Add(new SqlParameter("@nome", SqlDbType.VarChar));

                    command
                        .Parameters["@nome"]
                        .Value = receita.Nome;

                    command
                        .Parameters
                        .Add(new SqlParameter("@modopreparacao", SqlDbType.VarChar));

                    command
                        .Parameters["@modopreparacao"]
                        .Value = receita.ModoPreparacao;

                    command
                        .Parameters
                        .Add(new SqlParameter("@duracao", SqlDbType.Int));

                    command
                        .Parameters["@duracao"]
                        .Value = receita.Duracao;


                    command
                        .Parameters
                        .Add(new SqlParameter("@dificuldade", SqlDbType.VarChar));

                    command
                        .Parameters["@dificuldade"]
                        .Value = receita.Dificuldade;

                    command
                        .Parameters
                        .Add(new SqlParameter("@userid", SqlDbType.NVarChar));

                    command
                        .Parameters["@userid"]
                        .Value = receita.UserID;

                    command
                        .Parameters
                        .Add(new SqlParameter("@categoriaID", SqlDbType.Int));

                    command
                        .Parameters["@categoriaID"]
                        .Value = receita.CategoriaID;
                    
                    command
                        .Parameters
                        .Add(new SqlParameter("@imageurl", SqlDbType.NVarChar));

                    command
                        .Parameters["@imageurl"]
                        .Value = receita.ImageUrl;


                    connection.Open();

                    command.ExecuteNonQuery();
                }
            }
        }

        public static void AlterarReceita(Receita receita)
        {
            using (var connection = new Connection2().Conection)
            {
                using (var command = new SqlCommand(
                    cmdText: "EditReceita",
                    connection: connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command
                        .Parameters
                        .Add(new SqlParameter("@receitaID", SqlDbType.Int));

                    command
                        .Parameters["@receitaID"]
                        .Value = receita.ReceitaID;

                    command
                        .Parameters
                        .Add(new SqlParameter("@nome", SqlDbType.VarChar));

                    command
                        .Parameters["@nome"]
                        .Value = receita.Nome;

                    command
                        .Parameters
                        .Add(new SqlParameter("@modopreparacao", SqlDbType.VarChar));

                    command
                        .Parameters["@modopreparacao"]
                        .Value = receita.ModoPreparacao;

                    command
                        .Parameters
                        .Add(new SqlParameter("@duracao", SqlDbType.Int));

                    command
                        .Parameters["@duracao"]
                        .Value = receita.Duracao;

                    command
                        .Parameters
                        .Add(new SqlParameter("@dificuldade", SqlDbType.VarChar));

                    command
                        .Parameters["@dificuldade"]
                        .Value = receita.Dificuldade;

                    command
                        .Parameters
                        .Add(new SqlParameter("@userid", SqlDbType.NVarChar));

                    command
                        .Parameters["@userid"]
                        .Value = receita.UserID;

                    command
                        .Parameters
                        .Add(new SqlParameter("@categoriaID", SqlDbType.Int));

                    command
                        .Parameters["@categoriaID"]
                        .Value = receita.CategoriaID;

                    command
                        .Parameters
                        .Add(new SqlParameter("@imageurl", SqlDbType.NVarChar));

                    command
                        .Parameters["@imageurl"]
                        .Value = receita.ImageUrl;



                    connection.Open();

                    command.ExecuteNonQuery();
                }
            }
        }

        public static void ExcluirReceita(int receitaid)
        {
            using (var connection = new Connection2().Conection)
            {
                using (var command = new SqlCommand(
                cmdText: "RemoveReceita",
                connection: connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add(new SqlParameter("@receitaid", SqlDbType.Int));
                    command.Parameters["@receitaid"].Value = receitaid;

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        public DataTable ListarTodasReceitas()
        {
            using (var connection =
                new Connection2().Conection)
            {
                var sql = "select " +
                    " ReceitaID, " +
                    " Nome" +
                    " from Receitas ";

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
        public DataTable ListarReceitaIngredientes()
        {
            using (var connection =
                new Connection2().Conection)
            {
                var sql = "select " +
                    " NomeReceita, " +
                    " Ingrediente, " +
                    " Quantidade" +
                    " from ReceitasDetalheIngredientes ";

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

        public DataTable ListarTodasReceitasDetalhadas()
        {
            using (var connection =
                new Connection2().Conection)
            {
                var sql = "select " +
                    " ReceitaID, " +
                    " NomeReceita [Nome da Receita], " +
                    " ModoPreparacao [Modo Preparação], " +
                    " Duracao [Duração (em Minutos)]," +
                    " Dificuldade," +
                    " UserName [Autor da Receita]," +
                    " Categoria" +
                    " from ReceitasGeral ";

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

        public static Receita ListarReceitaPorID(int receitaID)
        {
            using (var connection =
                new Connection2().Conection)
            {
                var sql = "select " +
                    " ReceitaID, " +
                    " r.Nome Nome, " +
                    " ModoPreparacao, " +
                    " Duracao," +
                    " Dificuldade," +
                    " u.UserName Autor," +
                    " c.nome Categoria," +
                    " ImageUrl" +
                    " from Receitas r" +
                    " inner join Categorias c on c.CategoriaID=r.CategoriaID" +
                    " inner join AspNetUsers u on u.Id = r.UserID" +
                    " where ReceitaID = @ReceitaID"
                    ;

                using (var command = new SqlCommand(
                    cmdText: sql,
                    connection: connection))
                {
                    command
                    .Parameters
                    .Add(new SqlParameter("@ReceitaID", SqlDbType.Int, 0, "ReceitaID"));

                    command.Parameters["@ReceitaID"].Value = receitaID;
                    connection.Open();

                    using (var reader = command.ExecuteReader())
                    {
                        if (!reader.HasRows) return null;

                        reader.Read();
                        return new Receita
                        {
                            Nome = reader["Nome"].ToString(),
                            ModoPreparacao = reader["ModoPreparacao"].ToString(),
                            Duracao = int.Parse(reader["Duracao"].ToString()),
                            Dificuldade = reader["Dificuldade"].ToString(),
                            User = reader["Autor"].ToString(),
                            Categoria = reader["Categoria"].ToString(),
                            ImageUrl = reader["ImageUrl"].ToString(),
                        };
                    }

                }

            }
        }
    }
}
