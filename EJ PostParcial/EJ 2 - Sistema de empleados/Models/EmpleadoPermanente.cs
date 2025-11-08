using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_PostParcial.EJ_2___Sistema_de_empleados.Models
{
    internal class EmpleadoPermanente : Empleado
    {
        public int antiguedad { get; protected set; }
        public override void CalcularSueldo() 
        {
         sueldoBase += antiguedad * 1500;
        }
        public EmpleadoPermanente(int id, string nombre, string apellido, decimal sueldoBase, int antiguedad)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.sueldoBase = sueldoBase;
            this.antiguedad = antiguedad;
        }
        public override void Modificar(Empleado empleado)
        {
            base.Modificar(empleado);
            if (empleado is EmpleadoPermanente empPerm)
            {
                this.antiguedad = empPerm.antiguedad;
            }
        }
    }
}
