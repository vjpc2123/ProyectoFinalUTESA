using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        private bool N = false;
        private bool E = false;

        private void limpiar()
        {
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtCodigo.Clear();
            txtNombre.Focus();
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
            txtNombre.ReadOnly = !stado;
            txtDescripcion.ReadOnly = !stado;
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

            }
            else
            {
                Habilitar(false);
                btnNuevo.Enabled = true;
                btnGrabar.Enabled = false;
                btnEditar.Enabled = true;
                btnLimpiar.Enabled = false;
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
            frmVistaDetalleCompra frm = frmVistaDetalleCompra.getinstancia();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void frmCompra_Load(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
