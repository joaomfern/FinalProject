using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceitasDAL
{
    public class ListaIngrediente
    {
        public ListaIngrediente(int receitaID, int incredienteID, string quantidade)
        {
            ReceitaID = receitaID;
            IncredienteID = incredienteID;
            Quantidade = quantidade;
        }

        public ListaIngrediente() { }

        public int ReceitaID { get; set; }
        public string Receita { get; set; }
        public int IncredienteID { get; set; }
        public string Ingrediente { get; set; }
        public string Quantidade { get; set; }
    }
}
