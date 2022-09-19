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

namespace ServidorRentaUned
{
    public partial class VConsultarVehiculoSucursal : Form
    {
        PantallaPrincipalServer menu = new PantallaPrincipalServer();
        ManejoSQL sql = new ManejoSQL();
       
        public VConsultarVehiculoSucursal(PantallaPrincipalServer menuformparameter)
        {
            InitializeComponent();
            menu = menuformparameter;
        }
        private void VConsultarVehiculoSucursal_Load(object sender, EventArgs e)
        {
            cargarSucursalAsoc();
            
            int filas = this.dGV_SucursalesAsoc.RowCount;
            //Si no encuentra filas agregadas regresara al menú
            if (filas == 0)
            {
                MessageBox.Show("No se ha realizado ninguna asociación de Vehiculos a Sucursales! \nRealice al menos una asociación e intentelo de nuevo.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                menu.Show();
            }
            columVehiculosAsocName();

        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            this.Close();
            menu.Show();
        }

        public void cargarSucursalAsoc()
        {
            List<VehiculoSucursal> lista = new List<VehiculoSucursal>(sql.Consultar_VehiculoSucursal());

            this.dGV_SucursalesAsoc.Rows.Clear();
            this.dGV_SucursalesAsoc.ColumnCount = 5;

            this.dGV_SucursalesAsoc.Columns[0].Name = "ID Asignación";
            this.dGV_SucursalesAsoc.Columns[1].Name = "Fecha de Asociación";
            this.dGV_SucursalesAsoc.Columns[2].Name = "Identificacíon Sucursal";
            this.dGV_SucursalesAsoc.Columns[3].Name = "Nombre Sucursal";
            this.dGV_SucursalesAsoc.Columns[4].Name = "Dirección Sucursal";
           
           
            //Carga las sucursales de la lista vehiculoSucursal
            foreach (var vehiculoSucursal in lista)
            {
                    this.dGV_SucursalesAsoc.Rows.Add(vehiculoSucursal.IdAsignacion, vehiculoSucursal.Fecha.Date.ToString("dd-MM-yyyy"),
                        vehiculoSucursal.sucursales.Identificacion, vehiculoSucursal.sucursales.Nombre, vehiculoSucursal.sucursales.Direccion);
                
            }
            this.dGV_SucursalesAsoc.ClearSelection();

        }

        public void cargarVehiculosAsoc(int IDSucursalAux, int IDAsignacionAux)
        {
            //recibe el ID sucursal y lo envia a consultar en la base de datos          
            List<VehiculoSucursal> lista = new List<VehiculoSucursal>(sql.Consultar_VehiculoSucursal());

            this.dGV_VehiculosSucursalAsoc.Rows.Clear();
           
            
            foreach (var vehiculoSucursal in lista)
            {
                if(vehiculoSucursal.sucursales.Identificacion == IDSucursalAux &&
                    vehiculoSucursal.IdAsignacion == IDAsignacionAux)
                //carga la tabla vehiculos asociados con la coincidencia encontrada
                {
                    this.dGV_VehiculosSucursalAsoc.Rows.Add(vehiculoSucursal.vehiculos.IdPlaca,
                        vehiculoSucursal.vehiculos.Marca, vehiculoSucursal.vehiculos.Modelo);                 
                }
            }
            
        }

        private void dGV_SucursalesAsoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dGV_SucursalesAsoc.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    //Asigna al auxiliar el id de la Consultar_Sucursales clickeada
                    int IDSucursalAux = Convert.ToInt32(this.dGV_SucursalesAsoc.CurrentRow.Cells["Identificacíon Sucursal"].FormattedValue);
                    int IDAsignacionAux = Convert.ToInt32(this.dGV_SucursalesAsoc.CurrentRow.Cells["ID Asignación"].FormattedValue);
                    
                    //Pasa por parametro el id Consultar_Sucursales clickeado para cargar los vehiculos asociados a la Sucursal
                    cargarVehiculosAsoc(IDSucursalAux, IDAsignacionAux);

                }

            }
            catch (Exception)
            {
                this.dGV_VehiculosSucursalAsoc.Rows.Clear();
                return;
            }

        }

        private void columVehiculosAsocName()
        {
            this.dGV_VehiculosSucursalAsoc.ColumnCount = 3;
            this.dGV_VehiculosSucursalAsoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dGV_VehiculosSucursalAsoc.Columns[0].Name = "Placa";
            this.dGV_VehiculosSucursalAsoc.Columns[1].Name = "Marca";
            this.dGV_VehiculosSucursalAsoc.Columns[2].Name = "Modelo";
        }
    }
}






