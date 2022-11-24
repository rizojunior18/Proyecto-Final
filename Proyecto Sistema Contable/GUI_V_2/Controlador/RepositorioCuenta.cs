using GUI_V_2.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GUI_V_2.Controlador
{
    public class RepositorioCuenta : IRepositorio<Cuenta>
    {
        public List<Cuenta> Read {
            get; set;  
        }

        public List<Cuenta> list
        {
            get; set;
        }


        public bool Eliminar()
        {
            throw new NotImplementedException();
        }

        public bool BulkCreate(List<Cuenta> entidad)
        {
            throw new NotImplementedException();
        }

        public List<Cuenta> Buscar(Cuenta nombre)
        {
            throw new NotImplementedException();
        }

        public bool Crear(Cuenta entidad)
        {
            list.Add(entidad);
            return true;
        }

        bool IRepositorio<Cuenta>.Editar(Cuenta entidadModificada)
        {
            throw new NotImplementedException();
        }

        bool IRepositorio<Cuenta>.EliminarPorID(Cuenta entidad)
        {
            throw new NotImplementedException();
        }

        public List<Cuenta> llenarCuentas()
        {
            Cuenta cuenta = new Cuenta();
            List<Cuenta> lstCuenta = new List<Cuenta>();
            lstCuenta.Clear();
            lstCuenta = new List<Cuenta>();

            lstCuenta.Add(new Cuenta("Activo circulante", "Caja"));
            lstCuenta.Add(new Cuenta("Activo circulante", "Bancos"));
            lstCuenta.Add(new Cuenta("Activo circulante", "Inversiones en bonos"));
            lstCuenta.Add(new Cuenta("Activo circulante", "Clientes"));
            lstCuenta.Add(new Cuenta("Activo circulante", "Documentos por cobrar"));
            lstCuenta.Add(new Cuenta("Activo circulante", "Deudores"));
            lstCuenta.Add(new Cuenta("Activo circulante", "Inventario"));
            lstCuenta.Add(new Cuenta("Activo circulante", "Propaganda y publicidad"));
            lstCuenta.Add(new Cuenta("Activo circulante", "Papelería y útiles"));
            lstCuenta.Add(new Cuenta("Activo circulante", "Anticipo a proveedores"));
            lstCuenta.Add(new Cuenta("Activo circulante", "Rentas pagadas por anticipado"));
            lstCuenta.Add(new Cuenta("Activo circulante", "Primas de seguro"));

            ///Activos no corrientes
            lstCuenta.Add(new Cuenta("Activo no circulante", "Terreno"));
            lstCuenta.Add(new Cuenta("Activo no circulante", "Edificios"));
            lstCuenta.Add(new Cuenta("Activo no circulante", "Mobiliario y equipo"));
            lstCuenta.Add(new Cuenta("Activo no circulante", "Maquinaria y Equipo"));
            lstCuenta.Add(new Cuenta("Activo no circulante", "Vehículos"));
            lstCuenta.Add(new Cuenta("Activo no circulante", "Herramientas"));
            lstCuenta.Add(new Cuenta("Activo no circulante", "Equipo de reparto"));
            lstCuenta.Add(new Cuenta("Activo no circulante", "Derechos de autor"));
            lstCuenta.Add(new Cuenta("Activo no circulante", "Marcas y patentes"));
            lstCuenta.Add(new Cuenta("Activo no circulante", "Licencias"));
            lstCuenta.Add(new Cuenta("Activo no circulante", "Gastos de instalación"));
            lstCuenta.Add(new Cuenta("Activo no circulante", "Depósito en garantía"));
            lstCuenta.Add(new Cuenta("Activo no circulante", "Depósito programas informáticos"));

            //Pasivos corrientes
            lstCuenta.Add(new Cuenta("Pasivo circulante", "Proveedores"));
            lstCuenta.Add(new Cuenta("Pasivo circulante", "Sueldos y salarios por pagar"));
            lstCuenta.Add(new Cuenta("Pasivo circulante", "Impuestos por pagar"));
            lstCuenta.Add(new Cuenta("Pasivo circulante", "Intereses por pagar"));
            lstCuenta.Add(new Cuenta("Pasivo circulante", "Documentos por pagar"));
            lstCuenta.Add(new Cuenta("Pasivo circulante", "Acreedores"));
            lstCuenta.Add(new Cuenta("Pasivo circulante", "Prestamos bancarios"));
            lstCuenta.Add(new Cuenta("Pasivo circulante", "Prestamos hipotecarios"));
            lstCuenta.Add(new Cuenta("Pasivo circulante", "Rentas cobradas por anticipado"));
            lstCuenta.Add(new Cuenta("Pasivo circulante", "Anticipo de clientes"));
            lstCuenta.Add(new Cuenta("Pasivo circulante", "Servicios cobrados por anticipado"));
            lstCuenta.Add(new Cuenta("Pasivo circulante", "Cuentas por pagar a corto plazo"));

            //Pasivos no corrientes
            lstCuenta.Add(new Cuenta("Pasivo no circulante", "Cuentas por pagar a lP"));
            lstCuenta.Add(new Cuenta("Pasivo no circulante", "Obligaciones comerciales"));
            lstCuenta.Add(new Cuenta("Pasivo no circulante", "Obligaciones a lP"));

            //Capital contable
            lstCuenta.Add(new Cuenta("Capital", "Reservas"));
            lstCuenta.Add(new Cuenta("Capital", "Resultados acumulados"));
            return lstCuenta;

        }


       
    }
}
