using EJ_PostParcial.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EJ_PostParcial.EJ_2___Sistema_de_empleados.Models;
namespace EJ_PostParcial.EJ_2___Sistema_de_empleados.Module
{
    internal class EmpleadoModule : ModuleBase
    {
        protected List<IModule> subModulos = new();
        public string nombre => "Gestión de Vehículos";

        public EmpleadoModule()
        {
            subModulos.Add(new EmpleadoTemporalModule());
            subModulos.Add(new EmpleadoPermanenteModule());
        }

    }
}
