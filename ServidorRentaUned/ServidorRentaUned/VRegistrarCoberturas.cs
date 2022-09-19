using DLL_Clase;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ServidorRentaUned
{
    public partial class VRegistrarCoberturas : Form
    {
        PantallaPrincipalServer menu = new PantallaPrincipalServer();
        ManejoSQL sql = new ManejoSQL();

        String estado;
        int idTipoVehiculoAux;
        public VRegistrarCoberturas(PantallaPrincipalServer menuformparameter)
        {

            InitializeComponent();
            menu = menuformparameter;

        }
        private void VRegistraCoberturas_Load(object sender, EventArgs e)
        {
            cargarIDTipoVehiculos();
            mostrarTipoVehiculos();

            int filas = this.dGV_TipoVehiculos.RowCount;
            //Si no encuentra filas agregadas regresara al menú
            if (filas == 0)
            {
                MessageBox.Show("Debe registrar al menos un Tipo de Vehiculo para acceder a registrar Vehiculos! \nRegistre al menos un Tipo de Vehiculo e intentelo de nuevo.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                menu.Show();
            }
            else
            {
                this.dGV_TipoVehiculos.Columns["Estado"].Visible = false;
                this.dGV_TipoVehiculos.Columns["Id"].HeaderText = "ID. Tipo Vehiculo";
                this.dGV_TipoVehiculos.Columns["EstadoTipoVehiculo"].HeaderText = "Estado";

                idTipoVehiculoAux = ((TipoVehiculos)this.cb_IDtipoVehiculo.SelectedItem).Id;
                this.cb_EstadoCobertura.SelectedIndex = 0;


            }

        }

        private void btn_SaveCoberturas_Click(object sender, EventArgs e)
        {
            bool encontrar = false;
            //lista generica con los datos de la consulta
            List<Coberturas> lista = new List<Coberturas>(sql.Consultar_Coberturas());//lista generica con los datos de la consulta
            foreach (var cobertura in lista)//Recorre la lista
            {
                //Activa el bool si encuentra coincidencia con el ID digitado
                if (cobertura.IdCobertura == int.Parse(this.txt_IDCobertura.Text))
                {
                    encontrar = true;
                }
            }
            if (encontrar == true)
            {
                MessageBox.Show("El ID de la Cobertura de Seguro digitado se encuentra registrado! \nCambie el ID e intentelo nuevamente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                Coberturas objCoberturas = new Coberturas();

                objCoberturas.IdCobertura = int.Parse(this.txt_IDCobertura.Text);
                objCoberturas.Descripcion = this.txt_Descripcion.Text;
                objCoberturas.Monto = int.Parse(this.txt_Monto.Text);
                objCoberturas.IdTipoVehiculo = idTipoVehiculoAux;

                if (estado == "Activo")
                {
                    objCoberturas.Estado = true;
                }
                else
                {
                    objCoberturas.Estado = false;
                }

                sql.Insert_Coberturas(objCoberturas);
                reset();

                //Funcion para validar otro registro
                var option = MessageBox.Show("Registro Exitoso!\n¿Desea Registrar otra cobertura?", "Registrar", MessageBoxButtons.YesNo,
                         MessageBoxIcon.Question);
                if (option == DialogResult.No)
                {
                    this.Close();
                    menu.Show();
                }

            }
        }

        private void cb_IDtipoVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {

            idTipoVehiculoAux = ((TipoVehiculos)this.cb_IDtipoVehiculo.SelectedItem).Id;
        }

        private void cb_EstadoCobertura_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice;
            indice = cb_EstadoCobertura.SelectedIndex;
            estado = cb_EstadoCobertura.Items[indice].ToString();

        }

        public void mostrarTipoVehiculos()
        {
            this.dGV_TipoVehiculos.DataSource = sql.Consultar_TipoVehiculos();
            this.dGV_TipoVehiculos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void cargarIDTipoVehiculos()
        {
            this.cb_IDtipoVehiculo.DataSource = sql.Consultar_TipoVehiculos();
            this.cb_IDtipoVehiculo.DisplayMember = "Id";

        }

        public void reset()
        {
            this.txt_Descripcion.Text = "";
            this.txt_IDCobertura.Text = "";
            this.txt_Monto.Text = "";
            this.cb_EstadoCobertura.SelectedIndex = 0;
            this.cb_IDtipoVehiculo.SelectedIndex = 0;

        }

        private void txt_Monto_KeyPress(object sender, KeyPressEventArgs e)
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
            var vr = !string.IsNullOrWhiteSpace(this.txt_Descripcion.Text) &&
                !string.IsNullOrWhiteSpace(this.txt_IDCobertura.Text) &&
                !string.IsNullOrWhiteSpace(this.txt_Monto.Text);
            this.btn_SaveCoberturas.Enabled = vr;
        }

        private void txt_IDCobertura_TextChanged(object sender, EventArgs e)
        {
            activarGuardar();
        }


        private void txt_Descripcion_TextChanged(object sender, EventArgs e)
        {
            activarGuardar();
        }

        private void txt_Monto_TextChanged(object sender, EventArgs e)
        {
            activarGuardar();
        }

        private void txt_IDCobertura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten numeros enteros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            this.Close();
            menu.Show();
        }

        
    }
}