using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    class DUbicacion
    {

        private int _idUbicacion;
        public int IdUbicacion { get => _idUbicacion; set => _idUbicacion = value; }

        private string _nombre;
        public string Nombre { get => _nombre; set => _nombre = value; }

        private string _descripcion;
        public string Descripcion { get => _descripcion; set => _descripcion = value; }

        private string _buscador;
        public string Buscador { get => _buscador; set => _buscador = value; }

        public DUbicacion()
        {


        }

        public DUbicacion (int idubicacion, string nombre, string descripcion, string buscador)
        {
            IdUbicacion = idubicacion;
            Nombre = nombre;
            Descripcion = descripcion;
            Buscador = buscador;
        }

        public string InsertarUbicacion(DUbicacion Ubicacion)
        {
            string retorno = "";
            Conexion con = new Conexion();

            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con.AbriConexion();
                cmd.CommandText = "INSERTAR_UBICACION";
                cmd.CommandType = CommandType.StoredProcedure;


                SqlParameter parId = new SqlParameter();
                parId.ParameterName = "@idubicacion";
                parId.SqlDbType = SqlDbType.Int;
                parId.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(parId);

                SqlParameter parNombre = new SqlParameter();
                parNombre.ParameterName = "@nombre";
                parNombre.SqlDbType = SqlDbType.VarChar;
                parNombre.Size = 50;
                parNombre.Value = Ubicacion.Nombre;
                cmd.Parameters.Add(parNombre);

                SqlParameter parDescripcion = new SqlParameter();
                parDescripcion.ParameterName = "@descripcion";
                parDescripcion.SqlDbType = SqlDbType.VarChar;
                parDescripcion.Size = 150;
                parDescripcion.Value = Ubicacion.Descripcion;
                cmd.Parameters.Add(parDescripcion);

                retorno = cmd.ExecuteNonQuery() == 1 ? "Ok" : "No es posible ingresar los datos";
            }
            catch (Exception ex)
            {

                retorno = ex.Message;
            }
            finally { con.CerrarConexion(); }



            return retorno;
        }

        public string ModificarUbicacion(DUbicacion Ubicacion)
        {
            string retorno = "";
            Conexion con = new Conexion();

            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con.AbriConexion();
                cmd.CommandText = "MODIFICAR_UBICACION";
                cmd.CommandType = CommandType.StoredProcedure;


                SqlParameter parId = new SqlParameter();
                parId.ParameterName = "@idubicacion";
                parId.SqlDbType = SqlDbType.Int;
                parId.Value = Ubicacion.IdUbicacion;
                cmd.Parameters.Add(parId);

                SqlParameter parNombre = new SqlParameter();
                parNombre.ParameterName = "@nombre";
                parNombre.SqlDbType = SqlDbType.VarChar;
                parNombre.Size = 50;
                parNombre.Value = Ubicacion.Nombre;
                cmd.Parameters.Add(parNombre);

                SqlParameter parDescripcion = new SqlParameter();
                parDescripcion.ParameterName = "@descripcion";
                parDescripcion.SqlDbType = SqlDbType.VarChar;
                parDescripcion.Size = 150;
                parDescripcion.Value = Ubicacion.Descripcion;
                cmd.Parameters.Add(parDescripcion);

                retorno = cmd.ExecuteNonQuery() == 1 ? "Ok" : "No es posible Modificar los datos";
            }
            catch (Exception ex)
            {

                retorno = ex.Message;
            }
            finally { con.CerrarConexion(); }



            return retorno;
        }

        public string EliminarUbicacion(DUbicacion Ubicacion)
        {
            string retorno = "";
            Conexion con = new Conexion();

            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con.AbriConexion();
                cmd.CommandText = "ELIMINAR_UBICACION";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parId = new SqlParameter();
                parId.ParameterName = "@idubicacion";
                parId.SqlDbType = SqlDbType.Int;
                parId.Value = Ubicacion.IdUbicacion;
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

        public DataTable MostrarUbicacion()
        {
            DataTable dtReturn = new DataTable("Ubicacion");
            Conexion con = new Conexion();
            try
            {


                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con.AbriConexion();
                cmd.CommandText = "MOSTRAR_TODOS_UBICACION";
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

        public DataTable BuscarUbicacion_Nombre(DUbicacion Ubicacion)
        {
            DataTable dtretur = new DataTable("Ubicacion");
            Conexion con = new Conexion();


            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con.AbriConexion();
                cmd.CommandText = "MOSTRAR_NOMBRE_UBICACION";
                cmd.CommandType = CommandType.StoredProcedure;


                SqlParameter ParBuscador = new SqlParameter();
                ParBuscador.ParameterName = "@nombre";
                ParBuscador.SqlDbType = SqlDbType.VarChar;
                ParBuscador.Size = 50;
                ParBuscador.Value = Ubicacion.Buscador;
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

        public DataTable BuscarUbicacion_Descripcion(DUbicacion Ubicacion)
        {
            DataTable dtretur = new DataTable("Ubicacion");
            Conexion con = new Conexion();
            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con.AbriConexion();
                cmd.CommandText = "MOSTRAR_NOMBRE_UBICACION";
                cmd.CommandType = CommandType.StoredProcedure;


                SqlParameter ParBuscador = new SqlParameter();
                ParBuscador.ParameterName = "@descripcion";
                ParBuscador.SqlDbType = SqlDbType.VarChar;
                ParBuscador.Size = 150;
                ParBuscador.Value = Ubicacion.Buscador;
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
