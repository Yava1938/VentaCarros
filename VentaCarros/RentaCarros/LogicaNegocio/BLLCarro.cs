using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using AccesoDatos;

namespace LogicaNegocio
{
    public class BLLCarro
    {
        public static void Insertar(VOCarro carro)
        {
            try
            {
                DALCarro.Insertar(carro);
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error al insertar el registro" + ex.Message);
            }

        }//End Insertar 

        public static void Eliminar(string idCarro)
        {
            try
            {
                DALCarro.Eliminar(int.Parse(idCarro));
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error al eliminar el registro" + ex.Message);
            }
        }//End Eliminar

        public static List<VOCarro> ConsultarCarros( bool? disponibilidad)
        {
            List<VOCarro> carros = null;
            try
            {
                carros = DALCarro.ConsultarCarros(disponibilidad);
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error al eliminar el registro" + ex.Message);
            }
            return carros;
        }//End Eliminar

        public static void Actualizar(VOCarro carro)
        {
            try
            {
                DALCarro.Actualizar(carro);
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error al insertar el registro" + ex.Message);
            }
        }//End Actualizar
        public static void ActualizarDisponibilidad(bool disponibilidad, int idCarro)
        {
            try
            {
                DALCarro.ActualizarDisponibilidad(disponibilidad, idCarro);
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error al insertar el registro" + ex.Message);
            }
        }//End Actualizar

        public static VOCarro ConsultarCarro(string idCarro)
        {
            VOCarro carro = null;
            try
            {
                carro = DALCarro.ConsultarCarro(int.Parse(idCarro));
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error al consultar el registro" + ex.Message);
            }
            return carro;
        }
    }
}
