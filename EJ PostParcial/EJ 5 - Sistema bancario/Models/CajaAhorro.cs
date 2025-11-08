using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_PostParcial.EJ_5___Sistema_bancario.Models
{
    internal class CajaAhorro : Cuenta
    {
        protected float tasaInteres { get; set; }
        public CajaAhorro(int numeroCuenta, string titular, decimal saldo, float tasaInteres)
        {
            this.numeroCuenta = numeroCuenta;
            this.titular = titular;
            this.saldo = saldo;
            this.tasaInteres = tasaInteres;
        }
        public decimal CalcularInteres()
        {
            return saldo * (decimal)tasaInteres;
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
