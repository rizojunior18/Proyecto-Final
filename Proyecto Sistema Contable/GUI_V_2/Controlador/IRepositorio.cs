using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_V_2.Controlador
{
    public interface IRepositorio<T> where T : class
    {

        bool Crear(T entidad);
        bool Editar(T entidadModificada);
        bool Eliminar();
        List<T> Buscar(T nombre);
        List<T> Read { get; set; }

        bool EliminarPorID(T entidad);

        bool BulkCreate(List<T> entidad);


    }
}
