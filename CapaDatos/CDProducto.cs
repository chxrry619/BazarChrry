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

        public string Editar(CDProducto prod)
        {
            string rpta = "";

            try
            {
                using (SqlConnection SqlCon = new SqlConnection())
                {
                    SqlCon.Open();

                    using (SqlCommand SqlCmd = new SqlCommand("editar_producto", SqlCon))
                    {
                        SqlCmd.CommandType = CommandType.StoredProcedure;

                        SqlCmd.Parameters.AddWithValue("@idproducto", prod.Idproducto);
                        SqlCmd.Parameters.AddWithValue("@codigo", prod.Codigo);
                        SqlCmd.Parameters.AddWithValue("@nombre", prod.Nombre);
                        SqlCmd.Parameters.AddWithValue("@descripcion", prod.Descripcion);
                        SqlCmd.Parameters.AddWithValue("@f_ingreso", prod.F_ingreso);

                        // Fecha de vencimiento puede ser NULL
                        if (prod.F_vencimiento == DateTime.MinValue)
                            SqlCmd.Parameters.AddWithValue("@f_vencimiento", DBNull.Value);
                        else
                            SqlCmd.Parameters.AddWithValue("@f_vencimiento", prod.F_vencimiento);

                        SqlCmd.Parameters.AddWithValue("@precio_compra", prod.Precio_compra);
                        SqlCmd.Parameters.AddWithValue("@precio_venta", prod.Precio_venta);
                        SqlCmd.Parameters.AddWithValue("@stock", prod.Stock);
                        SqlCmd.Parameters.AddWithValue("@estado", prod.Estado);
                        SqlCmd.Parameters.AddWithValue("@idcategoria", prod.Idcategoria);

                        rpta = SqlCmd.ExecuteNonQuery() == 1
                            ? "OK"
                            : "No se pudo editar el producto";
                    }
                }
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }

            return rpta;
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




