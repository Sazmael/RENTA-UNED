using System;
using System.Windows.Forms;
using ServidorRentaUned.Clases;
using DLL_Clase;
using System.Net.Sockets;
using System.Net;
using System.Drawing;
using System.Threading;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;

////                                     ICONOS TOMADOS DE: https://iconos8.es/

namespace ServidorRentaUned
{

    public partial class PantallaPrincipalServer : Form
    {
        //Variables para el manejo de la base y la escucha del Servidor-Cliente
        ManejoSQL sql = new ManejoSQL();
        TcpListener tcpListener;
        Thread procesoEscucharClientes;
        StreamReader serverReader;
        StreamWriter serverWriter;

        //Crear metodos para escribir los eventos y clientes on en los espacios
        EscribirTxtDelegado modificarTxtBitacora;
        ModificarListDelegado modificarListBitacora;

        //Delegado de los eventos servidor
        private delegate void EscribirTxtDelegado(String txt);
        private delegate void ModificarListDelegado(String txt, bool agregar);

        private void EscribirTxtBitacora(String txt)
        {
            this.txt_Bitacora.AppendText(DateTime.Now.ToString() + " - " + txt);
            txt_Bitacora.AppendText(Environment.NewLine); //Salto de linea
        }

        //Modifica la lista de la bitacora recibiendo y eliminando cliente
        private void ModificarListBitacora(string txt, bool agregar)
        {
            try
            {
                if (agregar == true)
                {

                    list_Usuarios.Items.Add(txt);
                    this.txt_ClientesConectados.Text = list_Usuarios.Items.Count.ToString();
                }
                else
                {

                    list_Usuarios.Items.Remove(txt);
                    this.txt_ClientesConectados.Text = list_Usuarios.Items.Count.ToString();
                }
            }
            catch (Exception)
            {

                list_Usuarios.Items.Remove(txt);
                txt_ClientesConectados.Text = list_Usuarios.Items.Count.ToString();
            }

        }
        
        static bool iniciarServidor = false;

        public PantallaPrincipalServer()
        {
            /////////////////////Inicio/////////////////////////////////
            InitializeComponent();
            customizarDisenio();
            
            txt_ClientesConectados.Text = list_Usuarios.Items.Count.ToString();//Contar lista y pasarla al texbox

            //Condicional para controles de la pantalla principal activas o desactivados
            if (iniciarServidor == true)
            {
                this.label_EstadoServer.ForeColor = Color.Green;
                this.label_EstadoServer.Text = "Servidor: ONLINE";
                this.btn_Conectar.Enabled = false;
                this.btn_Desconectar.Enabled = true;
            }
            else
            {
                this.label_EstadoServer.ForeColor = Color.Red;
                this.label_EstadoServer.Text = "Servidor: OFFLINE";
                this.btn_Conectar.Enabled = true;
                this.btn_Desconectar.Enabled = false;
            }

            modificarTxtBitacora = new EscribirTxtDelegado(EscribirTxtBitacora);
            modificarListBitacora = new ModificarListDelegado(ModificarListBitacora);

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

        ///////////////////////Metodos conectar servidor////////////////////
        ///Referencia de los metodos para la conexion tomados de:  
        /// Cátedra Tecnología de Sistemas/Informática UNED CR/Sesión Virtual #3 Programación avanzada IIC2002. 
        /// Referencia de los metodos para la conexion tomados de:  
        /// https://youtu.be/wK6Kexsq8ZM
        private void btn_Conectar_Click(object sender, EventArgs e)
        {
            //Variable de la IP
            IPAddress direccionIP = IPAddress.Parse("127.0.0.1");
            tcpListener = new TcpListener(direccionIP, 14100); //Asigna Ip y puerto
            iniciarServidor = true;

            //Escuchar clientes mediante nuevo hilo
            procesoEscucharClientes = new Thread(new ThreadStart(EscucharClientes));
            procesoEscucharClientes.Start();

            //Escribir evento iniciar servidor en la bitacora
            txt_Bitacora.Text = "Servidor iniciado con la IP " + direccionIP.ToString() + " y puerto 14100";
            txt_Bitacora.AppendText(Environment.NewLine);

            this.label_EstadoServer.ForeColor = Color.Lime;
            this.label_EstadoServer.Text = "Servidor: ONLINE";
            this.panelBitacora.BackColor = Color.Lime;
            this.txt_Bitacora.BackColor = Color.Lime;
            this.list_Usuarios.BackColor = Color.Lime;
            this.btn_Conectar.Enabled = false;
            this.btn_Desconectar.Enabled = true;


        }

        private void btn_Desconectar_Click(object sender, EventArgs e)
        {
            txt_Bitacora.Text = "Servidor detenido"; //evento bitacora
            txt_Bitacora.AppendText(Environment.NewLine);//nextline bitacora

            iniciarServidor = false; 
            tcpListener.Stop(); //detener escucha
            
            this.list_Usuarios.Items.Clear(); //quitar clientes
            this.txt_ClientesConectados.Text = list_Usuarios.Items.Count.ToString();//refresh clientes conectados

            //Cambiar colores de textos y cajas
            this.label_EstadoServer.Text = "Servidor: OFFLINE";
            this.label_EstadoServer.ForeColor = Color.Crimson;
            this.panelBitacora.BackColor = Color.Crimson;
            this.txt_Bitacora.BackColor = Color.Crimson;
            this.list_Usuarios.BackColor = Color.Crimson;
            this.btn_Conectar.Enabled = true;
            this.btn_Desconectar.Enabled = false;

        }

        private void EscucharClientes()
        {
            tcpListener.Start();
            try
            {
                while (iniciarServidor)
                {
                    
                    //Se bloquea hasta que un cliente se haya conectado al servidor 
                    TcpClient client = tcpListener.AcceptTcpClient();
                    /*Se crea un nuevo hilo para manejar la comunicación con los clientes que se conectan al servidor*/
                    Thread clientThread = new Thread(new ParameterizedThreadStart(ComunicacionCliente));
                    clientThread.Start(client);
                }
               
            }
            catch (Exception)
            {

                return;
            }
        }

        private void ComunicacionCliente(object cliente)
        {
            //variable para la escucha del cliente
            TcpClient tcpCliente = (TcpClient)cliente;
            serverReader = new StreamReader(tcpCliente.GetStream()); //obtiene los bytes recibidos y los castea
            serverWriter = new StreamWriter(tcpCliente.GetStream());

            while (iniciarServidor == true)
            {
                try
                {
                    //lee los metodos recibidos y los pasa al switch
                    var paquete = serverReader.ReadLine();
                    PaqueteSocket<object> paqueteRecibido = JsonConvert.DeserializeObject<PaqueteSocket<Object>>(paquete); //DesSerializar paquete recibido
                    SelectMetodo(paqueteRecibido.Metodo, paquete, ref serverWriter);
                }
                catch (Exception)
                {
                    break;
                }

            }
            tcpCliente.Close();
        }

        /////////////SWITCH de metodos rebibidos desde la tcpCliente
        public void SelectMetodo(string Metodo, string Paquete, ref StreamWriter serverStreamWriter)
        {
            switch (Metodo)
            {
                case "Conectar":
                    PaqueteSocket<string> paqueteConectar = JsonConvert.DeserializeObject<PaqueteSocket<string>>(Paquete);
                    ConectarServer();
                    break;

                case "PermitirAcceso":
                    PaqueteSocket<string> paqueteAcceso = JsonConvert.DeserializeObject<PaqueteSocket<string>>(Paquete);
                    PermitirAcceso(paqueteAcceso.Entidad);
                    break;

                case "DenegarAcceso":
                    PaqueteSocket<string> paqueteDenegar = JsonConvert.DeserializeObject<PaqueteSocket<string>>(Paquete);
                    DenegarAcceso(paqueteDenegar.Entidad);
                    break;

                case "Desconectar":
                    PaqueteSocket<string> paqueteDesconectar = JsonConvert.DeserializeObject<PaqueteSocket<string>>(Paquete);
                    DesconectarServer(paqueteDesconectar.Entidad);
                    break;

                case "Check":
                    PaqueteSocket<string> paqueteCheck = JsonConvert.DeserializeObject<PaqueteSocket<string>>(Paquete);
                    CheckConexion(paqueteCheck.Entidad);
                    break;

                case "ConsultarClientes":
                    PaqueteSocket<string> paqueteconsultarClientes = JsonConvert.DeserializeObject<PaqueteSocket<string>>(Paquete);
                    ConsultarClientes(paqueteconsultarClientes.Entidad);
                    break;

                case "ConsultarSucursales":
                    ObtenerSucursales(ref serverWriter);
                    break;

                case "VehiculosAsoc":
                    PaqueteSocket<int> paqueteVehiculosAsoc = JsonConvert.DeserializeObject<PaqueteSocket<int>>(Paquete);//Se deserializa el objeto recibido mediante json
                    VehiculosAsoc(paqueteVehiculosAsoc.Entidad, ref serverWriter);
                    break;

                case "CargarCoberturas":
                    PaqueteSocket<int> paqueteCoberturasTipo = JsonConvert.DeserializeObject<PaqueteSocket<int>>(Paquete);//Se deserializa el objeto recibido mediante json
                    CargarCoberturas(paqueteCoberturasTipo.Entidad, ref serverWriter);
                    break;

                case "Reservar":
                    PaqueteSocket<Reservas> paqueteReservar = JsonConvert.DeserializeObject<PaqueteSocket<Reservas>>(Paquete);// Se deserializa el objeto recibido mediante json
                    Reservar(paqueteReservar.Entidad);
                    break;

                case "ConsultarReservasCliente":
                    PaqueteSocket<string> paqueteReservasCliente = JsonConvert.DeserializeObject<PaqueteSocket<string>>(Paquete);//Se deserializa el objeto recibido mediante json
                    ReservasCliente(paqueteReservasCliente.Entidad, ref serverWriter);
                    break;

                default:
                    break;
            }
        }

        ////////////Eventos de la bitacora
        private void ConectarServer()
        {
            this.txt_Bitacora.Invoke(modificarTxtBitacora, new object[] { "Nueva conexion en la IP 127.0.0.1 y puerto 14100 ..." });
            
        }
        private void DesconectarServer(String IDCliente)
        {
            this.txt_Bitacora.Invoke(modificarTxtBitacora, new object[] { IDCliente + " Se ha desconectado." });
            this.list_Usuarios.Invoke(modificarListBitacora, new object[] { IDCliente, false });

        }

        private void CheckConexion(String IDCliente)
        {
            this.txt_Bitacora.Invoke(modificarTxtBitacora, new object[] { "Check de conexion con Cliente " + IDCliente + " exitosa..." });

            //Refrescar lista de conexiones
            this.list_Usuarios.Invoke(modificarListBitacora, new object[] { IDCliente, false });
            this.list_Usuarios.Invoke(modificarListBitacora, new object[] { IDCliente, true });
        }

        private void ConsultarClientes(String IDCliente)
        {
            List<Clientes> listaClientes = new List<Clientes>();

            listaClientes = sql.Consultar_Clientes();

            serverWriter.WriteLine(JsonConvert.SerializeObject(listaClientes));
            serverWriter.Flush();
            this.txt_Bitacora.Invoke(modificarTxtBitacora, new object[] { "Servidor revisando clientes registrados para dar acceso al usuario " + IDCliente +"..." });

        }

        private void PermitirAcceso(String IDCliente)
        {

            this.txt_Bitacora.Invoke(modificarTxtBitacora, new object[] { "Servidor permitio el acceso a " + IDCliente + "..."});
            this.list_Usuarios.Invoke(modificarListBitacora, new object[] { IDCliente, true });

        }
        private void DenegarAcceso(String IDCliente)
        {
            this.txt_Bitacora.Invoke(modificarTxtBitacora, new object[] { "Servidor denego el acceso a " + IDCliente + "."});        

        }

        private void ObtenerSucursales(ref StreamWriter serverWriter)
        {
            List<Sucursales> listaSucursalesActivas = new List<Sucursales>();

            listaSucursalesActivas = sql.Consultar_Sucursales();

            serverWriter.WriteLine(JsonConvert.SerializeObject(listaSucursalesActivas));
            serverWriter.Flush();

            this.txt_Bitacora.Invoke(modificarTxtBitacora, new object[] { "Se consulto las Sucursales al servidor... "});
        }

        private void VehiculosAsoc(int IDSucursalAux, ref StreamWriter servidorStreamWriter)
        {
            List<VehiculoSucursal> listaVehiculosAsoc = new List<VehiculoSucursal>();

            listaVehiculosAsoc = sql.Consultar_VehiculosAsociados(IDSucursalAux);

            serverWriter.WriteLine(JsonConvert.SerializeObject(listaVehiculosAsoc));
            serverWriter.Flush();
            this.txt_Bitacora.Invoke(modificarTxtBitacora, new object[] { "Se consulto los Vehiculos asociados a la Sucursal " + IDSucursalAux + "..." });
        }
        private void CargarCoberturas(int IdTipoVehiculoAux,ref StreamWriter servidorStreamWriter)
        {
            List<Coberturas> listaCoberturas = new List<Coberturas>();

            listaCoberturas = sql.Consultar_Coberturas();

            serverWriter.WriteLine(JsonConvert.SerializeObject(listaCoberturas));
            serverWriter.Flush();
            this.txt_Bitacora.Invoke(modificarTxtBitacora, new object[] { "Se consulto las Coberturas asociadas al Tipo de vehiculo " + IdTipoVehiculoAux + "..." });
        }
        private void Reservar(Reservas objReservas)
        {
            sql.Insert_Reservas(objReservas);
            this.txt_Bitacora.Invoke(modificarTxtBitacora, new object[] { objReservas.IdCliente + " Ha realizado una Reserva..." });
        }
        private void ReservasCliente(string IDCliente, ref StreamWriter servidorStreamWriter)
        {
            this.txt_Bitacora.Invoke(modificarTxtBitacora, new object[] { IDCliente + " Ha consultado sus Reservaciones..." });
            List<Reservas> listaReservas = new List<Reservas>();

            listaReservas = sql.ConsultarReservasCliente(IDCliente);

            servidorStreamWriter.WriteLine(JsonConvert.SerializeObject(listaReservas));
            servidorStreamWriter.Flush();


        }

        //////////////////////////////////////////////////////////////////////////////////////////
        ///         CODIGO DE DISEÑO
        private void customizarDisenio()
        {
            this.panel_SubMenuRegistrar.Visible = false;
            this.panel_SubMenuConsultar.Visible = false;
            

        }

        private void hideSubMenu()
        {
            if(panel_SubMenuRegistrar.Visible == true)
            {
                panel_SubMenuRegistrar.Visible = false;
            }
            if (this.panel_SubMenuConsultar.Visible == true)
            {
                panel_SubMenuConsultar.Visible = false;
            }
        }

        private void showSubmenu(Panel Submenu)
        {
            if(Submenu.Visible == false)
            {
                hideSubMenu();
                Submenu.Visible = true;
            }
            else
            {
                Submenu.Visible = false;
            }
        }

        private void btn_DesplegarRegistrar_Click(object sender, EventArgs e)
        {
            showSubmenu(this.panel_SubMenuRegistrar);
        }

        private void btn_DesplegarConsultar_Click(object sender, EventArgs e)
        {
            showSubmenu(this.panel_SubMenuConsultar);
        }

        ///////////////////////////////////////////
        ///                     Abrir ventanas
        private void btn_RegistrarSucursales_Click(object sender, EventArgs e)
        {
            this.Hide();
            VRegistrarSucursal rs = new VRegistrarSucursal(this);
            rs.Show();

            hideSubMenu();
        }

        private void btn_RegistrarClientes_Click(object sender, EventArgs e)
        {
            this.Hide();
            VRegistrarClientes rc = new VRegistrarClientes(this);
            rc.Show();

            hideSubMenu();
        }

        private void btn_RegistrarTipoVehiculo_Click(object sender, EventArgs e)
        {
            this.Hide();
            VRegistrarTipoVehiculo rtv = new VRegistrarTipoVehiculo(this);
            rtv.Show();

            hideSubMenu();
        }

        private void btn_RegistrarVehiculos_Click(object sender, EventArgs e)
        {
            this.Hide();
            VRegistrarVehiculos rv = new VRegistrarVehiculos(this);
            rv.Show();

            hideSubMenu();
        }

        private void btn_RegistrarVehiculoSucursal_Click(object sender, EventArgs e)
        {
            this.Hide();
            VAsociarVehiculoSucursal avs = new VAsociarVehiculoSucursal(this);
            avs.Show();

            hideSubMenu();
        }

        private void btn_RegistrarCoberturas_Click(object sender, EventArgs e)
        {
            this.Hide();
            VRegistrarCoberturas rcob = new VRegistrarCoberturas(this);
            rcob.Show();

            hideSubMenu();
        }

        private void btn_ConsultarSucursales_Click(object sender, EventArgs e)
        {
            this.Hide();
            VConsultarSucursales cs = new VConsultarSucursales(this);
            cs.Show();

            hideSubMenu();
        }

        private void btn_ConsultarClientes_Click(object sender, EventArgs e)
        {
            this.Hide();
            VConsultarClientes cc = new VConsultarClientes(this);
            cc.Show();

            hideSubMenu();
        }

        private void btn_ConsultarTipoVehículos_Click(object sender, EventArgs e)
        {
            this.Hide();
            VConsultarTipoVehiculo ctv = new VConsultarTipoVehiculo(this);
            ctv.Show();

            hideSubMenu();
        }

        private void btn_ConsultarVehiculos_Click(object sender, EventArgs e)
        {
            this.Hide();
            VConsultarVehiculos cv = new VConsultarVehiculos(this);
            cv.Show();

            hideSubMenu();
        }

        private void btn_ConsultarVehiculosSucursal_Click(object sender, EventArgs e)
        {
            this.Hide();
            VConsultarVehiculoSucursal cvs = new VConsultarVehiculoSucursal(this);
            cvs.Show();

            hideSubMenu();
        }

        private void btn_ConsultarCobertura_Click(object sender, EventArgs e)
        {
            this.Hide();
            btn_Volver ccbob = new btn_Volver(this);
            ccbob.Show();

            hideSubMenu();
        }
    }


}
