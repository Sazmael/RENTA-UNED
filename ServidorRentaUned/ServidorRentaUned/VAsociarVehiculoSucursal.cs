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
    public partial class VAsociarVehiculoSucursal : Form
    {
        PantallaPrincipalServer menu = new PantallaPrincipalServer();
        ManejoSQL sql = new ManejoSQL();

        //Auxiliares
        public int IDsucursalAux;
        public String idPlacaAux = null;
        public int indiceSucursal;
        public int indiceSucursalActiva;
        public bool activarSave = false;

        public VAsociarVehiculoSucursal(PantallaPrincipalServer menuformparameter)
        {
            InitializeComponent();
            menu = menuformparameter;

            
           


        }
        private void VAsociarVehiculoSucursal_Load(object sender, EventArgs e)
        {
            cargarSucursales();
            cargarVehiculos();

            int filaSucursal = this.dGV_Sucursales.RowCount;
            int filaVehiculos = this.dGV_Vehiculos.RowCount;

            //Si no encuentra filas agregadas regresara al menú
            if (filaSucursal == 0 || filaVehiculos == 0)
            {
                MessageBox.Show("Registre al menos una Sucursal y un Vehiculo para acceder a la asociación!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                menu.Show();
            }
            else
            {
                ColumnVehiculosAsocNames();
            }
            

        }
        private void btn_SaveAsociar_Click(object sender, EventArgs e)
        {
            if (this.dGV_Vehiculos.SelectedRows.Count == 0 || this.cb_Sucursales.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione al menos un Vehiculo y una Sucursal e intentelo nuevamente!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                bool encontrar = false;
                //lista generica con los datos de la consulta
                List<VehiculoSucursal> lista = new List<VehiculoSucursal>(sql.Consultar_VehiculoSucursal());//lista generica con los datos de la consulta
                foreach (var vehiculoSucursal in lista)//Recorre la lista
                {
                    //Activa el bool si encuentra coincidencia con el ID digitado
                    if (vehiculoSucursal.IdAsignacion == int.Parse(this.txt_IDAsignacion.Text))
                    {
                        encontrar = true;
                    }
                }
                if (encontrar == true)
                {
                    MessageBox.Show("El ID de asignación digitado se encuentra registrado! \nCambie el ID e intentelo nuevamente.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else
                {
                    //Instanciar objeto VehiculoSucursal
                    VehiculoSucursal objVehiculoSucursal = new VehiculoSucursal();

                    objVehiculoSucursal.IdSucursal = IDsucursalAux;
                    objVehiculoSucursal.IdAsignacion = int.Parse(this.txt_IDAsignacion.Text);
                    objVehiculoSucursal.Fecha = this.date_FechaAsignacion.Value;
                    objVehiculoSucursal.IdPlaca = idPlacaAux;

                    //Envia el objeto a la clase Insert 
                    sql.Insert_VehiculoSucursal(objVehiculoSucursal);

                    //Cargar vehiculo asociado
                    cargarVehiculosAsociados(objVehiculoSucursal.IdSucursal);

                    this.txt_IDAsignacion.Text = "";

                    //Funcion para validar otro registro
                    var option = MessageBox.Show("Registro Exitoso!\n¿Desea asociar otro vehiculo a la Sucursal?", "Registrar", MessageBoxButtons.YesNo,
                             MessageBoxIcon.Question);
                    if (option == DialogResult.No)
                    {
                        this.Close();
                        menu.Show();

                    }
                    else
                    {
                        this.cb_Sucursales.Enabled = false;
                        this.date_FechaAsignacion.Enabled = false;
                        this.dGV_Vehiculos.ClearSelection();
                        this.btn_SaveAsociar.Enabled = false;


                    }
                }
            }
        }

        public void cargarSucursales()
        {
            this.dGV_Sucursales.ColumnCount = 3;
            
            this.dGV_Sucursales.Columns[0].Name = "Identificacion";
            this.dGV_Sucursales.Columns[1].Name = "Nombre";
            this.dGV_Sucursales.Columns[2].Name = "Direccion";

            List<Sucursales> lista = new List<Sucursales>(sql.Consultar_Sucursales()); //Lista Generica para guardar las Sucursales
            foreach (var sucursal in lista)
            {
                if (sucursal.EstadoSucursal == "Activo")
                {
                    this.dGV_Sucursales.Rows.Add(sucursal.Identificacion, sucursal.Nombre, sucursal.Direccion);

                    //Cargar sucursales en el combobox
                    this.cb_Sucursales.Items.Add(sucursal);
                    this.cb_Sucursales.DisplayMember = "Nombre";
                }
            }
        }

        private void cb_Sucursales_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                this.dGV_Vehiculos.ClearSelection();
                //Pasar el id Consultar_Sucursales al auxiliar
                IDsucursalAux = ((Sucursales)cb_Sucursales.SelectedItem).Identificacion;
                cargarVehiculosAsociados(IDsucursalAux);

            }
            catch (Exception)
            {
                
                idPlacaAux = null;
                return;
            }
        }

        public void cargarVehiculos()
        {
            this.dGV_Vehiculos.Rows.Clear();
            //recibe el ID sucursal y lo envia a consultar en la base de datos          
            List<Vehiculos> lista = new List<Vehiculos>(sql.Consultar_Vehiculos());

            this.dGV_Vehiculos.ColumnCount = 5;
           
            this.dGV_Vehiculos.Columns[0].Name = "Placa";
            this.dGV_Vehiculos.Columns[1].Name = "Marca";
            this.dGV_Vehiculos.Columns[2].Name = "Modelo";
            this.dGV_Vehiculos.Columns[3].Name = "Descripción";
            this.dGV_Vehiculos.Columns[4].Name = "Costo alquiler";
          
            foreach (var vehiculo in lista)
            {
                this.dGV_Vehiculos.Rows.Add(vehiculo.IdPlaca, vehiculo.Marca,
                 vehiculo.Modelo, vehiculo.tipoVehiculo.Descripcion, vehiculo.CostoAlquiler);
            }
            this.dGV_Vehiculos.ClearSelection();
        }

        public void cargarVehiculosAsociados(int IDsucursalAux)
        {
            this.dGV_VehiculosAsociados.Rows.Clear();

            //recibe el ID sucursal y lo envia a consultar en la base de datos          
            List<VehiculoSucursal> lista = new List<VehiculoSucursal>(sql.Consultar_VehiculoSucursal());
                       
            foreach (var vehiculoSucursal in lista)
            {
                if (vehiculoSucursal.sucursales.Identificacion == IDsucursalAux)
                //carga la tabla vehiculos asociados con la coincidencia encontrada
                {
                    this.dGV_VehiculosAsociados.Rows.Add(vehiculoSucursal.vehiculos.IdPlaca,
                        vehiculoSucursal.vehiculos.Marca, vehiculoSucursal.vehiculos.Modelo,
                        vehiculoSucursal.vehiculos.tipoVehiculo.Descripcion, vehiculoSucursal.vehiculos.CostoAlquiler);

                    this.dGV_VehiculosAsociados.ClearSelection();
                }
            }

        }

        public void revisarVehiculoClickeado(int IDsucursalAux, String idPlacaAux)
        {
            bool encontrar = false;

            //lista generica con los datos de la consulta
            List<VehiculoSucursal> lista = new List<VehiculoSucursal>(sql.Consultar_VehiculoSucursal());

            foreach (var vehiculoSucursal in lista)//Recorre la lista
            {

                //Activa el bool si encuentra coincidencia con el ID digitado
                if (vehiculoSucursal.IdSucursal == IDsucursalAux &&
                    vehiculoSucursal.IdPlaca == idPlacaAux)
                {

                    encontrar = true;
                }
            }
            if (encontrar == true)
            {
                MessageBox.Show("Este vehiculo ya se encuentra asociado a la Sucursal! \nSeleccione otro Vehiculo e intentelo nuevamente.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.dGV_Vehiculos.CurrentRow.Cells["Placa"].ReadOnly = true;
                this.dGV_Vehiculos.ClearSelection();
                activarSave = false;
                idPlacaAux = null;
                return;
            }
        }
        private void dGV_Vehiculos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //Pasar a String la placa del indice
            idPlacaAux = this.dGV_Vehiculos.CurrentRow.Cells["Placa"].FormattedValue.ToString();

            revisarVehiculoClickeado(IDsucursalAux, idPlacaAux); //Metodo para validar si el vehiculo esta asociado

        }

        private void txt_IDAsignacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten numeros enteros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_IDAsignacion_TextChanged(object sender, EventArgs e)
        {
            activarSave = !string.IsNullOrEmpty(this.txt_IDAsignacion.Text);
            this.btn_SaveAsociar.Enabled = activarSave;

        }

        public void ColumnVehiculosAsocNames()
        {
            this.dGV_VehiculosAsociados.Rows.Clear();
            this.dGV_VehiculosAsociados.ColumnCount = 5;

            this.dGV_VehiculosAsociados.Columns[0].Name = "Placa";
            this.dGV_VehiculosAsociados.Columns[1].Name = "Marca";
            this.dGV_VehiculosAsociados.Columns[2].Name = "Modelo";
            this.dGV_VehiculosAsociados.Columns[3].Name = "Tipo de vehiculo";
            this.dGV_VehiculosAsociados.Columns[4].Name = "Costo alquiler";
        }
        private void btn_Volver_Click(object sender, EventArgs e)
        {
            this.Close();
            menu.Show();
        }

        
    }
}
