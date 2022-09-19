using DLL_Clase;
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
    public partial class VConsultarVehiculos : Form
    {
        PantallaPrincipalServer menu = new PantallaPrincipalServer();
        
        
        public VConsultarVehiculos(PantallaPrincipalServer menuformparameter)
        {
            InitializeComponent();
            menu = menuformparameter;
            
            
        }
        private void VConsultarVehiculos_Load(object sender, EventArgs e)
        {
            cargarVehiculos();

            int filas = this.dGV_Vehiculos.RowCount;
            //Si no encuentra filas agregadas regresara al menú
            if (filas == 0)
            {
                MessageBox.Show("No hay registros de Vehiculos! \nRegistre al menos un Vehiculo e intentelo de nuevo.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                menu.Show();
            }          

        }
        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            menu.Show();
        }

        public void cargarVehiculos()
        {
            ManejoSQL sql = new ManejoSQL();

            //Lista de la consulta en la base de datos          
            List<Vehiculos> lista = new List<Vehiculos>(sql.Consultar_Vehiculos());

            this.dGV_Vehiculos.ColumnCount = 6;
            this.dGV_Vehiculos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            this.dGV_Vehiculos.Columns[0].Name = "Placa";
            this.dGV_Vehiculos.Columns[1].Name = "Marca";
            this.dGV_Vehiculos.Columns[2].Name = "Modelo";
            this.dGV_Vehiculos.Columns[3].Name = "Tipo de vehiculo";
            this.dGV_Vehiculos.Columns[4].Name = "Costo alquiler";
            this.dGV_Vehiculos.Columns[5].Name = "Kilometraje";

            this.dGV_Vehiculos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach (var vehiculo in lista)
            {
                this.dGV_Vehiculos.Rows.Add(vehiculo.IdPlaca, vehiculo.Marca,
                 vehiculo.Modelo, vehiculo.tipoVehiculo.Descripcion, vehiculo.CostoAlquiler,
                 vehiculo.Kilometraje);
            }


        }

       
    }
    
}
