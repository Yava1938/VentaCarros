using Entidades;
using LogicaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Agencia.Rentas
{
    public partial class AltaRentas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime prueba = DateTime.Now;
                VORenta renta = new VORenta(Convert.ToDateTime(FechaSalida.Value), txtDestino.Text,
                "EN_PROCESO", int.Parse(ddlRenta.SelectedValue), int.Parse(ddlCapitan.SelectedValue));
                BLLRenta.InsertarSalida(renta);
                LimpiarFormulario();
                Response.Redirect("SalidasProceso.aspx");
            }
            catch (Exception ex)
            {
                ScriptManager.RegisterClientScriptBlock(this, GetType(), "Mensaje de error",
                    "alert('Se registro un error al realizar la operacion." + ex.Message + "');", true);
            }
        }

        public void CatalogoCarros()
        {
            ddlVehiculo.Items.Clear();
            List<VOCarro> carros = BLLCarro.ConsultarCarrosDisponibles(null);
            foreach (VOCarro carro in carros)
            {
                ddlCliente.Items.Add(new ListItem(carro.Nombre, carro.IdCarro.ToString()));
            }
        }

        public void CatalogoClientes()
        {
            /*ddlCliente.Items.Clear();
            List<VOCliente> cliente = BLLCliente.ConsultarClientes();
            foreach (VOCliente barco in cliente)
            {
                ddlCliente.Items.Add(new ListItem(cliente.Nombre, cliente.IdCliente.ToString()));
            }*/
        }

        public void LimpiarFormulario()
        {
            ddlVehiculo.SelectedIndex = 0;
            ddlCliente.SelectedIndex = 0;
            txtDuracionRenta.Text = "";
            FechaRenta.Value = "";
        }
    }
}