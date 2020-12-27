using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class VOCliente
    {
        private int idCliente;
        private string nombreCliente;
        private string apellidopaterno;
        private string apellidomaterno;
        private string correo;
        private string telefono;
        private string direccion;
        private string urlfoto;

        public VOCliente(int cliente, string nombreCliente, string apellidopaterno, string apellidomaterno, string correo, string telefono, string direccion, string urlfoto)
        {
            this.IdCliente = cliente;
            this.NombreCliente = nombreCliente;
            this.Apellido_paterno = apellidopaterno;
            this.Apellido_materno = apellidomaterno;
            this.Correo = correo;
            this.Telefono = telefono;
            this.Direccion = direccion;
            this.Urlfoto = urlfoto;
        }
        public VOCliente(string nombreCliente, string apellidopaterno, string apellidomaterno, string correo, string telefono, string direccion, string urlfoto)
        {
            this.NombreCliente = nombreCliente;
            this.Apellido_paterno = apellidopaterno;
            this.Apellido_materno = apellidomaterno;
            this.Correo = correo;
            this.Telefono = telefono;
            this.Direccion = direccion;
            this.Urlfoto = urlfoto;
        }
        public VOCliente(DataRow fila)
        {
            IdCliente               = int.Parse(fila["IdCliente"].ToString());
            NombreCliente                  = fila["NombreCliente"].ToString();
            Apellido_paterno         = fila["Apellido_paterno"].ToString();
            Apellido_materno         = fila["Apellido_materno"].ToString();
            Correo                  = fila["Correo"].ToString();
            Telefono                = fila["Telefono"].ToString();
            Direccion               = fila["Direccion"].ToString();
            Urlfoto                 = fila["UrlFoto"].ToString();
        }
        public int IdCliente
        {
            get
            {
                return idCliente;
            }
            set
            {
                idCliente = value;
            }
        }//End Cliente

        public string NombreCliente
        {
            get
            {
                return nombreCliente;
            }
            set
            {
                nombreCliente = value;
            }
        }//End Nombre

        public string Apellido_paterno
        {
            get
            {
                return apellidopaterno;
            }
            set
            {
                apellidopaterno = value;
            }
        }//End Apellidopaterno

        public string Apellido_materno
        {
            get
            {
                return apellidomaterno;
            }
            set
            {
                apellidomaterno = value;
            }
        }//End Apellidomaterno

        public string Correo
        {
            get
            {
                return correo;
            }
            set
            {
                correo = value;
            }
        }//End Correo

        public string Telefono
        {
            get
            {
                return telefono;
            }
            set
            {
                telefono = value;
            }
        }//End telfono

        public string Direccion
        {
            get
            {
                return direccion;
            }
            set
            {
                direccion = value;
            }
        }//End Direccion

        public string Urlfoto
        {
            get
            {
                return urlfoto;
            }
            set
            {
                urlfoto = value;
            }
        }//End Urlfoto
    }
}
