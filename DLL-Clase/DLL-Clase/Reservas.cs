using System;

namespace DLL_Clase
{
    public class Reservas
    {
        private int idReserva;
        private String idCliente;
        private String idPlaca;
        private DateTime fechaReserva;
        private DateTime fechaInicio;
        private DateTime fechaFin;
        private int montoReserva;

        public Clientes clientes = new Clientes();
        public Vehiculos vehiculos = new Vehiculos();

        public Reservas()
        {
        }

        public Reservas(int idReserva, string idCliente, string idPlaca, DateTime fechaReserva, DateTime fechaInicio, DateTime fechaFin, int montoReserva)
        {
            this.IdReserva = idReserva;
            this.IdCliente = idCliente;
            this.IdPlaca = idPlaca;
            this.FechaReserva = fechaReserva;
            this.FechaInicio = fechaInicio;
            this.FechaFin = fechaFin;
            this.MontoReserva = montoReserva;
            
        }

        public int IdReserva { get => idReserva; set => idReserva = value; }
        public string IdCliente { get => idCliente; set => idCliente = value; }
        public string IdPlaca { get => idPlaca; set => idPlaca = value; }
        public DateTime FechaReserva { get => fechaReserva.Date; set => fechaReserva = value; }
        public DateTime FechaInicio { get => fechaInicio.Date; set => fechaInicio = value; }
        public DateTime FechaFin { get => fechaFin.Date; set => fechaFin = value; }
        public int MontoReserva { get => montoReserva; set => montoReserva = value; }
   
    }
}
