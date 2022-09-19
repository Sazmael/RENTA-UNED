using System;
using DLL_Clase;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

////                                     ICONOS TOMADOS DE: https://iconos8.es/
namespace ClienteRentaUned
{

    public partial class VLogin : Form
    {
        
        public String nombreCompleto;
        public String IdCliente;
        
        public bool conectado = false;

        public VLogin()
        {
            InitializeComponent();

            label_EstadoOnline.Text = "Conexión con servidor: OFF";
            this.label_EstadoOnline.ForeColor = System.Drawing.Color.Red;
            this.btn_Conectar.Enabled = true;
            this.btn_Desconectar.Enabled = false;

        }

        private void btn_Ingresar_Click(object sender, EventArgs e)
        {          
            if (conectado == true)
            {
                bool registrado = false;
                ClienteTCP tcp = new ClienteTCP();

                List<Clientes> lista = new List<Clientes>(tcp.ConsultarClientes(this.txt_IDClienteLog.Text)); //Lista generica Clientes
                
                foreach (var cliente in lista)
                {
                    if (cliente.Identificacion == this.txt_IDClienteLog.Text)
                    {                       
                        registrado = true;
                        IdCliente = cliente.Identificacion;
                        nombreCompleto = cliente.Nombre + " " + cliente.Primer_apellido + " " + cliente.Segundo_apellido;
                    }

                }

                if (registrado == true)
                {
                        tcp.PermitirAcesso(IdCliente);
                        MessageBox.Show("Bienvenido " + nombreCompleto);
                        VMenuCliente c = new VMenuCliente(this); //Pasar los datos del cliente registrado                                               
                        this.Hide();
                        c.Show();
                    
                    
                }
                else
                {
                    tcp.denegarAcesso(this.txt_IDClienteLog.Text);
                    MessageBox.Show("ID no registrado!\nSolicite su registro a la empresa RENTAUNED.", "NO REGISTRADO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Sin conexion!\nIntente conectarse al servidor e intente nuevamente", "OFFLINE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_Conectar_Click(object sender, EventArgs e)
        {          
            if (ClienteTCP.Conectar())
            {
                conectado = true;
                label_EstadoOnline.Text = "Conexión con servidor: ON";
                this.label_EstadoOnline.ForeColor = System.Drawing.Color.Lime;
                this.label_Login.ForeColor = System.Drawing.Color.Lime;
                this.btn_Conectar.Enabled = false;
                this.btn_Desconectar.Enabled = true;

            }
            else
            {
                conectado = false;
                MessageBox.Show("No se logro establecer conexion con el servidor, intente nuevamente", "OFFLINE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
           
        }

        private void btn_Desconectar_Click(object sender, EventArgs e)
        {
            conectado = false;
            if (ClienteTCP.Desconectar(txt_IDClienteLog.Text))
            {           
                this.label_EstadoOnline.ForeColor = System.Drawing.Color.Red;
                this.label_Login.ForeColor = System.Drawing.Color.Red;
                this.btn_Conectar.Enabled = true;
                this.btn_Desconectar.Enabled = false;
                label_EstadoOnline.Text = "Conexión con servidor: OFF";
            }
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //Preguntar si se desea salir
            var option = MessageBox.Show("¿Desea salir?", "Salir", MessageBoxButtons.YesNo,
                     MessageBoxIcon.Question);
            if (option == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void txt_IDClienteLog_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                MessageBox.Show("No se admiten espacios", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;

            }
        }

        private void txt_IDClienteLog_TextChanged(object sender, EventArgs e)
        {
            this.btn_Ingresar.Enabled = !string.IsNullOrWhiteSpace(this.txt_IDClienteLog.Text);
        }

        private void txt_IDClienteLog_Enter(object sender, EventArgs e)
        {
            if(this.txt_IDClienteLog.Text == "IDENTIFICACIÓN")
            {
                this.txt_IDClienteLog.Text = String.Empty;
                this.txt_IDClienteLog.ForeColor = Color.Black;
            }
        }

        private void txt_IDClienteLog_Leave(object sender, EventArgs e)
        {
            if (this.txt_IDClienteLog.Text == String.Empty)
            {
                this.txt_IDClienteLog.Text = "IDENTIFICACIÓN";
                this.txt_IDClienteLog.ForeColor = Color.Silver;
            }
        }
    }
}
