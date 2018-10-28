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

namespace CapaPresentacion.Vistas
{
    public partial class frmVistaUbicacion : Form
    {
        public frmVistaUbicacion()
        {
            InitializeComponent();
        }

        private void DisDTGV()//Metodo Dis DataGridView
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
        private void MsgConfirmacion(string Msg)
        {
            MessageBox.Show(Msg, "Sistema Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void MsgError(string Msg)
        {
            MessageBox.Show(Msg, "Sistema Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void MostrarDatos()
        {
            try
            {
                dtgvListado.DataSource = NUbicacion.Mostrar();
                dtgvListado.Columns[2].Width = 300;
                dtgvListado.Columns[1].Width = 250;

            }
            catch (Exception ex)
            {

                MsgError(ex.ToString());
            }
        }
        private void BuscarNombre()
        {

            dtgvListado.DataSource = NUbicacion.Buscar_Nombre(mtxtbuscar.Text);
            dtgvListado.Columns[2].Width = 300;
            dtgvListado.Columns[1].Width = 250;
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dtgvListado.RowCount);
        }
        private void BuscarDescripcion()
        {

            dtgvListado.DataSource = NUbicacion.Buscar_Descripcion(mtxtbuscar.Text);
            dtgvListado.Columns[2].Width = 300;
            dtgvListado.Columns[1].Width = 250;
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
        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cbBuscar.Text != "--Seleccionar--")
            {
                Nombre_O_Descripcion();
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

        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_BUTTON, HT_Caption, 0);
            }
        }

        private void frmVistaUbicacion_Load(object sender, EventArgs e)
        {
            MostrarDatos();
            DisDTGV();
        }

        private void dtgvListado_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                frmArticulo frm = frmArticulo.getinstancia();
                string par1, par2;
                par1 = Convert.ToString(dtgvListado.CurrentRow.Cells["Codigo"].Value);
                par2 = Convert.ToString(dtgvListado.CurrentRow.Cells["Nombre"].Value);
                frm.setterUbicacion(par1, par2);
                this.Hide();
            }
            catch (Exception)
            {

            }
        }
    }
}
