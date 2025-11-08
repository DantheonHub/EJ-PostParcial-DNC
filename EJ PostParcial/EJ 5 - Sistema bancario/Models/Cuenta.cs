using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EJ_PostParcial.Controller;
namespace EJ_PostParcial.EJ_5___Sistema_bancario.Models
{
    internal abstract class Cuenta : ID, IModificar<Cuenta>
    {
        public int id { get; protected set; }
        public int numeroCuenta { get; protected set; }
        public string titular { get; protected set; }
        public decimal saldo { get; protected set; }
        public abstract void Depositar(decimal monto);
        public abstract void Retirar(decimal monto);

        public virtual void Modificar(Cuenta codigo)
        {
            this.id = codigo.id;
            this.numeroCuenta = codigo.numeroCuenta;
            this.titular = codigo.titular;
            this.saldo = codigo.saldo;
        }
    }
}
