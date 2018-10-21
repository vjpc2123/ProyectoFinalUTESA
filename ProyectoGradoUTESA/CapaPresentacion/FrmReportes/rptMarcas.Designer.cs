namespace CapaPresentacion
{
    partial class rptMarcas
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.MarcaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProyectoDTSET = new CapaPresentacion.ProyectoDTSET();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.MarcaTableAdapter = new CapaPresentacion.ProyectoDTSETTableAdapters.MarcaTableAdapter();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MarcaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProyectoDTSET)).BeginInit();
            this.SuspendLayout();
            // 
            // MarcaBindingSource
            // 
            this.MarcaBindingSource.DataMember = "Marca";
            this.MarcaBindingSource.DataSource = this.ProyectoDTSET;
            // 
            // ProyectoDTSET
            // 
            this.ProyectoDTSET.DataSetName = "ProyectoDTSET";
            this.ProyectoDTSET.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DSetProyecto";
            reportDataSource1.Value = this.MarcaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.rptMarca.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(688, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // MarcaTableAdapter
            // 
            this.MarcaTableAdapter.ClearBeforeFill = true;
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
            this.btnCerrar.Location = new System.Drawing.Point(661, 3);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(24, 20);
            this.btnCerrar.TabIndex = 15;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // rptMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 450);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "rptMarcas";
            this.Text = "rptMarcas";
            this.Load += new System.EventHandler(this.rptMarcas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MarcaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProyectoDTSET)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource MarcaBindingSource;
        private ProyectoDTSET ProyectoDTSET;
        private ProyectoDTSETTableAdapters.MarcaTableAdapter MarcaTableAdapter;
        private System.Windows.Forms.Button btnCerrar;
    }
}