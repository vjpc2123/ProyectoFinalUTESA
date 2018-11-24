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
    public partial class frmVistaArticulo : Form
    {
        public frmVistaArticulo()
        {
            InitializeComponent();
        }

        private void MsgConfirmacion(string Msg)
        {
            MessageBox.Show(Msg, "Sistema Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void MsgError(string Msg)
        {
            MessageBox.Show(Msg, "Sistema Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void MostrarDatos()
        {
            try
            {
                dtgvListado.DataSource = NArticulo.Mostar();
                lblTotal.Text = "Total de Registros: " + Convert.ToString(dtgvListado.RowCount);
            }
            catch (Exception ex)
            {

                MsgError(ex.ToString());
            }
        }

        private void BuscarCodigo()
        {
            try
            {
                dtgvListado.DataSource = NArticulo.BuscarCodigoArticulo(mtxtbuscar.Text);
                lblTotal.Text = "Total de Registros: " + Convert.ToString(dtgvListado.RowCount);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void BuscarNombre()
        {
            try
            {
                dtgvListado.DataSource = NArticulo.BuscarNombreArticulo(mtxtbuscar.Text);
                lblTotal.Text = "Total de Registros: " + Convert.ToString(dtgvListado.RowCount);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void BuscarCategoria()
        {
            try
            {
                dtgvListado.DataSource = NArticulo.BuscarCategoriaArticulo(mtxtbuscar.Text);
                lblTotal.Text = "Total de Registros: " + Convert.ToString(dtgvListado.RowCount);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void BuscarPresentacion()
        {
            try
            {
                dtgvListado.DataSource = NArticulo.BuscarPresentacionArticulo(mtxtbuscar.Text);
                lblTotal.Text = "Total de Registros: " + Convert.ToString(dtgvListado.RowCount);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }


        private void BuscarMarca()
        {
            try
            {
                dtgvListado.DataSource = NArticulo.BuscarMarcaArticulo(mtxtbuscar.Text);
                lblTotal.Text = "Total de Registros: " + Convert.ToString(dtgvListado.RowCount);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void BuscarUbicacion()
        {
            try
            {
                dtgvListado.DataSource = NArticulo.BuscarMarcaArticulo(mtxtbuscar.Text);
                lblTotal.Text = "Total de Registros: " + Convert.ToString(dtgvListado.RowCount);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        public const int WM_BUTTON = 0xA1;
        public const int HT_Caption = 0x2;

        [DllImportAttribute("user32.dll")]

        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void buscar()
        {

            if (cbBuscar.Text == "Nombre")
            {
                BuscarNombre();
            }
            else if (cbBuscar.Text == "Codigo")
            {
                BuscarCodigo();
            }
            else if (cbBuscar.Text == "Categoria")
            {
                BuscarCategoria();
            }
            else if (cbBuscar.Text == "Marca")
            {
                BuscarMarca();
            }
            else if (cbBuscar.Text == "Presentacion")
            {
                BuscarPresentacion();
            }
            else if (cbBuscar.Text == "Ubicacion")
            {
                BuscarUbicacion();
            }
            else
            { MsgError("Debe Seleccionar una forma de Busqueda"); }
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cbBuscar.Text != "--Seleccionar--")
            {
                buscar();
            }
            else
            {
                MsgError("Debe Seleccionar Una forma de Busqueda");
            }

            if (dtgvListado.RowCount == 0)
            {
                MsgError("No se encuentran datos con las caracteristicas indicadas.");
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmVistaDetallesCompra_Load(object sender, EventArgs e)
        {
            DisDTGV();
         
            MostrarDatos();
        }

        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_BUTTON, HT_Caption, 0);
            }
        }

        private void dtgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgvListado_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                frmVistaDetalleCompra frm = frmVistaDetalleCompra.getinstancia();
                string par1, par2;
                par1 = Convert.ToString(dtgvListado.CurrentRow.Cells["Codigo"].Value);
                par2 = Convert.ToString(dtgvListado.CurrentRow.Cells["Nombre"].Value);
                frm.setterArticulos(par1, par2);
                this.Hide();
            }
            catch (Exception)
            {

            }
        }
    }
}
