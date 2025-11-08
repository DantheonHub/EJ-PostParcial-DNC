using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_PostParcial.EJ_5___Sistema_bancario.Models
{
    internal class CuentaCorriente : Cuenta
    {
        protected float limiteDescubierto { get; set; }
        public CuentaCorriente(int numeroCuenta, string titular, decimal saldo, float limiteDescubierto)
        {
            this.numeroCuenta = numeroCuenta;
            this.titular = titular;
            this.saldo = saldo;
            this.limiteDescubierto = limiteDescubierto;
        }

        public override void Depositar(decimal monto)
        {
            saldo += monto;
        }
        public override void Retirar(decimal monto)
        {
            if (monto <= saldo)
            {
                saldo -= monto;
            }
            else
            {
                Console.WriteLine("Fondos insuficientes");
            }
        }
    }
}
