using DocumentFormat.OpenXml.InkML;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
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

        public static void SaveUsuario(Usuario u)
        {
            pfe.Usuario.Add(u);

            pfe.SaveChanges();

        }

        public static List<UsuarioEmpleado> ShowUsuarios()
        {
            var consulta = (from p in pfe.Persona
                            join u in pfe.Usuario on p.IdPersona
                            equals u.IdPersona
                            select new UsuarioEmpleado
                            {
                                IdUsuario = u.IdUsuario,
                                Username = u.Username,
                                RoleUser = u.RoleUser,
                                PrimerNombre = p.PrimerNombre,
                                PrimerApellido = p.PrimerApellido
                            });
            return consulta.ToList();
        }

        public static void EliminarUsuario(string userName)
        {
            var consulta = (from u in pfe.Usuario
                            where u.Username == userName 
                            select u).First();

            pfe.Usuario.Remove(consulta);
            pfe.SaveChanges();
        }

        public static void ActualizarUsuario(string userName,string passWord)
        {
          
            
        }
    }
}
