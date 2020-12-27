using Entidades;
using LogicaNegocio;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Agencia.Catalogo.Carros
{
    public partial class EditarCarro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["Id"] == null)
                    Response.Redirect("ListaCarros.aspx");
                else
                {
                    bool disponibilidad = true;
                    string idCarro = Request.QueryString["Id"].ToString();
                    VOCarro carro = BLLCarro.ConsultarCarro(idCarro);
                    CargarFormulario(carro);
                    disponibilidad = (bool)carro.Disponibilidad;
                    if (disponibilidad)
                    {
                        lblCarro.ForeColor = System.Drawing.Color.Green;
                        btnEliminar.Visible = true;
                    }
                    else
                    {
                        lblCarro.ForeColor = System.Drawing.Color.Red;
                        btnEliminar.Visible = false;
                    }
                }

            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                VOCarro carro = new VOCarro(Convert.ToInt32(lblCarro.Text),
                                            txtNombreCarro.Text,
                                            txtModeloCarro.Text,
                                            txtMarcaCarro.Text,
                                            txtMatriculaCarro.Text,
                                            Convert.ToInt32(txtAnioCarro.Text),
                                            Convert.ToDouble(txtPrecioCarro.Text),
                                            imgFotoCarro.ImageUrl, null);
                BLLCarro.Actualizar(carro);
                LimpiarFormulario();
                Response.Redirect("ListaCarros.aspx");
            }
            catch (Exception ex)
            {

                ScriptManager.RegisterClientScriptBlock(this, GetType(), "Mensaje de error", "alert('Se registro un error a realizar la operacion." + ex.Message + "');", true);
            }

        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                BLLCarro.Eliminar(lblCarro.Text);
                LimpiarFormulario();
                Response.Redirect("ListaCarros.aspx");
            }
            catch (Exception ex)
            {
                ScriptManager.RegisterClientScriptBlock(this, GetType(), "Mensaje de error",
                    "alert('Se registro un error al realizar la operacion." + ex.Message + "');", true);
            }

        }

        protected void btnSubeImagen_Click(object sender, EventArgs e)
        {
            if (SubeImagen.Value != "")
            {
                string fileName = Path.GetFileName(SubeImagen.PostedFile.FileName);
                string fileExt = Path.GetExtension(fileName).ToLower();
                if ((fileExt != ".jpg") && (fileExt != ".png") && (fileExt != ".jpeg"))
                {
                    lblUrlFoto.InnerText = "Archivo no valido";
                }
                else
                {
                    string path = Server.MapPath("~/Imagenes/Carros/");
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    SubeImagen.PostedFile.SaveAs(path + fileName);
                    string url = "/Imagenes/Carros/" + fileName;
                    imgFotoCarro.ImageUrl = url;
                    btnGuardar.Visible = true;
                }
            }

        }
        

        public void LimpiarFormulario()
        {
            txtNombreCarro.Text = "";
            txtModeloCarro.Text = "";
            txtMarcaCarro.Text = "";
            txtMatriculaCarro.Text = "";
            txtAnioCarro.Text = "";
            txtPrecioCarro.Text = "";
            lblUrlFoto.InnerText = "";
            imgFotoCarro.ImageUrl = "";
            btnGuardar.Visible = false;

        }

        public void CargarFormulario(VOCarro carro)
        {
            txtNombreCarro.Text = carro.Nombre;
            txtModeloCarro.Text = carro.Modelo;
            txtMarcaCarro.Text = carro.Marca;
            txtMatriculaCarro.Text = carro.Matricula;
            lblCarro.Text = carro.IdCarro.ToString();
            txtAnioCarro.Text = carro.Anio.ToString();
            txtPrecioCarro.Text = carro.Precio.ToString();
            lblUrlFoto.InnerText = carro.UrlFoto;
            imgFotoCarro.ImageUrl = carro.UrlFoto;
        }
    }
}