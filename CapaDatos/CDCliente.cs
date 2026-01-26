using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CDCliente
    {
        public int Idcliente { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Dni { get; set; }
        public string Rfc { get; set; }
        public string Telefono { get; set; }
        public string Estado { get; set; }
        public string Buscar { get; set; }

        public DataTable Listar()
        {
            DataTable resul = new DataTable("cliente");
            SqlConnection conexion = new SqlConnection();

            try
            {
                conexion.ConnectionString = Conexion.Conn;
                conexion.Open();

                SqlCommand cmd = new SqlCommand("splistar_cliente", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter sqlDat = new SqlDataAdapter(cmd);
                sqlDat.Fill(resul);
            }
            catch (Exception)
            {
                resul = null;
                throw;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

            return resul;
        }


        public string Guardar(CDCliente cli)
        {
            string resul = "";
            SqlConnection conexion = new SqlConnection();

            try
            {
                conexion.ConnectionString = Conexion.Conn;
                conexion.Open();

                SqlCommand cmd = new SqlCommand("spguardar_cliente", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@idcliente", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.Parameters.AddWithValue("@nombre", cli.Nombre);
                cmd.Parameters.AddWithValue("@apellidos", cli.Apellidos);
                cmd.Parameters.AddWithValue("@dni", cli.Dni);
                cmd.Parameters.AddWithValue("@rfc", cli.Rfc);
                cmd.Parameters.AddWithValue("@telefono", cli.Telefono);
                cmd.Parameters.AddWithValue("@estado", cli.Estado);

                resul = cmd.ExecuteNonQuery() == 1
                    ? "OK"
                    : "No se pudo insertar el registro";
            }
            catch (Exception ex)
            {
                resul = ex.Message;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

            return resul;
        }
    }
}
