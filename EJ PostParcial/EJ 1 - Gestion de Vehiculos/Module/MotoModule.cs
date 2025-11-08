using EJ_PostParcial.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EJ_PostParcial.EJ_1_Gestion_de_Vehiculos.Models;
namespace EJ_PostParcial.EJ_1___Gestion_de_Vehiculos.Module
{
    internal class MotoModule : ModuleBase
    {
        public MotoModule()
        {
            nombre = "Gestión de Motos";
            acciones = new()
            {
                { "Agregar moto", Agregar },
                { "Eliminar moto", Eliminar },
                { "Mostrar todos los motos", MostrarTodos },
                { "Modificar moto", Modificar },
                { "Buscar por id", BuscarPorId }
            };
        }
        protected void Agregar() => Console.WriteLine("moto agregado");
        protected void Eliminar() => Console.WriteLine("moto eliminado");
        protected void Modificar() => Console.WriteLine("moto modificado");
        protected void MostrarTodos() => Console.WriteLine("Mostrando motos...");
        protected void BuscarPorId() => Console.WriteLine("Buscando camion por ID");

    }
}
