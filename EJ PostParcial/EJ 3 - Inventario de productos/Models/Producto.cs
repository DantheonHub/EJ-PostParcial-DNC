using EJ_PostParcial.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_PostParcial.EJ_3___Inventario_de_productos.Models
{
    internal abstract class Producto : IModificar<Producto>, ID
    {
        public int id { get; protected set; }
        public string nombre { get; protected set; }
        public decimal precioBase { get; protected set; }
        public virtual void Modificar(Producto entidad)
        {
            this.nombre = entidad.nombre;
            this.precioBase = entidad.precioBase;
        }
    }
}
