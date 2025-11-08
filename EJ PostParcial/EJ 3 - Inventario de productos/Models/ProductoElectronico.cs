using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_PostParcial.EJ_3___Inventario_de_productos.Models
{
    internal class ProductoElectronico : Producto
    {
        protected int mesesGarantia { get; set; }
        public ProductoElectronico(int id, string nombre, decimal precioBase, int mesesGarantia)
        {
            this.id = id;
            this.nombre = nombre;
            this.precioBase = precioBase;
            this.mesesGarantia = mesesGarantia;
        }
        public override void Modificar(Producto entidad)
        {
            base.Modificar(entidad);
            if (entidad is ProductoElectronico prodElect)
            {
                this.mesesGarantia = prodElect.mesesGarantia;
            }
        }
    }
}
