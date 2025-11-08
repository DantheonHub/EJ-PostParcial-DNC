
using EJ_PostParcial.Controller;
using EJ_PostParcial.EJ_1___Gestion_de_Vehiculos.Controller;
using EJ_PostParcial.EJ_4___Gestión_educativa.Models;
using EJ_PostParcial.VIew;

namespace EJ_PostParcial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Sistema de Gestión de Vehículos";

            // Crear módulo principal
            VehiculoModule vehiculoModule = new VehiculoModule();

            // Crear el menú principal desde el módulo
            Menu menuPrincipal = vehiculoModule.ConstruirMenu();

            // Mostrar el menú principal
            menuPrincipal.Mostrar();

            Console.WriteLine("Gracias por usar el sistema. ¡Hasta luego!");
        }
    }
}
