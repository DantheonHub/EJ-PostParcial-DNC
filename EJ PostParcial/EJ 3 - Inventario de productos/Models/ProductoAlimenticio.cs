using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_PostParcial.EJ_3___Inventario_de_productos.Models
{
    internal class ProductoAlenticio : Producto
    {
        protected DateTime fechaVencimiento { get; set; }
        public ProductoAlenticio(int id, string nombre, decimal precioBase, DateTime fechaVencimiento)
        {
            this.id = id;
            this.nombre = nombre;
            this.precioBase = precioBase;
            this.fechaVencimiento = fechaVencimiento;
        }
        public override void Modificar(Producto entidad)
        {
            base.Modificar(entidad);
            if (entidad is ProductoAlenticio prodAlim)
            {
                this.fechaVencimiento = prodAlim.fechaVencimiento;
            }
        }
    }
}
