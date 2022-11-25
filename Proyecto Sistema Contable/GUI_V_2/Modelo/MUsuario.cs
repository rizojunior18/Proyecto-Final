using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_V_2.Modelo
{
    public class MUsuario
    {
        static proyectofinalEntities pfe = new proyectofinalEntities();

        public static bool IsValidUser(string username, string password)
        {
            var consulta = (from u in pfe.Usuario
                            where u.Username == username &&
                            u.Password == password select u);
            
            if (consulta.Any())
            {
                return true;
            }
            else
            {
                return false;
            }

            
        }
    }
}
