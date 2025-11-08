using EJ_PostParcial.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_PostParcial.EJ_2___Sistema_de_empleados.Module
{
    internal class EmpleadoTemporalModule : ModuleBase
    {
        public EmpleadoTemporalModule()
        {
            this.nombre = "Empleado Temporal";
            acciones = new()
            {
                { $"Agregar {this.nombre}", Agregar },
                { $"Eliminar {this.nombre}", Eliminar },
                { $"Mostrar todos los Empleado Temporales", MostrarTodos },
                { $"Modificar {this.nombre}", Modificar },
                { $"Buscar por id", BuscarPorId }
            };
        }

        protected void Agregar() => Console.WriteLine("Empleado temporal agregado");
        protected void Eliminar() => Console.WriteLine("Empleado temporal eliminado");
        protected void Modificar() => Console.WriteLine("Empleado temporales modificado");
        protected void MostrarTodos() => Console.WriteLine("Mostrando empleados temporales...");
        protected void BuscarPorId() => Console.WriteLine("Buscando camion por ID");
    }
 }

