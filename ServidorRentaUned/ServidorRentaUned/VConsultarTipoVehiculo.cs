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
    public partial class VConsultarTipoVehiculo : Form
    {
        PantallaPrincipalServer menu = new PantallaPrincipalServer();

        public VConsultarTipoVehiculo(PantallaPrincipalServer menuformparameter)
        {
            InitializeComponent();
            menu = menuformparameter;
        }
        private void VConsultarTipoVehiculo_Load(object sender, EventArgs e)
        {
            cargarTipoVehiculos();

            int filas = this.dGV_TipoVehiculos.RowCount;
            //Si no encuentra filas agregadas regresara al menú
            if (filas == 0)
            {
                MessageBox.Show("No hay registros de Tipos de Vehiculos! \nRegistre al menos un Tipo de Vehiculo e intentelo de nuevo.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                menu.Show();
            }
            else
            {
                this.dGV_TipoVehiculos.Columns["Estado"].Visible = false;
                this.dGV_TipoVehiculos.Columns["Id"].HeaderText = "ID";
                this.dGV_TipoVehiculos.Columns["EstadoTipoVehiculo"].HeaderText = "Estado";

            }


        }
        public void cargarTipoVehiculos()
        {         
            ManejoSQL sql = new ManejoSQL();

            this.dGV_TipoVehiculos.DataSource = sql.Consultar_TipoVehiculos();
            this.dGV_TipoVehiculos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; //auto size

        }
        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            menu.Show();
            
        }

        

       
    }
}
