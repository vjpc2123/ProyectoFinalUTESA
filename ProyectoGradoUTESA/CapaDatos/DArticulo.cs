using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
   public class DArticulo
    {
        

      
        private int _idArticulo;
        public int IdArticulo { get => _idArticulo; set => _idArticulo = value; }

        private string _nombre;
        public string Nombre { get => _nombre; set => _nombre = value; }

        private string _descripcion;
        public string Descripcion { get => _descripcion; set => _descripcion = value; }

        private byte[] _imagen;
        public byte[] Imagen { get => _imagen; set => _imagen = value; }

        private int _idCategoria;
        public int IdCategoria { get => _idCategoria; set => _idCategoria = value; }

        private int _idPresentacion;
        public int IdPresentacion { get => _idPresentacion; set => _idPresentacion = value; }

        private int _idUbicacion;
        public int idUbicacion { get => _idUbicacion; set => _idUbicacion = value; }

        private int _idMarca;
        public int IdMarca { get => _idMarca; set => _idMarca = value; }

        private string _buscador;
        public string Buscador { get => _buscador; set => _buscador = value; }

        private int _buscadorcodigo;
        public int Buscadorcodigo { get => _buscadorcodigo; set => _buscadorcodigo = value; }
        

        public DArticulo() { }

        public DArticulo(int idarticulo, string nombre, string desscripcion, int categoriaid, int presentacionid, int ubicacionid, int marcaid, string Buscador, byte[] Imagen,int buscarcodigo)
        {
            this.IdArticulo = idarticulo;
            this.Nombre = Nombre;
            this.Descripcion = desscripcion;
            this.IdCategoria = categoriaid;
            this.IdPresentacion = presentacionid;
            this.idUbicacion = ubicacionid;
            this.IdMarca = marcaid;
            this.Buscador = Buscador;
            this.Imagen = Imagen;
            this.Buscadorcodigo = buscarcodigo;

        }

        public string InsertarArticulo(DArticulo Articulo)
        {
            string Retorno = "";

            Conexion con = new Conexion();
           
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con.AbriConexion();
                cmd.CommandText = "INSERTAR_ARTICULO";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@idarticulo";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(ParId);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = Articulo.Nombre;
                cmd.Parameters.Add(ParNombre);

                SqlParameter parDescripcion = new SqlParameter();
                parDescripcion.ParameterName = "@descripcion";
                parDescripcion.SqlDbType = SqlDbType.VarChar;
                parDescripcion.Size = 150;
                parDescripcion.Value = Articulo.Descripcion;
                cmd.Parameters.Add(parDescripcion);

                SqlParameter parImagen = new SqlParameter();
                parImagen.ParameterName = "@imagen";
                parImagen.SqlDbType = SqlDbType.Image;
                parImagen.Value = Articulo.Imagen;
                cmd.Parameters.Add(parImagen);

                SqlParameter paridCategoria = new SqlParameter();
                paridCategoria.ParameterName = "@idcategoria";
                paridCategoria.SqlDbType = SqlDbType.Int;
                paridCategoria.Value = Articulo.IdCategoria;
                cmd.Parameters.Add(paridCategoria);

                SqlParameter parIdPresentacion = new SqlParameter();
                parIdPresentacion.ParameterName = "@idpresentacion";
                parIdPresentacion.SqlDbType = SqlDbType.Int;
                parIdPresentacion.Value = Articulo.IdPresentacion;
                cmd.Parameters.Add(parIdPresentacion);

                SqlParameter parIdUbicacion = new SqlParameter();
                parIdUbicacion.ParameterName = "@idubicacion";
                parIdUbicacion.SqlDbType = SqlDbType.Int;
                parIdUbicacion.Value = Articulo.idUbicacion;
                cmd.Parameters.Add(parIdUbicacion);

                SqlParameter parIdMarca = new SqlParameter();
                parIdMarca.ParameterName = "@idmarca";
                parIdMarca.SqlDbType = SqlDbType.Int;
                parIdMarca.Value = Articulo.IdMarca;
                cmd.Parameters.Add(parIdMarca);

                Retorno = cmd.ExecuteNonQuery() == 1 ? "Ok" : "No ha sido posible insertar los registros indicados";

            }
            catch (Exception ex)
            {

                Retorno = ex.ToString();
            }
            finally { con.CerrarConexion();}
            return Retorno;
        }
        public string EditarArticulo(DArticulo Articulo)
        {
            string Retorno = "";

            Conexion con = new Conexion();

            try
            {


                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con.AbriConexion();
                cmd.CommandText = "MODIFICAR_ARTICULO";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@idarticulo";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Value = Articulo.IdArticulo;
                cmd.Parameters.Add(ParId);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = Articulo.Nombre;
                cmd.Parameters.Add(ParNombre);

                SqlParameter parDescripcion = new SqlParameter();
                parDescripcion.ParameterName = "@descripcion";
                parDescripcion.SqlDbType = SqlDbType.VarChar;
                parDescripcion.Size = 150;
                parDescripcion.Value = Articulo.Descripcion;
                cmd.Parameters.Add(parDescripcion);

                SqlParameter parImagen = new SqlParameter();
                parImagen.ParameterName = "@imagen";
                parImagen.SqlDbType = SqlDbType.Image;
                parImagen.Value = Articulo.Imagen;
                cmd.Parameters.Add(parImagen);

                SqlParameter paridCategoria = new SqlParameter();
                paridCategoria.ParameterName = "@idcategoria";
                paridCategoria.SqlDbType = SqlDbType.Int;
                paridCategoria.Value = Articulo.IdCategoria;
                cmd.Parameters.Add(paridCategoria);

                SqlParameter parIdPresentacion = new SqlParameter();
                parIdPresentacion.ParameterName = "@idpresentacion";
                parIdPresentacion.SqlDbType = SqlDbType.Int;
                parIdPresentacion.Value = Articulo.IdPresentacion;
                cmd.Parameters.Add(parIdPresentacion);

                SqlParameter parIdUbicacion = new SqlParameter();
                parIdUbicacion.ParameterName = "@idubicacion";
                parIdUbicacion.SqlDbType = SqlDbType.Int;
                parIdUbicacion.Value = Articulo.idUbicacion;
                cmd.Parameters.Add(parIdUbicacion);

                SqlParameter parIdMarca = new SqlParameter();
                parIdMarca.ParameterName = "@idmarca";
                parIdMarca.SqlDbType = SqlDbType.Int;
                parIdMarca.Value = Articulo.IdMarca;
                cmd.Parameters.Add(parIdMarca);

                Retorno = cmd.ExecuteNonQuery() == 1 ? "Ok" : "No ha sido posible insertar los registros indicados";
            }
            catch (Exception ex)
            {

                Retorno = ex.ToString();
            }
            finally { con.CerrarConexion(); }
            return Retorno;
        }
        public string EliminarArticulo(DArticulo Articulo)
        {
            string msgRetorno = "";
            Conexion con = new Conexion();

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con.AbriConexion();
                cmd.CommandText = "ELIMINAR_ARTICULO";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@idarticulo";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Value = Articulo.IdArticulo;
                cmd.Parameters.Add(ParId);

                msgRetorno = cmd.ExecuteNonQuery() == 1 ? "Ok" : "No se ha podido eliminar el Registro";

            }
            catch (Exception ex)
            {

                msgRetorno = ex.Message;
            }
            finally { con.CerrarConexion(); }

            return msgRetorno;
        }
        public DataTable MostrarTodosArticulos()
        {
            DataTable DtRetorno = new DataTable("Articulo");
            Conexion con = new Conexion();

            try
            {
                
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "MOSTRAR_TODOS_ARTICULOS";
                cmd.Connection = con.AbriConexion();
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                ad.Fill(DtRetorno);
            }
            catch (Exception)
            {

                DtRetorno = null;
            }
            return DtRetorno;
        }
        public DataTable MostrarArticulo_Codigo(DArticulo Articulo)
        {
            DataTable dtRetorno = new DataTable("Articulo");

            Conexion con = new Conexion();

            try
            {
                
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con.AbriConexion();
                cmd.CommandText = "MOSTRAR_CODIGO_ARTICULO";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parBuscador = new SqlParameter();
                parBuscador.ParameterName = "@buscador";
                parBuscador.SqlDbType = SqlDbType.Int;
                parBuscador.Value = Articulo.Buscadorcodigo;
                cmd.Parameters.Add(parBuscador);

                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                ad.Fill(dtRetorno);
            }
            catch (Exception)
            {

                dtRetorno = null;
            }
            return dtRetorno;
        }
        public DataTable MostrarArticulo_Nombre(DArticulo Articulo)
        {
            DataTable dtRetorno = new DataTable("Articulo");
            Conexion con = new Conexion();
            

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con.AbriConexion();
                cmd.CommandText = "MOSTRAR_NOMBRE_ARTICULO";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parBuscador = new SqlParameter();
                parBuscador.ParameterName = "@buscador";
                parBuscador.SqlDbType = SqlDbType.VarChar;
                parBuscador.Size = 50;
                parBuscador.Value = Articulo.Buscador;
                cmd.Parameters.Add(parBuscador);

                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                ad.Fill(dtRetorno);

            }
            catch (Exception)
            {

                dtRetorno = null;
            }
            return dtRetorno;


        }
        public DataTable MostrarArticulo_Categoria(DArticulo Articulo)
        {
            DataTable dtRetorno = new DataTable("Articulo");
            Conexion con = new Conexion();


            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con.AbriConexion();
                cmd.CommandText = "MOSTRAR_NOMBRE_ARTICULO_CATE";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parBuscador = new SqlParameter();
                parBuscador.ParameterName = "@buscador";
                parBuscador.SqlDbType = SqlDbType.VarChar;
                parBuscador.Size = 50;
                parBuscador.Value = Articulo.Buscador;
                cmd.Parameters.Add(parBuscador);

                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                ad.Fill(dtRetorno);

            }
            catch (Exception)
            {

                dtRetorno = null;
            }
            return dtRetorno;


        }
        public DataTable MostrarArticulo_Presentacion(DArticulo Articulo)
        {
            DataTable dtRetorno = new DataTable("Articulo");
            Conexion con = new Conexion();


            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con.AbriConexion();
                cmd.CommandText = "MOSTRAR_NOMBRE_ARTICULO_PRESENT";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parBuscador = new SqlParameter();
                parBuscador.ParameterName = "@buscador";
                parBuscador.SqlDbType = SqlDbType.VarChar;
                parBuscador.Size = 50;
                parBuscador.Value = Articulo.Buscador;
                cmd.Parameters.Add(parBuscador);

                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                ad.Fill(dtRetorno);

            }
            catch (Exception)
            {

                dtRetorno = null;
            }
            return dtRetorno;


        }
        public DataTable MostrarArticulo_Marca(DArticulo Articulo)
        {
            DataTable dtRetorno = new DataTable("Articulo");
            Conexion con = new Conexion();


            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con.AbriConexion();
                cmd.CommandText = "MOSTRAR_NOMBRE_ARTICULO_MARCA";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parBuscador = new SqlParameter();
                parBuscador.ParameterName = "@buscador";
                parBuscador.SqlDbType = SqlDbType.VarChar;
                parBuscador.Size = 50;
                parBuscador.Value = Articulo.Buscador;
                cmd.Parameters.Add(parBuscador);

                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                ad.Fill(dtRetorno);

            }
            catch (Exception)
            {

                dtRetorno = null;
            }
            return dtRetorno;


        }
        public DataTable MostrarArticulo_Ubicacion(DArticulo Articulo)
        {
            DataTable dtRetorno = new DataTable("Articulo");
            Conexion con = new Conexion();


            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con.AbriConexion();
                cmd.CommandText = "MOSTRAR_NOMBRE_ARTICULO_UBIC";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parBuscador = new SqlParameter();
                parBuscador.ParameterName = "@buscador";
                parBuscador.SqlDbType = SqlDbType.VarChar;
                parBuscador.Size = 50;
                parBuscador.Value = Articulo.Buscador;
                cmd.Parameters.Add(parBuscador);

                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                ad.Fill(dtRetorno);

            }
            catch (Exception)
            {

                dtRetorno = null;
            }
            return dtRetorno;


        }

        /*8fi9*/
    }
}
