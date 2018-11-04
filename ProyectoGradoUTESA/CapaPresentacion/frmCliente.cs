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
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }
        #region Codigos Predeterminados.
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
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtCodigo.Clear();
            txtNombre.Focus();
        }
        private void DisDTGV()//Metodo Dis DataGridView
        {
            dtgvCategorias.BorderStyle = BorderStyle.Fixed3D;
            dtgvCategorias.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dtgvCategorias.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dtgvCategorias.DefaultCellStyle.SelectionBackColor = Color.FromArgb(147, 177, 215);
            dtgvCategorias.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dtgvCategorias.BackgroundColor = Color.FromArgb(171, 171, 171);

            dtgvCategorias.EnableHeadersVisualStyles = false;
            dtgvCategorias.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dtgvCategorias.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(28, 28, 28);
            dtgvCategorias.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

        }
        private void Habilitar(bool stado)//Habilitar o deshabilitar Txt
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

        

        public const int WM_BUTTON = 0xA1;
        public const int HT_Caption = 0x2;

        [DllImportAttribute("user32.dll")]

        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        #endregion
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
