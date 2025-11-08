using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_PostParcial.Controller
{
    public interface ICRUD<T>
    {
        void Agregar(T entidad);
        void Eliminar(T entidad);
        List<T> MostrarTodos();
        T ObtenerPorID(int id);
        bool CompararID(T entidad, int id);

    }
}
