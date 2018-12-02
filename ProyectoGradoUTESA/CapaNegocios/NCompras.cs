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
        public static string IngresarCompra( int idproveedor, string NCF, DateTime fechaCompra,string detalles)
        {
            DCompras obj = new DCompras();
            obj.IDProveedor = idproveedor;
            obj.NCF = NCF;
            obj.FechaCompra = fechaCompra;
            obj.Detalles = detalles;
            return obj.InsertarCompra(obj);
        }

        public static string IngresarDetalleCompra(int idcompra2,int idarticulo,int cantidad,decimal costounitario,decimal comprabruto,decimal descuento, decimal itbis, decimal compraneto)
        {
            DCompras obj = new DCompras();
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
