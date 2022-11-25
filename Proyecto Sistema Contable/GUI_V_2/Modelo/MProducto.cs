using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_V_2.Modelo
{
    public class MProducto
    {
        static proyectofinalEntities pfe = new proyectofinalEntities();

        public static void SaveProduct(Producto p)
        {
            pfe.Producto.Add(p);
            pfe.SaveChanges();
            
        }

        public static List<Producto> ShowAllProducts()
        {
            var consulta = (from p in pfe.Producto select p);
            return consulta.ToList();
        }

    }
}
