using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaNegocios
{
    public class NPresentacion
    {
        public static string IngresarPresentacion(string nombre, string descripcion)
        {
            DPresentacion OBJ = new DPresentacion();
            OBJ.Nombre = nombre;
            OBJ.Descripcion = descripcion;
            return OBJ.InsertarPresentacion(OBJ);
        }

        public static string ModificarPresentacion(int idpresentacion, string nombre, string descripcion)
        {
            DPresentacion obj = new DPresentacion();
            obj.IdPresentacion = idpresentacion;
            obj.Nombre = nombre;
            obj.Descripcion = descripcion;
            return obj.ModificarPresentacion(obj);
        }

        public static string Eliminar(int idpresentacion)
        {
            DPresentacion obj = new DPresentacion();
            obj.IdPresentacion = idpresentacion;
            return obj.EliminarPresentacion(obj);
        }

        public static DataTable Mostrar()
        {
            DPresentacion obj = new DPresentacion();
            return obj.MostrarPresentacion();
        }

        public static DataTable Buscar_Nombre(string Buscador)
        {
            DPresentacion obj = new DPresentacion();
            obj.Buscador = Buscador;
            return obj.BuscarPresentacion_Nombre(obj);
        }

        public static DataTable Buscar_Descripcion(string Buscador)
        {
            DPresentacion obj = new DPresentacion();
            obj.Buscador = Buscador;
            return obj.BuscarPresentacion_Descripcion(obj);
        }
    }
}
