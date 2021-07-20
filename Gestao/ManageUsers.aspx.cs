using ReceitasDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReceitasWeb.Gestao
{
    public partial class ManageUsers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var listaUsers = new ReceitasDAL.UtilizadorDAL();

            Listagem.DataSource = listaUsers.ListarTodosUtilizadores();
            Listagem.DataBind();
        }

        protected void Listagem_RowDataBound(object sender, GridViewRowEventArgs e)
        {

        }

        protected void Listagem_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "NameButtonAlterar")
            {
                var id = e.CommandArgument;
                Response.Redirect("~/Account/ManagePassword.aspx?m=" + id);
            }


            if (e.CommandName == "NameButtonEliminar")
            {
                var id = e.CommandArgument.ToString();
                UtilizadorDAL.ExcluirUtilizador(id);
            }

        }
    }
}