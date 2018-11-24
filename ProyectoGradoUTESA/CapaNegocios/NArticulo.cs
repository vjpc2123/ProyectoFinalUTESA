using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
namespace CapaNegocios
{
    public class NArticulo
    {
       
           
            public static string Insertar(string nombre, string descripcion, string idcategoria, string idpresentacion, string idubicacion, string idmarca, byte[] Imagen)
            {

                DArticulo obj = new DArticulo();
                obj.Nombre = nombre;
                obj.Descripcion = descripcion;
                obj.IdCategoria = Convert.ToInt32(idcategoria);
                obj.IdPresentacion = Convert.ToInt32(idpresentacion);
                obj.idUbicacion = Convert.ToInt32(idubicacion);
                obj.IdMarca = Convert.ToInt32(idmarca);
                obj.Imagen = Imagen;
                return obj.InsertarArticulo(obj);


            }

            public static string Editar(int idarticulo, string nombre, string descripcion, int idcategoria, int idpresentacion, int idubicacion, int idmarca, byte[] Imagen)
            {

                DArticulo obj = new DArticulo();
                obj.IdArticulo = idarticulo;
            obj.Nombre = nombre;
            obj.Descripcion = descripcion;
            obj.IdCategoria = idcategoria;
            obj.IdPresentacion = idpresentacion;
            obj.idUbicacion = idubicacion;
            obj.IdMarca = idmarca;
            obj.Imagen = Imagen;
            return obj.EditarArticulo(obj);

            }
            public static string Eliminar(int idarticulo)
            {

                DArticulo obj = new DArticulo();
                obj.IdArticulo = idarticulo;
                return obj.EliminarArticulo(obj);


            }

            public static DataTable Mostar()
            {
                DArticulo obj = new DArticulo();
                return obj.MostrarTodosArticulos();
            }

            public static DataTable BuscarCodigoArticulo(string  buscador)
            {
                DArticulo obj = new DArticulo();
                obj.Buscadorcodigo = Convert.ToInt32(buscador);
                return obj.MostrarArticulo_Codigo(obj);
            }
            
            public static DataTable BuscarNombreArticulo(string buscador)
            {
                DArticulo obj = new DArticulo();
                obj.Buscador = buscador;
                return obj.MostrarArticulo_Nombre(obj);
            }

            public static DataTable BuscarCategoriaArticulo(string buscador)
            {
                DArticulo obj = new DArticulo();
                obj.Buscador = buscador;
                return obj.MostrarArticulo_Categoria(obj);
            }

            public static DataTable BuscarPresentacionArticulo(string buscador)
            {
                DArticulo obj = new DArticulo();
                obj.Buscador = buscador;
                return obj.MostrarArticulo_Presentacion(obj);
            }

            public static DataTable BuscarMarcaArticulo(string buscador)
            {
                DArticulo obj = new DArticulo();
                obj.Buscador = buscador;
                return obj.MostrarArticulo_Marca(obj);
            }

            public static DataTable BuscarUbicacionMarca(string buscador)
            {
            DArticulo obj = new DArticulo();
            obj.Buscador = buscador;
            return obj.MostrarArticulo_Ubicacion(obj);
            }

    }
    }

