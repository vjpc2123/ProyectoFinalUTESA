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
    public partial class rptCategorias : Form
    {
        public rptCategorias()
        {
            InitializeComponent();
        }

        private void rptCategorias_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ProyectoDTSET.Categoria' table. You can move, or remove it, as needed.
            this.CategoriaTableAdapter.Fill(this.ProyectoDTSET.Categoria);

            this.reportViewer1.Refresh();


            this.reportViewer1.RefreshReport();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
