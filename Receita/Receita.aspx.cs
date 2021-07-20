using Microsoft.AspNet.Identity;
using ReceitasDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReceitasWeb.Receita
{
    public partial class Receita : System.Web.UI.Page
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
                

                var categorias = new CategoriaDAL();

                Categoria.DataSource = categorias.ListarTodasCategorias();
                Categoria.DataTextField = "Nome";
                Categoria.DataValueField = "CategoriaId";
                Categoria.DataBind();
            }


        }
        protected void Unnamed_Click(object sender, EventArgs e)
        {
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

                var receita = new ReceitasDAL.Receita(Nome.Text, Preparacao.Text, int.Parse(Duracao.Text), Dificuldade.SelectedItem.Text, Utilizador.SelectedItem.Value, int.Parse(Categoria.SelectedItem.Value), imageurl);
                ReceitaDAL.IncluirReceita(receita);


                Response.Redirect("~/Receita/ReceitaIngredientes.aspx");
            
        }
    }
}
