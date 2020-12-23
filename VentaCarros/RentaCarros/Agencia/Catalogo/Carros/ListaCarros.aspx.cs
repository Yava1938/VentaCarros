using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LogicaNegocio;

namespace Agencia.Catalogo.Carros
{
    public partial class ListaCarros : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarGrid();
            }

        }

        protected void gvCarros_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Select")
            {
                int index = int.Parse(e.CommandArgument.ToString());
                string idCarro = gvCarros.DataKeys[index].Values["IdCarro"].ToString();
                Response.Redirect("EditarCarro.aspx?Id=" + idCarro);
            }
        }
        public void CargarGrid()
        {
            gvCarros.DataSource = BLLCarro.ConsultarCarros(null);
            gvCarros.DataBind();
        }
    }
}