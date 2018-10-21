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
    public partial class rptPresentacion : Form
    {
        public rptPresentacion()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rptPresentacion_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ProyectoDTSET.Presentacion' table. You can move, or remove it, as needed.
            this.PresentacionTableAdapter.Fill(this.ProyectoDTSET.Presentacion);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
