using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CNProducto
    {
        public static DataTable Listar()
        {
            CDProducto Datos = new CDProducto();
            return Datos.Listar();
        }




        public static string Guardar(string nombre, string descripcion, decimal precio_compra, int stock, string estado)
        {
            CDProducto Datos = new CDProducto();
            Datos.Nombre = nombre;
            Datos.Descripcion = descripcion;
            Datos.Precio_compra = precio_compra;
            Datos.Stock = stock;
            Datos.Estado = estado;
            return Datos.Guardar(Datos);
        }

        public static string Editar(int idproducto, string nombre, string descripcion, decimal precio_compra, int stock, string estado)
        {
            CDProducto Datos = new CDProducto();

            Datos.Idproducto = idproducto;
            Datos.Nombre = nombre;
            Datos.Descripcion = descripcion;
            Datos.Precio_compra = precio_compra;
            Datos.Stock = stock;
            Datos.Estado = estado;

            return Datos.Editar(Datos);
        }

        public static string Eliminar(int idproducto)
        {
            CDProducto Datos = new CDProducto();
            Datos.Idproducto = idproducto;
            return Datos.Eliminar(Datos);
        }




    }
}
