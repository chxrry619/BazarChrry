using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ConexionHelper
    {
        public static string Probar()
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Conexion.Conn))
                {
                    cn.Open();
                    return "Conexión exitosa a la base de datos";
                }
            }
            catch (Exception ex)
            {
                return "Error de conexión: " + ex.Message;
            }
        }
    }
}