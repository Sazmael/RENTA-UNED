using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DLL_Clase;

namespace ServidorRentaUned
{
    public partial class VRegistrarTipoVehiculo : Form
    {
        PantallaPrincipalServer menu = new PantallaPrincipalServer();
        ManejoSQL sql = new ManejoSQL();
        String estado;
        public VRegistrarTipoVehiculo(PantallaPrincipalServer menuformparameter)
        {
            InitializeComponent();
            menu = menuformparameter;

            this.cb_EstadoTipoVehiculo.SelectedIndex = 0;
        }

        private void btn_SaveTipoVehiculo_Click(object sender, EventArgs e)
        {
            bool encontrar = false;
            //lista generica con los datos de la consulta
            List<TipoVehiculos> lista = new List<TipoVehiculos>(sql.Consultar_TipoVehiculos());//lista generica con los datos de la consulta
            foreach (var tipoVehiculo in lista)//Recorre la lista
            {
                //Activa el bool si encuentra coincidencia con el ID digitado
                if (tipoVehiculo.Id == int.Parse(this.txt_IDTipoVehiculo.Text))
                {
                    encontrar = true;
                }
            }
            if (encontrar == true)
            {
                MessageBox.Show("El ID del Tipo de Vehiculo digitado se encuentra registrado! \nCambie el ID e intentelo nuevamente.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                //Instancia el objeto vehiculo
                TipoVehiculos objTipoVehiculo = new TipoVehiculos();

                objTipoVehiculo.Id = int.Parse(this.txt_IDTipoVehiculo.Text);
                objTipoVehiculo.Descripcion = this.txt_DescripcionTipoVehiculo.Text;

                //Condicional para colocar true o false el estado
                if (estado == "Activo")
                {
                    objTipoVehiculo.Estado = true;
                }
                else
                {
                    objTipoVehiculo.Estado = false;
                }

                //envia a insertar a la tabla los datos recopilados
                sql.Insert_TipoVehiculo(objTipoVehiculo);
                reset();
                //Funcion para validar otro registro
                var option = MessageBox.Show("Registro exitoso! \n¿Desea registrar otro Tipo de vehiculo?", "Registrar", MessageBoxButtons.YesNo,
                         MessageBoxIcon.Question);
                if (option == DialogResult.No)
                {
                    this.Close();
                    menu.Show();
                }
            }

        }

        private void cb_EstadoTipoVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Selecciona el estado escogido del combobox
            int indice;
            indice = cb_EstadoTipoVehiculo.SelectedIndex;
            estado = cb_EstadoTipoVehiculo.Items[indice].ToString();
        }

        public void reset()
        {
            this.txt_DescripcionTipoVehiculo.Text = "";
            this.txt_IDTipoVehiculo.Text = "";
            this.cb_EstadoTipoVehiculo.SelectedIndex = 0;
        }

        private void activarGuardar()
        {
            var vr = !string.IsNullOrWhiteSpace(this.txt_DescripcionTipoVehiculo.Text) &&
                !string.IsNullOrWhiteSpace(this.txt_IDTipoVehiculo.Text);
            this.btn_SaveTipoVehiculo.Enabled = vr;
        }

        private void txt_IDTipoVehiculo_TextChanged(object sender, EventArgs e)
        {
            activarGuardar();
        }

        private void txt_DescripcionTipoVehiculo_TextChanged(object sender, EventArgs e)
        {
            activarGuardar();
        }

        private void txt_IDTipoVehiculo_KeyPress(object sender, KeyPressEventArgs e)
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




