using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServidorRentaUned.Clases
{
    public partial class btn_Volver : Form
    {
        PantallaPrincipalServer menu = new PantallaPrincipalServer();
       
        public btn_Volver(PantallaPrincipalServer menuformparameter)
        {
            InitializeComponent();
            menu = menuformparameter;

        }
        private void VConsultarCoberturas_Load(object sender, EventArgs e)
        {
            cargarCoberturas();

            int filas = this.dGV_Coberturas.RowCount;
            //Si no encuentra filas agregadas regresara al menú
            if (filas == 0)
            {
                MessageBox.Show("No hay registros de Coberturas de Seguro! \nRegistre al menos una Cobertura de Seguro e intentelo de nuevo.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                menu.Show();
            }
            else
            {

                //Ocultar columnas
                this.dGV_Coberturas.Columns["Estado"].Visible = false;
                //Cambiar nombre columnas
                this.dGV_Coberturas.Columns["IdCobertura"].HeaderText = "ID Cobertura";
                this.dGV_Coberturas.Columns["EstadoString"].HeaderText = "Estado";
                this.dGV_Coberturas.Columns["IdTipoVehiculo"].HeaderText = "ID Tipo Vehiculo";
            }

        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            this.Close();
            menu.Show();
        }

        public void cargarCoberturas()
        {
            ManejoSQL sql = new ManejoSQL();
            this.dGV_Coberturas.DataSource = sql.Consultar_Coberturas();
            this.dGV_Coberturas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }        
    }
}
