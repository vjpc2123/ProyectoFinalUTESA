using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmVistaDetalleCompra frm = new frmVistaDetalleCompra();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            
        }
    }
}
