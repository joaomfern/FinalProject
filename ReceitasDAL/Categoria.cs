using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceitasDAL
{
    public class Categoria
    {
        public Categoria(int categoriaID, string nome)
        {
            CategoriaID = categoriaID;
            Nome = nome;
        }

        public int CategoriaID { get; }
        public string Nome { get; }
    }
}
