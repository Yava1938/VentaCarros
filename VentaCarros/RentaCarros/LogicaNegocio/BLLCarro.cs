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
        }

    }//End cllass BBLCarro

}//End logica de negocio
