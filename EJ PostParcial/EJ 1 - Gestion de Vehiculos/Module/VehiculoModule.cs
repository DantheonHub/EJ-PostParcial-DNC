using EJ_PostParcial.Controller;
using EJ_PostParcial.Controller.EJ_1_Gestion_de_Vehiculos;
using EJ_PostParcial.EJ_1___Gestion_de_Vehiculos.Module;
using EJ_PostParcial.EJ_1_Gestion_de_Vehiculos.Models;
using EJ_PostParcial.VIew;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace EJ_PostParcial.EJ_1___Gestion_de_Vehiculos.Controller
{
    internal class VehiculoModule : ModuleBase
    {
        protected List<IModule> subModulos = new();

        public string nombre => "Gestión de Vehículos";

        public VehiculoModule()
        {
            subModulos.Add(new AutoModule());
            subModulos.Add(new MotoModule());
            subModulos.Add(new CamionModule());
        }
        public Menu ConstruirMenu()
        {
            Menu menuVehiculos = new(nombre);

            foreach (var modulo in subModulos)
            {
                var m = modulo;
                Menu subMenu = new(m.nombre);

                foreach (var accion in m.acciones)
                    subMenu.AgregarOpcion(accion.Key, new MenuOpcion(accion.Key, accion.Value));

                menuVehiculos.AgregarOpcion(m.nombre, subMenu);
            }
            return menuVehiculos;
        }
    }
}
     
       
      