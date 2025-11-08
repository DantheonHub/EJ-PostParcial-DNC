using EJ_PostParcial.Controller.EJ_1_Gestion_de_Vehiculos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_PostParcial.EJ_1_Gestion_de_Vehiculos.Models
{
    enum TipoMoto {Scooter, Deportiva, Enduro, Touring}
    internal class Moto : Vehiculo
    {
        public int cilindrada { get; protected set; }
        public TipoMoto tipo { get; protected set; }
        public bool tieneSidecar { get; protected set; }
        public Moto(int id, Marca marca, string modelo, int anio, TipoCombustible combustible, int cilindrada, TipoMoto tipo, bool tieneSidecar)
        {
            this.id = id;
            this.marca = marca;
            this.modelo = modelo;
            this.anio = anio;
            this.combustible = combustible;
            this.cilindrada = cilindrada;
            this.tipo = tipo;
            this.tieneSidecar = tieneSidecar;
        }
        public override void Modificar(Vehiculo vehiculo)
        {
            var moto = vehiculo as Moto;
            this.marca = moto.marca;
            this.modelo = moto.modelo;
            this.anio = moto.anio;
            this.combustible = moto.combustible;
            this.cilindrada = moto.cilindrada;
            this.tipo = moto.tipo;
            this.tieneSidecar = moto.tieneSidecar;
        }
    }
}
