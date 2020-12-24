using Entidades;
using LogicaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Agencia.Catalogo.Clientes
{
    public partial class DetalleCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["id"]==null)
                {
                    Response.Redirect("ListaCliente.aspx");
                }
                else
                {
                    string idCliente = Request.QueryString["id"].ToString();
                    VOCliente cliente = BLLCliente.ConsultarClientePorId(idCliente);
                    CargarFormulario(cliente);
                    CargarGrid(idCliente);
                }//End if/else
            }//End primer if
        }//End Page_load

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            Response.Redirect("EditarPersonas.aspx?Id=" + lblIdCliente.Text);

        }//End btn eliminar

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            BLLCliente.Eliminar(lblIdCliente.Text);
            Response.Redirect("ListaCliente.aspx");
        }//End btnEliminar

        public void CargarGrid(string idCliente)
        {
            gvCarros.DataSource = BLLCliente.ConsultarClientePorId(idCliente);
        }//End Cargargrid

        public void CargarFormulario(VOCliente cliente)
        {
            lblIdCliente.Text = cliente.IdCliente.ToString();
            lblNombre.Text = cliente.Nombre.ToString();
            lblApellido_paterno.Text = cliente.Apellido_paterno.ToString();
            lblApellido_materno.Text = cliente.Apellido_materno.ToString();
            lblCorreo.Text = cliente.Correo.ToString();
            lblTelefono.Text = cliente.Telefono.ToString();
            lblDireccion.Text = cliente.Direccion.ToString();
            imgFotoPersona.ImageUrl = cliente.Urlfoto.ToString();

        }
    }
}