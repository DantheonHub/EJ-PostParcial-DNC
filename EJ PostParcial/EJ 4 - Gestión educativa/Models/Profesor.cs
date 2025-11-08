using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_PostParcial.EJ_4___Gestión_educativa.Models
{
    enum Materia
    {
        Matematica,
        Lengua,
        Ciencias,
        POO,
        Ingles
    }
    internal class Profesor : Persona
    {
        protected Materia materia { get; set; }
        protected float sueldo { get; set; }
        public Profesor(int id, string nombre, int edad, Materia materia, float sueldo)
        {
            this.id = id;
            this.nombre = nombre;
            this.edad = edad;
            this.materia = materia;
            this.sueldo = sueldo;
        }
    }
}
