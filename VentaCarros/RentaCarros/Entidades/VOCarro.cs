using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class VOCarro
    {
        private int idCarro;
        private string nombre;
        private string modelo;
        private string marca;
        private string matricula;
        private int anio;
        private double precio;
        private bool disponibilidad;
        private string urlFoto;

        public VOCarro(int idCarro, string nombre, string modelo, string marca, string matricula, int anio, double precio, bool disponibilidad, string urlFoto)
        {
            this.IdCarro = idCarro;
            this.Nombre = nombre;
            this.Modelo = modelo;
            this.Marca = marca;
            this.Matricula = matricula;
            this.Anio = anio;
            this.Precio = precio;
            this.Disponibilidad = disponibilidad;
            this.UrlFoto = urlFoto;
        }
        public VOCarro(string nombre, string modelo, string marca, string matricula, int anio, double precio, bool disponibilidad, string urlFoto)
        {
            this.Nombre = nombre;
            this.Modelo = modelo;
            this.Marca = marca;
            this.Matricula = matricula;
            this.Anio = anio;
            this.Precio = precio;
            this.Disponibilidad = disponibilidad;
            this.UrlFoto = urlFoto;
        }
        public VOCarro(DataRow fila)
        {
            IdCarro = int.Parse(fila["IdCarro"].ToString());
            this.Nombre = fila["Nombre"].ToString();
            this.Modelo = fila["Modelo"].ToString();
            this.Marca = fila["Marca"].ToString();
            this.Matricula = fila["IdCarro"].ToString();
            this.Anio = int.Parse(fila["Anio"].ToString());
            this.Precio = double.Parse(fila["Precio"].ToString());
            this.Disponibilidad = bool.Parse(fila["Disponibilidad"].ToString());
            this.UrlFoto = fila["UrlFoto"].ToString();
        }
        public int IdCarro
        {
            get
            {
                return idCarro;
            }

            set
            {
                idCarro = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Modelo
        {
            get
            {
                return modelo;
            }

            set
            {
                modelo = value;
            }
        }

        public string Marca
        {
            get
            {
                return marca;
            }

            set
            {
                marca = value;
            }
        }

        public string Matricula
        {
            get
            {
                return matricula;
            }

            set
            {
                matricula = value;
            }
        }

        public int Anio
        {
            get
            {
                return anio;
            }

            set
            {
                anio = value;
            }
        }

        public double Precio
        {
            get
            {
                return precio;
            }

            set
            {
                precio = value;
            }
        }

        public bool Disponibilidad
        {
            get
            {
                return disponibilidad;
            }

            set
            {
                disponibilidad = value;
            }
        }

        public string UrlFoto
        {
            get
            {
                return urlFoto;
            }

            set
            {
                urlFoto = value;
            }
        }
    }
}
