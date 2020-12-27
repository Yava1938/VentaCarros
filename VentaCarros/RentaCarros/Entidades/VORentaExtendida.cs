using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class VORentaExtendida
    {
        private int idRenta;
        private string nombreCarro;
        private string nombreCliente;
        private int duracion;
        private DateTime fecha;
        private string estado;

        public VORentaExtendida(int idRenta, string nombreCarro, string nombreCliente, int duracion, DateTime fecha, string estado)
        {
            this.idRenta = idRenta;
            this.nombreCarro = nombreCarro;
            this.nombreCliente = nombreCliente;
            this.duracion = duracion;
            this.fecha = fecha;
            this.estado = estado;
        }

        public VORentaExtendida(string nombreCarro, string nombreCliente, int duracion, DateTime fecha, string estado)
        {
            
            this.nombreCarro = nombreCarro;
            this.nombreCliente = nombreCliente;
            this.duracion = duracion;
            this.fecha = fecha;
            this.estado = estado;
        }

        public VORentaExtendida(DataRow dr)
        {
            IdRenta = int.Parse(dr["IdRenta"].ToString());
            NombreCarro = dr["Nombre"].ToString(); 
            NombreCliente = dr["Nombre"].ToString();
            Duracion = int.Parse(dr["Duracion"].ToString());
            Fecha = DateTime.Parse(dr["Fecha"].ToString());
            Estado = dr["Estado"].ToString();
        }

        public int IdRenta
        {
            get
            {
                return idRenta;
            }

            set
            {
                idRenta = value;
            }
        }

        public string NombreCarro
        {
            get
            {
                return nombreCarro;
            }

            set
            {
                nombreCarro = value;
            }
        }

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
        }

        public int Duracion
        {
            get
            {
                return duracion;
            }

            set
            {
                duracion = value;
            }
        }

        public DateTime Fecha
        {
            get
            {
                return fecha;
            }

            set
            {
                fecha = value;
            }
        }

        public string Estado
        {
            get
            {
                return estado;
            }

            set
            {
                estado = value;
            }
        }
    }//end vo ventas
}