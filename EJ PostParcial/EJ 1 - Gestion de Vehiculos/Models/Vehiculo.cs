using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_PostParcial.Controller.EJ_1_Gestion_de_Vehiculos
{
    public enum Marca { Ford, Toyota, BMW, Bugatti, Yamaha }
    public enum TipoCombustible { Gasolina, Diesel, Electrico, Hibrido }
    internal abstract class Vehiculo : IModificar<Vehiculo>, ID
    {
        public int id {  get; protected set; }
        public Marca marca { get; protected set; }
        public string modelo { get; protected set; }
        public int anio { get; protected set; }
        public TipoCombustible combustible { get; protected set; }
        public virtual void Modificar(Vehiculo vehiculo)
        {
            this.marca = vehiculo.marca;
            this.modelo = vehiculo.modelo;
            this.anio = vehiculo.anio;
            this.combustible = vehiculo.combustible;
        }
    }
}
