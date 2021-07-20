using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceitasDAL
{
    public class UtilizadorDAL
    {
        public static void IncluirUtilizador(Utilizador utilizador)
        {
            using (var connection = new Connection2().Conection)
            {
                using (var command = new SqlCommand(
                    cmdText: "AddUser",
                    connection: connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command
                        .Parameters
                        .Add(new SqlParameter("@username", SqlDbType.VarChar));

                    command
                        .Parameters["@username"]
                        .Value = utilizador.Nome;

                    command
                        .Parameters
                        .Add(new SqlParameter("@email", SqlDbType.VarChar));

                    command
                        .Parameters["@email"]
                        .Value = utilizador.Email;

                    command
                        .Parameters
                        .Add(new SqlParameter("@password", SqlDbType.VarChar));

                    command
                        .Parameters["@password"]
                        .Value = utilizador.Password;

                    connection.Open();

                    command.ExecuteNonQuery();
                }
            }

        }
        public static void AlterarUtilizador(Utilizador utilizador)
        {
            using (var connection = new Connection2().Conection)
            {
                using (var command = new SqlCommand(
                    cmdText: "EditUser",
                    connection: connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command
                        .Parameters
                        .Add(new SqlParameter("@userid", SqlDbType.NVarChar));

                    command
                        .Parameters["@userid"]
                        .Value = utilizador.UserId;

                    command
                        .Parameters
                        .Add(new SqlParameter("@username", SqlDbType.VarChar));

                    command
                        .Parameters["@username"]
                        .Value = utilizador.Nome;

                    command
                        .Parameters
                        .Add(new SqlParameter("@email", SqlDbType.VarChar));

                    command
                        .Parameters["@email"]
                        .Value = utilizador.Email;

                    command
                        .Parameters
                        .Add(new SqlParameter("@password", SqlDbType.VarChar));

                    command
                        .Parameters["@password"]
                        .Value = utilizador.Password;

                    connection.Open();

                    command.ExecuteNonQuery();
                }
            }
        }
        public static void ExcluirUtilizador(string userid)
        {
            using (var connection = new Connection2().Conection)
            {
                using (var command = new SqlCommand(
                cmdText: "RemoveUser",
                connection: connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add(new SqlParameter("@userId", SqlDbType.NVarChar));
                    command.Parameters["@userId"].Value = userid;

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        public static Utilizador ListarUtilizadorPorId(string idUtilizador)
        {
            using (var conection = new Connection2().Conection)
            {
                var sql = "select " +
                    " Id, " +
                    " Username," +
                    " Email," +
                    " PasswordHash" +
                    " from AspNetUsers " +
                    " where Id = @userId";

                using (var command = new SqlCommand(
                    cmdText: sql,
                    connection: conection))
                {
                    command
                        .Parameters
                        .Add(new SqlParameter("@userID", SqlDbType.NVarChar, 0, "Id"));

                    command.Parameters["@userID"].Value = idUtilizador;

                    conection.Open();

                    using (var reader = command.ExecuteReader())
                    {
                        if (!reader.HasRows) return null;

                        reader.Read();
                        return new Utilizador
                        {
                            UserId = reader["Id"].ToString(),
                            Nome = reader["Username"].ToString(),
                            Email = reader["Email"].ToString(),
                            Password = reader["PasswordHash"].ToString(),
                        };

                    }

                }
            }
        }
        public  DataTable ListarTodosUtilizadores()
        {
            using (var connection =
                new Connection2().Conection)
            {
                var sql = "select " +
                    " Id, " +
                    " Username," +
                    " Email," +
                    " PasswordHash" +
                    " from AspNetUsers ";

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
