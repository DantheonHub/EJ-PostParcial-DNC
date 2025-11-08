using EJ_PostParcial.Controller;
using EJ_PostParcial.EJ_2___Sistema_de_empleados.Module;
using EJ_PostParcial.EJ_3___Inventario_de_productos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EJ_PostParcial.EJ_3___Inventario_de_productos.Controller.Module
{
    internal class ProductoModule : ModuleBase
    {
        protected List<IModule> subModulos = new();
        public string nombre => "Gestión de Vehículos";

        public ProductoModule()
        {
            subModulos.Add(new EmpleadoTemporalModule());
            subModulos.Add(new EmpleadoPermanenteModule());
        }
    }
}
