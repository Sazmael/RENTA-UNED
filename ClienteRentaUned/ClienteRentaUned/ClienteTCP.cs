using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DLL_Clase;
using Newtonsoft.Json;

namespace ClienteRentaUned
{
    public class ClienteTCP
    {
        private static IPAddress ipServidor;
        private static TcpClient conexionCliente;
        private static IPEndPoint serverEndPoint;
        private static StreamReader clientStreamReader;
        private static StreamWriter clientStreamWriter;

        ///////////////////////Metodos conectar con servidor////////////////////
        ///Referencia de los metodos para la conexion tomados de:  
        /// Cátedra Tecnología de Sistemas/Informática UNED CR/Sesión Virtual #3 Programación avanzada IIC2002. 
        /// Referencia de los metodos para la conexion tomados de:  
        /// https://youtu.be/wK6Kexsq8ZM

        //Metodos envian los parametros al servidor serializados y los retorna
        public static bool Conectar()
        {
            try
            {
                ipServidor = IPAddress.Parse("127.0.0.1");
                conexionCliente = new TcpClient();
                serverEndPoint = new IPEndPoint(ipServidor, 14100);
                conexionCliente.Connect(serverEndPoint);


                PaqueteSocket<string> paqueteConectar = new PaqueteSocket<string> { Metodo = "Conectar" };

                clientStreamReader = new StreamReader(conexionCliente.GetStream());
                clientStreamWriter = new StreamWriter(conexionCliente.GetStream());

                clientStreamWriter.WriteLine(JsonConvert.SerializeObject(paqueteConectar));
                clientStreamWriter.Flush();

                return true;

            }
            catch (Exception)
            {

                return false;
            }
        }
        public static bool CheckConexionServer(String IDCliente)
        {
            try
            {
                ipServidor = IPAddress.Parse("127.0.0.1");
                conexionCliente = new TcpClient();
                serverEndPoint = new IPEndPoint(ipServidor, 14100);
                conexionCliente.Connect(serverEndPoint);

                PaqueteSocket<string> paqueteConectar = new PaqueteSocket<string> { Metodo = "Check", Entidad = IDCliente };

                clientStreamReader = new StreamReader(conexionCliente.GetStream());
                clientStreamWriter = new StreamWriter(conexionCliente.GetStream());

                clientStreamWriter.WriteLine(JsonConvert.SerializeObject(paqueteConectar));
                clientStreamWriter.Flush();

                return true;

            }
            catch (Exception)
            {

                return false;
            }
        }
        public String PermitirAcesso(String IDCliente)
        {
            try
            {
                PaqueteSocket<string> paqueteAcceso = new PaqueteSocket<string> { Metodo = "PermitirAcceso", Entidad = IDCliente };
                clientStreamWriter.WriteLine(JsonConvert.SerializeObject(paqueteAcceso));
                clientStreamWriter.Flush();          
               
            }
            catch (Exception)
            {
         
               
            }
            return IDCliente;
        }
        public String denegarAcesso(String IDCliente)
        {
            try
            {
                PaqueteSocket<string> paqueteDenegar = new PaqueteSocket<string> { Metodo = "DenegarAcceso", Entidad = IDCliente };
                clientStreamWriter.WriteLine(JsonConvert.SerializeObject(paqueteDenegar));
                clientStreamWriter.Flush();

            }
            catch (Exception)
            {


            }
            return IDCliente;
        }
        public static bool Desconectar(String IDCliente)
        {
            try
            {
                ipServidor = IPAddress.Parse("127.0.0.1");
                conexionCliente = new TcpClient();
                serverEndPoint = new IPEndPoint(ipServidor, 14100);
                conexionCliente.Connect(serverEndPoint);

                PaqueteSocket<string> paqueteConectar = new PaqueteSocket<string> { Metodo = "Desconectar", Entidad = IDCliente };

                clientStreamReader = new StreamReader(conexionCliente.GetStream());           
                clientStreamWriter = new StreamWriter(conexionCliente.GetStream());
                clientStreamWriter.WriteLine(JsonConvert.SerializeObject(paqueteConectar));
                clientStreamWriter.Flush();

                return true;

            }
            catch (Exception)
            {
               
                return false;
            }
        }
        public List<Clientes> ConsultarClientes(String IDCliente)
        {
            List<Clientes> listaClientes = new List<Clientes>();
            try
            {
               
                PaqueteSocket<string> paqueteConsultarClientes = new PaqueteSocket<string> { Metodo = "ConsultarClientes" , Entidad = IDCliente };

                clientStreamWriter.WriteLine(JsonConvert.SerializeObject(paqueteConsultarClientes));
                clientStreamWriter.Flush();

                var paquete = clientStreamReader.ReadLine();
                listaClientes = JsonConvert.DeserializeObject<List<Clientes>>(paquete);

               
            }
            catch(Exception)
            {
                MessageBox.Show("No se logró establecer conexión con el servidor!\nIntentelo nuevamente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            return listaClientes;

        }
        public List<Sucursales> obtenerSucursales()
        {
            List<Sucursales> listaSucursalesActivas = new List<Sucursales>();
            try
            {

                PaqueteSocket<Sucursales> paqueteSucursalesActivas = new PaqueteSocket<Sucursales> { Metodo = "ConsultarSucursales" };
                
                clientStreamWriter.WriteLine(JsonConvert.SerializeObject(paqueteSucursalesActivas));
                clientStreamWriter.Flush();

                var paquete = clientStreamReader.ReadLine();
                listaSucursalesActivas = JsonConvert.DeserializeObject<List<Sucursales>>(paquete);


            }
            catch (Exception)
            {
                MessageBox.Show("No se logró establecer conexión con el servidor!\nIntentelo nuevamente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            return listaSucursalesActivas;

        }
        public List<VehiculoSucursal> vehiculosAsoc(int IDSucursalAux)
        {
            List<VehiculoSucursal> listaVehiculosAsoc = new List<VehiculoSucursal>();
            try
            {
                PaqueteSocket<int> paqueteVehiculosAsoc = new PaqueteSocket<int> { Metodo = "VehiculosAsoc", Entidad = IDSucursalAux};

                clientStreamWriter.WriteLine(JsonConvert.SerializeObject(paqueteVehiculosAsoc));
                clientStreamWriter.Flush();

                var paquete = clientStreamReader.ReadLine();
                listaVehiculosAsoc = JsonConvert.DeserializeObject<List<VehiculoSucursal>>(paquete);

            }
            catch (Exception)
            {
                MessageBox.Show("No se logró establecer conexión con el servidor!\nIntentelo nuevamente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            return listaVehiculosAsoc;

        }
        public List<Coberturas> CargarCoberturas(int IdTipoVehiculoAux)
        {
            List<Coberturas> listaCoberturasTipo = new List<Coberturas>();
            try
            {

                PaqueteSocket<int> paqueteCoberturas = new PaqueteSocket<int> { Metodo = "CargarCoberturas", Entidad = IdTipoVehiculoAux };

                clientStreamWriter.WriteLine(JsonConvert.SerializeObject(paqueteCoberturas));
                clientStreamWriter.Flush();

                var paquete = clientStreamReader.ReadLine();
                listaCoberturasTipo = JsonConvert.DeserializeObject<List<Coberturas>>(paquete);


            }
            catch (Exception)
            {
                MessageBox.Show("No se logró establecer conexión con el servidor!\nIntentelo nuevamente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            return listaCoberturasTipo;

        }
        public bool Reservar(Reservas objReserva)
        {
            try
            {
                PaqueteSocket<Reservas> paqueteReserva = new PaqueteSocket<Reservas> { Metodo = "Reservar", Entidad = objReserva };
                clientStreamWriter.WriteLine(JsonConvert.SerializeObject(paqueteReserva));
                clientStreamWriter.Flush();
                return true;
            }
            catch (Exception)
            {

                MessageBox.Show("No se logró establecer conexión con el servidor!\nIntentelo nuevamente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public List<Reservas> ConsultarReservasCliente(string IDCliente)
        {
            List<Reservas> listaReservas = new List<Reservas>();
            try
            {

                PaqueteSocket<string> paqueteConsultarReservas = new PaqueteSocket<string> { Metodo = "ConsultarReservasCliente", Entidad = IDCliente };

                clientStreamWriter.WriteLine(JsonConvert.SerializeObject(paqueteConsultarReservas));
                clientStreamWriter.Flush();

                var paquete = clientStreamReader.ReadLine();
                listaReservas = JsonConvert.DeserializeObject<List<Reservas>>(paquete);


            }
            catch (Exception)
            {
                MessageBox.Show("No se logró establecer conexión con el servidor!\nIntentelo nuevamente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            return listaReservas;

        }


    }
}
