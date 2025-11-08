using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EJ_PostParcial.Controller;
using EJ_PostParcial.EJ_4___Gestión_educativa.Models;
namespace EJ_PostParcial.EJ_4___Gestión_educativa.Module
{
    internal class ColegioModule
    {
        public CrudBase<Alumno> estudiante = new();
        public CrudBase<Profesor> profesor = new();
    }
}
