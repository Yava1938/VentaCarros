using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using LogicaNegocio;

namespace Agencia.Catalogo.Clientes
{
    public partial class AltaCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                VOCliente cliente = new VOCliente(txtNombre.Text, txtApellido_paterno.Text, txtApellido_materno.Text, txtCorreo.Text, txtTelefono.Text, txtDireccion.Text, lblUrlFoto.InnerText);
                BLLCliente.Insertar(cliente);
                LimpiarFormulario();
                Response.Redirect("ListaCliente.aspx");
            }
            catch (Exception ex)
            {
                ScriptManager.RegisterClientScriptBlock(this, GetType(), "Mensaje de Error", "alert('Se registró un error al realizar la operación');" + ex.Message, true);
            }
        }//End btnGuardar
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
        }//End Subirimagen
        public void LimpiarFormulario()
        {
            txtNombre.Text = "";
            txtApellido_paterno.Text = "";
            txtApellido_materno.Text = "";
            txtCorreo.Text = "";
            txtTelefono.Text = "";
            txtDireccion.Text = "";
            lblUrlFoto.InnerText = "";
            btnGuardar.Visible = false;
        }
    }
}