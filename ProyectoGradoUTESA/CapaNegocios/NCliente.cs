using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaNegocios
{
    public class NCliente
    {
        public static string Ingresar(string estatus, string nombre, string apellido, string telefono,
            string direccion, string ciudad, string sector, string contacto, string telefonocontacto, string tipoidentificacion,
            string identificacion, string correoelectronico)
        {
            DCliente obj = new DCliente();
            obj.Estatus = estatus;
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
            return obj.InsetarCliente(obj);
        }

        public static string Modificar(int idcliente, string estatus, string nombre, string apellido, string telefono,
            string direccion, string ciudad, string sector, string contacto, string telefonocontacto, string tipoidentificacion,
            string identificacion, string correoelectronico)
        {
            DCliente obj = new DCliente();
            obj.IdCliente = idcliente;
            obj.Estatus = estatus;
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
            return obj.ModificarCliente(obj);
        }

        public static string Eliminar(int idcliente)
        {
            DCliente obj = new DCliente();
            obj.IdCliente = idcliente;
            return obj.EliminarCliente(obj);
        }

        public static DataTable Mostrar()
        {
            DCliente obj = new DCliente();
            return obj.MostrarClientes();
        }

        public static DataTable Buscar_Nombre(string Buscador)
        {
            DCliente obj = new DCliente();
            obj.Buscador = Buscador;
            return obj.BuscarClientes_Nombre(obj);
        }

        public static DataTable Buscar_ID(string Buscador)
        {
            DCliente obj = new DCliente();
            obj.Buscador = Buscador;
            return obj.BuscarClientes_ID(obj);
        }
    }
}
