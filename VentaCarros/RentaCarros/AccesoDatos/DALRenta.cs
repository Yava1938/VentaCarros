using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class DALRenta
    {
        public static void InsertarRenta(VORenta renta)
        {
            Conexion conexion = new Conexion();
            SqlConnection cnn = new SqlConnection(conexion.CadenaConexion);
            int r = 0;
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("SP_InsertarRenta", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@IdCarro", SqlDbType.VarChar).Value = renta.IdCarro;
                cmd.Parameters.Add("@IdCliente", SqlDbType.VarChar).Value = renta.IdCliente;
                cmd.Parameters.Add("@Duracion", SqlDbType.VarChar).Value = renta.Duracion;
                cmd.Parameters.Add("@Fecha", SqlDbType.DateTime).Value = renta.Fecha;
                cmd.Parameters.Add("@Estado", SqlDbType.VarChar).Value = renta.Estado;
                r = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("No se pudo insertar el dato en la base de datos " + ex.Message);
            }
            finally
            {
                cnn.Close();
            }//End ty/catch
        }//End insertar

        public static List<VORentaExtendida> ConsultarRentas(string estado)
        {
            List<VORentaExtendida> lista = new List<VORentaExtendida>();
            DataSet ds = new DataSet();
            Conexion conexion = new Conexion();
            SqlConnection cnn = new SqlConnection(conexion.CadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand("SP_ConsultaRentasProceso", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Estado", SqlDbType.VarChar).Value = estado;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds, "Rentas");
                foreach (DataRow registro in ds.Tables[0].Rows)
                {
                    lista.Add(new VORentaExtendida(registro));
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error al consultar carros" + ex.Message);
            }
            return lista;
        }

        public static bool Finalizar(string estado, int idRenta)
        {
            Conexion conexion = new Conexion();
            SqlConnection cnn = new SqlConnection(conexion.CadenaConexion);
            int r = 0;
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("SP_FinalizarRenta", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Estado", SqlDbType.VarChar).Value = estado;
                cmd.Parameters.Add("@IdRenta", SqlDbType.Int).Value = idRenta;
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
    }
}
