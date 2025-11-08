using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_PostParcial.EJ_2___Sistema_de_empleados.Models
{
    internal class EmpleadoTemporal : Empleado
    {
        public int horasTrabajadas { get; protected set; }
        public decimal valorHora { get; protected set; }
        public override void CalcularSueldo()
        {
            sueldoBase = horasTrabajadas * valorHora; 
        }
        public EmpleadoTemporal(int id, string nombre, string apellido, int horasTrabajadas, decimal valorHora)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.horasTrabajadas = horasTrabajadas;
            this.valorHora = valorHora;
        }
        public override void Modificar(Empleado empleado)
        {
            base.Modificar(empleado);
            if (empleado is EmpleadoTemporal empTemp)
            {
                this.horasTrabajadas = empTemp.horasTrabajadas;
                this.valorHora = empTemp.valorHora;
            }
        }
    }
}
