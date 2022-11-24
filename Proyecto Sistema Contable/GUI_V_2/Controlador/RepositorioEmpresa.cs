using GUI_V_2.Modelo;
using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_V_2.Controlador
{
    public class RepositorioEmpresa : IRepositorio<Empresa>
    {
        private string DBName = "SistemaContable.db";
        private string TableName = "Empresa";
        public List<Empresa> Read {
            get
            {
                List<Empresa> datos = new List<Empresa>();
                using (var db = new LiteDatabase(DBName))
                {
                    datos = db.GetCollection<Empresa>(TableName).FindAll().ToList();
                }
                return datos;
            }
            set { }
        }

        public bool BulkCreate(List<Empresa> entidad)
        {
            throw new NotImplementedException();
        }

        public List<Empresa> Buscar(Empresa nombre)
        {
            throw new NotImplementedException();
        }

        public bool Crear(Empresa entidad)
        {
            bool flag = false;
            try
            {
                using (var db = new LiteDatabase(DBName))
                {
                    var coleccion = db.GetCollection<Empresa>(TableName);
                    coleccion.DeleteAll();
                    coleccion.Insert(entidad);
                    flag = true;

                }
            }
            catch (Exception)
            {

                flag = false;
            }

            return flag;
        }

        public bool Editar(Empresa entidadModificada)
        {
            throw new NotImplementedException();
        }

        public bool Eliminar()
        {
            throw new NotImplementedException();
        }

        public bool EliminarPorID(Empresa entidad)
        {
            throw new NotImplementedException();
        }
    }
}
