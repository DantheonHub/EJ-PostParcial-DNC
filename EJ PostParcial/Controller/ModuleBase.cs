using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_PostParcial.Controller
{
    internal abstract class ModuleBase : IModule
    {
        public string nombre { get; protected set; }
        public Dictionary<string, Action> acciones { get; protected set; } = new();
    }
}
