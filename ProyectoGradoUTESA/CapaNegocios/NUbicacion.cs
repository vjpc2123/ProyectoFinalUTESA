using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaNegocios
{
    public class NUbicacion
    {
        public static string Ingresar(string nombre, string descripcion)
        {
            DUbicacion OBJ = new DUbicacion();
            OBJ.Nombre = nombre;
            OBJ.Descripcion = descripcion;
            return OBJ.InsertarUbicacion(OBJ);
        }

        public static string Modificar(int idubicacion, string nombre, string descripcion)
        {
            DUbicacion obj = new DUbicacion();
            obj.IdUbicacion = idubicacion;
            obj.Nombre = nombre;
            obj.Descripcion = descripcion;
            return obj.ModificarUbicacion(obj);
        }

        public static string Eliminar(int idubicacion)
        {
            DUbicacion obj = new DUbicacion();
            obj.IdUbicacion = idubicacion;
            return obj.EliminarUbicacion(obj);
        }

        public static DataTable Mostrar()
        {
            DUbicacion obj = new DUbicacion();
            return obj.MostrarUbicacion();
        }

        public static DataTable Buscar_Nombre(string Buscador)
        {
            DUbicacion obj = new DUbicacion();
            obj.Buscador = Buscador;
            return obj.BuscarUbicacion_Nombre(obj);
        }

        public static DataTable Buscar_Descripcion(string Buscador)
        {
            DUbicacion obj = new DUbicacion();
            obj.Buscador = Buscador;
            return obj.BuscarUbicacion_Descripcion(obj);
        }
    }
}
