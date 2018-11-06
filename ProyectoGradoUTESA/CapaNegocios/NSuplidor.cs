using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaNegocios
{
    public class NSuplidor
    {
        public static string Ingresar(string estatus, string tiposupllidor, string nombre, string apellido, string telefono,
            string direccion, string ciudad, string sector, string contacto, string telefonocontacto, string tipoidentificacion,
            string identificacion, string correoelectronico)
        {
            DSuplidor obj = new DSuplidor();
            obj.Estatus = estatus;
            obj.TipoSuplidor = tiposupllidor;
            obj.Nombre = nombre;
            obj.Apellido = apellido;
            obj.Telefono = telefono;
            obj.Direccion = direccion;
            obj.Ciudad = ciudad;
            obj.Sector = sector;
            obj.Contacto = contacto;
            obj.TelefonoContacto = telefonocontacto;
            obj.TipoIdentificacion = tipoidentificacion;
            obj.Identificacion = identificacion;
            obj.CorreoElectronico = correoelectronico;
            return obj.InsetarSuplidor(obj);
        }

        public static string Modificar(int idsuplidor, string estatus, string tiposupllidor, string nombre, string apellido, string telefono,
            string direccion, string ciudad, string sector, string contacto, string telefonocontacto, string tipoidentificacion,
            string identificacion, string correoelectronico)
        {
            DSuplidor obj = new DSuplidor();
            obj.IdSuplidor = idsuplidor;
            obj.Estatus = estatus;
            obj.TipoSuplidor = tiposupllidor;
            obj.Nombre = nombre;
            obj.Apellido = apellido;
            obj.Telefono = telefono;
            obj.Direccion = direccion;
            obj.Ciudad = ciudad;
            obj.Sector = sector;
            obj.Contacto = contacto;
            obj.TelefonoContacto = telefonocontacto;
            obj.TipoIdentificacion = tipoidentificacion;
            obj.Identificacion = identificacion;
            obj.CorreoElectronico = correoelectronico;
            return obj.ModificarSuplidor(obj);
        }

        public static string Eliminar(int idsuplidor)
        {
            DSuplidor obj = new DSuplidor();
            obj.IdSuplidor = idsuplidor;
            return obj.EliminarSuplidor(obj);
        }

        public static DataTable Mostrar()
        {
            DSuplidor obj = new DSuplidor();
            return obj.MostrarSuplidores();
        }

        public static DataTable Buscar_Nombre(string Buscador)
        {
            DSuplidor obj = new DSuplidor();
            obj.Buscador = Buscador;
            return obj.BuscarSuplidores_Nombre(obj);
        }

        public static DataTable Buscar_ID(string Buscador)
        {
            DSuplidor obj = new DSuplidor();
            obj.Buscador = Buscador;
            return obj.BuscarSuplidores_ID(obj);
        }
    }
}
