using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
     class DMarca
    {
        private int _idMarca;
        public int IdMarca { get => _idMarca; set => _idMarca = value; }

        private string _nombre;
        public string Nombre { get => _nombre; set => _nombre = value; }

        private string _descripcion;
        public string Descripcion { get => _descripcion; set => _descripcion = value; }

        private string _buscador;
        public string Buscador { get => _buscador; set => _buscador = value; }

        public DMarca()
        {


        }

        public DMarca(int idmarca, string nombre, string descripcion, string buscador)
        {
            IdMarca = idmarca;
            Nombre = nombre;
            Descripcion = descripcion;
            Buscador = buscador;
        }

        public string InsertarMarca(DMarca Marca)
        {
            string retorno = "";
            Conexion con = new Conexion();

            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con.AbriConexion();
                cmd.CommandText = "INSERTAR_MARCA";
                cmd.CommandType = CommandType.StoredProcedure;


                SqlParameter parId = new SqlParameter();
                parId.ParameterName = "@idmarca";
                parId.SqlDbType = SqlDbType.Int;
                parId.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(parId);

                SqlParameter parNombre = new SqlParameter();
                parNombre.ParameterName = "@nombre";
                parNombre.SqlDbType = SqlDbType.VarChar;
                parNombre.Size = 50;
                parNombre.Value = Marca.Nombre;
                cmd.Parameters.Add(parNombre);

                SqlParameter parDescripcion = new SqlParameter();
                parDescripcion.ParameterName = "@descripcion";
                parDescripcion.SqlDbType = SqlDbType.VarChar;
                parDescripcion.Size = 150;
                parDescripcion.Value = Marca.Descripcion;
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

        public string ModificarMarca(DMarca Marca)
        {
            string retorno = "";
            Conexion con = new Conexion();

            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con.AbriConexion();
                cmd.CommandText = "MODIFICAR_MARCA";
                cmd.CommandType = CommandType.StoredProcedure;


                SqlParameter parId = new SqlParameter();
                parId.ParameterName = "@idmarca";
                parId.SqlDbType = SqlDbType.Int;
                parId.Value = Marca.IdMarca;
                cmd.Parameters.Add(parId);

                SqlParameter parNombre = new SqlParameter();
                parNombre.ParameterName = "@nombre";
                parNombre.SqlDbType = SqlDbType.VarChar;
                parNombre.Size = 50;
                parNombre.Value = Marca.Nombre;
                cmd.Parameters.Add(parNombre);

                SqlParameter parDescripcion = new SqlParameter();
                parDescripcion.ParameterName = "@descripcion";
                parDescripcion.SqlDbType = SqlDbType.VarChar;
                parDescripcion.Size = 150;
                parDescripcion.Value = Marca.Descripcion;
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

        public string EliminarMarca(DMarca Marca)
        {
            string retorno = "";
            Conexion con = new Conexion();

            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con.AbriConexion();
                cmd.CommandText = "ELIMINAR_MARCA";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parId = new SqlParameter();
                parId.ParameterName = "@idmarca";
                parId.SqlDbType = SqlDbType.Int;
                parId.Value = Marca.IdMarca;
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

        public DataTable MostrarMarca()
        {
            DataTable dtReturn = new DataTable("Marca");
            Conexion con = new Conexion();
            try
            {


                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con.AbriConexion();
                cmd.CommandText = "MOSTRAR_TODOS_MARCA";
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

        public DataTable BuscarMarca_Nombre(DMarca Marca)
        {
            DataTable dtretur = new DataTable("Marca");
            Conexion con = new Conexion();


            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con.AbriConexion();
                cmd.CommandText = "MOSTRAR_NOMBRE_MARCA";
                cmd.CommandType = CommandType.StoredProcedure;


                SqlParameter ParBuscador = new SqlParameter();
                ParBuscador.ParameterName = "@nombre";
                ParBuscador.SqlDbType = SqlDbType.VarChar;
                ParBuscador.Size = 50;
                ParBuscador.Value = Marca.Buscador;
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

        public DataTable BuscarMarca_Descripcion(DMarca Marca)
        {
            DataTable dtretur = new DataTable("Marca");
            Conexion con = new Conexion();
            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con.AbriConexion();
                cmd.CommandText = "MOSTRAR_DESCRIPCION_MARCA";
                cmd.CommandType = CommandType.StoredProcedure;


                SqlParameter ParBuscador = new SqlParameter();
                ParBuscador.ParameterName = "@descripcion";
                ParBuscador.SqlDbType = SqlDbType.VarChar;
                ParBuscador.Size = 150;
                ParBuscador.Value = Marca.Buscador;
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
