using EJ_PostParcial.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_PostParcial.EJ_2___Sistema_de_empleados.Models
{
    internal abstract class Empleado : IModificar<Empleado>, ID
    {
        public int id { get; protected set; }
        public string nombre { get; protected set; }
        public string apellido { get; protected set; }
        public decimal sueldoBase { get; protected set; }

        public abstract void CalcularSueldo();
        public virtual void Modificar(Empleado entidad)
        {
            this.nombre = entidad.nombre;
            this.apellido = entidad.apellido;
            this.sueldoBase = entidad.sueldoBase;
        }
    }
}
