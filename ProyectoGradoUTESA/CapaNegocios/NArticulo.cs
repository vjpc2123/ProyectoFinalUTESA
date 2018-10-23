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
       
           
            public static string Insertar(string nombre, string sipnosis, int id_generoliterario, int id_editorial, int id_autor, int id_estanteria, byte[] Imagen)
            {

                DArticulo obj = new DArticulo();
                obj. = nombre;
                obj.Sipnosis = sipnosis;
                obj.Id_GeneroLiterario = id_generoliterario;
                obj.Id_Editorial = id_editorial;
                obj.Id_Estanteria = id_estanteria;
                obj.Id_Autor = id_autor;
                obj.Imagen = Imagen;
                return obj.Insertar(objLibro);


            }

            public static string Editar(int id_libro, string nombre, string sipnosis, int id_generoliterario, int id_editorial, int id_autor, int id_estanteria, byte[] Imagen)
            {

                DLibro objLibro = new DLibro();
                objLibro.Id_Libro = id_libro;
                objLibro.Nombre = nombre;
                objLibro.Sipnosis = sipnosis;
                objLibro.Id_GeneroLiterario = id_generoliterario;
                objLibro.Id_Editorial = id_editorial;
                objLibro.Id_Estanteria = id_estanteria;
                objLibro.Id_Autor = id_autor;
                objLibro.Imagen = Imagen;
                return objLibro.Editar(objLibro);

            }
            public static string Eliminar(int id_libro)
            {

                DLibro objLibro = new DLibro();
                objLibro.Id_Libro = id_libro;
                return objLibro.Eliminar(objLibro);


            }

            public static DataTable MostarLibros()
            {
                DLibro obj = new DLibro();
                return obj.MostrarLibro();
            }

            public static DataTable BuscarNombreLibro(string buscador)
            {
                DLibro objLibro = new DLibro();
                objLibro.Buscador = buscador;
                return objLibro.BuscarNombre_Libro(objLibro);
            }

            public static DataTable BuscarAutorLibro(string buscador)
            {
                DLibro objLibro = new DLibro();
                objLibro.Buscador = buscador;
                return objLibro.Buscar_Autor_Libro(objLibro);
            }

            public static DataTable BuscarGeneroLibro(string buscador)
            {
                DLibro objLibro = new DLibro();
                objLibro.Buscador = buscador;
                return objLibro.Buscar_Genero_Libro(objLibro);
            }

            public static DataTable BuscarEditorialLibro(string buscador)
            {
                DLibro objLibro = new DLibro();
                objLibro.Buscador = buscador;
                return objLibro.Buscar_Editorial_Libro(objLibro);
            }

        }
    }

