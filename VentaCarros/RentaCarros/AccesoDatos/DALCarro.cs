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
        private static VOCarro carro;

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
        public static bool Actualizar(VOCarro carro)
        {
            Conexion conexion = new Conexion();
            SqlConnection cnn = new SqlConnection(conexion.CadenaConexion);
            int r = 0;
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("SP_ActualizarCarro", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@IdCarro", SqlDbType.Int).Value = carro.IdCarro;
                cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = carro.Nombre;
                cmd.Parameters.Add("@Modelo", SqlDbType.VarChar).Value = carro.Modelo;
                cmd.Parameters.Add("@Marca", SqlDbType.VarChar).Value = carro.Marca;
                cmd.Parameters.Add("@Matricula", SqlDbType.VarChar).Value = carro.Matricula;
                cmd.Parameters.Add("@Anio", SqlDbType.Int).Value = carro.Anio;
                cmd.Parameters.Add("@Precio", SqlDbType.Decimal).Value = carro.Precio;
                cmd.Parameters.Add("@UrlFoto", SqlDbType.VarChar).Value = carro.UrlFoto;
                cmd.Parameters.Add("@Disponibilidad", SqlDbType.Bit).Value = carro.Disponibilidad;
                r = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("No se pudo actualizar el dato en la base de datos " + ex.Message);
            }
            finally
            {
                cnn.Close();
            }
            if (r == 1)
                return true;
            else
                return false;
        }
        public static VOCarro ConsultarCarro(int idCarro)
        {

            VOCarro carro = null;
            Conexion conexion = new Conexion();
            SqlConnection cnn = new SqlConnection(conexion.CadenaConexion);
            DataSet ds = new DataSet();
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("SP_ConsultarCarroPorId", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@IdCarro", SqlDbType.Int).Value = idCarro;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds, "Carros");
                carro = new VOCarro(ds.Tables[0].Rows[0]);                
            }
            catch(Exception ex)
            {
                throw new ArgumentException("No se pudo completar la busqueda" + ex.Message);
            }
            finally
            {
                cnn.Close();
            }
            return carro;
        }
        public static List<VOCarro> ConsultarCarros(bool? disponibilidad)
        {
            List<VOCarro> lista = new List<VOCarro>();
            DataSet ds = new DataSet();
            Conexion conexion = new Conexion();
            SqlConnection cnn = new SqlConnection(conexion.CadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand("SP_ConsultarCarros", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Disponibilidad", SqlDbType.Bit).Value = disponibilidad;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds, "Carros");
                foreach (DataRow registro in ds.Tables[0].Rows)
	            {
                    lista.Add(new VOCarro(registro));
	            }
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Errorr al consultar carros" + ex.Message);
            }
            return lista;
        }
    }
}
