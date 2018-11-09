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

namespace CapaPresentacion
{
    public partial class frmMenuPrincipal : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            limpiarformulario();
        }

        private void btnMaximixar_Click(object sender, EventArgs e)
        {
       
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {

    
        }

        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMenuSlider_Click(object sender, EventArgs e)
        {
            if (panelMenuBAR.Width == 40)
            {
                panelMenuBAR.Width = 185;
                btnMercancia.Text = "Articulo";
                btnVender.Text = "Ventas";
                btnCliente.Text = "Cliente";
                btnSuplidor.Text = "Suplidor";
                btnCompra.Text = "Compra";
                btnMantenimiento.Text = "   Mantenimiento";

            }
            else
            {

                panelMenuBAR.Width = 40;
                btnMercancia.Text = "";
                btnVender.Text = "";
                btnCliente.Text = "";
                btnSuplidor.Text = "";
                btnCompra.Text = "";
                btnMantenimiento.Text = "";
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnVehiculo_Click(object sender, EventArgs e)
        {

            panelSeccionProyecto.Visible = true;
            panelSeccionProyecto.BringToFront();
            
        }

        private void panelFormularios_Paint(object sender, PaintEventArgs e)
        {

        }

        
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelFormularios.Controls.OfType<MiForm>().FirstOrDefault();
            if (formulario == null) 
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                panelFormularios.Controls.Add(formulario);
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                BringToFront();
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            
           
        }

        private void limpiarformulario()
        {
            panelSeccionProyecto.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button4_Click_1(object sender, EventArgs e)
        {

            
        }

        private void btnArticulo_MouseHover(object sender, EventArgs e)
        {
            
        }


        private void btnArticulo_MouseLeave(object sender, EventArgs e)
        {
        }

        private void panelSeccionProyecto_MouseLeave_1(object sender, EventArgs e)
        {
            
        }

        private void panelSeccionProyecto_MouseHover_1(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void btnArticulos_Click(object sender, EventArgs e)
        {
         
            limpiarformulario();
            
        }

        private void panelMenuBAR_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelMenuBAR_Click(object sender, EventArgs e)
        {
            limpiarformulario();
        }

        private void btnArticulos_MouseClick(object sender, MouseEventArgs e)
        {
            frmArticulo frm = frmArticulo.getinstancia();
            
            frm.TopLevel = false;
            panelFormularios.Controls.Add(frm);
            frm.Show();
            frm.BringToFront();


        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            AbrirFormulario<frmCategoria>();
        }

        private void btnMarca_MouseClick(object sender, MouseEventArgs e)
        {
            AbrirFormulario<frmMarca>();
        }

        private void btnPresentacion_MouseClick(object sender, MouseEventArgs e)
        {
            AbrirFormulario<frmPresentacion>();
        }

        private void btnUbicacion_MouseClick(object sender, MouseEventArgs e)
        {
            AbrirFormulario<frmUbicacion>();
        }

        private void btnSuplidor_MouseClick(object sender, MouseEventArgs e)
        {
            AbrirFormulario<frmSuplidor>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
