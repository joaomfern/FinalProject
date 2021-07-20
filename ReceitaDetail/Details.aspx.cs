using Microsoft.AspNet.Identity;
using ReceitasDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReceitasWeb.ReceitaDetail
{
    public partial class Details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string userId = User.Identity.GetUserId();

            var id = int.Parse(Request.QueryString["Name"]);
            var receita = ReceitaDAL.ListarReceitaPorID(id);

            Nome.Text = receita.Nome;
            ModoPreparacao.Text = receita.ModoPreparacao;
            Duracao.Text = receita.Duracao.ToString() + " minutos";
            Dificuldade.Text = receita.Dificuldade;
            Utilizador.Text = receita.User.ToString();
            Categoria.Text = receita.Categoria.ToString();
            ImageUrl.ImageUrl = receita.ImageUrl;


            var listaIngredientes = new ListaIngredienteDAL();
            
            ListagemIngredientes.DataSource = listaIngredientes.ListarIngredientesPorReceitaID(id);
            ListagemIngredientes.DataBind();

            //if(userId == receita.UserID)
            //{

            //}
    
        }

        protected void ListagemIngredientes_RowDataBound(object sender, GridViewRowEventArgs e)
        {

        }

        protected void ListagemIngredientes_RowCommand(object sender, GridViewCommandEventArgs e)
        {

        }

        protected void Remove_Click(object sender, EventArgs e)
        {
            var id = int.Parse(Request.QueryString["Name"]);
            ReceitaDAL.ExcluirReceita(id);
            Response.Redirect("~/Default.aspx");

        }

        protected void Alterar_Click(object sender, EventArgs e)
        {
            var id = int.Parse(Request.QueryString["Name"]);
            Response.Redirect("~/ReceitaDetail/Modify.aspx?Name=" + id);
        }
    }
}