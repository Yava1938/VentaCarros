using Entidades;
using LogicaNegocio;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Agencia.Catalogo.Clientes
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["id"] == null)
                {
                    Response.Redirect("ListaPersona.aspx");
                }
                else
                {
                    string idCliente = Request.QueryString["id"].ToString();
                    VOCliente cliente = BLLCliente.ConsultarClientePorId(idCliente);
                    CagarFormulario(cliente);
                }
            }//End if postback
        }//End page_load

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            VOCliente cliente = new VOCliente(int.Parse(lblIdCliente.Text), txtNombre.Text, txtApellido_paterno.Text, txtApellido_materno.Text, txtCorreo.Text, txtTelefono.Text, txtDireccion.Text, lblUrlFoto.InnerText);
        }//End btnGuardar

        public void CagarFormulario(VOCliente cliente)
        {
            lblIdCliente.Text = cliente.IdCliente.ToString();
            txtNombre.Text = cliente.Nombre.ToString();
            txtApellido_paterno.Text = cliente.Apellido_paterno.ToString();
            txtApellido_materno.Text = cliente.Apellido_materno.ToString();
            txtCorreo.Text = cliente.Correo.ToString();
            txtTelefono.Text = cliente.Telefono.ToString();
            txtDireccion.Text = cliente.Direccion.ToString();
            lblUrlFoto.InnerText = cliente.Urlfoto.ToString();
        }//End cargarformulario

        protected void btnSubeImagen_Click(object sender, EventArgs e)
        {
            if (SubeImagen.Value != "")
            {
                string fileName = Path.GetFileName(SubeImagen.PostedFile.FileName);
                string fileExt = Path.GetExtension(fileName).ToLower();
                if ((fileExt != ".jpg") && (fileExt != ".png") && (fileExt != ".jpeg"))
                {
                    lblUrlFoto.InnerText = "Archivo no válido";
                }
                else
                {
                    string path = Server.MapPath("~/Imagenes/Personas/");
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    SubeImagen.PostedFile.SaveAs(path + fileName);
                    string url = "/Imagenes/Personas/" + fileName;
                    lblUrlFoto.InnerText = url;
                    imgFotoPersona.ImageUrl = url;
                    btnGuardar.Visible = true;
                }
            }
        }//End btnSubirImagen

        public void LimpiarFormulario(VOCliente cliente)
        {
            txtNombre.Text = "";
            txtApellido_paterno.Text = "";
            txtApellido_materno.Text = "";
            txtCorreo.Text = "";
            txtTelefono.Text = "";
            txtDireccion.Text = "";
            lblUrlFoto.InnerText = "";
        }

    }
}