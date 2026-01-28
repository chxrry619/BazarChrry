using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace CapaDatos
{
    public class Conexion
    {
        public static string Conn =
            "Data Source=DESKTOP-JFC5IH6\\SQLEXPRESS;Initial Catalog=ventas;Integrated Security=True";

        public static bool ProbarConexion(out string mensaje)
        {
            mensaje = "";

            try
            {
                using (SqlConnection cn = new SqlConnection(Conn))
                {
                    cn.Open();
                    mensaje = "Conexión exitosa a la base de datos";
                    return true;
                }
            }
            catch (Exception ex)
            {
                mensaje = "Error de conexión: " + ex.Message;
                return false;
            }
        }
    }
}
