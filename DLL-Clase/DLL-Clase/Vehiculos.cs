using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL_Clase
{
    public class Vehiculos
    {
        private String idPlaca;
        private String marca;
        private String modelo;
        private int idtipoVehiculo;
        private int costoAlquiler;
        private int kilometraje;

        public TipoVehiculos tipoVehiculo = new TipoVehiculos();
        
        public Vehiculos()
        {
        }

        public Vehiculos(string idPlaca, string marca, string modelo, int idtipoVehiculo, int costoAlquiler, int kilometraje)
        {
            this.IdPlaca = idPlaca;
            this.Marca = marca;
            this.Modelo = modelo;
            this.IdtipoVehiculo = idtipoVehiculo;
            this.CostoAlquiler = costoAlquiler;
            this.Kilometraje = kilometraje;
            
        }

        public string IdPlaca { get => idPlaca; set => idPlaca = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public int IdtipoVehiculo { get => idtipoVehiculo; set => idtipoVehiculo = value; }
        public int CostoAlquiler { get => costoAlquiler; set => costoAlquiler = value; }
        public int Kilometraje { get => kilometraje; set => kilometraje = value; }
        
    }
}
