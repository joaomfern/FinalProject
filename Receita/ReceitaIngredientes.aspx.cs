using ReceitasDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReceitasWeb.Receita
{
    public partial class ReceitaIngredientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var ingredientes = new IngredienteDAL();

                Ingrediente.DataSource = ingredientes.ListarTodosIngredientes();
                Ingrediente.DataTextField = "Nome";
                Ingrediente.DataValueField = "IngredienteId";
                Ingrediente.DataBind();



                var receitas = new ReceitaDAL();

                Nome.DataSource = receitas.ListarTodasReceitas();
                Nome.DataTextField = "Nome";
                Nome.DataValueField = "ReceitaID";
                Nome.DataBind();
                Nome.SelectedIndex = Nome.Items.Count-1;


                var ingredientesPorReceita = new ListaIngredienteDAL();

                ListagemIngredientes.DataSource = ingredientesPorReceita.ListarIngredientesPorReceitaID(int.Parse(Nome.SelectedItem.Value));
                ListagemIngredientes.DataBind();

            }
    }

        protected void RegistarIngredientes_Click(object sender, EventArgs e)
        {

                var lista = new ListaIngrediente(int.Parse(Nome.SelectedItem.Value), int.Parse(Ingrediente.SelectedItem.Value), Quantidade.Text);
                ListaIngredienteDAL.IncluirListaIngrediente(lista);
                result.Text = " Ingrediente Adicionado";
                Quantidade.Text = "";


            var ingredientesPorReceita = new ListaIngredienteDAL();

            ListagemIngredientes.DataSource = ingredientesPorReceita.ListarIngredientesPorReceitaID(int.Parse(Nome.SelectedItem.Value));
            ListagemIngredientes.DataBind();
        }

        protected void RegistarReceita_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Default.aspx");
        }

        protected void ListagemIngredientes_RowDataBound(object sender, GridViewRowEventArgs e)
        {

        }

        protected void ListagemIngredientes_RowCommand(object sender, GridViewCommandEventArgs e)
        {

        }

        protected void Nome_SelectedIndexChanged(object sender, EventArgs e)
        {
            var receitaescolhida = int.Parse(Nome.SelectedItem.Value);

            var ingredientesPorReceita = new ListaIngredienteDAL();

            ListagemIngredientes.DataSource = ingredientesPorReceita.ListarIngredientesPorReceitaID(receitaescolhida);
            ListagemIngredientes.DataBind();

        }
    }
}