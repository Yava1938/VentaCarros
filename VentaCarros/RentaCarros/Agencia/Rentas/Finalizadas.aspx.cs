using LogicaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Agencia.Rentas
{
    public partial class Finalizadas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarGrid();
            }
        }

        protected void gvRentas_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Select")
            {
                Response.Redirect("AltaRenta.aspx");
            }
        }

        public void CargarGrid()
        {
            string estado = "FINALIZADA";
            gvRentas.DataSource = BLLRenta.ConsultarRentas(estado);
            gvRentas.DataBind();
        }
    }
}