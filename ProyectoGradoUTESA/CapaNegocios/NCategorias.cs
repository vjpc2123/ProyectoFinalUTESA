using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;
namespace CapaNegocios
{
    public class NCategoria
    {
        public static string IngresarCategoria(string nombre, string descripcion)
        {
            DCategorias OBJ = new DCategorias();
            OBJ.Nombre = nombre;
            OBJ.Descripcion = descripcion;
            return OBJ.InsertarCategorias(OBJ);
        }

        public static string ModificarCategoria(int idCategoria, string nombre, string descripcion)
        {
            DCategorias obj = new DCategorias();
            obj.IdCategoria = idCategoria;
            obj.Nombre = nombre;
            obj.Descripcion = descripcion;
            return obj.ModificarCategoria(obj);
        }

        public static string EliminarCategoria(int idcategoria)
        {
            DCategorias obj = new DCategorias();
            obj.IdCategoria = idcategoria;
            return obj.EliminarCategoria(obj);
        }

        public static DataTable MostratCategria()
        {
            DCategorias obj = new DCategorias();
            return obj.MostrarCategoria();
        }

        public static DataTable Buscar_Nombre_Categoria(string Buscador)
        {
            DCategorias obj = new DCategorias();
            obj.Buscador = Buscador;
            return obj.BuscarCategoria_Nombre(obj);
        }

        public static DataTable Buscar_Descripcion_Categoria(string Buscador)
        {
            DCategorias obj = new DCategorias();
            obj.Buscador = Buscador;
            return obj.BuscarCategoria_Descripcion(obj);
        }
    }
}
