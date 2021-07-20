using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceitasDAL
{
    public class Receita
    {
        public Receita(string nome, string modoPreparacao, int duracao, string dificuldade, string userID, int categoriaID, string imageurl)
        {
            Nome = nome;
            ModoPreparacao = modoPreparacao;
            Duracao = duracao;
            Dificuldade = dificuldade;
            UserID = userID;
            CategoriaID = categoriaID;
            ImageUrl = imageurl;
        }

        public Receita(int receitaId, string nome, string modoPreparacao, int duracao, string dificuldade, string userID, int categoriaID, string imageurl)
        {
            ReceitaID = receitaId;
            Nome = nome;
            ModoPreparacao = modoPreparacao;
            Duracao = duracao;
            Dificuldade = dificuldade;
            UserID = userID;
            CategoriaID = categoriaID;
            ImageUrl = imageurl;
        }

        public Receita() { }

        public string Nome { get; set; }
        public string ModoPreparacao { get; set; }
        public int Duracao { get; set; }
        public string Dificuldade { get; set; }
        public string UserID { get; set; }
        public string User { get; set; }
        public int CategoriaID { get; set; }
        public string Categoria { get; set; }
        public int ReceitaID { get; set; }
        public string ImageUrl { get; set; }
    }
}
