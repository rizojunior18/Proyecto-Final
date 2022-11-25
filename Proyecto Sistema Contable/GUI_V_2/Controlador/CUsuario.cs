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
    }
}
