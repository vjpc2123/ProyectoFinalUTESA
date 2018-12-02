using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocios;
namespace CapaPresentacion
{
    public partial class frmCompra : Form
    {
        public frmCompra()
        {
            InitializeComponent();
        }
        public static frmCompra _instancia;
        public static frmCompra getinstancia()
        {
            if (_instancia == null)
            {

                _instancia = new frmCompra();
            }

            return _instancia;
        }

        public void setterSuplidor(string id, string Nombre)
        {
            txtSuplidorNombre.Text = Nombre;
            txtIDSuplidor.Text = id;
        }
        private bool N = false;
        private bool E = false;

        private void MsgConfirmacion(string Msg)
        {
            MessageBox.Show(Msg, "Sistema Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void MsgError(string Msg)
        {
            MessageBox.Show(Msg, "Sistema Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void limpiar()
        {
            txtCodigoC.Clear();
           txtIDSuplidor.Clear();
            txtSuplidorNombre.Clear();
            txtNCFSuplidor.Clear();
            txtDetalles.Clear();
        }
        private void DisDTGV()
        {
            dtgvListado.BorderStyle = BorderStyle.Fixed3D;
            dtgvListado.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dtgvListado.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dtgvListado.DefaultCellStyle.SelectionBackColor = Color.FromArgb(147, 177, 215);
            dtgvListado.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dtgvListado.BackgroundColor = Color.FromArgb(171, 171, 171);

            dtgvListado.EnableHeadersVisualStyles = false;
            dtgvListado.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dtgvListado.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(28, 28, 28);
            dtgvListado.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

        }
        private void Habilitar(bool stado)
        {
            txtSuplidorNombre.ReadOnly = !stado;
            txtNCFSuplidor.ReadOnly = !stado;
            txtDetalles.ReadOnly = !stado;
        }
        private void HoB_btn()
        {
            if (N || E)
            {
                Habilitar(true);
                btnNuevo.Enabled = false;
                btnGrabar.Enabled = true;
                btnEditar.Enabled = false;
                btnLimpiar.Enabled = true;
                btnAgregar.Enabled = true;
                btnRemover.Enabled = true;

            }
            else
            {
                Habilitar(false);
                btnNuevo.Enabled = true;
                btnGrabar.Enabled = false;
                btnEditar.Enabled = true;
                btnLimpiar.Enabled = false;
                btnRemover.Enabled = false;
                btnAgregar.Enabled = false;
            }
        }

        private void MostrarDatos()
        {
            try
            {
                dtgvListado.DataSource = NPresentacion.Mostrar();
                dtgvListado.Columns[3].Width = 300;
                dtgvListado.Columns[2].Width = 250;
                lblTotal.Text = "Total de Registros: " + Convert.ToString(dtgvListado.RowCount);
            }
            catch (Exception ex)
            {

                MsgError(ex.ToString());
            }
        }
        private void BuscarNombre()
        {

            dtgvListado.DataSource = NPresentacion.Buscar_Nombre(mtxtbuscar.Text);
            dtgvListado.Columns[3].Width = 300;
            dtgvListado.Columns[2].Width = 250;
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dtgvListado.RowCount);
        }
        private void BuscarDescripcion()
        {

            dtgvListado.DataSource = NPresentacion.Buscar_Descripcion(mtxtbuscar.Text);
            dtgvListado.Columns[3].Width = 300;
            dtgvListado.Columns[2].Width = 250;
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dtgvListado.RowCount);
        }
        private void Nombre_O_Descripcion()
        {
            if (cbBuscar.Text == "Nombre")
            {
                BuscarNombre();
            }
            else if (cbBuscar.Text == "Descripcion")
            {
                BuscarDescripcion();
            }

        }

        public const int WM_BUTTON = 0xA1;
        public const int HT_Caption = 0x2;

        [DllImportAttribute("user32.dll")]

        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void btnNuevo_Click(object sender, EventArgs e)
        {



            try
            {
                ErrorIcono.Clear();

                string msgRespuesta = "";
                if (txtIDSuplidor.Text == "" || txtSuplidorNombre.Text == "" || txtNCFSuplidor.Text == "" || txtDetalles.Text == "")
                {
                    MsgError("Debe ingresar los datos correctamente para continuar: ");
                }
                if (txtIDSuplidor.Text == string.Empty)
                {
                    ErrorIcono.SetError(txtSuplidorNombre, "Debe ingresar un Suplidor");
                }
                if (txtNCFSuplidor.Text == string.Empty)
                {
                    ErrorIcono.SetError(txtNCFSuplidor, "Debe Ingresar un NCF");
                }

                else
                {
                    if (N == true)
                    {
                        msgRespuesta = NCompras.IngresarCompra(Convert.ToInt32(txtIDSuplidor.Text), txtNCFSuplidor.Text, dtpfecha.Value, txtDetalles.Text);
                    }
                    else
                    {
                        //   msgRespuesta = NPresentacion.ModificarPresentacion(Convert.ToInt32(txtCodigo.Text), txtNombre.Text.Trim(), txtDescripcion.Text.Trim());
                    }
                    if (msgRespuesta.Equals("Ok"))
                    {
                        if (N)
                        {
                            txtCodigoC.Text = NCompras.DevolverIDCompra();
                            frmVistaDetalleCompra frm = frmVistaDetalleCompra.getinstancia();
                            frm.ShowDialog();
                        }
                        else
                        {
                            MsgConfirmacion("Se han editado los datos correctamente");
                        }
                        N = false;
                        E = false;
                       
                     
                        MostrarDatos();
                        ErrorIcono.Clear();
                    }
                    else { MsgError(msgRespuesta); }
                }
            }

            catch (Exception ex)
            {

                MsgError(ex.Message + ex.StackTrace);
            }

         
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            frmVistaSuplidor frm = new frmVistaSuplidor();
            frm.ShowDialog();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void frmCompra_Load(object sender, EventArgs e)
        {
            DisDTGV();
            txtCodigoC.ReadOnly = true;
            MostrarDatos();
            Habilitar(false);
            HoB_btn();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            N = true;
            E = false;
            HoB_btn();
            limpiar();
            Habilitar(true);
            txtSuplidorNombre.Focus();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {

            try
            {
                ErrorIcono.Clear();

                string msgRespuesta = "";
                if (txtIDSuplidor.Text == "" || txtSuplidorNombre.Text == "" || txtNCFSuplidor.Text == "" || txtDetalles.Text == "")
                {
                    MsgError("Debe ingresar los datos correctamente para continuar: ");
                }
                if (txtIDSuplidor.Text == string.Empty)
                {
                    ErrorIcono.SetError(txtSuplidorNombre, "Debe ingresar un Suplidor");
                }
                if (txtNCFSuplidor.Text == string.Empty)
                {
                    ErrorIcono.SetError(txtNCFSuplidor, "Debe Ingresar un NCF");
                }
               
                else
                {
                    if (N == true)
                    {
                        msgRespuesta = NCompras.IngresarCompra(Convert.ToInt32(txtIDSuplidor.Text),txtNCFSuplidor.Text,dtpfecha.Value,txtDetalles.Text);
                    }
                    else
                    {
                    //   msgRespuesta = NPresentacion.ModificarPresentacion(Convert.ToInt32(txtCodigo.Text), txtNombre.Text.Trim(), txtDescripcion.Text.Trim());
                    }
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
                }
            }

            catch (Exception ex)
            {

                MsgError(ex.Message + ex.StackTrace);
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtSuplidorNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIDSuplidor_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
