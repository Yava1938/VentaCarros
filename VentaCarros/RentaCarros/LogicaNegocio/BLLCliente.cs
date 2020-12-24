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
        }//End actualizar

        public static VOCliente ConsultarClientePorId(string idCliente)
        {
            VOCliente cliente = null;
            try
            {
                cliente = DALCliente.ConsultarClientePorId(int.Parse(idCliente));

            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error al consultar el registro de persona" + ex.Message);
            }
            return cliente;
        }
        public static List<VOCliente> ConsultarClientes()
        {
            List<VOCliente> clientes = null;
            try
            {
                clientes = DALCliente.ConsultarClientes();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error al consultar el registro de persona");
            }
            return clientes;
        }
    }
}
