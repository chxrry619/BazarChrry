using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace CapaDatos
{
    public class CDProducto
    {
        public int Idproducto { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime F_ingreso { get; set; }
        public DateTime? F_vencimiento { get; set; }
        public decimal Precio_compra { get; set; }
        public decimal Precio_venta { get; set; }
        public int Stock { get; set; }
        public string Estado { get; set; }
        public int Idcategoria { get; set; }


        public DataTable Listar()
        {
            DataTable resul = new DataTable("Producto");
            SqlConnection conexion = new SqlConnection();

            try
            {
                conexion.ConnectionString = Conexion.Conn;
                conexion.Open();

                SqlCommand cmd = new SqlCommand("listar_producto", conexion);
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

        public string Eliminar(CDProducto prod)
        {
            string resul = "";
            SqlConnection conexion = new SqlConnection();

            try
            {
                conexion.ConnectionString = Conexion.Conn;
                conexion.Open();

                SqlCommand cmd = new SqlCommand("eliminar_producto", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idproducto", prod.Idproducto);

                resul = cmd.ExecuteNonQuery() == 1 ? "Producto eliminado correctamente": "No se pudo eliminar el producto";
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


        public string Guardar(CDProducto prod)
        {
            string resul = "";
            SqlConnection conexion = new SqlConnection();

            try
            {
                conexion.ConnectionString = Conexion.Conn;
                conexion.Open();

                SqlCommand cmd = new SqlCommand("sp_insertar_producto", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idproducto", prod.Idproducto);
                cmd.Parameters.AddWithValue("@codigo", prod.Codigo);
                cmd.Parameters.AddWithValue("@nombre", prod.Nombre);
                cmd.Parameters.AddWithValue("@descripcion", prod.Descripcion);
                cmd.Parameters.AddWithValue("@f_ingreso", prod.F_ingreso);

                
                cmd.Parameters.AddWithValue("@f_vencimiento", prod.F_vencimiento.HasValue ? (object)prod.F_vencimiento.Value : DBNull.Value);

                cmd.Parameters.AddWithValue("@precio_compra", prod.Precio_compra);
                cmd.Parameters.AddWithValue("@precio_venta", prod.Precio_venta);
                cmd.Parameters.AddWithValue("@stock", prod.Stock);
                cmd.Parameters.AddWithValue("@estado", prod.Estado);
                cmd.Parameters.AddWithValue("@idcategoria", prod.Idcategoria);


                resul = cmd.ExecuteNonQuery() == 1 ? "Se pudo añadir el producto correctamente": "No se pudo añadir el producto, favor de intentarlo más tarde";
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




