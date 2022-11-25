using DocumentFormat.OpenXml.Drawing;
using GUI_V_2.Modelo;
using LiteDB;
using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_V_2.Controlador
{
    public class RepositorioBalance : IRepositorio<CuentaBalance>
    {
      

        //BASE DE DATOS NOSQL -> ORIENTADA A DOCUMENTOS-> LiteDB
        private string DBName = "SistemaContable.db";
        private string TableName = "CuentaBalance";

        public List<CuentaBalance> Read
        {
            get
            {
                List<CuentaBalance> datos = new List<CuentaBalance>();
                using (var db = new LiteDatabase(DBName))
                {
                    datos = db.GetCollection<CuentaBalance>(TableName).FindAll().ToList();
                }
                return datos;
            }
            set { }
           
        }

        public List<CuentaBalance> ReadPasivo
        {
            get
            {
                return Read.Where(item => item.tipoCuenta.Contains("Pasivo")).ToList();
            }
            set { }
        }

        public List<CuentaBalance> ReadActivo
        {
            get
            {
                return Read.Where(item => item.tipoCuenta.Contains("Activo")).ToList();
            }
            set { }
        }

        public List<CuentaBalance> ReadCapital
        {
            get
            {
                return Read.Where(item => item.tipoCuenta.Contains("Capital")).ToList();
            }
            set { }
        }



        public bool Eliminar()
        {
            try
            {
                using (var db = new LiteDatabase(DBName))
                {
                    var coleccion = db.GetCollection<CuentaBalance>(TableName);
                    coleccion.DeleteAll();
                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool BulkCreate(List<CuentaBalance> entidad)
        {
            throw new NotImplementedException();
        }

        public List<CuentaBalance> Buscar(CuentaBalance nombre)
        {
            throw new NotImplementedException();
        }

        public bool Crear(CuentaBalance entidad)
        {
            bool flag = false;
            try
            {
                using (var db = new LiteDatabase(DBName))
                {
                    var coleccion = db.GetCollection<CuentaBalance>(TableName);

                        coleccion.Insert(entidad);
                        flag=true;
                    
                }
            }
            catch (Exception)
            {

                flag = false;
            }

            return flag;
        }

        public bool Editar(CuentaBalance entidadModificada)
        {
            throw new NotImplementedException();
        }

        public bool EliminarPorID(CuentaBalance entidad)
        {
            throw new NotImplementedException();
        }

        public bool ValidarCuenta(CuentaBalance entidad)
        {
            CuentaBalance objCuenta= Read.SingleOrDefault(item => item.nombreCuenta.Equals(entidad.nombreCuenta));
            if (objCuenta == null)
            {
                return false;
            }
            else
            {
                return true;
            }

            /*for (int i = 0; i < Read.Count; i++)
            {
                if (Read[i].nombreCuenta!=(entidad.nombreCuenta))
                {
                    flag = true;
                    
                }
                else { flag = false; break; }
            }*/

        }



        public void ImportarDatos(string patharchivo)
        {
            CuentaBalance objProd;
            RepositorioCuenta objCuenta;
            SLDocument sl = new SLDocument(patharchivo);
            int irow = 2;
            List<CuentaBalance> lstBG = new List<CuentaBalance>();
            List<Cuenta> lstCuentas = new List<Cuenta>();

            Eliminar();

            while (!string.IsNullOrEmpty(sl.GetCellValueAsString(irow, 1)))
            {
                objProd = new CuentaBalance();
                objCuenta = new RepositorioCuenta();
                lstCuentas = objCuenta.llenarCuentas();

                objProd.nombreCuenta = sl.GetCellValueAsString(irow, 1).ToString();
                for (int i = 0; i < lstCuentas.Count; i++)
                {
                    if (lstCuentas[i].nombreCuenta.ToUpper().Equals(objProd.nombreCuenta.ToUpper()))
                    {
                        objProd.tipoCuenta = lstCuentas[i].tipoCuenta;
                    }
                }
                objProd.monto = double.Parse(sl.GetCellValueAsString(irow, 2));


                if (ValidarCuenta(objProd))
                {
                    MessageBox.Show("No se pueden repetir la cuentas");
                }
                else
                {
                    Crear(objProd);
                }
                
                irow++;

            }
        }
    }
}
