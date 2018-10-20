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
    public partial class frmCategoria : Form
    {
        public frmCategoria()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisDTGV();

        }

        private void DisDTGV()
        {
            dtgvVehiculo.BorderStyle = BorderStyle.Fixed3D;
            dtgvVehiculo.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dtgvVehiculo.CellBorderStyle = DataGridViewCellBorderStyle.RaisedVertical;
            dtgvVehiculo.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dtgvVehiculo.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dtgvVehiculo.BackgroundColor = Color.FromArgb(171, 171, 171);

            dtgvVehiculo.EnableHeadersVisualStyles = false;
            dtgvVehiculo.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dtgvVehiculo.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dtgvVehiculo.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
