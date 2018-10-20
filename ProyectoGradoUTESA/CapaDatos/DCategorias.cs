using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
   public  class DCategorias
    {
        private int _idCategoria;
        public int IdCategoria { get => _idCategoria; set => _idCategoria = value; }

        private string _nombre;
        public string Nombre { get => _nombre; set => _nombre = value; }

        private string _descripcion;
        public string Descripcion { get => _descripcion; set => _descripcion = value; }

        private string _buscador;
        public string Buscador { get => _buscador; set => _buscador = value; }

        public DCategorias()
        {


        }

        public DCategorias(int idcategoria,string nombre,string descripcion,string buscador)
        {
            IdCategoria = idcategoria;
            Nombre = nombre;
            Descripcion = descripcion;
            Buscador = buscador;
        }

        public string InsertarCategorias(DCategorias Categorias)
        {
            string retorno = "";
            Conexion con = new Conexion();

            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con.AbriConexion();
                cmd.CommandText = "INSERTAR_CATEGORIA";
                cmd.CommandType = CommandType.StoredProcedure;


                SqlParameter parId = new SqlParameter();
                parId.ParameterName = "@idcategoria";
                parId.SqlDbType = SqlDbType.Int;
                parId.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(parId);

                SqlParameter parNombre = new SqlParameter();
                parNombre.ParameterName = "@nombre";
                parNombre.SqlDbType = SqlDbType.VarChar;
                parNombre.Size = 50;
                parNombre.Value = Categorias.Nombre;
                cmd.Parameters.Add(parNombre);

                SqlParameter parDescripcion = new SqlParameter();
                parDescripcion.ParameterName = "@descripcion";
                parDescripcion.SqlDbType = SqlDbType.VarChar;
                parDescripcion.Size = 150;
                parDescripcion.Value = Categorias.Descripcion;
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

        public string ModificarCategoria(DCategorias Categorias)
        {
            string retorno = "";
            Conexion con = new Conexion();

            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con.AbriConexion();
                cmd.CommandText = "MODIFICAR_CATEGORIA";
                cmd.CommandType = CommandType.StoredProcedure;


                SqlParameter parId = new SqlParameter();
                parId.ParameterName = "@idcategoria";
                parId.SqlDbType = SqlDbType.Int;
                parId.Value = Categorias.IdCategoria;
                cmd.Parameters.Add(parId);

                SqlParameter parNombre = new SqlParameter();
                parNombre.ParameterName = "@nombre";
                parNombre.SqlDbType = SqlDbType.VarChar;
                parNombre.Size = 50;
                parNombre.Value = Categorias.Nombre;
                cmd.Parameters.Add(parNombre);

                SqlParameter parDescripcion = new SqlParameter();
                parDescripcion.ParameterName = "@descripcion";
                parDescripcion.SqlDbType = SqlDbType.VarChar;
                parDescripcion.Size = 150;
                parDescripcion.Value = Categorias.Descripcion;
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

        public string EliminarCategoria(DCategorias Categorias)
        {
            string retorno = "";
            Conexion con = new Conexion();

            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con.AbriConexion();
                cmd.CommandText = "ELIMINAR_CATEGORIA";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parIdCategoria = new SqlParameter();
                parIdCategoria.ParameterName = "@idcategoria";
                parIdCategoria.SqlDbType = SqlDbType.Int;
                parIdCategoria.Value = Categorias.IdCategoria;
                cmd.Parameters.Add(parIdCategoria);

                retorno = cmd.ExecuteNonQuery() == 1 ? "Ok" : "No se ha podido eliminar el Registro";



            }
            catch (Exception ex)
            {

                retorno = ex.Message;
            }
            finally { con.CerrarConexion(); }

            return retorno;

        }

        public DataTable MostrarCategoria()
        {
            DataTable dtReturn = new DataTable("Categoria");
            Conexion con = new Conexion();
            try
            {
               

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con.AbriConexion();
                cmd.CommandText = "MOSTRAR_TODOS_CATEGORIA";
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

        public DataTable BuscarCategoria_Nombre(DCategorias Categorias)
        {
            DataTable dtretur = new DataTable("Categoria");
            Conexion con = new Conexion();


            try
            {
               
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con.AbriConexion();
                cmd.CommandText = "MOSTRAR_NOMBRE_CATEGORIA";
                cmd.CommandType = CommandType.StoredProcedure;


                SqlParameter ParBuscador = new SqlParameter();
                ParBuscador.ParameterName = "@nombre";
                ParBuscador.SqlDbType = SqlDbType.VarChar;
                ParBuscador.Size = 50;
                ParBuscador.Value = Categorias.Buscador;
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

        public DataTable BuscarCategoria_Descripcion(DCategorias Categorias)
        {
            DataTable dtretur = new DataTable("Categoria");
            Conexion con = new Conexion();
            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con.AbriConexion();
                cmd.CommandText = "MOSTRAR_DESCRIPCION_CATEGORIA";
                cmd.CommandType = CommandType.StoredProcedure;


                SqlParameter ParBuscador = new SqlParameter();
                ParBuscador.ParameterName = "@descripcion";
                ParBuscador.SqlDbType = SqlDbType.VarChar;
                ParBuscador.Size = 150;
                ParBuscador.Value = Categorias.Buscador;
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
