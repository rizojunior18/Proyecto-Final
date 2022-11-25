using GUI_V_2.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_V_2.Controlador
{
    public class CEmpleados
    {
        public static void SaveEmpleado(string primerNombre, string segundoNombre, string primerApellido, 
            string segundoApellido, string correo, string telefono)
        {
            Persona persona = new Persona();
            persona.PrimerNombre = primerNombre;
            persona.SegundoNombre = segundoNombre;
            persona.PrimerApellido = primerApellido;
            persona.SegundoApellido = segundoApellido;
            persona.Correo = correo;
            persona.Telefono = telefono;

            MEmpleados.SaveEmpleado(persona);
        }

        public static List<Persona> ShowAllPeople()
        {
            return MEmpleados.ShowAllPeople();
        }
    }
}
