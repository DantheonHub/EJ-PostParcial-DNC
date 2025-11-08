using EJ_PostParcial.Controller;
using EJ_PostParcial.EJ_1_Gestion_de_Vehiculos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace EJ_PostParcial.EJ_1___Gestion_de_Vehiculos.Module
{
    internal class AutoModule : ModuleBase
    {
        public AutoModule()
        {
            nombre = "Gestión de Autos";
            acciones = new()
            {
                { "Agregar auto", Agregar },
                { "Eliminar auto", Eliminar },
                { "Mostrar todos los autos", MostrarTodos },
                { "Modificar auto", Modificar },
                { "Buscar por id", BuscarPorId }
            };
        }
        protected void Agregar() => Console.WriteLine("Auto agregado");
        protected void Eliminar() => Console.WriteLine("Auto eliminado");
        protected void Modificar() => Console.WriteLine("Auto modificado");
        protected void MostrarTodos() => Console.WriteLine("Mostrando autos...");
        protected void BuscarPorId() => Console.WriteLine("Buscando camion por ID");
    }
}
