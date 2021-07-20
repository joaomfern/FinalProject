using Microsoft.AspNet.Identity;
using ReceitasDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReceitasWeb.Receita
{
    public partial class NovoIngrediente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string userId = User.Identity.GetUserId();

            if (!IsPostBack)
            {
                var utilizadores = new UtilizadorDAL();

                Utilizador.DataSource = utilizadores.ListarTodosUtilizadores();
                Utilizador.DataTextField = "Username";
                Utilizador.DataValueField = "Id";
                Utilizador.DataBind();
                Utilizador.SelectedValue = userId;


                var listaIngredientes = new IngredienteDAL();

                ListagemIngredientes.DataSource = listaIngredientes.ListarTodosIngredientes();
                ListagemIngredientes.DataBind();

            }

        }

        protected void NovoIngrediente_Click(object sender, EventArgs e)
        {
            var ingrediente = new Ingrediente(NovoIngredientenome.Text, Utilizador.SelectedItem.Value,NovoIngredienteDescription.Text);
            IngredienteDAL.IncluirIngrediente(ingrediente);

            Response.Redirect("~/Receita/ReceitaIngredientes.aspx");
        }

        protected void ListagemIngredientes_RowDataBound(object sender, GridViewRowEventArgs e)
        {

        }

        protected void ListagemIngredientes_RowCommand(object sender, GridViewCommandEventArgs e)
        {

        }
    }
}