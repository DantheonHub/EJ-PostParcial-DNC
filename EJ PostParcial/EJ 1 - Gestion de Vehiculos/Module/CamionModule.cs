using EJ_PostParcial.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EJ_PostParcial.EJ_1_Gestion_de_Vehiculos.Models;
namespace EJ_PostParcial.EJ_1___Gestion_de_Vehiculos.Module
{
    internal class  CamionModule : ModuleBase
    {
        public CamionModule()
        {
            nombre = "Gestión de Camiones";
            acciones = new()
            {
                { "Agregar camion", Agregar },
                { "Eliminar camion", Eliminar },
                { "Mostrar todos los camiones", MostrarTodos },
                { "Modificar camion", Modificar },
                { "Buscar por id", BuscarPorId }
            };
        }
        protected void Agregar() => Console.WriteLine("Camion agregado");
        protected void Eliminar() => Console.WriteLine("Camion eliminado");
        protected void Modificar() => Console.WriteLine("Camion modificado");
        protected void MostrarTodos() => Console.WriteLine("Mostrando camiones...");
        protected void BuscarPorId() => Console.WriteLine("Buscando camion por ID");
    }
}
