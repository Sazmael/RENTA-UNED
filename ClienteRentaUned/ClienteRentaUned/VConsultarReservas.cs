using DLL_Clase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteRentaUned
{
    public partial class VConsultarReservas : Form
    {
        ClienteTCP tcp = new ClienteTCP();
        VLogin loginCliente = new VLogin();
        List<Reservas> lista = new List<Reservas>();
        public VConsultarReservas(VLogin Parameter)
        {
            InitializeComponent();
            this.loginCliente = Parameter;
            this.label_NombreCliente.Text = "Reservas de " + loginCliente.nombreCompleto;
        }

        private void VConsultarReservas_Load(object sender, EventArgs e)
        {


        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            VMenuCliente c = new VMenuCliente(loginCliente);
            this.Close();
            c.Show();
        }

        private void btn_TodaReserva_Click(object sender, EventArgs e)
        {
            this.dGV_Reservas.Rows.Clear();
            if (ClienteTCP.CheckConexionServer(loginCliente.IdCliente) == true)
            {
                lista = tcp.ConsultarReservasCliente(loginCliente.IdCliente);
                if (lista.Count() == 0)
                {
                    MessageBox.Show("Usted no poseé Reservas de vehiculos en RENTA-UNED!", "Sin reservas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else
                {
                    foreach (var reserva in lista)
                    {
                        if (loginCliente.IdCliente == reserva.IdCliente)
                        {

                            this.dGV_Reservas.ColumnCount = 11;
                            nombrarColumnas();
                            this.dGV_Reservas.Rows.Add(reserva.clientes.Nombre, reserva.clientes.Primer_apellido, reserva.clientes.Segundo_apellido,
                                reserva.vehiculos.IdPlaca, reserva.vehiculos.Modelo, reserva.vehiculos.Marca,
                                reserva.IdReserva, reserva.FechaReserva.Date.ToString("dd-MM-yyyy"), reserva.FechaInicio.Date.ToString("dd-MM-yyyy"), reserva.FechaFin.Date.ToString("dd-MM-yyyy"),
                                reserva.MontoReserva);

                        }
                    }
                }

            }
            else
            {
                MessageBox.Show("No se logró establecer conexión con el servidor!\nIntentelo nuevamente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btn_BuscarReserva_Click(object sender, EventArgs e)
        {

            bool encontrar = false;
            if (ClienteTCP.CheckConexionServer(loginCliente.IdCliente) == true)
            {
                lista = tcp.ConsultarReservasCliente(loginCliente.IdCliente);
                this.dGV_Reservas.Rows.Clear();

                foreach (var reserva in lista)
                {
                    if (reserva.IdReserva == int.Parse(this.txt_IDReserva.Text) && loginCliente.IdCliente == reserva.IdCliente)
                    {
                        encontrar = true;
                        this.dGV_Reservas.ColumnCount = 11;
                        nombrarColumnas();
                        this.dGV_Reservas.Rows.Add(reserva.clientes.Nombre, reserva.clientes.Primer_apellido, reserva.clientes.Segundo_apellido,
                        reserva.vehiculos.IdPlaca, reserva.vehiculos.Modelo, reserva.vehiculos.Marca,
                        reserva.IdReserva, reserva.FechaReserva.Date.ToString("dd-MM-yyyy"), reserva.FechaInicio.Date.ToString("dd-MM-yyyy"), reserva.FechaFin.Date.ToString("dd-MM-yyyy"),
                        reserva.MontoReserva);

                    }

                }
                if (encontrar == false)
                {
                    MessageBox.Show("Reserva con el ID de asignación " + this.txt_IDReserva.Text + " no encontrada");
                }

            }
            else
            {
                MessageBox.Show("No se logró establecer conexión con el servidor!\nIntentelo nuevamente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void nombrarColumnas()
        {
            this.dGV_Reservas.Columns[0].Name = "Nombre Cliente";
            this.dGV_Reservas.Columns[1].Name = "Primer Apellido";
            this.dGV_Reservas.Columns[2].Name = "Segundo. Apellido";
            this.dGV_Reservas.Columns[3].Name = "Placa Vehiculo";
            this.dGV_Reservas.Columns[4].Name = "Modelo Vehiculo";
            this.dGV_Reservas.Columns[5].Name = "Marca Vehiculo";
            this.dGV_Reservas.Columns[6].Name = "ID de Reserva";
            this.dGV_Reservas.Columns[7].Name = "Fecha de Reserva";
            this.dGV_Reservas.Columns[8].Name = "Fecha de Inicio Reserva";
            this.dGV_Reservas.Columns[9].Name = "Fecha de Fin Reserva";
            this.dGV_Reservas.Columns[10].Name = "Monto de Reserva";
        }

        private void txt_IDReserva_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten numeros enteros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_IDReserva_TextChanged(object sender, EventArgs e)
        {
            this.btn_BuscarReserva.Enabled = !string.IsNullOrWhiteSpace(this.txt_IDReserva.Text);

        }
    }
}
