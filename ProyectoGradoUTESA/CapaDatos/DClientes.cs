using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DClientes
    {
        private int _idCliente;
        public int IdCliente { get => _idCliente; set => _idCliente = value; }
<<<<<<< HEAD

        
=======
        private string _estatus;
        public string Estatus { get => _estatus; set => _estatus = value; }
        private string _nombre;
        public string Nombre { get => _nombre; set => _nombre = value; }
        private string _apellido;
        public string Apellido { get => _apellido; set => _apellido = value; }
        private string _telefono;
        public string Telefono { get => _telefono; set => _telefono = value; }
        private string _direccion;
        public string Direccion { get => _direccion; set => _direccion = value; }
        private string _ciudad;
        public string Ciudad { get => _ciudad; set => _ciudad = value; }
        private string _sector;
        public string Sector { get => _sector; set => _sector = value; }
        private string _contacto;
        public string Contacto { get => _contacto; set => _contacto = value; }
        private string _telefonoContacto;
        public string TelefonoContacto { get => _telefonoContacto; set => _telefonoContacto = value; }
        private string _tipoIdentificacion;
        public string TipoIdentificacion { get => _tipoIdentificacion; set => _tipoIdentificacion = value; }
        private string _identificacion;
        public string Identificacion { get => _identificacion; set => _identificacion = value; }
        private string _correo;
        public string CorreoElectronico { get => _correo; set => _correo = value; }
        private string _buscador;
        public string Buscador { get => _buscador; set => _buscador = value; }

        #endregion

        public DCliente()
        {

        }
        public DCliente(int idcliente, string estatus, string nombre, string apellido,
            string telefono, string direccion, string ciudad, string sector, string contacto, string telefonocontacto,
            string tipoidentificacion, string identificacion, string correoelectronico, string buscador)
        {
            this.IdCliente = idcliente;
            this.Estatus = estatus;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Telefono = telefono;
            this.Direccion = direccion;
            this.Ciudad = ciudad;
            this.Sector = sector;
            this.Contacto = contacto;
            this.TelefonoContacto = telefonocontacto;
            this.TipoIdentificacion = tipoidentificacion;
            this.Identificacion = identificacion;
            this.CorreoElectronico = correoelectronico;
            this.Buscador = buscador;
        }

        public string InsetarCliente(DCliente Clientes)
        {

            string retorno = "";
            Conexion con = new Conexion();

            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con.AbriConexion();
                cmd.CommandText = "INSERTAR_CLIENTE";
                cmd.CommandType = CommandType.StoredProcedure;


                SqlParameter parId = new SqlParameter();
                parId.ParameterName = "@idcliente";
                parId.SqlDbType = SqlDbType.Int;
                parId.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(parId);

                SqlParameter parEstatus = new SqlParameter();
                parEstatus.ParameterName = "@estatus";
                parEstatus.SqlDbType = SqlDbType.VarChar;
                parEstatus.Size = 10;
                parEstatus.Value = Clientes.Estatus;
                cmd.Parameters.Add(parEstatus);

                SqlParameter parNombre = new SqlParameter();
                parNombre.ParameterName = "@nombre";
                parNombre.SqlDbType = SqlDbType.VarChar;
                parNombre.Size = 50;
                parNombre.Value = Clientes.Nombre;
                cmd.Parameters.Add(parNombre);

                SqlParameter parApellido = new SqlParameter();
                parApellido.ParameterName = "@apellido";
                parApellido.SqlDbType = SqlDbType.VarChar;
                parApellido.Size = 50;
                parApellido.Value = Clientes.Apellido;
                cmd.Parameters.Add(parApellido);

                SqlParameter parTelefono = new SqlParameter();
                parTelefono.ParameterName = "@telefono";
                parTelefono.SqlDbType = SqlDbType.VarChar;
                parTelefono.Size = 20;
                parTelefono.Value = Clientes.Telefono;
                cmd.Parameters.Add(parTelefono);


                SqlParameter parDireccion = new SqlParameter();
                parDireccion.ParameterName = "@direccion";
                parDireccion.SqlDbType = SqlDbType.VarChar;
                parDireccion.Size = 150;
                parDireccion.Value = Clientes.Direccion;
                cmd.Parameters.Add(parDireccion);

                SqlParameter parCiudad = new SqlParameter();
                parCiudad.ParameterName = "@ciudad";
                parCiudad.SqlDbType = SqlDbType.VarChar;
                parCiudad.Size = 150;
                parCiudad.Value = Clientes.Ciudad;
                cmd.Parameters.Add(parCiudad);

                SqlParameter parSector = new SqlParameter();
                parSector.ParameterName = "@sector";
                parSector.SqlDbType = SqlDbType.VarChar;
                parSector.Size = 150;
                parSector.Value = Clientes.Sector;
                cmd.Parameters.Add(parSector);

                SqlParameter parContacto = new SqlParameter();
                parContacto.ParameterName = "@contacto";
                parContacto.SqlDbType = SqlDbType.VarChar;
                parContacto.Size = 50;
                parContacto.Value = Clientes.Contacto;
                cmd.Parameters.Add(parContacto);

                SqlParameter parTelefonoContacto = new SqlParameter();
                parTelefonoContacto.ParameterName = "@telefonocontacto";
                parTelefonoContacto.SqlDbType = SqlDbType.VarChar;
                parTelefonoContacto.Size = 50;
                parTelefonoContacto.Value = Clientes.TelefonoContacto;
                cmd.Parameters.Add(parTelefonoContacto);

                SqlParameter parTipoIdentificacion = new SqlParameter();
                parTipoIdentificacion.ParameterName = "@tipoidentificacion";
                parTipoIdentificacion.SqlDbType = SqlDbType.VarChar;
                parTipoIdentificacion.Size = 50;
                parTipoIdentificacion.Value = Clientes.TipoIdentificacion;
                cmd.Parameters.Add(parTipoIdentificacion);

                SqlParameter parIdentificacion = new SqlParameter();
                parIdentificacion.ParameterName = "@identificacion";
                parIdentificacion.SqlDbType = SqlDbType.VarChar;
                parIdentificacion.Size = 50;
                parIdentificacion.Value = Clientes.Identificacion;
                cmd.Parameters.Add(parIdentificacion);

                SqlParameter parCorreoElectronico = new SqlParameter();
                parCorreoElectronico.ParameterName = "@correoelectronico";
                parCorreoElectronico.SqlDbType = SqlDbType.VarChar;
                parCorreoElectronico.Size = 150;
                parCorreoElectronico.Value = Clientes.CorreoElectronico;
                cmd.Parameters.Add(parCorreoElectronico);

                retorno = cmd.ExecuteNonQuery() == 1 ? "Ok" : "No es posible ingresar los datos";
            }
            catch (Exception ex)
            {

                retorno = ex.Message;
            }
            finally { con.CerrarConexion(); }



            return retorno;
        }

        public string ModificarCliente(DCliente Clientes)
        {

            string retorno = "";
            Conexion con = new Conexion();

            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con.AbriConexion();
                cmd.CommandText = "MODIFICAR_CLIENTE";
                cmd.CommandType = CommandType.StoredProcedure;


                SqlParameter parId = new SqlParameter();
                parId.ParameterName = "@idcliente";
                parId.SqlDbType = SqlDbType.Int;
                parId.Value = Clientes.IdCliente;
                cmd.Parameters.Add(parId);

                SqlParameter parEstatus = new SqlParameter();
                parEstatus.ParameterName = "@estatus";
                parEstatus.SqlDbType = SqlDbType.VarChar;
                parEstatus.Size = 10;
                parEstatus.Value = Clientes.Estatus;
                cmd.Parameters.Add(parEstatus);

                SqlParameter parNombre = new SqlParameter();
                parNombre.ParameterName = "@nombre";
                parNombre.SqlDbType = SqlDbType.VarChar;
                parNombre.Size = 50;
                parNombre.Value = Clientes.Nombre;
                cmd.Parameters.Add(parNombre);

                SqlParameter parApellido = new SqlParameter();
                parApellido.ParameterName = "@apellido";
                parApellido.SqlDbType = SqlDbType.VarChar;
                parApellido.Size = 50;
                parApellido.Value = Clientes.Apellido;
                cmd.Parameters.Add(parApellido);

                SqlParameter parTelefono = new SqlParameter();
                parTelefono.ParameterName = "@telefono";
                parTelefono.SqlDbType = SqlDbType.VarChar;
                parTelefono.Size = 20;
                parTelefono.Value = Clientes.Telefono;
                cmd.Parameters.Add(parTelefono);


                SqlParameter parDireccion = new SqlParameter();
                parDireccion.ParameterName = "@direccion";
                parDireccion.SqlDbType = SqlDbType.VarChar;
                parDireccion.Size = 150;
                parDireccion.Value = Clientes.Direccion;
                cmd.Parameters.Add(parDireccion);

                SqlParameter parCiudad = new SqlParameter();
                parCiudad.ParameterName = "@ciudad";
                parCiudad.SqlDbType = SqlDbType.VarChar;
                parCiudad.Size = 150;
                parCiudad.Value = Clientes.Ciudad;
                cmd.Parameters.Add(parCiudad);

                SqlParameter parSector = new SqlParameter();
                parSector.ParameterName = "@sector";
                parSector.SqlDbType = SqlDbType.VarChar;
                parSector.Size = 150;
                parSector.Value = Clientes.Sector;
                cmd.Parameters.Add(parSector);

                SqlParameter parContacto = new SqlParameter();
                parContacto.ParameterName = "@contacto";
                parContacto.SqlDbType = SqlDbType.VarChar;
                parContacto.Size = 50;
                parContacto.Value = Clientes.Contacto;
                cmd.Parameters.Add(parContacto);

                SqlParameter parTelefonoContacto = new SqlParameter();
                parTelefonoContacto.ParameterName = "@telefonocontacto";
                parTelefonoContacto.SqlDbType = SqlDbType.VarChar;
                parTelefonoContacto.Size = 50;
                parTelefonoContacto.Value = Clientes.TelefonoContacto;
                cmd.Parameters.Add(parTelefonoContacto);

                SqlParameter parTipoIdentificacion = new SqlParameter();
                parTipoIdentificacion.ParameterName = "@tipoidentificacion";
                parTipoIdentificacion.SqlDbType = SqlDbType.VarChar;
                parTipoIdentificacion.Size = 50;
                parTipoIdentificacion.Value = Clientes.TipoIdentificacion;
                cmd.Parameters.Add(parTipoIdentificacion);

                SqlParameter parIdentificacion = new SqlParameter();
                parIdentificacion.ParameterName = "@identificacion";
                parIdentificacion.SqlDbType = SqlDbType.VarChar;
                parIdentificacion.Size = 50;
                parIdentificacion.Value = Clientes.Identificacion;
                cmd.Parameters.Add(parIdentificacion);

                SqlParameter parCorreoElectronico = new SqlParameter();
                parCorreoElectronico.ParameterName = "@correoelectronico";
                parCorreoElectronico.SqlDbType = SqlDbType.VarChar;
                parCorreoElectronico.Size = 150;
                parCorreoElectronico.Value = Clientes.CorreoElectronico;
                cmd.Parameters.Add(parCorreoElectronico);

                retorno = cmd.ExecuteNonQuery() == 1 ? "Ok" : "No es posible ingresar los datos";
            }
            catch (Exception ex)
            {

                retorno = ex.Message;
            }
            finally { con.CerrarConexion(); }



            return retorno;
        }

        public string EliminarCliente(DCliente Clientes)
        {
            string retorno = "";
            Conexion con = new Conexion();

            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con.AbriConexion();
                cmd.CommandText = "ELIMINAR_CLIENTE";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parId = new SqlParameter();
                parId.ParameterName = "@idcliente";
                parId.SqlDbType = SqlDbType.Int;
                parId.Value = Clientes.IdCliente;
                cmd.Parameters.Add(parId);

                retorno = cmd.ExecuteNonQuery() == 1 ? "Ok" : "No se ha podido eliminar el Registro";



            }
            catch (Exception ex)
            {

                retorno = ex.Message;
            }
            finally { con.CerrarConexion(); }

            return retorno;

        }

        public DataTable MostrarClientes()
        {
            DataTable dtReturn = new DataTable("Cliente");
            Conexion con = new Conexion();
            try
            {


                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con.AbriConexion();
                cmd.CommandText = "MOSTRAR_TODOS_CLIENTES";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                ad.Fill(dtReturn);
            }
            catch (Exception ex)
            {
                dtReturn = null;
            }

            return dtReturn;
        }

        public DataTable BuscarClientes_Nombre(DCliente Clientes)
        {
            DataTable dtretur = new DataTable("Clientes");
            Conexion con = new Conexion();


            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con.AbriConexion();
                cmd.CommandText = "MOSTRAR_NOMBRE_CLIENTES";
                cmd.CommandType = CommandType.StoredProcedure;


                SqlParameter ParBuscador = new SqlParameter();
                ParBuscador.ParameterName = "@buscador";
                ParBuscador.SqlDbType = SqlDbType.VarChar;
                ParBuscador.Size = 50;
                ParBuscador.Value = Clientes.Buscador;
                cmd.Parameters.Add(ParBuscador);

                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                ad.Fill(dtretur);

            }
            catch (Exception)
            {

                dtretur = null;
            }
            return dtretur;
        }

        public DataTable BuscarClientes_ID(DCliente Clientes)
        {
            DataTable dtretur = new DataTable("Clientes");
            Conexion con = new Conexion();


            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con.AbriConexion();
                cmd.CommandText = "MOSTRAR_IDENTIFICIACION_CLIENTES";
                cmd.CommandType = CommandType.StoredProcedure;


                SqlParameter ParBuscador = new SqlParameter();
                ParBuscador.ParameterName = "@buscador";
                ParBuscador.SqlDbType = SqlDbType.VarChar;
                ParBuscador.Size = 50;
                ParBuscador.Value = Clientes.Buscador;
                cmd.Parameters.Add(ParBuscador);

                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                ad.Fill(dtretur);

            }
            catch (Exception)
            {

                dtretur = null;
            }
            return dtretur;
        }
>>>>>>> Formulario Cliente Done
    }
}
