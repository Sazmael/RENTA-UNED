using DLL_Clase;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ServidorRentaUned
{
    public partial class VRegistrarVehiculos : Form
    {
        PantallaPrincipalServer menu = new PantallaPrincipalServer();
        ManejoSQL sql = new ManejoSQL();

        //Auxiliares
        public static int idTipoVehiculoAux;
        public static String descripcionAux;
        public static bool estadoAux;

        public VRegistrarVehiculos(PantallaPrincipalServer menuformparameter)
        {
            InitializeComponent();
            menu = menuformparameter;
        }

        private void VRegistarVehiculos_Load(object sender, EventArgs e)
        {
            //Cargar los tipos de vehiculo
            mostrarTipoVehiculos();
            cargarCBIDTipoVehiculos();

            int filas = this.dGV_TipoVehiculos2.RowCount;
            //Si no encuentra filas agregadas regresara al menú
            if (filas == 0)
            {

                MessageBox.Show("Debe registrar al menos un Tipo de Vehiculo para acceder a registrar Vehiculos! \nRegistre al menos un Tipo de Vehiculo e intentelo de nuevo.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                menu.Show();
            }
            else
            {
                this.dGV_TipoVehiculos2.Columns["Estado"].Visible = false;
                this.dGV_TipoVehiculos2.Columns["Id"].HeaderText = "ID. Tipo Vehiculo";
                this.dGV_TipoVehiculos2.Columns["EstadoTipoVehiculo"].HeaderText = "Estado";

                cb_IDtipoVehiculo.SelectedIndex = 0;
                idTipoVehiculoAux = ((TipoVehiculos)this.cb_IDtipoVehiculo.SelectedItem).Id;


            }
        }

        private void btn_SaveVehiculos_Click(object sender, EventArgs e)
        {
            bool encontrar = false;
            //lista generica con los datos de la consulta
            List<Vehiculos> lista = new List<Vehiculos>(sql.Consultar_Vehiculos());//lista generica con los datos de la consulta
            foreach (var Vehiculo in lista)//Recorre la lista
            {
                //Activa el bool si encuentra coincidencia con el ID digitado
                if (Vehiculo.IdPlaca == this.txt_IDPlaca.Text)
                {
                    encontrar = true;
                }
            }
            if (encontrar == true)
            {
                MessageBox.Show("La Placa del Vehiculo digitada se encuentra registrada! \nCambie la Placa e intentelo nuevamente.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                Vehiculos objVehiculos = new Vehiculos();

                objVehiculos.IdPlaca = this.txt_IDPlaca.Text;
                objVehiculos.Marca = this.txt_MarcaVehiculo.Text;
                objVehiculos.Modelo = this.txt_ModeloVehiculo.Text;
                objVehiculos.IdtipoVehiculo = idTipoVehiculoAux;
                objVehiculos.CostoAlquiler = int.Parse(this.txt_CostoAlquilerVehiculo.Text);
                objVehiculos.Kilometraje = int.Parse(this.txt_KilometrajeVehiculo.Text);

                //Pasar datos capturados a la base de datos
                sql.Insert_Vehiculos(objVehiculos);
                reset();

                //Funcion para validar otro registro
                var option = MessageBox.Show("Registro exitoso! \n¿Desea registrar otro vehiculo?", "Registrar", MessageBoxButtons.YesNo,
                         MessageBoxIcon.Question);
                if (option == DialogResult.No)
                {
                    this.Close();
                    menu.Show();
                }

            }

        }

        public void mostrarTipoVehiculos()
        {
            this.dGV_TipoVehiculos2.DataSource = sql.Consultar_TipoVehiculos();
            this.dGV_TipoVehiculos2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void cb_IDtipoVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            idTipoVehiculoAux = ((TipoVehiculos)this.cb_IDtipoVehiculo.SelectedItem).Id;

        }

        public void cargarCBIDTipoVehiculos()
        {

            this.cb_IDtipoVehiculo.DataSource = sql.Consultar_TipoVehiculos();
            this.cb_IDtipoVehiculo.DisplayMember = "Id";

        }

        public void reset()
        {
            this.txt_IDPlaca.Text = "";
            this.txt_MarcaVehiculo.Text = "";
            this.txt_ModeloVehiculo.Text = "";
            this.txt_CostoAlquilerVehiculo.Text = "";
            this.txt_KilometrajeVehiculo.Text = "";
            this.cb_IDtipoVehiculo.SelectedIndex = 0;
        }

        private void txt_CostoAlquilerVehiculo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten numeros enteros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_KilometrajeVehiculo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten numeros enteros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private void activarGuardar()
        {
            var vr = !string.IsNullOrWhiteSpace(this.txt_CostoAlquilerVehiculo.Text) &&
                !string.IsNullOrWhiteSpace(this.txt_IDPlaca.Text) &&
                !string.IsNullOrWhiteSpace(this.txt_KilometrajeVehiculo.Text) &&
                !string.IsNullOrWhiteSpace(this.txt_MarcaVehiculo.Text) &&
                !string.IsNullOrWhiteSpace(this.txt_ModeloVehiculo.Text);
            this.btn_SaveVehiculos.Enabled = vr;
        }

        private void txt_IDPlaca_TextChanged(object sender, EventArgs e)
        {
            activarGuardar();
        }

        private void txt_MarcaVehiculo_TextChanged(object sender, EventArgs e)
        {
            activarGuardar();
        }

        private void txt_ModeloVehiculo_TextChanged(object sender, EventArgs e)
        {
            activarGuardar();
        }

        private void txt_CostoAlquilerVehiculo_TextChanged(object sender, EventArgs e)
        {
            activarGuardar();
        }

        private void txt_KilometrajeVehiculo_TextChanged(object sender, EventArgs e)
        {
            activarGuardar();
        }

        private void txt_IDPlaca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                MessageBox.Show("No se admiten espacios", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;

            }
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            this.Close();
            menu.Show();
        }
    }
}