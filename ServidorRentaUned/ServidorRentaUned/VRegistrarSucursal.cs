using DLL_Clase;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ServidorRentaUned
{
    public partial class VRegistrarSucursal : Form
    {

        PantallaPrincipalServer menu = new PantallaPrincipalServer();

        ManejoSQL sql = new ManejoSQL();
        String estado;

        public VRegistrarSucursal(PantallaPrincipalServer menuformparameter)
        {
            InitializeComponent();
            menu = menuformparameter;

            this.cb_EstadoSucursal.SelectedIndex = 0;

        }

        private void btn_SaveRegistroSucursal_Click(object sender, EventArgs e)
        {
            bool encontrar = false;
            //lista generica con los datos de la consulta
            List<Sucursales> lista = new List<Sucursales>(sql.Consultar_Sucursales());//lista generica con los datos de la consulta
            foreach (var sucursal in lista)//Recorre la lista
            {
                //Activa el bool si encuentra coincidencia con el ID digitado
                if(sucursal.Identificacion == int.Parse(this.txt_IDSucursal.Text))
                {
                    encontrar = true;
                }
            }
            if (encontrar == true)
            {
                MessageBox.Show("El ID de la Sucursal digitada se encuentra registrada! \nCambie el ID e intentelo nuevamente.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                //Instanciar objeto Sucursales
                Sucursales objSucursal = new Sucursales();

                objSucursal.Identificacion = int.Parse(txt_IDSucursal.Text);
                objSucursal.Nombre = this.txt_NombreSucursal.Text;
                objSucursal.Direccion = this.txt_DireccionSucursal.Text;
                objSucursal.Telefono = this.txt_TelefonoSucursal.Text;

                //Condicional para asignar el estado
                if (estado == "Activo")
                {
                    objSucursal.Estado = true;
                }
                else
                {
                    objSucursal.Estado = false;

                }
                //Enviar recopilados del objeto a la Base de datos
                sql.Insert_Sucursal(objSucursal);
                reset();

                //Funcion para validar otro registro
                var option = MessageBox.Show("Registro Exitoso! \n¿Desea registrar otra Sucursal?", "Agregar", MessageBoxButtons.YesNo,
                         MessageBoxIcon.Question);
                if (option == DialogResult.No)
                {
                    this.Close();
                    menu.Show();
                }
            }
        }

        private void txt_IDSucursal_TextChanged(object sender, EventArgs e)
        {
            activarGuardar();
        }

        private void cb_EstadoSucursal_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Pasar el indice del combobox a String
            int indice;
            indice = cb_EstadoSucursal.SelectedIndex;
            estado = cb_EstadoSucursal.Items[indice].ToString();

        }

        public void reset()
        {
            this.txt_NombreSucursal.Text = "";
            this.txt_IDSucursal.Text = "";
            this.txt_DireccionSucursal.Text = "";
            this.txt_TelefonoSucursal.Text = "";
            this.cb_EstadoSucursal.SelectedIndex = 0;
        }

        private void txt_IDSucursal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten numeros enteros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_NombreSucursal_TextChanged(object sender, EventArgs e)
        {
            activarGuardar();
        }

        private void txt_DireccionSucursal_TextChanged(object sender, EventArgs e)
        {
            activarGuardar();
        }

        private void txt_TelefonoSucursal_TextChanged(object sender, EventArgs e)
        {
            activarGuardar();
        }

        private void activarGuardar()
        {
            var vr = !string.IsNullOrWhiteSpace(this.txt_DireccionSucursal.Text) &&
                !string.IsNullOrWhiteSpace(this.txt_IDSucursal.Text) &&
                !string.IsNullOrWhiteSpace(this.txt_NombreSucursal.Text) &&
                !string.IsNullOrWhiteSpace(this.txt_TelefonoSucursal.Text);
            this.btn_SaveRegistroSucursal.Enabled = vr;
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            this.Close();
            menu.Show();
        }

        private void VRegistrarSucursal_Load(object sender, EventArgs e)
        {

        }
        
    }
}



