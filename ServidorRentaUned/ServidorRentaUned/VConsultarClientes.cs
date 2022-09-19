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
    public partial class VConsultarClientes : Form
    {
        PantallaPrincipalServer menu = new PantallaPrincipalServer();
        public VConsultarClientes(PantallaPrincipalServer menuformparameter)
        {
            InitializeComponent();
            menu = menuformparameter;


        }
        private void VConsultarClientes_Load(object sender, EventArgs e)
        {
            cargarClientes();

            int filas = this.dGV_Clientes.RowCount;
            //Si no encuentra filas agregadas regresara al menú
            if (filas == 0)
            {
                MessageBox.Show("No hay registros de Clientes! \nRegistre al menos un Cliente e intentelo de nuevo.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                menu.Show();
            }
            else
            {
                CambiarnombreColumnas();
            }
            
        }

        public void cargarClientes()
        {
            //Instanciar clase de manejo sql
            ManejoSQL sql = new ManejoSQL();

            //Cargar datos de la base de datos
            this.dGV_Clientes.DataSource = sql.Consultar_Clientes();
            this.dGV_Clientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        private void btn_CerrarConsultaCliente_Click(object sender, EventArgs e)
        {
            this.Close();
            menu.Show();
        }

        public void CambiarnombreColumnas()
        {
            this.dGV_Clientes.Columns["Primer_apellido"].HeaderText = "Primer apellido";
            this.dGV_Clientes.Columns["Segundo_apellido"].HeaderText = "Segundo apellido";
            this.dGV_Clientes.Columns["Fecha_nacimiento"].HeaderText = "Fecha. Nacimiento";
        }

        
    }
}
