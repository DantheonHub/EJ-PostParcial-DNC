using EJ_PostParcial.Controller.EJ_1_Gestion_de_Vehiculos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_PostParcial.EJ_1_Gestion_de_Vehiculos.Models
{
    enum TipoCarroceria{ Furgo, Camioneta, Cisterna }
    internal class Camion : Vehiculo
    {
        protected int capacidadCarga {  get; set; }
        protected int cantidadEjes { get; set; }
        protected bool tieneSidecar { get; set; }
        protected TipoCarroceria carroceria { get; set; }
        public Camion(int id, Marca marca, string modelo, int anio, TipoCombustible combustible, int capacidadCarga, int cantidadEjes, TipoCarroceria carroceria)
        {
            this.id = id;
            this.marca = marca;
            this.modelo = modelo;
            this.anio = anio;
            this.combustible = combustible;
            this.capacidadCarga = capacidadCarga;
            this.cantidadEjes = cantidadEjes;
            this.carroceria = carroceria;
        }
        public override void Modificar(Vehiculo vehiculo)
        {
            var camion = vehiculo as Camion;
            this.marca = camion.marca;
            this.modelo = camion.modelo;
            this.anio = camion.anio;
            this.combustible = camion.combustible;
            this.capacidadCarga = camion.capacidadCarga;
            this.cantidadEjes = camion.cantidadEjes;
            this.carroceria = camion.carroceria;
        }
    }
}
