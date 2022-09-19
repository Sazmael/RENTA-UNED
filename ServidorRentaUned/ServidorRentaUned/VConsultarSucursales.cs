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
    public partial class VConsultarSucursales : Form
    {
        //instanciar objetos
        PantallaPrincipalServer menu = new PantallaPrincipalServer();
        
        public VConsultarSucursales(PantallaPrincipalServer menuformparameter)
        {
            InitializeComponent();
            menu = menuformparameter;
            
        }

        private void VConsultarSucursales_Load(object sender, EventArgs e)
        {
            cargarSucursales();

            int filas = this.dGV_Sucursales.RowCount;
            //Si no encuentra filas agregadas regresara al menú
            if (filas == 0)
            {
                MessageBox.Show("No hay registros de Sucursales! \nRegistre al menos una Consultar_Sucursales y intentelo de nuevo.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                menu.Show();
            }
            else
            {
                //Ocultar la columna de checks de estados
                this.dGV_Sucursales.Columns["Estado"].Visible = false;

                //Cambia el nombre de la columna
                this.dGV_Sucursales.Columns["EstadoSucursal"].HeaderText = "Estado";
            }

        }

        public void cargarSucursales()
        {

            ManejoSQL sql = new ManejoSQL();
            //Cargar datos al datasource de la tabla Sucursales
            this.dGV_Sucursales.DataSource = sql.Consultar_Sucursales();
            this.dGV_Sucursales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; //auto size

                    
            
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            menu.Show();
        }
    }
}
