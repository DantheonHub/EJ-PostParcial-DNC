using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_PostParcial.VIew
{
    internal class Menu
    {
        public string titulo { get; protected set; }
        protected List<MenuOpcion> opciones { get; set; } = new();

        public Menu(string titulo)
        {
            this.titulo = titulo;
        }
        public void MostrarMenu() { }
        public void AgregarOpcion(string v, MenuOpcion opcion)
        {
            opciones.Add(opcion);
        }
        public void AgregarOpcion(string texto, Menu subMenu)
        {
            opciones.Add(new MenuOpcion(texto, () => subMenu.Mostrar()));
        }
        public void Mostrar()
        {

            while (true)
            {
                Console.Clear();
                Console.WriteLine($"=== {this.titulo} ===");

                for (int i = 0; i < opciones.Count; i++)
                    Console.WriteLine($"{i + 1}. {opciones[i].opcion}");

                Console.WriteLine("0. Salir");
                Console.Write("\nSeleccione una opción: ");

                if (!int.TryParse(Console.ReadLine(), out int opcion))
                    continue;

                if (opcion == 0)
                    break;

                if (opcion >= 1 && opcion <= opciones.Count)
                    opciones[opcion - 1].metodo();
            }
        }
    }
}
