using LogicaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Agencia.Catalogo.Clientes
{
    public partial class ListaPersona : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarGrid();
            }//End postback
        }//Ene page_load

        protected void gvClientes_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Select")
            {
                int index = int.Parse(e.CommandArgument.ToString());
                string idCliente = gvClientes.DataKeys[index].Values["IdCliente"].ToString();
                Response.Redirect("EditarCliente.aspx?Id=" + idCliente);
            }//End if commandname
        }//End rowcommand

        public void CargarGrid()
        {
            gvClientes.DataSource = BLLCliente.ConsultarClientes();
            gvClientes.DataBind();
        }
    }
}