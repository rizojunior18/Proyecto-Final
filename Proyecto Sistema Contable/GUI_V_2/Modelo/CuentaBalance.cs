using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_V_2.Modelo
{
    public class CuentaBalance
    {
        public string tipoCuenta { get; set; }
        public string nombreCuenta { get; set; }
        public double monto { get; set; }
        public CuentaBalance() { }

        public CuentaBalance(string tipoCuenta,
            string nombreCuenta, double monto)
        {
            this.tipoCuenta = tipoCuenta;
            this.nombreCuenta = nombreCuenta;
            this.monto = monto;
        }
    }
}
