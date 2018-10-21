using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DPresentacion
    {

            private int _idPresentacion;
            public int IdPresentacion { get => _idPresentacion; set => _idPresentacion = value; }

            private string _nombre;
            public string Nombre { get => _nombre; set => _nombre = value; }

            private string _descripcion;
            public string Descripcion { get => _descripcion; set => _descripcion = value; }

            private string _buscador;
            public string Buscador { get => _buscador; set => _buscador = value; }

            public DPresentacion()
            {


            }

            public DPresentacion(int idpresentacion, string nombre, string descripcion, string buscador)
            {
                IdPresentacion = idpresentacion;
                Nombre = nombre;
                Descripcion = descripcion;
                Buscador = buscador;
            }

            public string InsertarPresentacion(DPresentacion Presentacion)
            {
                string retorno = "";
                Conexion con = new Conexion();

                try
                {

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con.AbriConexion();
                    cmd.CommandText = "INSERTAR_PRESENTACION";
                    cmd.CommandType = CommandType.StoredProcedure;


                    SqlParameter parId = new SqlParameter();
                    parId.ParameterName = "@idpresentacion";
                    parId.SqlDbType = SqlDbType.Int;
                    parId.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(parId);

                    SqlParameter parNombre = new SqlParameter();
                    parNombre.ParameterName = "@nombre";
                    parNombre.SqlDbType = SqlDbType.VarChar;
                    parNombre.Size = 50;
                    parNombre.Value = Presentacion.Nombre;
                    cmd.Parameters.Add(parNombre);

                    SqlParameter parDescripcion = new SqlParameter();
                    parDescripcion.ParameterName = "@descripcion";
                    parDescripcion.SqlDbType = SqlDbType.VarChar;
                    parDescripcion.Size = 150;
                    parDescripcion.Value = Presentacion.Descripcion;
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

            public string ModificarPresentacion(DPresentacion Presentacion)
            {
                string retorno = "";
                Conexion con = new Conexion();

                try
                {

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con.AbriConexion();
                    cmd.CommandText = "MODIFICAR_PRESENTACION";
                    cmd.CommandType = CommandType.StoredProcedure;


                    SqlParameter parId = new SqlParameter();
                    parId.ParameterName = "@idpresentacion";
                    parId.SqlDbType = SqlDbType.Int;
                    parId.Value = Presentacion.IdPresentacion;
                    cmd.Parameters.Add(parId);

                    SqlParameter parNombre = new SqlParameter();
                    parNombre.ParameterName = "@nombre";
                    parNombre.SqlDbType = SqlDbType.VarChar;
                    parNombre.Size = 50;
                    parNombre.Value = Presentacion.Nombre;
                    cmd.Parameters.Add(parNombre);

                    SqlParameter parDescripcion = new SqlParameter();
                    parDescripcion.ParameterName = "@descripcion";
                    parDescripcion.SqlDbType = SqlDbType.VarChar;
                    parDescripcion.Size = 150;
                    parDescripcion.Value = Presentacion.Descripcion;
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

            public string EliminarPresentacion(DPresentacion Presentacion)
            {
                string retorno = "";
                Conexion con = new Conexion();

                try
                {

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con.AbriConexion();
                    cmd.CommandText = "ELIMINAR_PRESENTACION";
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter parId = new SqlParameter();
                    parId.ParameterName = "@idpresentacion";
                    parId.SqlDbType = SqlDbType.Int;
                    parId.Value = Presentacion.IdPresentacion;
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

            public DataTable MostrarPresentacion()
            {
                DataTable dtReturn = new DataTable("Presentacion");
                Conexion con = new Conexion();
                try
                {


                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con.AbriConexion();
                    cmd.CommandText = "MOSTRAR_TODOS_PRESENTACION";
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

            public DataTable BuscarPresentacion_Nombre(DPresentacion Presentacion)
            {
                DataTable dtretur = new DataTable("Presentacion");
                Conexion con = new Conexion();


                try
                {

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con.AbriConexion();
                    cmd.CommandText = "MOSTRAR_NOMBRE_PRESENTACION";
                    cmd.CommandType = CommandType.StoredProcedure;


                    SqlParameter ParBuscador = new SqlParameter();
                    ParBuscador.ParameterName = "@nombre";
                    ParBuscador.SqlDbType = SqlDbType.VarChar;
                    ParBuscador.Size = 50;
                    ParBuscador.Value = Presentacion.Buscador;
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

            public DataTable BuscarPresentacion_Descripcion(DPresentacion Presentacion)
            {
                DataTable dtretur = new DataTable("Presentacion");
                Conexion con = new Conexion();
                try
                {

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con.AbriConexion();
                    cmd.CommandText = "MOSTRAR_DESCRIPCION_PRESENTACION";
                    cmd.CommandType = CommandType.StoredProcedure;


                    SqlParameter ParBuscador = new SqlParameter();
                    ParBuscador.ParameterName = "@descripcion";
                    ParBuscador.SqlDbType = SqlDbType.VarChar;
                    ParBuscador.Size = 150;
                    ParBuscador.Value = Presentacion.Buscador;
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



