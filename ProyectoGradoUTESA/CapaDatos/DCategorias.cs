using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DCategorias
    {
        private int _idCategoria;
        public int IdCategoria { get => _idCategoria; set => _idCategoria = value; }

        private string _nombre;
        public string Nombre { get => _nombre; set => _nombre = value; }

        private string _descripcion;
        public string Descripcion { get => _descripcion; set => _descripcion = value; }

        public DCategorias()
        {


        }

        public DCategorias(int idcategoria,string nombre,string descripcion)
        {
            IdCategoria = idcategoria;
            Nombre = nombre;
            Descripcion = descripcion;
        }
    }
}
