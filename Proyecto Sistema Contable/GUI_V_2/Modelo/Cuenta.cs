using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_V_2.Modelo
{
    public class Cuenta
    {
        public string tipoCuenta { get; set; }
        public string nombreCuenta { get; set; }

        public Cuenta()
        {

        }


        public Cuenta(string tipoCuenta, string nombreCuenta)
        {
            this.tipoCuenta = tipoCuenta;
            this.nombreCuenta = nombreCuenta;
        }
        
    }
}
