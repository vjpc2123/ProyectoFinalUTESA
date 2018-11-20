using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocios
{
    public class NCompras

    {
        public static string IngresarCompra(int idcompra, int idproveedor, string NCF, string tipoDocumento, DateTime fechaCompra)
        {
            DCompras obj = new DCompras();
            obj.IDCompra = idcompra;
            obj.IDProveedor = idproveedor;
            obj.NCF = NCF;
            obj.TipoDocumento = tipoDocumento;
            obj.FechaCompra = fechaCompra;
            return obj.InsertarCompra(obj);
        }
    }

}
