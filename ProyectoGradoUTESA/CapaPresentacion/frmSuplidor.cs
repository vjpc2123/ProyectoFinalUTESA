﻿using System;
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
    public partial class frmSuplidor : Form
    {
        public frmSuplidor()
        {
            InitializeComponent();
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
            rdPersona.Checked = true;
            rdEmpresa.Checked = false;
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
            rdEmpresa.Enabled = stado;
            rdPersona.Enabled = stado;
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
                dtgvListado.DataSource = NSuplidor.Mostrar();
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

            dtgvListado.DataSource = NSuplidor.Buscar_Nombre(mtxtbuscar.Text);
            dtgvListado.Columns[3].Width = 300;
            dtgvListado.Columns[2].Width = 250;
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dtgvListado.RowCount);
        }
        private void BuscarID()
        {

            dtgvListado.DataSource = NSuplidor.Buscar_ID(mtxtbuscar.Text);
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbEstado_SelectedIndexChanged(object sender, EventArgs e)
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmSuplidor_Load(object sender, EventArgs e)
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
                MsgError("Debe Seleccionar Una forma de Busqueda");
            }

            if (dtgvListado.RowCount == 0)
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

        private string PersonaOEmpresa()
        {
            string retorno = "";
            
            return retorno;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                ErrorIcono.Clear();

                string msgRespuesta = "";
                if (txtNombre.Text == "" || cbITdentificacion.Text == "--Seleccionar--" || txtNOIdentificacion.Text == "   -       -" || txtNOIdentificacion.Text == "   -     -"||txtNombreContactor.Text == "")
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
                if (rdPersona.Checked == true)
                {
                    if (txtApellido.Text == "")
                    {
                        ErrorIcono.SetError(txtApellido, "Debe ingresar un Apellido");
                    }
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
                       // msgRespuesta = NSuplidor.Ingresar(cbEstado.Text,);
                    }
                    else
                    {
                   //    msgRespuesta = NUbicacion.Modificar(Convert.ToInt32(txtCodigo.Text), txtNombre.Text.Trim(), txtDescripcion.Text.Trim());
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

        private void SeleccionarTipoID()
        {

        }

        private void cbITdentificacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbITdentificacion.Text == "Cedula")
            {
                txtNOIdentificacion.Mask = "000-0000000-0";
            }
            else if (cbITdentificacion.Text == "RNC")
            {
                txtNOIdentificacion.Mask = "000-00000-0";
            }
            else
            {
                txtNOIdentificacion.Mask = "";
            }
           
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdPersona_CheckedChanged(object sender, EventArgs e)
        {
            if (rdEmpresa.Checked == true)
            {
                rdPersona.Checked = false;
                txtApellido.ReadOnly = true;
            }
        }

        private void rdEmpresa_CheckedChanged(object sender, EventArgs e)
        {
            if (rdPersona.Checked == true)
            {
                rdEmpresa.Checked = false;
                txtApellido.ReadOnly = false;
            }
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
