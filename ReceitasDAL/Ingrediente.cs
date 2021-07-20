using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceitasDAL
{
    public class Ingrediente
    {
        public Ingrediente( string nome, string userID, string descricao)
        {
            Nome = nome;
            UserID = userID;
            Descricao = descricao;
        }

        public int IngredienteID { get; }
        public string Nome { get; }
        public string UserID { get; }
        public string Descricao { get; }
    }
}
