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
    public partial class AltaRenta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CatalogoClientes();
                CatalogoCarros();
            }
        }

        public void CatalogoClientes()
        {
            ddlCliente.Items.Clear();
            List<VOCliente> clientes = BLLCliente.ConsultarClientes();
            foreach (VOCliente cliente in clientes)
            {
                ddlCliente.Items.Add(new ListItem(cliente.Nombre, cliente.IdCliente.ToString()));
            }
        }
        public void CatalogoCarros()
        {
            ddlCarro.Items.Clear();
            List<VOCarro> carros = BLLCarro.ConsultarCarros(true);
            foreach (VOCarro carro in carros)
            {
                ddlCarro.Items.Add(new ListItem(carro.Nombre, carro.IdCarro.ToString()));
            }
        }
        public void LimpiarFormulario()
        {
            ddlCliente.SelectedIndex = 0;
            ddlCarro.SelectedIndex = 0;
            txtDuracion.Text = "";
            FechaRenta.Value = "";
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime prueba = DateTime.Now;
                VORenta renta = new VORenta(int.Parse(ddlCarro.SelectedValue),
                                            int.Parse(ddlCliente.SelectedValue),
                                            int.Parse(txtDuracion.Text), 
                                            Convert.ToDateTime(FechaRenta.Value),
                                            "EN_RENTA"
                                            );
                BLLRenta.InsertarRenta(renta);
                BLLCarro.ActualizarDisponibilidad(false, int.Parse(ddlCarro.SelectedValue));
                LimpiarFormulario();
                Response.Redirect("EnRenta.aspx");
            }
            catch (Exception ex)
            {
                ScriptManager.RegisterClientScriptBlock(this, GetType(), "Mensaje de error",
                    "alert('Se registro un error al realizar la operacion." + ex.Message + "');", true);
            }

        }
    }
}