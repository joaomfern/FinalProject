using ReceitasDAL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReceitasWeb.ReceitaDetail
{
    public partial class Modify : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
            var id = int.Parse(Request.QueryString["Name"]);
            var receita = ReceitaDAL.ListarReceitaPorID(id);

            Nome.Text = receita.Nome;
            Preparacao.Text = receita.ModoPreparacao;
            Duracao.Text = receita.Duracao.ToString();
            Dificuldade.SelectedValue = receita.Dificuldade;


                var utilizadores = new UtilizadorDAL();

                Utilizador.DataSource = utilizadores.ListarTodosUtilizadores();
                Utilizador.DataTextField = "Username";
                Utilizador.DataValueField = "Id";
                Utilizador.DataBind();
                Utilizador.Items.FindByText(receita.User).Selected=true;

                var categorias = new CategoriaDAL();
                Categoria.DataSource = categorias.ListarTodasCategorias();
                Categoria.DataTextField = "Nome";
                Categoria.DataValueField = "CategoriaId";
                Categoria.DataBind();
                Categoria.Items.FindByText(receita.Categoria).Selected = true;


                Imagem.GetRouteUrl(receita.ImageUrl);

            }
        }

        protected void Modificar_Click(object sender, EventArgs e)
        {
            var id = int.Parse(Request.QueryString["Name"]);


            var imageurl = "";
            string path = Server.MapPath("~/Imagens/");
            Boolean fileOK = false;
            if (Imagem.HasFile)
            {
                string extencao = Path.GetExtension(Imagem.FileName).ToLower();
                string[] extencoespermitidas = { ".png", ".jpg" };

                for (int i = 0; i < extencoespermitidas.Length; i++)
                    if (extencao == extencoespermitidas[i]) fileOK = true;

                if (fileOK)
                {
                    Imagem.PostedFile.SaveAs(path + Imagem.FileName);
                    imageurl = "~/Imagens/" + Imagem.FileName.ToString();
                }
            }

            var receitaAlterada = new ReceitasDAL.Receita(id,Nome.Text, Preparacao.Text, int.Parse(Duracao.Text), Dificuldade.SelectedItem.Text, Utilizador.SelectedItem.Value, int.Parse(Categoria.SelectedItem.Value), imageurl);
            ReceitaDAL.AlterarReceita(receitaAlterada);

            Response.Redirect("~/ReceitaDetail/Details.aspx?Name=" + id);
        }
    }
}