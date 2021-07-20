using ReceitasDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReceitasWeb.Gestao
{
    public partial class ChangeUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var id = Request.QueryString["Name"];
                var utilizador = UtilizadorDAL.ListarUtilizadorPorId(id);

                UserName.Text = utilizador.Nome;
                Email.Text = utilizador.Email;
            }
        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            var id = Request.QueryString["Name"];
            var userAlterado = new Utilizador(id,UserName.Text,Email.Text,Password.Text);
            UtilizadorDAL.AlterarUtilizador(userAlterado);

            Response.Redirect("~/Gestao/ManageUsers.aspx");
        }
    }
}