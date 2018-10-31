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
    public partial class frmArticulo : Form
    {
        
        public frmArticulo()
        {
            InitializeComponent();
        }
        #region Clases a Utilizar  
        private bool N = false;
        private bool E = false;

        public static frmArticulo _instancia;
        public static frmArticulo getinstancia()
        {
            if (_instancia == null)
            {

                _instancia = new frmArticulo();
            }

            return _instancia;
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

        private void limpiar()
        {
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtCategoriaID.Clear();
            txtCategoria.Clear();
            txtPresentacionID.Clear();
            txtPresentacion.Clear();
            txtMarcaID.Clear();
            txtMarca.Clear();
            txtUbicacion.Clear();
            txtUbicacionID.Clear();
            txtCodigo.Clear();
            pbImagen.Image = global::CapaPresentacion.Properties.Resources.Gallery_100px;
            pbImagen.SizeMode = PictureBoxSizeMode.CenterImage;
            txtNombre.Focus();
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
                btnCategoria.Enabled = true;
                btnMarca.Enabled = true;
                btnPresentacion.Enabled = true;
                btnUbicacion.Enabled = true;
                btnAddFoto.Enabled = true;
                btnRemoveFoto.Enabled = true;

            }
            else
            {
                Habilitar(false);
                btnNuevo.Enabled = true;
                btnGrabar.Enabled = false;
                btnEditar.Enabled = true;
                btnLimpiar.Enabled = false;
                btnCategoria.Enabled = false;
                btnMarca.Enabled = false;
                btnPresentacion.Enabled = false;
                btnUbicacion.Enabled = false;
                btnAddFoto.Enabled = false;
                btnRemoveFoto.Enabled = false;
            }
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


        #endregion

        public void setterCategoria(string id, string Nombre)
        {
            txtCategoria.Text = Nombre;
            txtCategoriaID.Text = id;
        }
        public void setterMarca(string id, string Nombre)
        {
            txtMarca.Text = Nombre;
            txtMarcaID.Text = id;
        }
        public void setterPresentacion(string id, string Nombre)
        {
            txtPresentacion.Text = Nombre;
            txtPresentacionID.Text = id;
        }
        public void setterUbicacion(string id, string Nombre)
        {
            txtUbicacion.Text = Nombre;
            txtUbicacionID.Text = id;
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_BUTTON, HT_Caption, 0);
            }
        }

        private void cbBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
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
                if (txtNombre.Text == "" || txtDescripcion.Text == ""||txtCategoria.Text == ""|| txtPresentacion.Text == "" ||txtUbicacion.Text == ""||txtMarca.Text == "")
                {
                    MsgError("Debe ingresar los datos correctamente para continuar: ");
                }
                if (txtNombre.Text == string.Empty)
                {
                    ErrorIcono.SetError(txtNombre, "Debe ingresar un nombre");
                }
                if (txtDescripcion.Text == string.Empty)
                {
                    ErrorIcono.SetError(txtDescripcion, "Debe Ingresar una Descripcion");
                }
                if (txtCategoria.Text == string.Empty)
                {
                    ErrorIcono.SetError(txtCategoria, "Debe Ingresar una Categoria");
                }
                if (txtPresentacion.Text == string.Empty)
                {
                    ErrorIcono.SetError(txtPresentacion, "Debe Ingresar una Presentacion");
                }
                if (txtUbicacion.Text == string.Empty)
                {
                    ErrorIcono.SetError(txtUbicacion, "Debe Ingresar una Ubicacion");
                }
                if (txtMarca.Text == string.Empty)
                {
                    ErrorIcono.SetError(txtMarca, "Debe Ingresar una Marca");
                }
               
                else
                {
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    pbImagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    pbImagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] imagen = ms.GetBuffer();
                    if (N == true)
                    {
                        msgRespuesta = NArticulo.Insertar(txtNombre.Text.Trim(), txtDescripcion.Text.Trim(),txtCategoriaID.Text,txtPresentacionID.Text,txtUbicacionID.Text,txtMarcaID.Text,imagen);
                    }
                    else
                    {
                        msgRespuesta = NArticulo.Editar(txtCodigo.Text,txtNombre.Text.Trim(),txtDescripcion.Text.Trim(),txtCategoriaID.Text,txtPresentacionID.Text,txtUbicacionID.Text,txtMarcaID.Text,imagen);
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

        private void dtgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewCheckBoxCell chkEliminar = (DataGridViewCheckBoxCell)dtgvListado.Rows[e.RowIndex].Cells["Eliminar"];
                chkEliminar.Value = !Convert.ToBoolean(chkEliminar.Value);
            }
            catch (Exception)
            {


            }
        }

        private void dtgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                N = false;
                E = false;
                HoB_btn();
                limpiar();
                Habilitar(false);
                txtCodigo.Text = Convert.ToString(dtgvListado.CurrentRow.Cells["Codigo"].Value);
                txtNombre.Text = Convert.ToString(dtgvListado.CurrentRow.Cells["Nombre"].Value);
                txtDescripcion.Text = Convert.ToString(dtgvListado.CurrentRow.Cells["Descripcion"].Value);
                tcProyecto.SelectedIndex = 1;
            }
            catch (Exception)
            {


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

        private void SelectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (SelectAll.Checked == true)
            {
                for (int i = 0; i <= dtgvListado.Rows.Count - 1; i++)
                {
                    dtgvListado.Rows[i].Cells[0].Value = true;
                }
            }
            else
            {
                for (int i = 0; i <= dtgvListado.Rows.Count - 1; i++)
                {
                    dtgvListado.Rows[i].Cells[0].Value = false;
                }
            }

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void frmArticulo_Load(object sender, EventArgs e)
        {
            DisDTGV();
            txtCodigo.ReadOnly = true;
            MostrarDatos();
            Habilitar(false);
            HoB_btn();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmVistaCategoria categorias = new frmVistaCategoria();
            categorias.ShowDialog();
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmArticulo_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instancia =  new frmArticulo();
        }

        private void frmArticulo_FormClosing(object sender, FormClosingEventArgs e)
        {
           _instancia = null;
        }

        private void btnPresentacion_Click(object sender, EventArgs e)
        {
            Vistas.frmVistaPresentacion FRM = new Vistas.frmVistaPresentacion();
            FRM.ShowDialog();
        }

        private void btnUbicacion_Click(object sender, EventArgs e)
        {
            Vistas.frmVistaUbicacion frm = new Vistas.frmVistaUbicacion();
            frm.ShowDialog();
        }

        private void btnMarca_Click(object sender, EventArgs e)
        {
            Vistas.frmVistaMarca FRM = new Vistas.frmVistaMarca();
            FRM.ShowDialog();
        }

        private void txtCategoria_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtPresentacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtUbicacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnAddFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog diag = new OpenFileDialog();
            DialogResult result = diag.ShowDialog();
            if (result == DialogResult.OK)
            {
                pbImagen.SizeMode = PictureBoxSizeMode.CenterImage;
                pbImagen.Image = Image.FromFile(diag.FileName);
            }
        }

        private void btnRemoveFoto_Click(object sender, EventArgs e)
        {
            pbImagen.Image = global::CapaPresentacion.Properties.Resources.Gallery_100px;
            pbImagen.SizeMode = PictureBoxSizeMode.CenterImage;
        }
    }
}
