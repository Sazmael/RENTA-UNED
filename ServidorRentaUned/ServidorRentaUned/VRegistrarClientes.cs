using DLL_Clase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServidorRentaUned
{
    public partial class VRegistrarClientes : Form
    {
        PantallaPrincipalServer menu = new PantallaPrincipalServer();
        ManejoSQL sql = new ManejoSQL();

        public VRegistrarClientes(PantallaPrincipalServer menuformparameter)
        {
            InitializeComponent();
            menu = menuformparameter;

            this.date_FechaCumpleanios.Value = DateTime.Today;
            this.check_GeneroM.Checked = true;
        }

        private void btn_SaveClientes_Click(object sender, EventArgs e)
        {
            bool encontrar = false;
            //lista generica con los datos de la consulta
            List<Clientes> lista = new List<Clientes>(sql.Consultar_Clientes());//lista generica con los datos de la consulta
            foreach (var cliente in lista)//Recorre la lista
            {
                //Activa el bool si encuentra coincidencia con el ID digitado
                if (cliente.Identificacion == this.txt_IDCliente.Text)
                {
                    encontrar = true;
                }
            }
            if (encontrar == true)
            {
                MessageBox.Show("El ID del Cliente digitado se encuentra registrado! \nCambie el ID e intentelo nuevamente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                //Instancia de objeto clientes
                Clientes objClientes = new Clientes();

                objClientes.Identificacion = this.txt_IDCliente.Text;
                objClientes.Nombre = this.txt_NombreCliente.Text;
                objClientes.Primer_apellido = this.txt_Apellido1Cliente.Text;
                objClientes.Segundo_apellido = this.txt_Apellido2Cliente.Text;
                objClientes.Fecha_nacimiento = this.date_FechaCumpleanios.Value;

                if (this.check_GeneroM.Checked)
                {
                    objClientes.Genero = 'M';

                }
                if (this.check_GeneroF.Checked)
                {

                    objClientes.Genero = 'F';
                }

                //Enviar los datos recopilados a la base de datos
                sql.Insert_Clientes(objClientes);
                reset();

                //Funcion para validar otro registro
                var option = MessageBox.Show("Registro Exitoso! \n¿Desea registrar otro Cliente?", "Registrar", MessageBoxButtons.YesNo,
                         MessageBoxIcon.Question);
                if (option == DialogResult.No)
                {
                    this.Close();
                    menu.Show();
                }
            }
        }

        private void check_GeneroM_CheckedChanged(object sender, EventArgs e)
        {
            //Quitar check de F, si M esta activado
            if (this.check_GeneroM.Checked)
            {
                this.check_GeneroF.Checked = false;
            }
        }

        private void check_GeneroF_CheckedChanged(object sender, EventArgs e)
        {
            //Quitar check de M, si F esta activado
            if (this.check_GeneroF.Checked)
            {
                this.check_GeneroM.Checked = false;
            }
        }

        public void reset()
        {
            this.txt_NombreCliente.Text = "";
            this.txt_IDCliente.Text = "";
            this.txt_Apellido1Cliente.Text = "";
            this.txt_Apellido2Cliente.Text = "";
            this.date_FechaCumpleanios.Value = DateTime.Today;
            this.check_GeneroM.Checked = true;
        }

        private void activarGuardar()
        {
            var vr = !string.IsNullOrWhiteSpace(this.txt_NombreCliente.Text) &&
                !string.IsNullOrWhiteSpace(this.txt_IDCliente.Text) &&
                !string.IsNullOrWhiteSpace(this.txt_Apellido1Cliente.Text) &&
                !string.IsNullOrWhiteSpace(this.txt_Apellido2Cliente.Text);
            this.btn_SaveClientes.Enabled = vr;
        }

        private void txt_IDCliente_TextChanged(object sender, EventArgs e)
        {
            activarGuardar();
        }

        private void txt_NombreCliente_TextChanged(object sender, EventArgs e)
        {
            activarGuardar();
        }

        private void txt_Apellido1Cliente_TextChanged(object sender, EventArgs e)
        {
            activarGuardar();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            activarGuardar();
        }

        private void txt_Apellido2Cliente_TextChanged(object sender, EventArgs e)
        {
            activarGuardar();
        }
        private void txt_IDCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                MessageBox.Show("No se admiten espacios", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;

            }
        }

        private void txt_Apellido1Cliente_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsWhiteSpace(e.KeyChar))
            {
                MessageBox.Show("No se admiten espacios", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;

            }

        }

        private void txt_Apellido2Cliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                MessageBox.Show("No se admiten espacios", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;

            }
        }

        private void txt_NombreCliente_KeyPress(object sender, KeyPressEventArgs e)
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
