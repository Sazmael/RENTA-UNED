using DLL_Clase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteRentaUned
{
    public partial class VReservarVehiculo : Form
    {
        ClienteTCP tcp = new ClienteTCP();
        VLogin loginCliente = new VLogin();
        List<int> montosSelected = new List<int>();
        List<int> indiceSelected = new List<int>();

        DataGridViewCheckBoxColumn checkCoberturas = new DataGridViewCheckBoxColumn();

        public int IDSucursalAux = 0;
        public String IDPlacaAux = null;
        public String ModeloAux;
        public String MarcaAux;
        public int IdTipoVehiculoAux;
        public int MontoCoberturaAux;
        public double CostoTotalRenta;
        public double CostoCoberturasDia = 0;

        public VReservarVehiculo(VLogin Parameter)//Parametros del cliente del Login
        {
            InitializeComponent();
            this.loginCliente = Parameter;
            this.label_NombreCliente.Text = "Reserve su Vehiculo preferido " + loginCliente.nombreCompleto + "!";

        }
        private void VReservarVehiculo_Load(object sender, EventArgs e)
        {
            cargarCBSucursales();
            this.cbSucursalesActivas.SelectedIndex = -1;
        }
        private void btn_InfoReserva_Click(object sender, EventArgs e)
        {
            //Calculo fechas
            double diasTotales = (this.date_FechaFin.Value.Date - this.date_FechaInicio.Value.Date).TotalDays;
            if (diasTotales <= 0)///Validación de fechas correctas
            {
                MessageBox.Show("Rango de fechas invalido, reviselas e intente nuevamente");
                this.btn_SaveReserva.Enabled = false;

            }
            else
            {
                if (this.dGV_VehiculosSucursalAsoc.SelectedRows.Count == 0 || this.cbSucursalesActivas.SelectedIndex < 0)
                {
                    MessageBox.Show("Debe seleccionar al menos una Sucursal y un Vehiculo para consultar la factura");
                }
                else
                {
                    this.btn_SaveReserva.Enabled = true;
                    CostoCoberturasDia = 0;
                    CostoTotalRenta = 0;

                    //Calculos
                    //Sumar los montos de la lista costo coberturas por dia
                    foreach (var monto in montosSelected)
                    {
                        CostoCoberturasDia += monto;
                    }

                    //Calculo alquiler vehiculo * día totales
                    double costoVehiculoTotal = double.Parse(this.dGV_VehiculosSucursalAsoc.CurrentRow.Cells["Costo alquiler por dia"].Value.ToString()) * diasTotales;

                    double CostoCoberturasTotal = CostoCoberturasDia * diasTotales;
                    CostoTotalRenta = costoVehiculoTotal + CostoCoberturasTotal;

                    //Limpiar y colocar las columnas de la infoReserca
                    this.dGV_InfoReserva.Rows.Clear();
                    this.dGV_InfoReserva.ColumnCount = 9;

                    this.dGV_InfoReserva.Columns[0].Name = "Placa. Vehiculo";
                    this.dGV_InfoReserva.Columns[1].Name = "Marca. Vehiculo";
                    this.dGV_InfoReserva.Columns[2].Name = "Modelo. Vehiculo";
                    this.dGV_InfoReserva.Columns[3].Name = "Fecha de inicio/Fin";
                    this.dGV_InfoReserva.Columns[4].Name = "Costo del vehiculo por día";
                    this.dGV_InfoReserva.Columns[5].Name = "Costo del vehiculo en total";
                    this.dGV_InfoReserva.Columns[6].Name = "Costo Coberturas por día";
                    this.dGV_InfoReserva.Columns[7].Name = "Costo Coberturas en total";
                    this.dGV_InfoReserva.Columns[8].Name = "Costo total de la renta";

                    //Agrega filas
                    this.dGV_InfoReserva.Rows.Add(IDPlacaAux, this.dGV_VehiculosSucursalAsoc.CurrentRow.Cells["Marca"].Value.ToString(),
                        this.dGV_VehiculosSucursalAsoc.CurrentRow.Cells["Modelo"].Value.ToString(),
                        this.date_FechaInicio.Value.Date.ToString("dd/MM/yyyy") + " / " + this.date_FechaFin.Value.Date.ToString("dd/MM/yyyy"),
                        this.dGV_VehiculosSucursalAsoc.CurrentRow.Cells["Costo alquiler por dia"].Value.ToString(), costoVehiculoTotal, CostoCoberturasDia,
                        CostoCoberturasTotal, CostoTotalRenta);

                    this.btn_SaveReserva.Enabled = true;
                }
            }

        }

        private void btn_SaveReserva_Click(object sender, EventArgs e)
        {
            if (ClienteTCP.CheckConexionServer(loginCliente.IdCliente) == true)
            {
                bool vehiculoOcupado = false;
                List<Reservas> listaReservasVehiculos = new List<Reservas>(tcp.ConsultarReservasCliente(loginCliente.IdCliente));
                foreach (var reservas in listaReservasVehiculos)
                {
                    if (reservas.IdPlaca == IDPlacaAux &&
                       date_FechaInicio.Value.Date <= reservas.FechaFin)
                    {
                        vehiculoOcupado = true;
                    }
                }
                if (vehiculoOcupado == true)
                {
                    MessageBox.Show("Lo sentimos, el Vehiculo seleccionado se encuentra reservado en el rango de fechas escogido.", "Vehiculo Ocupado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.btn_SaveReserva.Enabled = false;

                }
                else
                {

                    //Instancia del objeto reservas
                    Reservas objReservas = new Reservas();

                    objReservas.IdCliente = loginCliente.IdCliente;
                    objReservas.IdPlaca = IDPlacaAux;
                    objReservas.FechaReserva = DateTime.Now;
                    objReservas.FechaInicio = this.date_FechaInicio.Value;
                    objReservas.FechaFin = this.date_FechaFin.Value;
                    objReservas.MontoReserva = int.Parse(CostoTotalRenta.ToString());

                    //Se envia el objeto reserva al servidor
                    tcp.Reservar(objReservas);

                    //Funcion para validar otro registro
                    var option = MessageBox.Show("Reserva exitosa! \n¿Desea Reservar otro Vehiculo?", "Reservar", MessageBoxButtons.YesNo,
                             MessageBoxIcon.Question);
                    if (option == DialogResult.No)
                    {
                        VMenuCliente c = new VMenuCliente(loginCliente);
                        this.Close();
                        c.Show();
                    }
                    else
                    {   //resetear controles

                        refreshCoberturas();
                        this.btn_InfoReserva.Enabled = false;
                        this.btn_SaveReserva.Enabled = false;
                        date_FechaInicio.Value = DateTime.Today.Date;
                        date_FechaFin.Value = DateTime.Today.Date;

                        refreshVehiculos();

                    }

                }
            }
            else
            {
                MessageBox.Show("No se logró establecer conexión con el servidor!\nIntentelo nuevamente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        public void cargarCBSucursales()
        {
            if (ClienteTCP.CheckConexionServer(loginCliente.IdCliente) == true)
            {
                List<Sucursales> lista = new List<Sucursales>(tcp.obtenerSucursales()); //Lista Generica para guardar las Sucursales

                foreach (var sucursal in lista)
                {
                    if (sucursal.EstadoSucursal == "Activo")
                    {
                        //Cargar sucursales en el combobox
                        this.cbSucursalesActivas.Items.Add(sucursal);
                        this.cbSucursalesActivas.DisplayMember = "Nombre";
                    }

                }
                if (this.cbSucursalesActivas.Items.Count == 0)
                {
                    MessageBox.Show("Lo sentimos, no se encontraron Sucursales Activas en RENTA-UNED!\nSe devolvera al Menú Principal", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    VMenuCliente c = new VMenuCliente(loginCliente);
                    this.Close();
                    c.Show();

                }
            }
            else
            {
                MessageBox.Show("No se logró establecer conexión con el servidor!\nIntentelo nuevamente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }
        private void btn_Volver_Click(object sender, EventArgs e)
        {
            VMenuCliente c = new VMenuCliente(loginCliente);
            this.Close();
            c.Show();
        }

        public void cargarVehiculosAsoc(int IDSucursalAux)
        {

            if (ClienteTCP.CheckConexionServer(loginCliente.IdCliente) == true)
            {
                List<VehiculoSucursal> listaVehiculos = new List<VehiculoSucursal>(tcp.vehiculosAsoc(IDSucursalAux));
                // Validacion Consultar Sucursales sin vehiculos
                if (listaVehiculos.Count() == 0)
                {
                    MessageBox.Show("La Sucursal no posee Vehiculos asociados.\nSeleccione otra Sucursal e intentelo nuevamente.", "Sin vehiculos", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    refreshVehiculos();
                    refreshCoberturas();


                }
                else
                {
                    //Setiar columnas de la tabla Vehiculos
                    this.dGV_VehiculosSucursalAsoc.ColumnCount = 7;
                    this.dGV_VehiculosSucursalAsoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    this.dGV_VehiculosSucursalAsoc.Columns[0].Name = "Placa";
                    this.dGV_VehiculosSucursalAsoc.Columns[1].Name = "Marca";
                    this.dGV_VehiculosSucursalAsoc.Columns[2].Name = "Modelo";
                    this.dGV_VehiculosSucursalAsoc.Columns[3].Name = "Kilometraje";
                    this.dGV_VehiculosSucursalAsoc.Columns[4].Name = "Costo alquiler por dia";
                    this.dGV_VehiculosSucursalAsoc.Columns[5].Name = "Tipo de vehiculo";
                    this.dGV_VehiculosSucursalAsoc.Columns[6].Name = "ID del Tipo Vehiculo";
                    //carga la tabla vehiculos asociados con la consulta recibida
                    foreach (var vehiculoSucursal in listaVehiculos)
                    {
                        this.dGV_VehiculosSucursalAsoc.Rows.Add(vehiculoSucursal.vehiculos.IdPlaca,
                            vehiculoSucursal.vehiculos.Marca, vehiculoSucursal.vehiculos.Modelo,
                            vehiculoSucursal.vehiculos.Kilometraje, vehiculoSucursal.vehiculos.CostoAlquiler,
                            vehiculoSucursal.vehiculos.tipoVehiculo.Descripcion, vehiculoSucursal.vehiculos.IdtipoVehiculo);

                        this.dGV_VehiculosSucursalAsoc.Columns[6].Visible = false;
                    }
                    this.dGV_VehiculosSucursalAsoc.ClearSelection();
                }
            }
            else
            {
                MessageBox.Show("No se logró establecer conexión con el servidor!\nIntentelo nuevamente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void dGV_VehiculosSucursalAsoc_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            refreshCoberturas();
            this.btn_InfoReserva.Enabled = true;

            //Asigna al auxiliar el id de la placa clickeada
            IDPlacaAux = this.dGV_VehiculosSucursalAsoc.CurrentRow.Cells["Placa"].Value.ToString();
            ModeloAux = this.dGV_VehiculosSucursalAsoc.CurrentRow.Cells["Modelo"].Value.ToString();
            MarcaAux = this.dGV_VehiculosSucursalAsoc.CurrentRow.Cells["Marca"].Value.ToString();

            //Asigna al auxiliar del id del tipoVehiculo clickeado
            IdTipoVehiculoAux = int.Parse(this.dGV_VehiculosSucursalAsoc.CurrentRow.Cells["ID del Tipo Vehiculo"].Value.ToString());

            CargarCoberturasTipoVehiculo(IdTipoVehiculoAux);
        }

        public void CargarCoberturasTipoVehiculo(int IdTipoVehiculoAux)
        {
            if (ClienteTCP.CheckConexionServer(loginCliente.IdCliente) == true)
            {
                List<Coberturas> listaCoberturas = new List<Coberturas>(); //Lista generica coberturas

                listaCoberturas = tcp.CargarCoberturas(IdTipoVehiculoAux);

                this.dGV_Coberturas.Rows.Clear();
                this.dGV_Coberturas.ColumnCount = 2;
                this.dGV_Coberturas.Columns[0].Name = "Cobertura de Seguro";
                this.dGV_Coberturas.Columns[1].Name = "Monto";

                //agregar checkbox
                this.dGV_Coberturas.Columns.Add(checkCoberturas);
                this.dGV_Coberturas.Columns[2].Name = "Marcar";

                //Auto Size
                this.dGV_Coberturas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                foreach (var tipoCobertura in listaCoberturas)
                {

                    //Cargar coberturas con el IDtipoVehiculo seleccionado
                    if (tipoCobertura.IdTipoVehiculo == IdTipoVehiculoAux)
                    {
                        //Carga Coberturas a la tabla
                        this.dGV_Coberturas.Rows.Add(tipoCobertura.Descripcion, tipoCobertura.Monto);

                    }
                }
            }
            else
            {
                MessageBox.Show("No se logró establecer conexión con el servidor!\nIntentelo nuevamente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void cbSucursalesActivas_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbSucursalesActivas.SelectedIndex >= 0)
            {
                //Pasar el id Consultar_Sucursales al auxiliar
                IDSucursalAux = ((Sucursales)cbSucursalesActivas.SelectedItem).Identificacion;

                //Pasar el auxialiar IDSucursal para cargar sus vehiculos
                cargarVehiculosAsoc(IDSucursalAux);

            }
            refreshCoberturas();
        }

        private void dGV_Coberturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 2 && e.RowIndex != -1)
            {

                //Colocar values al checkbox
                DataGridViewCheckBoxCell check = (DataGridViewCheckBoxCell)dGV_Coberturas.Rows[e.RowIndex].Cells[2];

                if (check.Value == check.TrueValue)
                {
                    dGV_Coberturas.Rows[e.RowIndex].Cells[2].Value = check.FalseValue;
                    dGV_Coberturas.Rows[e.RowIndex].Cells[2].Value = false;
                }
                else
                {
                    dGV_Coberturas.Rows[e.RowIndex].Cells[2].Value = check.TrueValue;
                    dGV_Coberturas.Rows[e.RowIndex].Cells[2].Value = true;

                }

                int filaSelected = dGV_Coberturas.CurrentRow.Index;

                //Pasar el monto del indice al auxiliar             
                MontoCoberturaAux = int.Parse(this.dGV_Coberturas.Rows[e.RowIndex].Cells["Monto"].FormattedValue.ToString());


                //lista placas
                if (montosSelected.Contains(MontoCoberturaAux))
                {
                    montosSelected.Remove(MontoCoberturaAux);

                }
                else
                {
                    montosSelected.Add(MontoCoberturaAux);

                }


            }
        }
        public void refreshCoberturas()
        {
            this.dGV_Coberturas.Rows.Clear();
            montosSelected.Clear();

        }
        public void refreshVehiculos()
        {
            this.cbSucursalesActivas.SelectedIndex = -1;
            this.dGV_VehiculosSucursalAsoc.Rows.Clear();
            this.btn_InfoReserva.Enabled = false;
        }
    }
}
