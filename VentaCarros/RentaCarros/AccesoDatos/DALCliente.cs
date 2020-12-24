using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace AccesoDatos
{
    public class DALCliente
    {
        public static void InsertarCliente(VOCliente cliente)
        {
            Conexion conexion = new Conexion();
            SqlConnection cnn = new SqlConnection(conexion.CadenaConexion);
            int r = 0;
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("SP_InsertarCliente", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = cliente.Nombre;
                cmd.Parameters.Add("@Apellido_paterno", SqlDbType.VarChar).Value = cliente.Apellido_paterno;
                cmd.Parameters.Add("@Apellido_materno", SqlDbType.VarChar).Value = cliente.Apellido_materno;
                cmd.Parameters.Add("@Correo", SqlDbType.VarChar).Value = cliente.Correo;
                cmd.Parameters.Add("@Telefono", SqlDbType.VarChar).Value = cliente.Telefono;
                cmd.Parameters.Add("@Direccion", SqlDbType.VarChar).Value = cliente.Direccion;
                cmd.Parameters.Add("@UrlFoto", SqlDbType.VarChar).Value = cliente.Urlfoto;
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

        public static void ActualizarCliente(VOCliente cliente)
        {
            Conexion conexion = new Conexion();
            SqlConnection cnn = new SqlConnection(conexion.CadenaConexion);
            int r = 0;
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("SP_ActualizarCliente", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@IdCliente", SqlDbType.Int).Value = cliente.IdCliente;
                cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = cliente.Nombre;
                cmd.Parameters.Add("@Apellido_paterno", SqlDbType.VarChar).Value = cliente.Apellido_paterno;
                cmd.Parameters.Add("@Apellido_materno", SqlDbType.VarChar).Value = cliente.Apellido_materno;
                cmd.Parameters.Add("@Correo", SqlDbType.VarChar).Value = cliente.Correo;
                cmd.Parameters.Add("@Telefono", SqlDbType.VarChar).Value = cliente.Telefono;
                cmd.Parameters.Add("@Direccion", SqlDbType.VarChar).Value = cliente.Direccion;
                cmd.Parameters.Add("@UrlFoto", SqlDbType.VarChar).Value = cliente.Urlfoto;
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
        }//End Actualizar

        public static void EliminarCliente(int idCliente)
        {
            Conexion conexion = new Conexion();
            SqlConnection cnn = new SqlConnection(conexion.CadenaConexion);
            int r = 0;
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("SP_EliminarCliente", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@IdCliente", SqlDbType.VarChar).Value = idCliente;
                r = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("No se pudo actualizar el registro en la base de datos " + ex.Message);
            }
            finally
            {
                cnn.Close();
            }//End tyr/catch
        }//End EliminarCliente

        public static VOCliente ConsultarClientePorId(int idCliente)
        {
            VOCliente cliente = null;
            Conexion conexion = new Conexion();
            SqlConnection cnn = new SqlConnection(conexion.CadenaConexion);
            SqlDataReader datos;
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("SP_ConsultarClientePorId", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@IdCliente", SqlDbType.Int).Value = idCliente;
                datos = cmd.ExecuteReader();
                while (datos.Read())
                {
                    cliente = new VOCliente(Convert.ToInt32(datos.GetValue(0).ToString()),
                        datos.GetValue(1).ToString(),
                        datos.GetValue(2).ToString(),
                        datos.GetValue(3).ToString(),
                        datos.GetValue(4).ToString(),
                        datos.GetValue(5).ToString(),
                        datos.GetValue(6).ToString(),
                        datos.GetValue(7).ToString());
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException("No se pudo completar la busqueda");
            }
            finally
            {
                cnn.Close();
            }
            return cliente;
        }//End ConsultarClientePorId
        public static List<VOCliente> ConsultarClientes()
        {
            DataSet ds = new DataSet();
            Conexion conexion = new Conexion();
            SqlConnection cnn = new SqlConnection(conexion.CadenaConexion);
            List<VOCliente> clientes = new List<VOCliente>();
            try
            {
                SqlCommand cmd = new SqlCommand("SP_ConsultarClientes", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds, "Clientes");
                foreach (DataRow registro in ds.Tables[0].Rows)
                {
                    clientes.Add(new VOCliente(registro));

                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error al consultar el registro de cliente");
            }
            return clientes;
        }//End consultarpersona
    }//End DALCliente
}
