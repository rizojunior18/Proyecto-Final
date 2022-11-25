using GUI_V_2.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_V_2.Controlador
{
    public class CProducto
    {
        public static void SaveProduct(string nombreProducto, string descripcion, string categoria, string marca, int precio, int cantidadDisponible)
        {
            Producto producto = new Producto();
            producto.NombreProducto = nombreProducto;
            producto.Descripcion = descripcion;
            producto.Categoria = categoria;
            producto.Marca = marca;
            producto.Precio = precio;
            producto.CantidadDisponible = cantidadDisponible;

            MProducto.SaveProduct(producto);
        }

        public static List<Producto> ShowAllProducts()
        {
            return MProducto.ShowAllProducts();
        } 
    }
}
