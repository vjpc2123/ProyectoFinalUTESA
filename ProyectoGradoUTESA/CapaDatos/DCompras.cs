using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DCompras
    {

        
        #region Compra
        private int _idCompra;
        public int IDCompra { get => _idCompra; set => _idCompra = value; }
        private int _idProveedor;
        public int IDProveedor { get => _idProveedor; set => _idProveedor = value; }
        private string _NCFSuplidor;
        public string NCF { get => _NCFSuplidor; set => _NCFSuplidor = value; }
        private string _tipoDocumento;
        public string TipoDocumento { get => _tipoDocumento; set => _tipoDocumento = value; }
        private DateTime _fechaCompra;
        public DateTime FechaCompra { get => _fechaCompra; set => _fechaCompra = value; }
        
        #endregion

        #region DetalleCompra
        private int _idDetalleCompra;
        public int IDDetalleCompra { get => _idDetalleCompra; set => _idDetalleCompra = value; }
        private int _idCompra2;
        public int IDCompra2 { get => _idCompra2; set => _idCompra2 = value; }
        private int _idArticulo;
        public int IDArticulo { get => _idArticulo; set => _idArticulo = value; }
        private int _cantidad;
        public int Cantidad { get => _cantidad; set => _cantidad = value; }
        private decimal _costounitario;
        public decimal CostoUnitario { get => _costounitario; set => _costounitario = value; }
        private decimal _compraBruto;
        public decimal CompraBruto { get => _compraBruto; set => _compraBruto = value; }
        private decimal _descuento;
        public decimal Descuento { get => _descuento; set => _descuento = value; }
        private decimal _ITBIS;
        public decimal ITBIS { get => _ITBIS; set => _ITBIS = value; }
        private decimal _compraNeto;
        public decimal CompraNeto { get => _compraNeto; set => _compraNeto = value; }
     
        #endregion 
        public DCompras() { }
        public DCompras(int idcompra, int idproveedor, string ncf,string tipodocumento, DateTime fecha)
        {
            this.IDCompra = idcompra;
            this.IDProveedor = idproveedor;
            this.NCF = ncf;
            this.TipoDocumento = tipodocumento;
            this.FechaCompra = fecha;
        }
        public DCompras(int iddetallecompra,int idcompra2,int idarticulo,int cantidad, decimal costounitario,decimal comprabruto, decimal descuento,decimal itbis, decimal compraneto)
        {
            this.IDDetalleCompra = iddetallecompra;
            this.IDCompra2 = idcompra2;
            this.IDArticulo = idarticulo;
            this.Cantidad = cantidad;
            this.CostoUnitario = costounitario;
            this.CompraBruto = comprabruto;
            this.Descuento = descuento;
            this.ITBIS = itbis;
            this.CompraNeto = comprabruto;
        }

        
        public string InsertarCompra(DCompras Compras)
        {

            string retorno = "";
            
            Conexion con = new Conexion();

            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con.AbriConexion();
                cmd.CommandText = "INSERTAR_COMPRA";
                cmd.CommandType = CommandType.StoredProcedure;


                SqlParameter parId = new SqlParameter();
                parId.ParameterName = "@idCompra";
                parId.SqlDbType = SqlDbType.Int;
                parId.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(parId);

                SqlParameter parIDProveedor = new SqlParameter();
                parIDProveedor.ParameterName = "@idProveedor";
                parIDProveedor.SqlDbType = SqlDbType.Int;
                parIDProveedor.Value = Compras.IDProveedor;
                cmd.Parameters.Add(parIDProveedor);

                SqlParameter NumeroComprobante = new SqlParameter();
                NumeroComprobante.ParameterName = "@NumeroComprobante";
                NumeroComprobante.SqlDbType = SqlDbType.VarChar;
                NumeroComprobante.Size = 20;
                NumeroComprobante.Value = Compras.NCF;
                cmd.Parameters.Add(NumeroComprobante);

                SqlParameter parTipoDocumento = new SqlParameter();
                parTipoDocumento.ParameterName = "@TipoDocumento";
                parTipoDocumento.SqlDbType = SqlDbType.VarChar;
                parTipoDocumento.Size = 20;
                parTipoDocumento.Value = Compras.TipoDocumento;
                cmd.Parameters.Add(parTipoDocumento);

                SqlParameter parFechaCompra = new SqlParameter();
                parFechaCompra.ParameterName = "@FechaCompra";
                parFechaCompra.SqlDbType = SqlDbType.Date;
                parFechaCompra.Value = Compras.FechaCompra;
                cmd.Parameters.Add(parFechaCompra);
                

                retorno = cmd.ExecuteNonQuery() == 1 ? "Ok" : "No es posible ingresar los datos";
                
            }
            catch (Exception ex)
            {

                retorno = ex.Message;
            }
            finally { con.CerrarConexion(); }



            return retorno;

             
        }
        public string DevolverIDCompra()
        {
            string retorno = "";

            Conexion con = new Conexion();

            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con.AbriConexion();
                cmd.CommandText = "Devolver_IDCompra";
                cmd.CommandType = CommandType.StoredProcedure;
                retorno = Convert.ToString(cmd.ExecuteScalar()) ;
            }
            catch (Exception ex)
            {

                retorno = ex.Message;
            }
            finally { con.CerrarConexion(); }

            return retorno;

        }
        public string Insertar_DetalleCompra(DCompras Compras)
        {

            string retorno = "";
            Conexion con = new Conexion();

            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con.AbriConexion();
                cmd.CommandText = "INSERTAR_DETALLE_COMPRA";
                cmd.CommandType = CommandType.StoredProcedure;


                SqlParameter parId = new SqlParameter();
                parId.ParameterName = "@idDetalleCompra";
                parId.SqlDbType = SqlDbType.Int;
                parId.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(parId);

                SqlParameter paridCompra = new SqlParameter();
                paridCompra.ParameterName = "@idCompra";
                paridCompra.SqlDbType = SqlDbType.Int;
                paridCompra.Value = Compras.IDCompra2;
                cmd.Parameters.Add(paridCompra);

                SqlParameter paridArticulo = new SqlParameter();
                paridArticulo.ParameterName = "@idArticulo";
                paridArticulo.SqlDbType = SqlDbType.Int;
                paridArticulo.Value = Compras.IDArticulo;
                cmd.Parameters.Add(paridArticulo);

                SqlParameter parCantidad = new SqlParameter();
                parCantidad.ParameterName = "@cantidad";
                parCantidad.SqlDbType = SqlDbType.Int;
                parCantidad.Value = Compras.Cantidad;
                cmd.Parameters.Add(parCantidad);

                SqlParameter parCostoUnitario = new SqlParameter();
                parCostoUnitario.ParameterName = "@costoUnitario";
                parCostoUnitario.SqlDbType = SqlDbType.Decimal;             
                parCostoUnitario.Value = Compras.CostoUnitario;
                cmd.Parameters.Add(parCostoUnitario);

                SqlParameter parCostoBruto = new SqlParameter();
                parCostoBruto.ParameterName = "@CompraBruto";
                parCostoBruto.SqlDbType = SqlDbType.Decimal;
                parCostoBruto.Value = Compras.CompraBruto;
                cmd.Parameters.Add(parCostoBruto);

                SqlParameter parDescuento = new SqlParameter();
                parDescuento.ParameterName = "@CompraBruto";
                parDescuento.SqlDbType = SqlDbType.Decimal;
                parDescuento.Value = Compras.Descuento;
                cmd.Parameters.Add(parDescuento);

                SqlParameter parITBIS = new SqlParameter();
                parITBIS.ParameterName = "@CompraBruto";
                parITBIS.SqlDbType = SqlDbType.Decimal;
                parITBIS.Value = Compras.CompraBruto;
                cmd.Parameters.Add(parITBIS);

                SqlParameter parCompraNeto = new SqlParameter();
                parCompraNeto.ParameterName = "@CompraBruto";
                parCompraNeto.SqlDbType = SqlDbType.Decimal;
                parCompraNeto.Value = Compras.CompraNeto;
                cmd.Parameters.Add(parCompraNeto);



                retorno = cmd.ExecuteNonQuery() == 1 ? "Ok" : "No es posible ingresar los datos";
            }
            catch (Exception ex)
            {

                retorno = ex.Message;
            }
            finally { con.CerrarConexion(); }



            return retorno;
        }
    }
}
