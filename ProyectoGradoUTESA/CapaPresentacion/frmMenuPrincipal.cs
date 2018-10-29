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
                btnArticulo.Text = "Articulo";
                btnVender.Text = "Ventas";
                btnCliente.Text = "Cliente";
                btnSuplidor.Text = "Suplidor";
                btnCompra.Text = "Compra";
                btnMantenimiento.Text = "   Mantenimiento";

            }
            else
            {

                panelMenuBAR.Width = 40;
                btnArticulo.Text = "";
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
            panelSeccionArticulos.Visible = true;
            
           
            
        }

        private void panelFormularios_Paint(object sender, PaintEventArgs e)
        {

        }

        public void ExecuteFormIntoPanel(object FormSon)
        {
            try
            {
                if (this.panelFormularios.Controls.Count > 0)
                    this.panelFormularios.Controls.RemoveAt(0);
                Form fh = FormSon as Form;
                fh.TopLevel = false;
                fh.FormBorderStyle = FormBorderStyle.None;
                fh.Dock = DockStyle.Fill;
                this.panelFormularios.Controls.Add(fh);
                this.panelFormularios.Tag = fh;
                fh.Show();
            }
            catch (Exception)
            {

                
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            panelSeccionArticulos.Visible = false;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {

            frmArticulo frm = frmArticulo.getinstancia();
            ExecuteFormIntoPanel(frm);
        }
    }
}
