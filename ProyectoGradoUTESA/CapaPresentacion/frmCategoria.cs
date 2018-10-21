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
    public partial class frmCategoria : Form
    {
        private bool N = false;
        private bool E = false;
        public frmCategoria()
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
        private void limpiar()
        {
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtCodigo.Clear();
            txtNombre.Focus();
        }
        private void DisDTGV()
        {
            dtgvCategorias.BorderStyle = BorderStyle.Fixed3D;
            dtgvCategorias.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dtgvCategorias.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dtgvCategorias.DefaultCellStyle.SelectionBackColor = Color.FromArgb(147, 177, 215);
            dtgvCategorias.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dtgvCategorias.BackgroundColor = Color.FromArgb(171, 171, 171);

            dtgvCategorias.EnableHeadersVisualStyles = false;
            dtgvCategorias.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dtgvCategorias.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(28,28,28);
            dtgvCategorias.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

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
                dtgvCategorias.DataSource = NCategoria.MostratCategria();
                dtgvCategorias.Columns[3].Width = 300;
                dtgvCategorias.Columns[2].Width = 250;
                lblTotal.Text = "Total de Registros: " + Convert.ToString(dtgvCategorias.RowCount);
            }
            catch (Exception ex)
            {

                MsgError(ex.ToString());
            }
        }
        private void BuscarNombre()
        {

            dtgvCategorias.DataSource = NCategoria.Buscar_Nombre_Categoria(mtxtbuscar.Text);
            dtgvCategorias.Columns[3].Width = 300;
            dtgvCategorias.Columns[2].Width = 250;
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dtgvCategorias.RowCount);
        }
        private void BuscarDescripcion()
        {

            dtgvCategorias.DataSource = NCategoria.Buscar_Descripcion_Categoria(mtxtbuscar.Text);
            dtgvCategorias.Columns[3].Width = 300;
            dtgvCategorias.Columns[2].Width = 250;
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dtgvCategorias.RowCount);
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
            else
            {
                MsgError("Debe Seleccionar Una forma de Busqueda");
            }
        }

        public const int WM_BUTTON = 0xA1;
        public const int HT_Caption = 0x2;

        [DllImportAttribute("user32.dll")]

        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();


        private void Form1_Load(object sender, EventArgs e)
        {
            DisDTGV();
            txtCodigo.ReadOnly = true;
            MostrarDatos();
            Habilitar(false);
            HoB_btn();

        }



        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

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

        private void cbBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void mtxtbuscar_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Nombre_O_Descripcion();
            if (dtgvCategorias.RowCount == 0)
            {
                MsgError("No se encuentran datos con las caracteristicas indicadas.");
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
                if (txtNombre.Text == "" || txtDescripcion.Text == "")
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
                else
                {
                    if (N == true)
                    {
                        msgRespuesta = NCategoria.IngresarCategoria(txtNombre.Text.Trim(), txtDescripcion.Text.Trim());
                    }
                    else
                    {
                        msgRespuesta = NCategoria.ModificarCategoria(Convert.ToInt32(txtCodigo.Text), txtNombre.Text.Trim(), txtDescripcion.Text.Trim());
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

        private void dtgvCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCheckBoxCell chkEliminar = (DataGridViewCheckBoxCell)dtgvCategorias.Rows[e.RowIndex].Cells["Eliminar"];
            chkEliminar.Value = !Convert.ToBoolean(chkEliminar.Value);
        }

        private void dtgvCategorias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            N = false;
            E = false;
            HoB_btn();
            limpiar();
            Habilitar(false);
            txtCodigo.Text = Convert.ToString(dtgvCategorias.CurrentRow.Cells["Codigo"].Value);
            txtNombre.Text = Convert.ToString(dtgvCategorias.CurrentRow.Cells["Nombre"].Value);
            txtDescripcion.Text = Convert.ToString(dtgvCategorias.CurrentRow.Cells["Descripcion"].Value);
            tcCategoria.SelectedIndex = 1;
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
                            Respuesta = NCategoria.EliminarCategoria(Convert.ToInt32(Codigo));

                            if (Respuesta.Equals("Ok"))
                            {

                                MostrarDatos();
                            }
                            else
                            {
                                MsgError(Respuesta);

                            }
                        }

                    }
                    if (comparar != dtgvCategorias.RowCount)
                    {
                        MsgConfirmacion("Se han eliminado los datos correctamente");
                        mtxtbuscar.Text = "";
                    }
                    else { MsgError("Debe seleccionar los campos que desea eliminar");
                        mtxtbuscar.Text = "";
                    }
                   
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            N = false;
            E = false;
            HoB_btn();
            limpiar();
            Habilitar(false);
            ErrorIcono.Clear();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            rptCategorias report = new rptCategorias();
            report.ShowDialog();
        }
    }
    }
        
    

