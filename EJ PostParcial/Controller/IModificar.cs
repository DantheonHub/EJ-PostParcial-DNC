using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_PostParcial.Controller
{
    internal interface IModificar<T>
    {
        void Modificar(T entidad);
        
    }
}
