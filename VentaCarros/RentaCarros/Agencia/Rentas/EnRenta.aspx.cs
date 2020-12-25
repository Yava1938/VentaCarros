using LogicaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Agencia.Rentas
{
    public partial class EnRenta : System.Web.UI.Page
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
                int index = int.Parse(e.CommandArgument.ToString());
                string idRenta = gvRentas.DataKeys[index].Values["IdRenta"].ToString();
                string idCarro = gvRentas.DataKeys[index].Values["IdCarro"].ToString();
                string estado = "FINALIZADA"; 
                BLLRenta.FinalizarRentas(estado, Convert.ToInt32(idRenta)); 
                BLLCarro.ActualizarDisponibilidad(true, Convert.ToInt32(idCarro)); 
                Response.Redirect("Finalizadas.aspx" );
            }
        }
        public void CargarGrid()
        {
            string estado = "EN_RENTA";
            gvRentas.DataSource = BLLRenta.ConsultarRentas(estado);
            gvRentas.DataBind();
        }
    }
}
