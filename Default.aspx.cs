using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReceitasWeb
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var listaReceitas = new ReceitasDAL.ReceitaDAL();

            Listagem.DataSource = listaReceitas.ListarTodasReceitasDetalhadas();
            Listagem.DataBind();
        }

        protected void Listagem_RowDataBound(object sender, GridViewRowEventArgs e)
        {

        }

        protected void Listagem_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "NameButton")
            {
                var id = e.CommandArgument;

                Response.Redirect("ReceitaDetail/Details.aspx?Name=" + id);
            }
        }


    }
}