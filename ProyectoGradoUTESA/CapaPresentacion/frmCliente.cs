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
            txtDireccion.Clear();
            txtCodigo.Clear();
            cbEstado.Text = "Activo";
            txtApellido.Clear();
            txtTelefono.Clear();
            cbITdentificacion.Text = "--Seleccionar--";
            txtNOIdentificacion.Clear();
            cbCuidad.Text = "--Seleccionar--";
            cbSector.Text = "--Seleccionar--";
            txtNombreContactor.Clear();
            txtTelefonoContacto.Clear();
            txtCorreo.Clear();
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
            txtDireccion.ReadOnly = !stado;
            cbEstado.Enabled = stado;
            txtApellido.ReadOnly = !stado;
            txtTelefono.ReadOnly = !stado;
            cbITdentificacion.Enabled = stado;
            txtNOIdentificacion.ReadOnly = !stado;
            cbCuidad.Enabled = stado;
            cbSector.Enabled = stado;
            txtNombreContactor.ReadOnly = !stado;
            txtTelefonoContacto.ReadOnly = !stado;
            txtCorreo.ReadOnly = !stado;
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
                dtgvCategorias.DataSource = NSuplidor.Mostrar();
                dtgvCategorias.Columns[2].Visible = false;
                dtgvCategorias.Columns[1].Visible = false;
                lblTotal.Text = "Total de Registros: " + Convert.ToString(dtgvCategorias.RowCount);
            }
            catch (Exception ex)
            {

                MsgError(ex.ToString());
            }
        }
        private void BuscarNombre()
        {

            dtgvCategorias.DataSource = NSuplidor.Buscar_Nombre(mtxtbuscar.Text);
            dtgvCategorias.Columns[2].Visible = false;
            dtgvCategorias.Columns[1].Visible = false;
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dtgvCategorias.RowCount);
        }
        private void BuscarID()
        {

            dtgvCategorias.DataSource = NSuplidor.Buscar_ID(mtxtbuscar.Text);
            dtgvCategorias.Columns[2].Visible = false;
            dtgvCategorias.Columns[1].Visible = false;
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dtgvCategorias.RowCount);
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

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbEstado_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbITdentificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            DisDTGV();
            txtCodigo.ReadOnly = true;
            MostrarDatos();
            Habilitar(false);
            HoB_btn();
        }

        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_BUTTON, HT_Caption, 0);
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
                MsgError("Debe seleccionar una forma de búsqueda");
            }

            if (dtgvCategorias.RowCount == 0)
            {
                MsgError("No se encuentran datos con las características indicadas.");
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            N = true;
            E = false;
            HoB_btn();
            limpiar();
            Habilitar(true);
            txtNombre.Focus();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                ErrorIcono.Clear();

                string msgRespuesta = "";
                if (txtNombre.Text == "" || cbITdentificacion.Text == "--Seleccionar--" || txtNOIdentificacion.Text == "   -       -" || txtNOIdentificacion.Text == "   -     -" || txtNombreContactor.Text == "")
                {
                    MsgError("Debe ingresar los datos correctamente para continuar: ");
                }
                if (cbITdentificacion.Text == "--Seleccionar--")
                {
                    ErrorIcono.SetError(cbITdentificacion, "Debe Seleccionar un Tipo de Identificacion");
                }
                if (txtNOIdentificacion.Text == string.Empty && cbITdentificacion.Text == "Pasaporte")
                {
                    ErrorIcono.SetError(txtNOIdentificacion, "Debe ingresar un Pasaporte");
                }

                if (txtNOIdentificacion.Text == "   -       -")
                {
                    ErrorIcono.SetError(txtNOIdentificacion, "Debe ingresar una Cedula");
                }
                if (txtNOIdentificacion.Text == "   -     -")
                {
                    ErrorIcono.SetError(txtNOIdentificacion, "Debe ingresar una RNC");
                }
                if (txtApellido.Text == "")
                    {
                        ErrorIcono.SetError(txtApellido, "Debe ingresar un Apellido");
                    }
                if (txtNombre.Text == "")
                {
                    ErrorIcono.SetError(txtNombre, "Debe ingresar un Nombre del Cliente");
                }
                if (txtNombreContactor.Text == "")
                {
                    ErrorIcono.SetError(txtNombreContactor, "Debe ingresar un Contacto");
                }


                else
                {
                    if (N == true)
                    {
                        msgRespuesta = NCliente.Ingresar(cbEstado.Text, txtNombre.Text, txtApellido.Text, txtTelefono.Text, txtDireccion.Text, cbCuidad.Text, cbSector.Text, txtNombreContactor.Text, txtTelefonoContacto.Text, cbITdentificacion.Text, txtNOIdentificacion.Text, txtCorreo.Text);
                    }
                    else
                    {
                        msgRespuesta = NCliente.Modificar(Convert.ToInt32(txtCodigo.Text), cbEstado.Text, txtNombre.Text, txtApellido.Text, txtTelefono.Text, txtDireccion.Text, cbCuidad.Text, cbSector.Text, txtNombreContactor.Text, txtTelefonoContacto.Text, cbITdentificacion.Text, txtNOIdentificacion.Text, txtCorreo.Text);
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

        private void cbITdentificacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbITdentificacion.Text == "Cedula")
            {
                txtNOIdentificacion.Mask = "000-0000000-0";
            }
            else
            {
                txtNOIdentificacion.Mask = "";
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Equals(""))
            {
                MsgError("Debe Seleccionar que registro va a editar");
            }
            else
            {
                E = true;
                HoB_btn();
                Habilitar(true);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            N = false;
            E = false;
            HoB_btn();
            limpiar();
            Habilitar(false);
            ErrorIcono.Clear();
        }

        private void dtgvCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewCheckBoxCell chkEliminar = (DataGridViewCheckBoxCell)dtgvCategorias.Rows[e.RowIndex].Cells["Eliminar"];
                chkEliminar.Value = !Convert.ToBoolean(chkEliminar.Value);
            }
            catch (Exception)
            {


            }
        }

        private void dtgvCategorias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                N = false;
                E = false;
                HoB_btn();
                limpiar();
                Habilitar(false);
                txtCodigo.Text = Convert.ToString(dtgvCategorias.CurrentRow.Cells["Codigo"].Value);
                cbEstado.Text = Convert.ToString(dtgvCategorias.CurrentRow.Cells["Estatus"].Value);
                txtNombre.Text = Convert.ToString(dtgvCategorias.CurrentRow.Cells["Nombre"].Value);
                txtApellido.Text = Convert.ToString(dtgvCategorias.CurrentRow.Cells["Apellido"].Value);
                cbITdentificacion.Text = Convert.ToString(dtgvCategorias.CurrentRow.Cells["Documento"].Value);
                txtNOIdentificacion.Text = Convert.ToString(dtgvCategorias.CurrentRow.Cells["Identificacion"].Value);
                txtTelefono.Text = Convert.ToString(dtgvCategorias.CurrentRow.Cells["Telefono"].Value);
                txtDireccion.Text = Convert.ToString(dtgvCategorias.CurrentRow.Cells["Direccion"].Value);
                cbCuidad.Text = Convert.ToString(dtgvCategorias.CurrentRow.Cells["Ciudad"].Value);
                cbSector.Text = Convert.ToString(dtgvCategorias.CurrentRow.Cells["Sector"].Value);
                txtNombreContactor.Text = Convert.ToString(dtgvCategorias.CurrentRow.Cells["Contacto"].Value);
                txtTelefonoContacto.Text = Convert.ToString(dtgvCategorias.CurrentRow.Cells["TelefonoContacto"].Value);
                txtCorreo.Text = Convert.ToString(dtgvCategorias.CurrentRow.Cells["CorreoElectronico"].Value);
                if (Convert.ToString(dtgvCategorias.CurrentRow.Cells["TipoSuplidor"].Value) == "Persona")
                tcCategoria.SelectedIndex = 1;
            }
            catch (Exception)
            {


            }
        }

        private void cbBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBuscar.Text == "Cedula")
            {
                mtxtbuscar.Mask = "000-0000000-0";
            }
            else
            {
                mtxtbuscar.Mask = "";
            }

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {

            int comparar = dtgvCategorias.RowCount;
            DialogResult Result = MessageBox.Show("Desea Eliminar los registros seleccionados?", "Sistema Facturacion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (Result == DialogResult.Yes)
            {
                N = false;
                E = false;
                HoB_btn();
                limpiar();

                Habilitar(false);
                try
                {
                    string Codigo;
                    string Respuesta = "";
                    foreach (DataGridViewRow row in dtgvCategorias.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToString(row.Cells[1].Value);
                            Respuesta = NCliente.Eliminar(Convert.ToInt32(Codigo));
                            if (Respuesta != ("Ok"))
                            { MsgError(Respuesta); }
                        }

                    }
                    MostrarDatos();
                    if (comparar != dtgvCategorias.RowCount)
                    {
                        MsgConfirmacion("Se han eliminado los datos correctamente");
                        mtxtbuscar.Text = "";
                    }
                    else
                    {
                        MsgError("Debe seleccionar los campos que desea eliminar");
                        mtxtbuscar.Text = "";
                    }
                    SelectAll.Checked = false;
                    MostrarDatos();

                    {

                    }

                }

                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message + ex.StackTrace);
                }

            }
        }

        private void SelectAll_CheckedChanged(object sender, EventArgs e)
        {

            if (SelectAll.Checked == true)
            {
                for (int i = 0; i <= dtgvCategorias.Rows.Count - 1; i++)
                {
                    dtgvCategorias.Rows[i].Cells[0].Value = true;
                }
            }
            else
            {
                for (int i = 0; i <= dtgvCategorias.Rows.Count - 1; i++)
                {
                    dtgvCategorias.Rows[i].Cells[0].Value = false;
                }
            }
        }
    }
}
