using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data.SqlClient;

namespace AccesoDatos
{
    public class DALCarro
    {
        public static bool Insertar(VOCarro carro)
        {
            Conexion conexion = new Conexion();
            SqlConnection cnn = new SqlConnection(conexion.CadenaConexion);
            int r = 0;
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("SP_InsertarCarro",cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = carro.Nombre;
                cmd.Parameters.Add("@Modelo", SqlDbType.VarChar).Value = carro.Modelo;
                cmd.Parameters.Add("@Marca", SqlDbType.VarChar).Value = carro.Marca;
                cmd.Parameters.Add("@Matricula", SqlDbType.VarChar).Value = carro.Matricula;
                cmd.Parameters.Add("@Anio", SqlDbType.Int).Value = carro.Anio;
                cmd.Parameters.Add("@Precio", SqlDbType.Decimal).Value = carro.Precio;
                cmd.Parameters.Add("@UrlFoto", SqlDbType.VarChar).Value = carro.UrlFoto;
                r = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new ArgumentException("No se pudo insertar el dato en la Base de datos" + ex.Message);
            }
            finally
            {
                cnn.Close();
            }

            if (r == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool Eliminar(int idCarro)
        {
            Conexion conexion = new Conexion();
            SqlConnection cnn = new SqlConnection(conexion.CadenaConexion);
            int r = 0;
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("SP_EliminarCarro", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@IdCarro", SqlDbType.Int).Value = idCarro;
                r = cmd.ExecuteNonQuery();

            }
            catch (Exception ex )
            {

                throw new ArgumentException ("No se pudo eliminar el dato en la Base de datos" + ex.Message);
            }
            finally
            {
                cnn.Close();
            }
            if (r == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
