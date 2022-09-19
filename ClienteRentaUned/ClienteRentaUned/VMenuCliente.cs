using DLL_Clase;
using ClienteRentaUned;
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
    public partial class VMenuCliente : Form
    {

        VLogin loginCliente = new VLogin();

        public VMenuCliente(VLogin Parameter)//Parametros del cliente del Login
        {
            InitializeComponent();
            loginCliente = Parameter;
            this.label_NombreCliente.Text = "Bienvenido " + loginCliente.nombreCompleto;
        }
        private void VCliente_Load(object sender, EventArgs e)
        {


        }
        private void btn_AbrirReserva_Click(object sender, EventArgs e)
        {
            this.Close();
            VReservarVehiculo rv = new VReservarVehiculo(loginCliente);//Parametros del cliente del Login
            rv.Show();
        }

        private void btn_AbrirConsultaReserva_Click(object sender, EventArgs e)
        {
            this.Close();
            VConsultarReservas cr = new VConsultarReservas(loginCliente);//Parametros del cliente del Login
            cr.Show();
        }

        private void btn_CerrarSesion_Click(object sender, EventArgs e)
        {
            //Preguntar si se desea salir
            var option = MessageBox.Show("¿Desea Cerrar Sesión?\nSerá dirigido al Login y se le desconectara del servidor", "Cerrar Sesión", MessageBoxButtons.YesNo,
                     MessageBoxIcon.Question);
            if (option == DialogResult.Yes)
            {
                ClienteTCP.Desconectar(loginCliente.IdCliente);

                this.Close();
                VLogin lc = new VLogin();//Parametros del cliente del Login
                lc.Show();
            }
            
        }
    }
}
