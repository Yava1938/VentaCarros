﻿using AccesoDatos;
using LogicaNegocios;
using Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Agencia.Catalogo.Carros
{
    public partial class AltaCarros : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubeImagen_Click(object sender, EventArgs e)
        {
            if (SubeImagen.Value != "")
            {
                string fileName = Path.GetFileName(SubeImagen.PostedFile.FileName);
                string fileExt = Path.GetExtension(fileName).ToLower();
                if ((fileExt != ".jpg")&&(fileExt != ".png")&&(fileExt != ".jpeg"))
                {
                    lblUrlFoto.InnerText= "Archivo no valido";
                }
                else
                {
                    string path = Server.MapPath("~/Imagenes/Carros");
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    SubeImagen.PostedFile.SaveAs(path + fileName);
                    string url = "/Imagenes/Carros/" + fileName;
                    imgFotoCarro.ImageUrl= url;
                    btnGuardar.Visible = true;
                }
            }

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                VOCarro carro = new VOCarro(txtNombreCarro.Text, txtModeloCarro.Text,
                    txtMarcaCarro.Text, rfvTxtMatriculaCarro.Text, Convert.ToInt32(txtAnioCarro.Text), 
                    Convert.ToDouble(txtPrecioCarro.Text), lblUrlFoto.InnerText, true);
                    BLLCarro.Insertar(carro);
                    LimpiarFormulario();
                    Response.Redirect("ListaCarros.aspx");
            }
            catch (Exception ex)
            {

                ScriptManager.RegisterClientScriptBlock(this, GetType(), "Mensaje de error", "alert('Se registro un error a realizar la operacion." + ex.Message+"');", true);
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
    }
}