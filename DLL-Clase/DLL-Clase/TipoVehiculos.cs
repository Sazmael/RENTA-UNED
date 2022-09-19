using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL_Clase
{
    public class TipoVehiculos
    {
        private int id;
        private String descripcion;
        private bool estado;

        private String estadoTipoVehiculo;

        public TipoVehiculos()
        {
        }

        public TipoVehiculos(int id, string descripcion, bool estado, string estadoTipoVehiculo)
        {
            this.Id = id;
            this.Descripcion = descripcion;
            this.Estado = estado;
            this.EstadoTipoVehiculo = estadoTipoVehiculo;
        }

        public int Id { get => id; set => id = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public bool Estado { get => estado; set => estado = value; }
        public string EstadoTipoVehiculo { get => estadoTipoVehiculo; set => estadoTipoVehiculo = value; }
    }
}
