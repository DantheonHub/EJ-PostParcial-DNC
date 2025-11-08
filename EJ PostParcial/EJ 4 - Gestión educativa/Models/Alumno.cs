using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_PostParcial.EJ_4___Gestión_educativa.Models
{
    internal class Alumno : Persona
    {
        protected int legajo { get; set; }
        protected float promedio { get; set; }
        public Alumno(int id, string nombre, int edad, int legajo, float promedio)
        {
            this.id = id;
            this.nombre = nombre;
            this.edad = edad;
            this.legajo = legajo;
            this.promedio = promedio;
        }
    }
}
