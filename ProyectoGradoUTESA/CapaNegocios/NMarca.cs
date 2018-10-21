using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaNegocios
{
   public class NMarca
    {
        public static string IngresarMarca(string nombre, string descripcion)
        {
            DMarca OBJ = new DMarca();
            OBJ.Nombre = nombre;
            OBJ.Descripcion = descripcion;
            return OBJ.InsertarMarca(OBJ);
        }

        public static string ModificarMarca(int idmarca, string nombre, string descripcion)
        {
            DMarca obj = new DMarca();
            obj.IdMarca = idmarca;
            obj.Nombre = nombre;
            obj.Descripcion = descripcion;
            return obj.ModificarMarca(obj);
        }

        public static string EliminarMarca(int idmarca)
        {
            DMarca obj = new DMarca();
            obj.IdMarca = idmarca;
            return obj.EliminarMarca(obj);
        }

        public static DataTable MostrarMarca()
        {
            DMarca obj = new DMarca();
            return obj.MostrarMarca();
        }

        public static DataTable Buscar_Nombre_Marca(string Buscador)
        {
            DMarca obj = new DMarca();
            obj.Buscador = Buscador;
            return obj.BuscarMarca_Nombre(obj);
        }

        public static DataTable Buscar_Descripcion_Marca(string Buscador)
        {
            DMarca obj = new DMarca();
            obj.Buscador = Buscador;
            return obj.BuscarMarca_Descripcion(obj);
        }
    }
}
