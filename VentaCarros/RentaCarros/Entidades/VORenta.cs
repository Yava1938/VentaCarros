using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class VORenta
    {
        private int idRenta;
        private int idCarro;
        private int idCliente;
        private int duracion;
        private DateTime fecha;
        private string estado;

        public VORenta(int idRenta, int idCarro, int idCliente, int duracion, DateTime fecha, string estado)
        {
            this.idRenta = idRenta;
            this.idCarro = idCarro;
            this.idCliente = idCliente;
            this.duracion = duracion;
            this.fecha = fecha;
            this.estado = estado;
        }

        public VORenta()
        {
            IdRenta = 0;
            IdCarro = 0;
            IdCliente = 0;
            Duracion = 0;
            Fecha = DateTime.Now;
            Estado = "";
        }

        public VORenta(DataRow dr)
        {
            IdRenta = int.Parse(dr["IdRenta"].ToString());
            IdCarro = int.Parse(dr["IdCarro"].ToString());
            IdCliente = int.Parse(dr["IdCliente"].ToString());
            Duracion = int.Parse(dr["Duracion"].ToString());
            Fecha = DateTime.Parse(dr["Fecha"].ToString()); ;
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
    }
}
