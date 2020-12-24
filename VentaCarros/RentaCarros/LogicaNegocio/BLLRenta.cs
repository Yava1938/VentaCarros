using Entidades;
using LogicaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class BLLRenta
    {
        private static readonly object DALRenta;

        public static void InsertarSalida(VORenta renta)
        {
            try
            {
                VOCliente cliente = new VOCliente(renta.IdCliente, null, null, null, null, null, false, null);
                BLLCliente.Actualizar(cliente);
                VOCarro carro = new VOCarro(renta.IdCarro, null, null, null, null, null, null, false);
                BLLCarro.Actualizar(carro);
                BLLRenta.InsertarSalida(renta);
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error al insertar el registro de salida");
            }
        }

        public static void FinalizarRenta(string idRenta)
        {
            try
            {
                int id = int.Parse(idRenta);
                DALRenta.FinalizarRenta(id, Enum.GetName(typeof(EstadoRenta), EstadoRenta.FINALIZADA));
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error al finalizar la salida");
            }
        }

        public enum EstadoSalida
        {
            EN_PROCESO,
            FINALIZADA
        }
    }
}
