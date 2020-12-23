using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using AccesoDatos;

namespace LogicaNegocio
{
    public class BLLCliente
    {
        public static void Insertar(VOCliente cliente)
        {
            try
            {
                DALCliente.InsertarCliente(cliente);
            }
            catch
            {
                throw new ArgumentException("No se pudo insertar el dato");
            }
        }//End insertar
        public static void Eliminar(string idCliente)
        {
            try
            {
                DALCliente.EliminarCliente(int.Parse(idCliente));
            }
            catch
            {
                throw new ArgumentException("No se pudo eliminar el dato");
            }
        }//End eliminar

        public static void Actualizar(VOCliente cliente)
        {
            try
            {
                DALCliente.ActualizarCliente(cliente);
            }
            catch
            {
                throw new ArgumentException("No se pudo actualizar el dato");
            }
        }
    }
}
