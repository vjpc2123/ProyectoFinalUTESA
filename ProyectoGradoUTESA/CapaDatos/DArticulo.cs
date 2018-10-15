using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    class DArticulo
    {
        private int _idArticulo;
        public int IdArticulo { get => _idArticulo; set => _idArticulo = value; }

        private string _nombre;
        public string Nombre { get => _nombre; set => _nombre = value; }

        private string _descripcion;
        public string Descripcion { get => _descripcion; set => _nombre = value; }

        private byte[] _imagen;
        public byte[] Imagen { get => Imagen; set => _imagen = value; }

        private int _idCategoria;
        public int IdCategoria { get => _idCategoria; set => _idCategoria = value; }

        private int _idPresentacion;
        public int IdPresentacion { get => _idPresentacion; set => _idPresentacion = value; }

        private int _idUbicacion;
        public int idUbicacion { get => _idUbicacion; set => _idUbicacion = value;}

        private int _idMarca;
        public int IdMarca { get => _idMarca; set => _idMarca = value; }

        private string _buscador;
        public string Buscador { get => _buscador; set => _buscador = value; }



        public DArticulo() { }

        public DArticulo(int idarticulo, string nombre, string desscripcion, int categoriaid, int presentacionid, int ubicacionid, int marcaid, string Buscador, byte[] Imagen)
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
                parIdMarca.SqlDbType = SqlDbType.Image;
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

        public string Editar(DArticulo Articulo)
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
                parIdMarca.SqlDbType = SqlDbType.Image;
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

                msgRetorno = cmd.ExecuteNonQuery() == 1 ? "Ok" : "No ha sido posible ejecutar la accion eliminar";

            }
            catch (Exception ex)
            {

                msgRetorno = ex.Message;
            }
            finally { con.AbriConexion(); }

            return msgRetorno;
        }

        public DataTable MostrarLibro()
        {
            DataTable DtRetorno = new DataTable("Libro");
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Conexion.Cn;

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "spmostrar_libro";
                cmd.Connection = con;
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

        public DataTable BuscarNombre_Libro(DLibro Libro)
        {
            DataTable dtRetorno = new DataTable("Libro");
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Conexion.Cn;

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "spbuscar_nombre_libro";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parBuscador = new SqlParameter();
                parBuscador.ParameterName = "@buscador";
                parBuscador.SqlDbType = SqlDbType.VarChar;
                parBuscador.Size = 50;
                parBuscador.Value = Libro.Buscador;
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

        public DataTable Buscar_Genero_Libro(DLibro Libro)
        {
            DataTable dtRetorno = new DataTable("Libro");
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Conexion.Cn;

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "spbuscar_genero_libro";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parBuscador = new SqlParameter();
                parBuscador.ParameterName = "@buscador";
                parBuscador.SqlDbType = SqlDbType.VarChar;
                parBuscador.Size = 50;
                parBuscador.Value = Libro.Buscador;
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

        public DataTable Buscar_Autor_Libro(DLibro Libro)
        {
            DataTable dtRetorno = new DataTable("Libro");
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Conexion.Cn;
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "spbuscar_autor_libro";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parBuscador = new SqlParameter();
                parBuscador.ParameterName = "@buscador";
                parBuscador.SqlDbType = SqlDbType.VarChar;
                parBuscador.Size = 50;
                parBuscador.Value = Libro.Buscador;
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

        public DataTable Buscar_Editorial_Libro(DLibro Libro)
        {
            DataTable dtRetorno = new DataTable("Libro");
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Conexion.Cn;
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "spbuscar_editorial_libro";
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parBuscador = new SqlParameter();
                parBuscador.ParameterName = "@buscador";
                parBuscador.SqlDbType = SqlDbType.VarChar;
                parBuscador.Size = 50;
                parBuscador.Value = Libro.Buscador;
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


        public DataTable BuscarInventa7rio(DArticulo Articulo)
        {
            DataTable dtRetorno = new DataTable("Libro");
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Conexion.Cn;

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SP_INVENTARIO";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parBuscador = new SqlParameter();
                parBuscador.ParameterName = "@BUSCADOR";
                parBuscador.SqlDbType = SqlDbType.VarChar;
                parBuscador.Size = 50;
                parBuscador.Value = Libro.Buscador;
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
