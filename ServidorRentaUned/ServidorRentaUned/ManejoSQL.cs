using DLL_Clase;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ServidorRentaUned
{
    public class ManejoSQL
    {
        //Variables para el manejo de SQL
        public SqlCommand comando;
        public SqlConnection conexion;
        public SqlDataReader fila;
        public ManejoSQL()
        {
            try
            {
                //conexion configurada en la app config
                conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);

            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error inesperado al intentar establecer conexión con la base de datos." , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
         
        public void Insert_Sucursal(Sucursales sucursal) //Registrar Sucursales
        {
            //Recibe por parametros los datos de la Sucursal y los envia a la base de datos
            try
            {
                conexion.Open(); //Enciende la conexion con la base de datos configurada

                //Comando para insertar los objetos de la Consultar_Sucursales recibidos
                comando = new SqlCommand("INSERT INTO [dbo].[Sucursal]([IdSucursal],[Nombre],[Direccion],[Estado],[Telefono]) VALUES (@IdSucursal, @Nombre, @Direccion, @Estado, @Telefono);", conexion);

                comando.Parameters.Add(new SqlParameter("@IdSucursal", sucursal.Identificacion));
                comando.Parameters.Add(new SqlParameter("@Nombre", sucursal.Nombre));
                comando.Parameters.Add(new SqlParameter("@Telefono", sucursal.Telefono));
                comando.Parameters.Add(new SqlParameter("@Direccion", sucursal.Direccion));
                comando.Parameters.Add(new SqlParameter("@Estado", sucursal.Estado));

                comando.ExecuteNonQuery(); //Ejecuta el comando
                conexion.Close(); // Cierra conexion 
            }
            catch (Exception)
            {
                MessageBox.Show("No se logró establecer conexión con la base de datos!\nIntentelo nuevamente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conexion.Close();
            }
        }
       
        public List<Sucursales> Consultar_Sucursales() //Metodo para Cargar sucursales de la tabla
        {
            List<Sucursales> lista = new List<Sucursales>(); //Lista Generica para guardar las Sucursales
            try
            {
                conexion.Open();//Abre conexion con la base de datos

                comando = new SqlCommand("select *,CASE When Estado = 1 then 'Activo'	Else 'Inactivo' End as EstadoSucursal From Sucursal;", conexion);

                fila = comando.ExecuteReader();//Ejecuta el comando a enviar a la base

                if (fila.HasRows)
                {
                    //Lee el resultado del comando en la base de datos y extrae los datos
                    while (fila.Read())
                    {
                        Sucursales sucursal = new Sucursales();

                        sucursal.Identificacion = Convert.ToInt32(fila["IdSucursal"]);
                        sucursal.Nombre = fila["Nombre"].ToString();
                        sucursal.Direccion = fila["Direccion"].ToString();
                        sucursal.Telefono = fila["Telefono"].ToString();
                        sucursal.EstadoSucursal = fila["EstadoSucursal"].ToString();

                        lista.Add(sucursal); //Guarda los datos Sucursal
                    }
                }

                conexion.Close(); //cierra conexion

            }
            catch (Exception)
            {
                MessageBox.Show("No se logró establecer conexión con la base de datos!\nIntentelo nuevamente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conexion.Close();
            }

            return lista;
        }
     
        public void Insert_Clientes(Clientes clientes) //Registrar Clientes
        {
            try
            {
                conexion.Open(); //Abre conexion con la base de datos
                comando = new SqlCommand("INSERT INTO [dbo].[Cliente] VALUES(@IdCliente, @Nombre, @PrimerApellido, @SegundoApellido, @FechaNacimiento, @Genero);", conexion);

                comando.Parameters.Add(new SqlParameter("@IdCliente", clientes.Identificacion));
                comando.Parameters.Add(new SqlParameter("@Nombre", clientes.Nombre));
                comando.Parameters.Add(new SqlParameter("@PrimerApellido", clientes.Primer_apellido));
                comando.Parameters.Add(new SqlParameter("@SegundoApellido", clientes.Segundo_apellido));
                comando.Parameters.Add(new SqlParameter("@FechaNacimiento", clientes.Fecha_nacimiento));
                comando.Parameters.Add(new SqlParameter("@Genero", clientes.Genero));
                comando.ExecuteNonQuery(); //Ejecuta el comando con los parametros recibidos
                conexion.Close(); //Cierra conexion

            }
            catch (Exception)
            {
                MessageBox.Show("No se logró establecer conexión con la base de datos!\nIntentelo nuevamente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conexion.Close();
            }

        }

        public List<Clientes> Consultar_Clientes() //Metodo para cargar los datos de la tabla Clientes
        {
            List<Clientes> lista = new List<Clientes>(); //Lista generica Clientes
            try
            {
                conexion.Open(); //Abre conexion con la base de datos
                comando = new SqlCommand("SELECT [IdCliente],[Nombre],[PrimerApellido],[SegundoApellido],[FechaNacimiento],[Genero] FROM [dbo].[Cliente];", conexion);

                fila = comando.ExecuteReader(); //Ejecuta el comando

                if (fila.HasRows)
                {
                    //Extrae los datos de la tabla clientes de la base de datos
                    while (fila.Read())
                    {

                        Clientes clientes = new Clientes();

                        clientes.Identificacion = fila["IdCliente"].ToString();
                        clientes.Nombre = fila["Nombre"].ToString();
                        clientes.Primer_apellido = fila["PrimerApellido"].ToString();
                        clientes.Segundo_apellido = fila["SegundoApellido"].ToString();
                        clientes.Fecha_nacimiento = DateTime.Parse(fila["FechaNacimiento"].ToString());
                        clientes.Genero = char.Parse(fila["Genero"].ToString());
                        lista.Add(clientes); //Agrega los datos recibidos a la lista
                    }
                }

                conexion.Close(); //Cierrra conexion
            }
            catch (Exception)
            {
                MessageBox.Show("No se logró establecer conexión con la base de datos!\nIntentelo nuevamente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //conexion.Close();
            }
            return lista; //Devuelve la lista con los datos obtenidos
        }       

        public void Insert_TipoVehiculo(TipoVehiculos tipoVehiculo)//Metodo para enviar los datos TipoVehiculo a la tabla
        {
            try
            {
                conexion.Open();//Abre conexion con la tabla
                comando = new SqlCommand("INSERT INTO [dbo].[TipoVehiculo]([IdTipo] ,[Descripcion] ,[Estado])  VALUES (@IdTipo, @Descripcion,@Estado);", conexion);

                comando.Parameters.Add(new SqlParameter("@IdTipo", tipoVehiculo.Id));
                comando.Parameters.Add(new SqlParameter("@Descripcion", tipoVehiculo.Descripcion));
                comando.Parameters.Add(new SqlParameter("@Estado", tipoVehiculo.Estado));

                comando.ExecuteNonQuery();//Ejecuta el comando
                conexion.Close();//Cierra conexion
            }
            catch (Exception)
            {
                MessageBox.Show("No se logró establecer conexión con la base de datos!\nIntentelo nuevamente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conexion.Close();
            }
        }

        public List<TipoVehiculos>  Consultar_TipoVehiculos() //Metodo para cargar los tipo vehiculos de la tabla
        {
            List<TipoVehiculos> listaTipoVehiculos = new List<TipoVehiculos>(); //Lista generica tipo vehiculo
            try
            {
                conexion.Open();//Abre conexion con la tabla
                comando = new SqlCommand("Select * , CASE When Estado = 1 then 'Activo'	Else 'Inactivo' End as EstadoTipoVehiculo From TipoVehiculo;", conexion);

                fila = comando.ExecuteReader();

                if (fila.HasRows)
                {
                    while (fila.Read())
                    {
                        TipoVehiculos tipoVehiculo = new TipoVehiculos();

                        tipoVehiculo.Id = int.Parse(fila["IdTipo"].ToString());
                        tipoVehiculo.Descripcion = fila["Descripcion"].ToString();
                        tipoVehiculo.Estado = bool.Parse(fila["Estado"].ToString());
                        tipoVehiculo.EstadoTipoVehiculo = fila["EstadoTipoVehiculo"].ToString();

                        listaTipoVehiculos.Add(tipoVehiculo);
                    }
                }

                conexion.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("No se logró establecer conexión con la base de datos!\nIntentelo nuevamente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conexion.Close();
            }

            return listaTipoVehiculos;
        }      

        public void Insert_Vehiculos(Vehiculos vehiculos)
        {

            conexion.Open();
            comando = new SqlCommand("INSERT INTO [dbo].[Vehiculo] ([IdPlaca],[Marca],[Modelo],[IdTipoVehiculo],[CostoAlquilerDia],[Kilometraje]) VALUES (@IdPlaca, @Marca, @Modelo, @IdTipoVehiculo, @CostoAlquilerDia, @Kilometraje);", conexion);

            comando.Parameters.Add(new SqlParameter("@IdPlaca", vehiculos.IdPlaca));
            comando.Parameters.Add(new SqlParameter("@Marca", vehiculos.Marca));
            comando.Parameters.Add(new SqlParameter("@Modelo", vehiculos.Modelo));
            comando.Parameters.Add(new SqlParameter("@IdTipoVehiculo", vehiculos.IdtipoVehiculo));
            comando.Parameters.Add(new SqlParameter("@CostoAlquilerDia", vehiculos.CostoAlquiler));
            comando.Parameters.Add(new SqlParameter("@Kilometraje", vehiculos.Kilometraje));
            comando.ExecuteNonQuery();
            conexion.Close();

        }

        public List<Vehiculos> Consultar_Vehiculos()
        {
            List<Vehiculos> lista = new List<Vehiculos>();
            try
            {
                conexion.Open();
                comando = new SqlCommand("SELECT [IdPlaca] ,[Marca],[Modelo],[IdTipoVehiculo],[CostoAlquilerDia],[Kilometraje], [Descripcion] FROM [RENTAUNED].[dbo].[Vehiculo] join TipoVehiculo on Vehiculo.IdTipoVehiculo = TipoVehiculo.IdTipo;", conexion);

                fila = comando.ExecuteReader();

                if (fila.HasRows)
                {
                    while (fila.Read())
                    {

                        Vehiculos vehiculos = new Vehiculos();

                        vehiculos.IdPlaca = fila["IdPlaca"].ToString();
                        vehiculos.Marca = fila["Marca"].ToString();
                        vehiculos.Modelo = fila["Modelo"].ToString();
                        vehiculos.CostoAlquiler = int.Parse(fila["CostoAlquilerDia"].ToString());
                        vehiculos.Kilometraje = int.Parse(fila["Kilometraje"].ToString());
                        vehiculos.IdtipoVehiculo = int.Parse(fila["IdTipoVehiculo"].ToString());
                        vehiculos.tipoVehiculo.Descripcion = fila["Descripcion"].ToString();

                        lista.Add(vehiculos);

                    }
                }
                fila.Close();
                conexion.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("No se logró establecer conexión con la base de datos!\nIntentelo nuevamente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conexion.Close();
            }

            return lista;
        }
      
        public void Insert_Coberturas(Coberturas coberturas)
        {

            conexion.Open();
            comando = new SqlCommand("INSERT INTO [dbo].[CoberturaSeguro] ([IdCobertura],[Descripcion],[IdTipoVehiculo],[Estado],[Monto]) VALUES(@IdCobertura, @Descripcion, @IdTipoVehiculo, @Estado, @Monto);", conexion);

            comando.Parameters.Add(new SqlParameter("@IdCobertura", coberturas.IdCobertura));
            comando.Parameters.Add(new SqlParameter("@Descripcion", coberturas.Descripcion));
            comando.Parameters.Add(new SqlParameter("@IdTipoVehiculo", coberturas.IdTipoVehiculo));
            comando.Parameters.Add(new SqlParameter("@Estado", coberturas.Estado));
            comando.Parameters.Add(new SqlParameter("@Monto", coberturas.Monto));

            comando.ExecuteNonQuery();
            conexion.Close();

        }

        public List<Coberturas> Consultar_Coberturas()
        {
            List<Coberturas> lista = new List<Coberturas>();
            try
            {
                conexion.Open();
                comando = new SqlCommand("SELECT TipoVehiculo.Descripcion DescripcionTipo, CoberturaSeguro.IdTipoVehiculo, [IdCobertura],CoberturaSeguro.Descripcion,[IdTipoVehiculo],CoberturaSeguro.Estado,[Monto],TipoVehiculo.IdTipo,CASE When [CoberturaSeguro].Estado = 1 then 'Activo'	Else 'Inactivo' End as EstadoCobertura FROM [dbo].[CoberturaSeguro] join TipoVehiculo on CoberturaSeguro.IdTipoVehiculo = TipoVehiculo.IdTipo;", conexion);

                fila = comando.ExecuteReader();

                if (fila.HasRows)
                {
                    while (fila.Read())
                    {
                        Coberturas coberturas = new Coberturas();

                        //coberturas.tipovehiculos.Descripcion = fila["DescripcionTipo"].ToString();
                        coberturas.IdCobertura = int.Parse(fila["IdCobertura"].ToString());
                        coberturas.Descripcion = fila["Descripcion"].ToString();
                        coberturas.IdTipoVehiculo = int.Parse(fila["IdTipoVehiculo"].ToString());
                        coberturas.EstadoString = fila["EstadoCobertura"].ToString();
                        coberturas.Monto = int.Parse(fila["Monto"].ToString());

                        lista.Add(coberturas);

                    }
                }
                fila.Close();
                conexion.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("No se logró establecer conexión con la base de datos!\nIntentelo nuevamente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conexion.Close();

            }

            return lista;
        }
       
        public void Insert_VehiculoSucursal(VehiculoSucursal vehiculoSucursal)
        {
            conexion.Open();
            comando = new SqlCommand("INSERT INTO [dbo].[VehiculoSucursal]([IdAsignacion],[IdSucursal],[IdPlaca],[FechaAsignacion]) VALUES (@IdAsignacion, @IdSucursal, @IdPlaca, @FechaAsignacion);", conexion);

            comando.Parameters.Add(new SqlParameter("@IdAsignacion", vehiculoSucursal.IdAsignacion));
            comando.Parameters.Add(new SqlParameter("@IdSucursal", vehiculoSucursal.IdSucursal));
            comando.Parameters.Add(new SqlParameter("@IdPlaca", vehiculoSucursal.IdPlaca));
            comando.Parameters.Add(new SqlParameter("@FechaAsignacion", vehiculoSucursal.Fecha));

            comando.ExecuteNonQuery();
            conexion.Close();

        }      
        
        public List<VehiculoSucursal> Consultar_VehiculoSucursal()
        {
            List<VehiculoSucursal> lista = new List<VehiculoSucursal>();
            try
            {
                conexion.Open();
                comando = new SqlCommand("SELECT * FROM [dbo].[VehiculoSucursal] Join Sucursal on VehiculoSucursal.IdSucursal = Sucursal.IdSucursal Join Vehiculo on VehiculoSucursal.IdPlaca = Vehiculo.IdPlaca Join TipoVehiculo on Vehiculo.IdTipoVehiculo = TipoVehiculo.IdTipo;", conexion);
              
                fila = comando.ExecuteReader();

                if (fila.HasRows)
                {
                    while (fila.Read())
                    {
                        VehiculoSucursal vehiculoSucursal = new VehiculoSucursal();

                        vehiculoSucursal.IdAsignacion = int.Parse(fila["IdAsignacion"].ToString());
                        vehiculoSucursal.Fecha = DateTime.Parse(fila["FechaAsignacion"].ToString());
                        vehiculoSucursal.IdSucursal = int.Parse(fila["IdSucursal"].ToString());
                        vehiculoSucursal.IdPlaca = fila["IdPlaca"].ToString();

                        //Datos Sucursal
                        vehiculoSucursal.sucursales.Identificacion = int.Parse(fila["IdSucursal"].ToString());
                        vehiculoSucursal.sucursales.Nombre = fila["Nombre"].ToString();
                        vehiculoSucursal.sucursales.Direccion = fila["Direccion"].ToString();

                        //Datos Vehiculos                       
                        vehiculoSucursal.vehiculos.IdPlaca = fila["IdPlaca"].ToString();
                        vehiculoSucursal.vehiculos.Marca = fila["Marca"].ToString();
                        vehiculoSucursal.vehiculos.Modelo = fila["Modelo"].ToString();
                        vehiculoSucursal.vehiculos.CostoAlquiler = int.Parse(fila["CostoAlquilerDia"].ToString());
                        vehiculoSucursal.vehiculos.Kilometraje = int.Parse(fila["Kilometraje"].ToString());
                        vehiculoSucursal.vehiculos.IdtipoVehiculo = int.Parse(fila["IdTipoVehiculo"].ToString());
                        vehiculoSucursal.vehiculos.tipoVehiculo.Descripcion = fila["Descripcion"].ToString();

                        lista.Add(vehiculoSucursal);

                    }
                }
                fila.Close();
                conexion.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("No se logró establecer conexión con la base de datos!\nIntentelo nuevamente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conexion.Close();

            }

            return lista;

        }

        public List<VehiculoSucursal> Consultar_VehiculosAsociados(int IDSucursalAux)
        {
            List<VehiculoSucursal> lista = new List<VehiculoSucursal>();
            try
            {
                conexion.Open();
                comando = new SqlCommand("SELECT VehiculoSucursal.[FechaAsignacion], Sucursal.[IdSucursal], Sucursal.[Nombre], Sucursal.[Direccion], VehiculoSucursal.[IdSucursal],VehiculoSucursal.[IdAsignacion], Vehiculo.[IdPlaca],[CostoAlquilerDia], Vehiculo.IdTipoVehiculo, [Kilometraje],[Descripcion], Vehiculo.[Marca], Vehiculo.[Modelo] FROM [dbo].[VehiculoSucursal] Join Sucursal on VehiculoSucursal.IdSucursal = Sucursal.IdSucursal Join Vehiculo on VehiculoSucursal.IdPlaca = Vehiculo.IdPlaca Join TipoVehiculo on Vehiculo.IdTipoVehiculo = TipoVehiculo.IdTipo Where Sucursal.IdSucursal = " + IDSucursalAux + ";", conexion);

                fila = comando.ExecuteReader();

                if (fila.HasRows)
                {
                    while (fila.Read())
                    {

                        VehiculoSucursal vehiculosAsoc = new VehiculoSucursal();

                        vehiculosAsoc.IdSucursal = int.Parse(fila["IdSucursal"].ToString());
                        vehiculosAsoc.IdAsignacion = int.Parse(fila["IdAsignacion"].ToString());
                        vehiculosAsoc.vehiculos.IdPlaca = fila["IdPlaca"].ToString();
                        vehiculosAsoc.vehiculos.Marca = fila["Marca"].ToString();
                        vehiculosAsoc.vehiculos.Modelo = fila["Modelo"].ToString();
                        vehiculosAsoc.vehiculos.CostoAlquiler = int.Parse(fila["CostoAlquilerDia"].ToString());
                        vehiculosAsoc.vehiculos.Kilometraje = int.Parse(fila["Kilometraje"].ToString());
                        vehiculosAsoc.vehiculos.IdtipoVehiculo = int.Parse(fila["IdTipoVehiculo"].ToString());
                        vehiculosAsoc.vehiculos.tipoVehiculo.Descripcion = fila["Descripcion"].ToString();

                        lista.Add(vehiculosAsoc);

                    }
                }
                fila.Close();
                conexion.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("No se logró establecer conexión con la base de datos!\nIntentelo nuevamente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conexion.Close();

            }

            return lista;
        }
        public void Insert_Reservas(Reservas reservas)
        {
            conexion.Open();
            comando = new SqlCommand("INSERT INTO [dbo].[Reserva]([IdReserva],[IdCliente],[IdPlaca],[FechaReserva],[FechaInicio],[FechaFin],[MontoReserva]) VALUES ((SELECT coalesce( MAX(IdReserva),0) +1 from Reserva),@IdCliente ,@IdPlaca,@FechaReserva, @FechaInicio ,@FechaFin,@MontoReserva);", conexion);

            comando.Parameters.Add(new SqlParameter("@IdReserva", reservas.IdReserva));
            comando.Parameters.Add(new SqlParameter("@IdCliente", reservas.IdCliente));
            comando.Parameters.Add(new SqlParameter("@IdPlaca", reservas.IdPlaca));
            comando.Parameters.Add(new SqlParameter("@FechaReserva", reservas.FechaReserva));
            comando.Parameters.Add(new SqlParameter("@FechaInicio", reservas.FechaInicio));
            comando.Parameters.Add(new SqlParameter("@FechaFin", reservas.FechaFin));
            comando.Parameters.Add(new SqlParameter("@MontoReserva", reservas.MontoReserva));

            comando.ExecuteNonQuery();
            conexion.Close();

        }
        public List<Reservas> ConsultarReservasCliente(String IdCliente)
        {
            List<Reservas> lista = new List<Reservas>();
            try
            {
                conexion.Open();
                comando = new SqlCommand("SELECT c.IdCliente, c.[Nombre], c.PrimerApellido, c.SegundoApellido,v.[IdPlaca], v.Marca,v.Modelo, r.IdReserva ,[FechaReserva],[FechaInicio],[FechaFin],[MontoReserva]  FROM [dbo].[Reserva] r join Cliente c on r.IdCliente = c.IdCliente join Vehiculo v on v.IdPlaca = r.IdPlaca where r.IdCliente = "+IdCliente+";", conexion);

                fila = comando.ExecuteReader();

                if (fila.HasRows)
                {
                    while (fila.Read())
                    {
                        Reservas reservas = new Reservas();

                        reservas.IdReserva = int.Parse(fila["IdReserva"].ToString());
                        reservas.IdCliente = fila["IdCliente"].ToString();
                        reservas.IdPlaca = fila["IdPlaca"].ToString();
                        reservas.FechaReserva = DateTime.Parse(fila["FechaReserva"].ToString());
                        reservas.FechaInicio = DateTime.Parse(fila["FechaInicio"].ToString());
                        reservas.FechaFin = DateTime.Parse(fila["FechaFin"].ToString());
                        reservas.MontoReserva = int.Parse(fila["MontoReserva"].ToString());

                        //Datos cliente reserva
                        reservas.clientes.Identificacion = fila["IdCliente"].ToString();
                        reservas.clientes.Nombre = fila["Nombre"].ToString();
                        reservas.clientes.Primer_apellido = fila["PrimerApellido"].ToString();
                        reservas.clientes.Segundo_apellido = fila["SegundoApellido"].ToString();
                        //Datos vehiculo reserva
                        reservas.vehiculos.IdPlaca = fila["IdPlaca"].ToString();
                        reservas.vehiculos.Marca = fila["Marca"].ToString();
                        reservas.vehiculos.Modelo = fila["Modelo"].ToString();


                        lista.Add(reservas);

                    }
                }
                fila.Close();
                conexion.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("No se logró establecer conexión con la base de datos!\nIntentelo nuevamente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conexion.Close();

            }

            return lista;
        }

        public List<Reservas> ConsultarReservasVehiculos()
        {
            List<Reservas> lista = new List<Reservas>();
            try
            {
                conexion.Open();
                comando = new SqlCommand("SELECT v.[IdPlaca],[FechaInicio],[FechaFin]  FROM [dbo].[Reserva] r join Vehiculo v on v.IdPlaca = r.IdPlaca;", conexion);

                fila = comando.ExecuteReader();

                if (fila.HasRows)
                {
                    while (fila.Read())
                    {
                        Reservas reservas = new Reservas();

                        reservas.IdPlaca = fila["IdPlaca"].ToString();                       
                        reservas.FechaInicio = DateTime.Parse(fila["FechaInicio"].ToString());
                        reservas.FechaFin = DateTime.Parse(fila["FechaFin"].ToString());
                        
                        lista.Add(reservas);

                    }
                }
                fila.Close();
                conexion.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("No se logró establecer conexión con la base de datos!\nIntentelo nuevamente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conexion.Close();

            }

            return lista;
        }


    }

}
