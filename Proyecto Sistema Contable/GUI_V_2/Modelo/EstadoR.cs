using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_V_2.Modelo
{
    public class EstadoR
    {
        public EstadoR() { }

        public double calcularVentasNetas(double ventas, double devoluciones, double descuento)
        {
            return ventas - (devoluciones + descuento);
        }

        public double calcularUtilidadBruta(double costoVentas, double ventasNetas)
        {
            return ventasNetas - costoVentas;
        }

        public double calcularUtilidadOperacional(double utilidadBruta, double gtoOperacional)
        {
            return utilidadBruta - gtoOperacional;
        }

        public double calcularUtilidadAntesImpuestos(double utilidadOperacional, double gtoFinanciero)
        {
            return utilidadOperacional - gtoFinanciero;
        }

        public double calcularIR(double UAI)
        {
            return 0.3 * UAI;
        }

        public double calcularUtilidadNeta(double UAI, double IR)
        {
            return UAI - IR;
        }

    }
}
