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
    public partial class frmVistaSuplidor : Form
    {
        public frmVistaSuplidor()
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
                dtgvListado.DataSource = NSuplidor.Mostrar();
                dtgvListado.Columns[2].Visible = false;
                dtgvListado.Columns[1].Visible = false;
                lblTotal.Text = "Total de Registros: " + Convert.ToString(dtgvListado.RowCount);
            }
            catch (Exception ex)
            {

                MsgError(ex.ToString());
            }
        }
        private void BuscarNombre()
        {

            dtgvListado.DataSource = NSuplidor.Buscar_Nombre(mtxtbuscar.Text);
            dtgvListado.Columns[2].Visible = false;
            dtgvListado.Columns[1].Visible = false;
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dtgvListado.RowCount);
        }
        private void BuscarID()
        {

            dtgvListado.DataSource = NSuplidor.Buscar_ID(mtxtbuscar.Text);
            dtgvListado.Columns[2].Visible = false;
            dtgvListado.Columns[1].Visible = false;
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dtgvListado.RowCount);
        }
        private void Nombre_O_Descripcion()
        {
            if (cbBuscar.Text == "Nombre")
            {
                BuscarNombre();
            }
            else
            {
                BuscarID();
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

        private void cbBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbBuscar.Text == "Cedula")
            {
                mtxtbuscar.Mask = "000-0000000-0";
            }
            else if (cbBuscar.Text == "RNC")
            {
                mtxtbuscar.Mask = "000-00000-0";
            }
            else
            {
                mtxtbuscar.Mask = "";
            }
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

        private void frmVistaSuplidor_Load(object sender, EventArgs e)
        {
            MostrarDatos();
            DisDTGV();
        }

        private void dtgvListado_DoubleClick(object sender, EventArgs e)
        {

            try
            {
                frmCompra frm = frmCompra.getinstancia();
                string par1, par2;
                par1 = Convert.ToString(dtgvListado.CurrentRow.Cells["Codigo"].Value);
                par2 = Convert.ToString(dtgvListado.CurrentRow.Cells["Nombre"].Value);
                frm.setterSuplidor(par1, par2);
                this.Hide();
            }
            catch (Exception)
            {

            }
        }
    }
}
