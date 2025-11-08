using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_PostParcial.VIew
{
    internal class MenuOpcion
    {
        public string opcion {  get; set; }
        public Action metodo { get; set; }
        public MenuOpcion(string opcion, Action metodo)
        {
            this.opcion = opcion;
            this.metodo = metodo;
        }
    }
}
