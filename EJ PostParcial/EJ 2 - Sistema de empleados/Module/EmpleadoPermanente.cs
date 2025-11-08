using EJ_PostParcial.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_PostParcial.EJ_2___Sistema_de_empleados.Module
{
    internal class EmpleadoPermanenteModule : ModuleBase
    {
        public EmpleadoPermanenteModule()
        {
            this.nombre = "Empleado Permanente";
            acciones = new()
            {
                { $"Agregar {this.nombre}", Agregar },
                { $"Eliminar {this.nombre}", Eliminar },
                { $"Mostrar todos los Empleado Permanentes", MostrarTodos },
                { $"Modificar {this.nombre}", Modificar },
                { $"Buscar por id", BuscarPorId }
            };
        }

        protected void Agregar() => Console.WriteLine("Camion agregado");
        protected void Eliminar() => Console.WriteLine("Camion eliminado");
        protected void Modificar() => Console.WriteLine("Camion modificado");
        protected void MostrarTodos() => Console.WriteLine("Mostrando camiones...");
        protected void BuscarPorId() => Console.WriteLine("Buscando camion por ID");
    }
 }

