using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DSuplidor
    {
        #region Declaracion de objetos
        private int _idSuplidor;
        public int IdSuplidor { get => _idSuplidor; set => _idSuplidor = value; }
        private string _estatus;
        public string Estatus { get => _estatus; set => _estatus = value; }
        private string _tipoSuplidor;
        public string TipoSuplidor { get => _tipoSuplidor; set => _tipoSuplidor = value; }
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

        public DSuplidor()
        {
                
        }
        public DSuplidor(int idsuplidor,string estatus,string tiposuplidor, string nombre, string apellido,
            string telefono, string direccion,string ciudad, string sector, string contacto, string telefonocontacto,
            string tipoidentificacion, string identificacion, string correoelectronico, string buscador)
        {
            this.IdSuplidor = idsuplidor;
            this.Estatus = estatus;
            this.TipoSuplidor = tiposuplidor;
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

        public string InsetarSuplidor(DSuplidor Suplidores)
        {

            string retorno = "";
            Conexion con = new Conexion();

            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con.AbriConexion();
                cmd.CommandText = "INSERTAR_SUPLIDOR";
                cmd.CommandType = CommandType.StoredProcedure;


                SqlParameter parId = new SqlParameter();
                parId.ParameterName = "@idsuplidor";
                parId.SqlDbType = SqlDbType.Int;
                parId.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(parId);

                SqlParameter parEstatus = new SqlParameter();
                parEstatus.ParameterName = "@estatus";
                parEstatus.SqlDbType = SqlDbType.VarChar;
                parEstatus.Size = 10;
                parEstatus.Value = Suplidores.Estatus;
                cmd.Parameters.Add(parEstatus);

                SqlParameter parTipoSuplidor = new SqlParameter();
                parTipoSuplidor.ParameterName = "@tiposuplidor";
                parTipoSuplidor.SqlDbType = SqlDbType.VarChar;
                parTipoSuplidor.Size = 10;
                parTipoSuplidor.Value = Suplidores.TipoSuplidor;
                cmd.Parameters.Add(parTipoSuplidor);

                SqlParameter parNombre = new SqlParameter();
                parNombre.ParameterName = "@nombre";
                parNombre.SqlDbType = SqlDbType.VarChar;
                parNombre.Size = 50;
                parNombre.Value = Suplidores.Nombre ;
                cmd.Parameters.Add(parNombre);

                SqlParameter parApellido = new SqlParameter();
                parApellido.ParameterName = "@apellido";
                parApellido.SqlDbType = SqlDbType.VarChar;
                parApellido.Size = 50;
                parApellido.Value = Suplidores.Apellido;
                cmd.Parameters.Add(parApellido);

                SqlParameter parTelefono = new SqlParameter();
                parTelefono.ParameterName = "@telefono";
                parTelefono.SqlDbType = SqlDbType.VarChar;
                parTelefono.Size = 20;
                parTelefono.Value = Suplidores.Telefono;
                cmd.Parameters.Add(parTelefono);


                SqlParameter parDireccion = new SqlParameter();
                parDireccion.ParameterName = "@direccion";
                parDireccion.SqlDbType = SqlDbType.VarChar;
                parDireccion.Size = 150;
                parDireccion.Value = Suplidores.Direccion;
                cmd.Parameters.Add(parDireccion);

                SqlParameter parCiudad = new SqlParameter();
                parCiudad.ParameterName = "@ciudad";
                parCiudad.SqlDbType = SqlDbType.VarChar;
                parCiudad.Size = 150;
                parCiudad.Value = Suplidores.Ciudad;
                cmd.Parameters.Add(parCiudad);

                SqlParameter parSector = new SqlParameter();
                parSector.ParameterName = "@sector";
                parSector.SqlDbType = SqlDbType.VarChar;
                parSector.Size = 150;
                parSector.Value = Suplidores.Sector;
                cmd.Parameters.Add(parSector);

                SqlParameter parContacto = new SqlParameter();
                parContacto.ParameterName = "@contacto";
                parContacto.SqlDbType = SqlDbType.VarChar;
                parContacto.Size = 50;
                parContacto.Value = Suplidores.Contacto;
                cmd.Parameters.Add(parContacto);

                SqlParameter parTelefonoContacto = new SqlParameter();
                parTelefonoContacto.ParameterName = "@telefonocontacto";
                parTelefonoContacto.SqlDbType = SqlDbType.VarChar;
                parTelefonoContacto.Size = 50;
                parTelefonoContacto.Value = Suplidores.TelefonoContacto;
                cmd.Parameters.Add(parTelefonoContacto);

                SqlParameter parTipoIdentificacion = new SqlParameter();
                parTipoIdentificacion.ParameterName = "@tipoidentificacion";
                parTipoIdentificacion.SqlDbType = SqlDbType.VarChar;
                parTipoIdentificacion.Size = 50;
                parTipoIdentificacion.Value = Suplidores.TipoIdentificacion;
                cmd.Parameters.Add(parTipoIdentificacion);

                SqlParameter parIdentificacion = new SqlParameter();
                parIdentificacion.ParameterName = "@identificacion";
                parIdentificacion.SqlDbType = SqlDbType.VarChar;
                parIdentificacion.Size = 50;
                parIdentificacion.Value = Suplidores.Identificacion;
                cmd.Parameters.Add(parIdentificacion);

                retorno = cmd.ExecuteNonQuery() == 1 ? "Ok" : "No es posible ingresar los datos";
            }
            catch (Exception ex)
            {

                retorno = ex.Message;
            }
            finally { con.CerrarConexion(); }



            return retorno;
        }

        public string ModificarSuplidor(DSuplidor Suplidores)
        {

            string retorno = "";
            Conexion con = new Conexion();

            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con.AbriConexion();
                cmd.CommandText = "MODIFICAR_SUPLIDOR";
                cmd.CommandType = CommandType.StoredProcedure;


                SqlParameter parId = new SqlParameter();
                parId.ParameterName = "@idsuplidor";
                parId.SqlDbType = SqlDbType.Int;
                parId.Value = Suplidores.IdSuplidor;                
                cmd.Parameters.Add(parId);

                SqlParameter parEstatus = new SqlParameter();
                parEstatus.ParameterName = "@estatus";
                parEstatus.SqlDbType = SqlDbType.VarChar;
                parEstatus.Size = 10;
                parEstatus.Value = Suplidores.Estatus;
                cmd.Parameters.Add(parEstatus);

                SqlParameter parTipoSuplidor = new SqlParameter();
                parTipoSuplidor.ParameterName = "@tiposuplidor";
                parTipoSuplidor.SqlDbType = SqlDbType.VarChar;
                parTipoSuplidor.Size = 10;
                parTipoSuplidor.Value = Suplidores.TipoSuplidor;
                cmd.Parameters.Add(parTipoSuplidor);

                SqlParameter parNombre = new SqlParameter();
                parNombre.ParameterName = "@nombre";
                parNombre.SqlDbType = SqlDbType.VarChar;
                parNombre.Size = 50;
                parNombre.Value = Suplidores.Nombre;
                cmd.Parameters.Add(parNombre);

                SqlParameter parApellido = new SqlParameter();
                parApellido.ParameterName = "@apellido";
                parApellido.SqlDbType = SqlDbType.VarChar;
                parApellido.Size = 50;
                parApellido.Value = Suplidores.Apellido;
                cmd.Parameters.Add(parApellido);

                SqlParameter parTelefono = new SqlParameter();
                parTelefono.ParameterName = "@telefono";
                parTelefono.SqlDbType = SqlDbType.VarChar;
                parTelefono.Size = 20;
                parTelefono.Value = Suplidores.Telefono;
                cmd.Parameters.Add(parTelefono);


                SqlParameter parDireccion = new SqlParameter();
                parDireccion.ParameterName = "@direccion";
                parDireccion.SqlDbType = SqlDbType.VarChar;
                parDireccion.Size = 150;
                parDireccion.Value = Suplidores.Direccion;
                cmd.Parameters.Add(parDireccion);

                SqlParameter parCiudad = new SqlParameter();
                parCiudad.ParameterName = "@ciudad";
                parCiudad.SqlDbType = SqlDbType.VarChar;
                parCiudad.Size = 150;
                parCiudad.Value = Suplidores.Ciudad;
                cmd.Parameters.Add(parCiudad);

                SqlParameter parSector = new SqlParameter();
                parSector.ParameterName = "@sector";
                parSector.SqlDbType = SqlDbType.VarChar;
                parSector.Size = 150;
                parSector.Value = Suplidores.Sector;
                cmd.Parameters.Add(parSector);

                SqlParameter parContacto = new SqlParameter();
                parContacto.ParameterName = "@contacto";
                parContacto.SqlDbType = SqlDbType.VarChar;
                parContacto.Size = 50;
                parContacto.Value = Suplidores.Contacto;
                cmd.Parameters.Add(parContacto);

                SqlParameter parTelefonoContacto = new SqlParameter();
                parTelefonoContacto.ParameterName = "@telefonocontacto";
                parTelefonoContacto.SqlDbType = SqlDbType.VarChar;
                parTelefonoContacto.Size = 50;
                parTelefonoContacto.Value = Suplidores.TelefonoContacto;
                cmd.Parameters.Add(parTelefonoContacto);

                SqlParameter parTipoIdentificacion = new SqlParameter();
                parTipoIdentificacion.ParameterName = "@tipoidentificacion";
                parTipoIdentificacion.SqlDbType = SqlDbType.VarChar;
                parTipoIdentificacion.Size = 50;
                parTipoIdentificacion.Value = Suplidores.TipoIdentificacion;
                cmd.Parameters.Add(parTipoIdentificacion);

                SqlParameter parIdentificacion = new SqlParameter();
                parIdentificacion.ParameterName = "@identificacion";
                parIdentificacion.SqlDbType = SqlDbType.VarChar;
                parIdentificacion.Size = 50;
                parIdentificacion.Value = Suplidores.Identificacion;
                cmd.Parameters.Add(parIdentificacion);

                retorno = cmd.ExecuteNonQuery() == 1 ? "Ok" : "No es posible ingresar los datos";
            }
            catch (Exception ex)
            {

                retorno = ex.Message;
            }
            finally { con.CerrarConexion(); }



            return retorno;
        }

        public string EliminarSuplidor(DSuplidor Suplidores)
        {
            string retorno = "";
            Conexion con = new Conexion();

            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con.AbriConexion();
                cmd.CommandText = "ELIMINAR_SUPLIDOR";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parId = new SqlParameter();
                parId.ParameterName = "@idsuplidor";
                parId.SqlDbType = SqlDbType.Int;
                parId.Value = Suplidores.IdSuplidor;
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

        public DataTable MostrarSuplidores()
        {
            DataTable dtReturn = new DataTable("Suplidor");
            Conexion con = new Conexion();
            try
            {


                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con.AbriConexion();
                cmd.CommandText = "MOSTRAR_TODOS_SUPLIDORES";
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

        public DataTable BuscarSuplidores_Nombre(DSuplidor Suplidores)
        {
            DataTable dtretur = new DataTable("Suplidores");
            Conexion con = new Conexion();


            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con.AbriConexion();
                cmd.CommandText = "MOSTRAR_NOMBRE_SUPLIDORES";
                cmd.CommandType = CommandType.StoredProcedure;


                SqlParameter ParBuscador = new SqlParameter();
                ParBuscador.ParameterName = "@buscador";
                ParBuscador.SqlDbType = SqlDbType.VarChar;
                ParBuscador.Size = 50;
                ParBuscador.Value = Suplidores.Buscador;
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

        public DataTable BuscarSuplidores_ID(DSuplidor Suplidores)
        {
            DataTable dtretur = new DataTable("Suplidores");
            Conexion con = new Conexion();


            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con.AbriConexion();
                cmd.CommandText = "MOSTRAR_IDENTIFICIACION_SUPLIDORES";
                cmd.CommandType = CommandType.StoredProcedure;


                SqlParameter ParBuscador = new SqlParameter();
                ParBuscador.ParameterName = "@buscador";
                ParBuscador.SqlDbType = SqlDbType.VarChar;
                ParBuscador.Size = 50;
                ParBuscador.Value = Suplidores.Buscador;
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
    }
}
