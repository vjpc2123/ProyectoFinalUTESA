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

        public static string IngresarDetalleCompra(int iddetallecompra,int idcompra2,int idarticulo,int cantidad,decimal costounitario,decimal comprabruto,decimal descuento, decimal itbis, decimal compraneto)
        {
            DCompras obj = new DCompras();
            obj.IDDetalleCompra = iddetallecompra;
            obj.IDCompra2 = idcompra2;
            obj.IDArticulo = idarticulo;
            obj.Cantidad = cantidad;
            obj.CostoUnitario = costounitario;
            obj.CompraBruto = comprabruto;
            obj.Descuento = descuento;
            obj.ITBIS = itbis;
            obj.CompraNeto = compraneto;
            return obj.Insertar_DetalleCompra(obj);
        }

        public static string DevolverIDCompra()
        {
            DCompras obj = new DCompras();
            return obj.DevolverIDCompra();
        }
    }

}
