using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL_Clase
{
    public class Coberturas
    {
        private int idCobertura;
        private String descripcion;
        private int idTipoVehiculo;
        private bool estado;
        private int monto;
        private String estadoString;
       
        public Coberturas()
        {

        }

        public Coberturas(int idCobertura, string descripcion, int idTipoVehiculo, bool estado, int monto)
        {
            this.IdCobertura = idCobertura;
            this.Descripcion = descripcion;
            this.IdTipoVehiculo = idTipoVehiculo;
            this.Estado = estado;
            this.Monto = monto;
            
        }

       
        public int IdCobertura { get => idCobertura; set => idCobertura = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int IdTipoVehiculo { get => idTipoVehiculo; set => idTipoVehiculo = value; }
        public bool Estado { get => estado; set => estado = value; }
        public int Monto { get => monto; set => monto = value; }
        public string EstadoString { get => estadoString; set => estadoString = value; }
    }
}
