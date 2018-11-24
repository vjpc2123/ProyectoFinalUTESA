namespace CapaPresentacion
{
    partial class frmVistaSuplidor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.tpLista = new System.Windows.Forms.TabPage();
            this.dtgvListado = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cbBuscar = new System.Windows.Forms.ComboBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.mtxtbuscar = new System.Windows.Forms.MaskedTextBox();
            this.tcCategoria = new System.Windows.Forms.TabControl();
            this.panelHeader.SuspendLayout();
            this.tpLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListado)).BeginInit();
            this.tcCategoria.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Controls.Add(this.btnCerrar);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(840, 30);
            this.panelHeader.TabIndex = 4;
            this.panelHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHeader_Paint);
            this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Vista Suplidores";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Image = global::CapaPresentacion.Properties.Resources.Close_Window_25px1;
            this.btnCerrar.Location = new System.Drawing.Point(812, 0);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(28, 30);
            this.btnCerrar.TabIndex = 12;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // tpLista
            // 
            this.tpLista.Controls.Add(this.mtxtbuscar);
            this.tpLista.Controls.Add(this.lblTotal);
            this.tpLista.Controls.Add(this.cbBuscar);
            this.tpLista.Controls.Add(this.btnBuscar);
            this.tpLista.Controls.Add(this.dtgvListado);
            this.tpLista.Location = new System.Drawing.Point(4, 24);
            this.tpLista.Name = "tpLista";
            this.tpLista.Padding = new System.Windows.Forms.Padding(3);
            this.tpLista.Size = new System.Drawing.Size(832, 610);
            this.tpLista.TabIndex = 0;
            this.tpLista.Text = "Lista";
            this.tpLista.UseVisualStyleBackColor = true;
            // 
            // dtgvListado
            // 
            this.dtgvListado.AllowUserToAddRows = false;
            this.dtgvListado.AllowUserToDeleteRows = false;
            this.dtgvListado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvListado.Location = new System.Drawing.Point(-4, 40);
            this.dtgvListado.Name = "dtgvListado";
            this.dtgvListado.ReadOnly = true;
            this.dtgvListado.Size = new System.Drawing.Size(840, 545);
            this.dtgvListado.TabIndex = 14;
            this.dtgvListado.DoubleClick += new System.EventHandler(this.dtgvListado_DoubleClick);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(86)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Image = global::CapaPresentacion.Properties.Resources.Search_25px;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(669, 3);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(108, 34);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // cbBuscar
            // 
            this.cbBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cbBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBuscar.FormattingEnabled = true;
            this.cbBuscar.Items.AddRange(new object[] {
            "Nombre",
            "Cedula",
            "RNC",
            "Pasaporte"});
            this.cbBuscar.Location = new System.Drawing.Point(13, 9);
            this.cbBuscar.Name = "cbBuscar";
            this.cbBuscar.Size = new System.Drawing.Size(137, 23);
            this.cbBuscar.TabIndex = 0;
            this.cbBuscar.Text = "--Seleccionar--";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(731, 529);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 16);
            this.lblTotal.TabIndex = 15;
            // 
            // mtxtbuscar
            // 
            this.mtxtbuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.mtxtbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtbuscar.Location = new System.Drawing.Point(156, 11);
            this.mtxtbuscar.Name = "mtxtbuscar";
            this.mtxtbuscar.Size = new System.Drawing.Size(409, 21);
            this.mtxtbuscar.TabIndex = 16;
            // 
            // tcCategoria
            // 
            this.tcCategoria.Controls.Add(this.tpLista);
            this.tcCategoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcCategoria.Location = new System.Drawing.Point(0, 30);
            this.tcCategoria.Name = "tcCategoria";
            this.tcCategoria.SelectedIndex = 0;
            this.tcCategoria.Size = new System.Drawing.Size(840, 638);
            this.tcCategoria.TabIndex = 5;
            // 
            // frmVistaSuplidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 668);
            this.Controls.Add(this.tcCategoria);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVistaSuplidor";
            this.Text = "frmVistaSuplidor";
            this.Load += new System.EventHandler(this.frmVistaSuplidor_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.tpLista.ResumeLayout(false);
            this.tpLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListado)).EndInit();
            this.tcCategoria.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.TabPage tpLista;
        public System.Windows.Forms.MaskedTextBox mtxtbuscar;
        private System.Windows.Forms.Label lblTotal;
        public System.Windows.Forms.ComboBox cbBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dtgvListado;
        private System.Windows.Forms.TabControl tcCategoria;
    }
}