using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocios;

namespace CapaPresentacion
{
    public partial class frmVistaDetalleCompra : Form
    {
        public frmVistaDetalleCompra()
        {
            InitializeComponent();
        }

        public static frmVistaDetalleCompra _instancia;
        public static frmVistaDetalleCompra getinstancia()
        {
            if (_instancia == null)
            {

                _instancia = new frmVistaDetalleCompra();
            }

            return _instancia;
        }
        private void tpDetalle_Click(object sender, EventArgs e)
        {

        }

        public void setterArticulos(string id, string Nombre)
        {
            txtNombre.Text = Nombre;
            txtIDArticulo.Text = id;
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            frmVistaArticulo frm = new frmVistaArticulo();
            frm.ShowDialog();
        }

        private void frmVistaDetalleCompra_Load(object sender, EventArgs e)
        {
            txtCodigo.Enabled = false;
        }

        private void txtIDArticulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtDescuento_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            
            
        }


        private void MsgConfirmacion(string Msg)
        {
            MessageBox.Show(Msg, "Sistema Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void MsgError(string Msg)
        {
            MessageBox.Show(Msg, "Sistema Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txtDescuento_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int valor = Convert.ToInt32(txtDescuento.Text);
                if (valor > 50)
                {
                    MsgError("El porcentaje no puede ser mayor al 50% del articulo.");
                    txtDescuento.Text = "0";
                }
            }
            catch (Exception)
            {

              
            }
           
        }
        int descuento = 0;
        private void txtDescuento_Leave(object sender, EventArgs e)
        {
            try
            {
                descuento = Convert.ToInt32(txtDescuento.Text);
                txtDescuento.Text = descuento.ToString() + "%";
            }
            catch (Exception)
            {

              
            }
            
        }

        decimal costo;

        private void txtCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar.ToString().Equals("."))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                
            }

           

        }

        private void txtCosto_Leave(object sender, EventArgs e)
        {
            try
            {
                costo = Convert.ToDecimal(txtCosto.Text);
                txtCosto.Text = costo.ToString("0.000") + " RD$";
            }
            catch (Exception)
            {


            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                ErrorIcono.Clear();

                string msgRespuesta = "";
                if (txtIDArticulo.Text == "" || txtNombre.Text == "" || txtCantidad.Text == "" || txtCosto.Text == "" || txtDescuento.Text == "")
                {
                    MsgError("Debe ingresar los datos correctamente para continuar: ");
                }
                if (txtNombre.Text == string.Empty)
                {
                    ErrorIcono.SetError(txtNombre, "Debe seleccionar un articulo");
                }
                if (txtCantidad.Text == string.Empty)
                {
                    ErrorIcono.SetError(txtCantidad, "Debe Ingresar una Cantidad");
                }
                if (txtCosto.Text == string.Empty)
                {
                    ErrorIcono.SetError(txtCosto, "Debe Ingresar el costo del producto");
                }
                if (txtDescuento.Text == string.Empty)
                {
                    ErrorIcono.SetError(txtDescuento, "Debe el porcentade de descuento");
                }
               

                else
                {
                   /*
                        msgRespuesta = NCompras.IngresarDetalleCompra(txtNombre.Text.Trim(), txtDescripcion.Text.Trim(), txtCategoriaID.Text, txtPresentacionID.Text, txtUbicacionID.Text, txtMarcaID.Text, imagen);
                    
                    
                    if (msgRespuesta.Equals("Ok"))
                    {
                        if (N)
                        {
                            MsgConfirmacion("Se han guardado los datos correctamente");
                        }
                        else
                        {
                            MsgConfirmacion("Se han editado los datos correctamente");
                        }
                        N = false;
                        E = false;
                        HoB_btn();
                        limpiar();
                        MostrarDatos();
                        ErrorIcono.Clear();
                    }
                    else { MsgError(msgRespuesta); }
                */}
            }

            catch (Exception ex)
            {

                MsgError(ex.Message + ex.StackTrace);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }


