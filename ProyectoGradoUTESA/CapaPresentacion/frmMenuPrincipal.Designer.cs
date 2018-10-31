namespace CapaPresentacion
{
    partial class frmMenuPrincipal
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
            this.lblUserName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMenuBAR = new System.Windows.Forms.Panel();
            this.panelFormularios = new System.Windows.Forms.Panel();
            this.panelSeccionProyecto = new System.Windows.Forms.Panel();
            this.btnArticulos = new System.Windows.Forms.Button();
            this.btnUbicacion = new System.Windows.Forms.Button();
            this.btnPresentacion = new System.Windows.Forms.Button();
            this.btnMarca = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnMantenimiento = new System.Windows.Forms.Button();
            this.btnCompra = new System.Windows.Forms.Button();
            this.btnSuplidor = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnVender = new System.Windows.Forms.Button();
            this.btnMercancia = new System.Windows.Forms.Button();
            this.btnMenuSlider = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelHeader.SuspendLayout();
            this.panelMenuBAR.SuspendLayout();
            this.panelFormularios.SuspendLayout();
            this.panelSeccionProyecto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panelHeader.Controls.Add(this.lblUserName);
            this.panelHeader.Controls.Add(this.btnMinimizar);
            this.panelHeader.Controls.Add(this.btnCerrar);
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Controls.Add(this.pictureBox1);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1164, 55);
            this.panelHeader.TabIndex = 1;
            this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseDown);
            // 
            // lblUserName
            // 
            this.lblUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(1084, 38);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(77, 17);
            this.lblUserName.TabIndex = 10;
            this.lblUserName.Text = "User Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(44, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Company Name";
            // 
            // panelMenuBAR
            // 
            this.panelMenuBAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panelMenuBAR.Controls.Add(this.button1);
            this.panelMenuBAR.Controls.Add(this.btnMantenimiento);
            this.panelMenuBAR.Controls.Add(this.btnCompra);
            this.panelMenuBAR.Controls.Add(this.btnSuplidor);
            this.panelMenuBAR.Controls.Add(this.btnCliente);
            this.panelMenuBAR.Controls.Add(this.btnVender);
            this.panelMenuBAR.Controls.Add(this.btnMercancia);
            this.panelMenuBAR.Controls.Add(this.btnMenuSlider);
            this.panelMenuBAR.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuBAR.Location = new System.Drawing.Point(0, 55);
            this.panelMenuBAR.Name = "panelMenuBAR";
            this.panelMenuBAR.Size = new System.Drawing.Size(185, 595);
            this.panelMenuBAR.TabIndex = 2;
            this.panelMenuBAR.Click += new System.EventHandler(this.panelMenuBAR_Click);
            this.panelMenuBAR.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenuBAR_Paint);
            // 
            // panelFormularios
            // 
            this.panelFormularios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.panelFormularios.Controls.Add(this.panelSeccionProyecto);
            this.panelFormularios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormularios.Location = new System.Drawing.Point(185, 55);
            this.panelFormularios.Name = "panelFormularios";
            this.panelFormularios.Size = new System.Drawing.Size(979, 595);
            this.panelFormularios.TabIndex = 3;
            this.panelFormularios.Click += new System.EventHandler(this.btnArticulos_Click);
            this.panelFormularios.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFormularios_Paint);
            // 
            // panelSeccionProyecto
            // 
            this.panelSeccionProyecto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panelSeccionProyecto.BackColor = System.Drawing.Color.Silver;
            this.panelSeccionProyecto.Controls.Add(this.btnArticulos);
            this.panelSeccionProyecto.Controls.Add(this.btnUbicacion);
            this.panelSeccionProyecto.Controls.Add(this.btnPresentacion);
            this.panelSeccionProyecto.Controls.Add(this.btnMarca);
            this.panelSeccionProyecto.Controls.Add(this.button2);
            this.panelSeccionProyecto.Location = new System.Drawing.Point(0, 77);
            this.panelSeccionProyecto.Name = "panelSeccionProyecto";
            this.panelSeccionProyecto.Size = new System.Drawing.Size(184, 389);
            this.panelSeccionProyecto.TabIndex = 0;
            this.panelSeccionProyecto.Visible = false;
            this.panelSeccionProyecto.Click += new System.EventHandler(this.btnArticulos_Click);
            this.panelSeccionProyecto.MouseLeave += new System.EventHandler(this.panelSeccionProyecto_MouseLeave_1);
            this.panelSeccionProyecto.MouseHover += new System.EventHandler(this.panelSeccionProyecto_MouseHover_1);
            // 
            // btnArticulos
            // 
            this.btnArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnArticulos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnArticulos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArticulos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnArticulos.FlatAppearance.BorderSize = 2;
            this.btnArticulos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnArticulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArticulos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArticulos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnArticulos.Image = global::CapaPresentacion.Properties.Resources.Product_30px1;
            this.btnArticulos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArticulos.Location = new System.Drawing.Point(0, 34);
            this.btnArticulos.Name = "btnArticulos";
            this.btnArticulos.Size = new System.Drawing.Size(184, 44);
            this.btnArticulos.TabIndex = 23;
            this.btnArticulos.Text = "Articulos";
            this.btnArticulos.UseVisualStyleBackColor = false;
            this.btnArticulos.Click += new System.EventHandler(this.btnArticulos_Click);
            this.btnArticulos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnArticulos_MouseClick);
            // 
            // btnUbicacion
            // 
            this.btnUbicacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUbicacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnUbicacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUbicacion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnUbicacion.FlatAppearance.BorderSize = 2;
            this.btnUbicacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnUbicacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUbicacion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUbicacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnUbicacion.Image = global::CapaPresentacion.Properties.Resources.Location_30px;
            this.btnUbicacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUbicacion.Location = new System.Drawing.Point(0, 310);
            this.btnUbicacion.Name = "btnUbicacion";
            this.btnUbicacion.Size = new System.Drawing.Size(184, 44);
            this.btnUbicacion.TabIndex = 22;
            this.btnUbicacion.Text = "Ubicacion";
            this.btnUbicacion.UseVisualStyleBackColor = false;
            this.btnUbicacion.Click += new System.EventHandler(this.btnArticulos_Click);
            this.btnUbicacion.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnUbicacion_MouseClick);
            this.btnUbicacion.MouseLeave += new System.EventHandler(this.panelSeccionProyecto_MouseLeave_1);
            this.btnUbicacion.MouseHover += new System.EventHandler(this.panelSeccionProyecto_MouseHover_1);
            // 
            // btnPresentacion
            // 
            this.btnPresentacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPresentacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnPresentacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPresentacion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnPresentacion.FlatAppearance.BorderSize = 2;
            this.btnPresentacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnPresentacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPresentacion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPresentacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnPresentacion.Image = global::CapaPresentacion.Properties.Resources.Table_Properties_30px;
            this.btnPresentacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPresentacion.Location = new System.Drawing.Point(0, 241);
            this.btnPresentacion.Name = "btnPresentacion";
            this.btnPresentacion.Size = new System.Drawing.Size(184, 44);
            this.btnPresentacion.TabIndex = 21;
            this.btnPresentacion.Text = "Presentacion";
            this.btnPresentacion.UseVisualStyleBackColor = false;
            this.btnPresentacion.Click += new System.EventHandler(this.btnArticulos_Click);
            this.btnPresentacion.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnPresentacion_MouseClick);
            this.btnPresentacion.MouseLeave += new System.EventHandler(this.panelSeccionProyecto_MouseLeave_1);
            this.btnPresentacion.MouseHover += new System.EventHandler(this.panelSeccionProyecto_MouseHover_1);
            // 
            // btnMarca
            // 
            this.btnMarca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnMarca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMarca.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnMarca.FlatAppearance.BorderSize = 2;
            this.btnMarca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarca.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnMarca.Image = global::CapaPresentacion.Properties.Resources.Bag_Brand_30px;
            this.btnMarca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMarca.Location = new System.Drawing.Point(0, 174);
            this.btnMarca.Name = "btnMarca";
            this.btnMarca.Size = new System.Drawing.Size(184, 44);
            this.btnMarca.TabIndex = 20;
            this.btnMarca.Text = "Marca";
            this.btnMarca.UseVisualStyleBackColor = false;
            this.btnMarca.Click += new System.EventHandler(this.btnArticulos_Click);
            this.btnMarca.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnMarca_MouseClick);
            this.btnMarca.MouseLeave += new System.EventHandler(this.panelSeccionProyecto_MouseLeave_1);
            this.btnMarca.MouseHover += new System.EventHandler(this.panelSeccionProyecto_MouseHover_1);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.button2.Image = global::CapaPresentacion.Properties.Resources.Sorting_30px;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 102);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 44);
            this.button2.TabIndex = 19;
            this.button2.Text = "Categorias";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnArticulos_Click);
            this.button2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button2_MouseClick);
            this.button2.MouseLeave += new System.EventHandler(this.panelSeccionProyecto_MouseLeave_1);
            this.button2.MouseHover += new System.EventHandler(this.panelSeccionProyecto_MouseHover_1);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::CapaPresentacion.Properties.Resources.Shutdown_27px;
            this.button1.Location = new System.Drawing.Point(-3, 555);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 40);
            this.button1.TabIndex = 18;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnMantenimiento
            // 
            this.btnMantenimiento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMantenimiento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMantenimiento.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnMantenimiento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnMantenimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMantenimiento.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMantenimiento.ForeColor = System.Drawing.Color.White;
            this.btnMantenimiento.Image = global::CapaPresentacion.Properties.Resources.Maintenance_30px;
            this.btnMantenimiento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMantenimiento.Location = new System.Drawing.Point(0, 422);
            this.btnMantenimiento.Name = "btnMantenimiento";
            this.btnMantenimiento.Size = new System.Drawing.Size(185, 44);
            this.btnMantenimiento.TabIndex = 17;
            this.btnMantenimiento.Text = "      Mantenimiento";
            this.btnMantenimiento.UseVisualStyleBackColor = true;
            this.btnMantenimiento.Click += new System.EventHandler(this.btnArticulos_Click);
            // 
            // btnCompra
            // 
            this.btnCompra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompra.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnCompra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompra.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompra.ForeColor = System.Drawing.Color.White;
            this.btnCompra.Image = global::CapaPresentacion.Properties.Resources.Buy_30px;
            this.btnCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompra.Location = new System.Drawing.Point(0, 353);
            this.btnCompra.Name = "btnCompra";
            this.btnCompra.Size = new System.Drawing.Size(185, 44);
            this.btnCompra.TabIndex = 16;
            this.btnCompra.Text = "Compra";
            this.btnCompra.UseVisualStyleBackColor = true;
            this.btnCompra.Click += new System.EventHandler(this.btnArticulos_Click);
            // 
            // btnSuplidor
            // 
            this.btnSuplidor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSuplidor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuplidor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSuplidor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSuplidor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuplidor.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuplidor.ForeColor = System.Drawing.Color.White;
            this.btnSuplidor.Image = global::CapaPresentacion.Properties.Resources.Deliver_Food_30px;
            this.btnSuplidor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuplidor.Location = new System.Drawing.Point(0, 284);
            this.btnSuplidor.Name = "btnSuplidor";
            this.btnSuplidor.Size = new System.Drawing.Size(185, 44);
            this.btnSuplidor.TabIndex = 15;
            this.btnSuplidor.Text = "Suplidor";
            this.btnSuplidor.UseVisualStyleBackColor = true;
            this.btnSuplidor.Click += new System.EventHandler(this.btnArticulos_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.ForeColor = System.Drawing.Color.White;
            this.btnCliente.Image = global::CapaPresentacion.Properties.Resources.Client_Management_30px;
            this.btnCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCliente.Location = new System.Drawing.Point(0, 215);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(185, 44);
            this.btnCliente.TabIndex = 14;
            this.btnCliente.Text = "Cliente";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnArticulos_Click);
            // 
            // btnVender
            // 
            this.btnVender.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVender.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnVender.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnVender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVender.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVender.ForeColor = System.Drawing.Color.White;
            this.btnVender.Image = global::CapaPresentacion.Properties.Resources.Sell_30px;
            this.btnVender.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVender.Location = new System.Drawing.Point(0, 146);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(185, 44);
            this.btnVender.TabIndex = 13;
            this.btnVender.Text = "Ventas";
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.btnArticulos_Click);
            // 
            // btnMercancia
            // 
            this.btnMercancia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMercancia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMercancia.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnMercancia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnMercancia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMercancia.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMercancia.ForeColor = System.Drawing.Color.White;
            this.btnMercancia.Image = global::CapaPresentacion.Properties.Resources.Handle_With_Care_25px;
            this.btnMercancia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMercancia.Location = new System.Drawing.Point(0, 77);
            this.btnMercancia.Name = "btnMercancia";
            this.btnMercancia.Size = new System.Drawing.Size(185, 44);
            this.btnMercancia.TabIndex = 12;
            this.btnMercancia.Text = "Mercancia";
            this.btnMercancia.UseVisualStyleBackColor = true;
            this.btnMercancia.Click += new System.EventHandler(this.btnVehiculo_Click);
            this.btnMercancia.MouseLeave += new System.EventHandler(this.btnArticulo_MouseLeave);
            this.btnMercancia.MouseHover += new System.EventHandler(this.btnArticulo_MouseHover);
            // 
            // btnMenuSlider
            // 
            this.btnMenuSlider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenuSlider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuSlider.FlatAppearance.BorderSize = 0;
            this.btnMenuSlider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuSlider.ForeColor = System.Drawing.Color.White;
            this.btnMenuSlider.Image = global::CapaPresentacion.Properties.Resources.Menu_30px;
            this.btnMenuSlider.Location = new System.Drawing.Point(140, 0);
            this.btnMenuSlider.Name = "btnMenuSlider";
            this.btnMenuSlider.Size = new System.Drawing.Size(45, 40);
            this.btnMenuSlider.TabIndex = 11;
            this.btnMenuSlider.UseVisualStyleBackColor = true;
            this.btnMenuSlider.Click += new System.EventHandler(this.btnMenuSlider_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Image = global::CapaPresentacion.Properties.Resources.Minimize_Window_25px;
            this.btnMinimizar.Location = new System.Drawing.Point(1097, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(30, 30);
            this.btnMinimizar.TabIndex = 7;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Image = global::CapaPresentacion.Properties.Resources.Close_Window_25px;
            this.btnCerrar.Location = new System.Drawing.Point(1133, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(30, 30);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.C_Sharp_Logo_25px;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 650);
            this.Controls.Add(this.panelFormularios);
            this.Controls.Add(this.panelMenuBAR);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenuPrincipal";
            this.Text = "frmMenuPrincipal";
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelMenuBAR.ResumeLayout(false);
            this.panelFormularios.ResumeLayout(false);
            this.panelSeccionProyecto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelMenuBAR;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnMantenimiento;
        private System.Windows.Forms.Button btnCompra;
        private System.Windows.Forms.Button btnSuplidor;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.Button btnMercancia;
        private System.Windows.Forms.Button btnMenuSlider;
        private System.Windows.Forms.Panel panelFormularios;
        private System.Windows.Forms.Panel panelSeccionProyecto;
        private System.Windows.Forms.Button btnUbicacion;
        private System.Windows.Forms.Button btnPresentacion;
        private System.Windows.Forms.Button btnMarca;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnArticulos;
    }
}