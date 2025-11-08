using EJ_PostParcial.Controller;
using EJ_PostParcial.Controller.EJ_1_Gestion_de_Vehiculos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_PostParcial.EJ_1_Gestion_de_Vehiculos.Models
{
    enum TipoTransmision { Manual, Automatica, Semiautomatica }
    internal class Auto : Vehiculo
    {
        public int cantidadPuertas {  get; protected set; }
        public TipoTransmision transmision { get; protected set; }
        public Auto(int id, Marca marca, string modelo, int anio, TipoCombustible combustible, int cantidadPuertas, TipoTransmision transmision)
        {
            this.id = id;
            this.marca = marca;
            this.modelo = modelo;
            this.anio = anio;
            this.combustible = combustible;
            this.cantidadPuertas = cantidadPuertas;
            this.transmision = transmision;
        }
        public override void Modificar(Vehiculo vehiculo)
        {
            var auto = vehiculo as Auto;
            this.marca = auto.marca;
            this.modelo = auto.modelo;
            this.anio = auto.anio;
            this.combustible = auto.combustible;
            this.cantidadPuertas = auto.cantidadPuertas;
            this.transmision = auto.transmision;
        }
    }
}
