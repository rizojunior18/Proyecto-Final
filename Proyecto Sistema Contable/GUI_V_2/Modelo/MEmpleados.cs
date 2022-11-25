using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_V_2.Modelo
{
    public class MEmpleados
    {
        static proyectofinalEntities pfe = new proyectofinalEntities();

        public static void SaveEmpleado(Persona p)
        {
            pfe.Persona.Add(p);

            pfe.SaveChanges();

        }
        public static List<Persona> ShowAllPeople()
        {
            var consulta = (from p in pfe.Persona select p);
            return consulta.ToList();
        }

    }
}
