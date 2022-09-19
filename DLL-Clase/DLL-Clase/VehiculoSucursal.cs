using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL_Clase
{
    public class VehiculoSucursal
    {
        private int idAsignacion;
        private DateTime fecha;
        private int idSucursal;
        private String idPlaca;

        public Vehiculos vehiculos = new Vehiculos();
        public Sucursales sucursales = new Sucursales();

        public VehiculoSucursal()
        {
        }

        public VehiculoSucursal(int idAsignacion, DateTime fecha, int idSucursal, string idPlaca)
        {
            this.IdAsignacion = idAsignacion;
            this.Fecha = fecha;
            this.IdSucursal = idSucursal;
            this.IdPlaca = idPlaca;
        }

        public int IdAsignacion { get => idAsignacion; set => idAsignacion = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public int IdSucursal { get => idSucursal; set => idSucursal = value; }
        public string IdPlaca { get => idPlaca; set => idPlaca = value; }
        
    }
}
