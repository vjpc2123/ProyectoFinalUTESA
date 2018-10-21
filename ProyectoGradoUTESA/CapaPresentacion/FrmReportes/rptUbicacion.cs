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
    public partial class rptUbicacion : Form
    {
        public rptUbicacion()
        {
            InitializeComponent();
        }

        private void rptUbicacion_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ProyectoDTSET.Ubicacion' table. You can move, or remove it, as needed.
            this.UbicacionTableAdapter.Fill(this.ProyectoDTSET.Ubicacion);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
