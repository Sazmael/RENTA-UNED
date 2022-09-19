using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL_Clase
{
    public class Sucursales
    {
        private int identificacion;
        private String nombre;
        private String direccion;
        private bool estado;
        private String telefono;

        private String estadoSucursal;

        //Constructores
        public Sucursales()
        {
        }

        public Sucursales(int identificacion, string nombre, string direccion, bool estado, string telefono, String estadoSucursal)
        {
            this.identificacion = identificacion;
            this.nombre = nombre;
            this.direccion = direccion;
            this.estado = estado;
            this.telefono = telefono;
            this.estadoSucursal = estadoSucursal;
        }

        //Metodos
        public int Identificacion { get => identificacion; set => identificacion = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public bool Estado { get => estado; set => estado = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string EstadoSucursal { get => estadoSucursal; set => estadoSucursal = value; }
    }
}
