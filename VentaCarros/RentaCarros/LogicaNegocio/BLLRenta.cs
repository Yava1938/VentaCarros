using AccesoDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class BLLRenta
    {
        public static void InsertarRenta(VORenta renta)
        {
            try
            {
                DALRenta.InsertarRenta(renta);
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error al insertar el registro" + ex.Message);
            }

        }//End Insertar 

        public static List<VORenta> ConsultarRentas(string estado)
        {
            List<VORenta> lista = null;
            try
            {
                lista = DALRenta.ConsultarRentas(estado);
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error al insertar el registro" + ex.Message);
            }

            return lista;

        }//End Insertar
        public static void FinalizarRentas(string estado, int idRenta)
        {
            try
            {
                DALRenta.Finalizar(estado, idRenta);
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error al insertar el registro" + ex.Message);
            }
        }//End Actualizar
    }
}
