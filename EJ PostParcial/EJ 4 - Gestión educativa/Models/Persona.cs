using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EJ_PostParcial.Controller;

namespace EJ_PostParcial.EJ_4___Gestión_educativa.Models
{
    internal abstract class Persona : ID
    {
        public int id { get; protected set; }
        public  string nombre { get; protected set; }
        public int edad { get; protected set; }
    }
}
