using EJ_PostParcial.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EJ_PostParcial.EJ_5___Sistema_bancario.Models;

namespace EJ_PostParcial.EJ_5___Sistema_bancario.Controller
{
    internal class CuentaModule
    {
        public CrudBase<CuentaCorriente> crudCuentaCorriente = new();
        public CrudBase<CajaAhorro> cajaAhorro = new();
    }
}
