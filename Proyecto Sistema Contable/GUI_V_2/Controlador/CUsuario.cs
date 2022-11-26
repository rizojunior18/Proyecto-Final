using GUI_V_2.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_V_2.Controlador
{
    public class CUsuario
    {
       public static bool IsValidUser(string username, string password)
        {
            return MUsuario.IsValidUser(username, password);
        }
        public static void SaveUsuario(int IdPersona, string username, string password, int permiso, string roleUser)
        {
            Usuario usuario = new Usuario();
            usuario.IdPersona = IdPersona;
            usuario.Username = username;
            usuario.Password = password;
            usuario.Permiso = permiso;
            usuario.RoleUser = roleUser;
            

            MUsuario.SaveUsuario(usuario);
        }

        public static List<UsuarioEmpleado> ShowUsuarios()
        {
            return MUsuario.ShowUsuarios();
        }
    }
}
