namespace AppFlickAdministrador.Vistas.Init
{
    partial class Dashboard
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
            Guna.UI.Animation.Animation animation2 = new Guna.UI.Animation.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel2 = new System.Windows.Forms.Panel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnEmpleados = new Guna.UI.WinForms.GunaButton();
            this.btnFunciones = new Guna.UI.WinForms.GunaButton();
            this.btnTarjetas = new Guna.UI.WinForms.GunaButton();
            this.labelFunciones = new System.Windows.Forms.Label();
            this.btnHorarios = new Guna.UI.WinForms.GunaButton();
            this.btnFacturación = new Guna.UI.WinForms.GunaButton();
            this.btnClientes = new Guna.UI.WinForms.GunaButton();
            this.labelPeliculas = new System.Windows.Forms.Label();
            this.labelHorarios = new System.Windows.Forms.Label();
            this.labelFacturacion = new System.Windows.Forms.Label();
            this.labelEmpleados = new System.Windows.Forms.Label();
            this.labelClientes = new System.Windows.Forms.Label();
            this.var_hora_actual = new Guna.UI.WinForms.GunaLabel();
            this.btnCerrar = new Guna.UI.WinForms.GunaCircleButton();
            this.logoImagen = new System.Windows.Forms.PictureBox();
            this.var_nombre_usuario = new Guna.UI.WinForms.GunaLabel();
            this.animacionLogo = new Guna.UI.WinForms.GunaTransition(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.panel2.Controls.Add(this.gunaLabel3);
            this.panel2.Controls.Add(this.panelPrincipal);
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Controls.Add(this.var_hora_actual);
            this.panel2.Controls.Add(this.btnCerrar);
            this.panel2.Controls.Add(this.logoImagen);
            this.panel2.Controls.Add(this.var_nombre_usuario);
            this.animacionLogo.SetDecoration(this.panel2, Guna.UI.Animation.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1028, 609);
            this.panel2.TabIndex = 25;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLabel3.CausesValidation = false;
            this.animacionLogo.SetDecoration(this.gunaLabel3, Guna.UI.Animation.DecorationType.None);
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.White;
            this.gunaLabel3.Location = new System.Drawing.Point(194, 12);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(397, 42);
            this.gunaLabel3.TabIndex = 71;
            this.gunaLabel3.Text = "Administración del sistema";
            this.gunaLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.animacionLogo.SetDecoration(this.panelPrincipal, Guna.UI.Animation.DecorationType.None);
            this.panelPrincipal.Location = new System.Drawing.Point(198, 70);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(809, 506);
            this.panelPrincipal.TabIndex = 70;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 98F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel1.Controls.Add(this.btnEmpleados, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnFunciones, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnTarjetas, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelFunciones, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnHorarios, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnFacturación, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnClientes, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelPeliculas, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelHorarios, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelFacturacion, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelEmpleados, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelClientes, 1, 4);
            this.animacionLogo.SetDecoration(this.tableLayoutPanel1, Guna.UI.Animation.DecorationType.None);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 70);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(171, 297);
            this.tableLayoutPanel1.TabIndex = 67;
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.AnimationHoverSpeed = 0.07F;
            this.btnEmpleados.AnimationSpeed = 0.03F;
            this.btnEmpleados.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.btnEmpleados.BorderColor = System.Drawing.Color.Black;
            this.animacionLogo.SetDecoration(this.btnEmpleados, Guna.UI.Animation.DecorationType.None);
            this.btnEmpleados.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEmpleados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEmpleados.FocusedColor = System.Drawing.Color.Empty;
            this.btnEmpleados.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleados.ForeColor = System.Drawing.Color.White;
            this.btnEmpleados.Image = global::AppFlickAdministrador.Properties.Resources.icon_empleado;
            this.btnEmpleados.ImageSize = new System.Drawing.Size(20, 20);
            this.btnEmpleados.Location = new System.Drawing.Point(0, 245);
            this.btnEmpleados.Margin = new System.Windows.Forms.Padding(0);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(237)))));
            this.btnEmpleados.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEmpleados.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEmpleados.OnHoverImage = null;
            this.btnEmpleados.OnPressedColor = System.Drawing.Color.Black;
            this.btnEmpleados.Size = new System.Drawing.Size(167, 52);
            this.btnEmpleados.TabIndex = 74;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.TextOffsetX = 4;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // btnFunciones
            // 
            this.btnFunciones.AnimationHoverSpeed = 0.07F;
            this.btnFunciones.AnimationSpeed = 0.03F;
            this.btnFunciones.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.btnFunciones.BorderColor = System.Drawing.Color.Black;
            this.animacionLogo.SetDecoration(this.btnFunciones, Guna.UI.Animation.DecorationType.None);
            this.btnFunciones.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnFunciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFunciones.FocusedColor = System.Drawing.Color.Empty;
            this.btnFunciones.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFunciones.ForeColor = System.Drawing.Color.White;
            this.btnFunciones.Image = global::AppFlickAdministrador.Properties.Resources.icon_funciones;
            this.btnFunciones.ImageSize = new System.Drawing.Size(20, 20);
            this.btnFunciones.Location = new System.Drawing.Point(0, 0);
            this.btnFunciones.Margin = new System.Windows.Forms.Padding(0);
            this.btnFunciones.Name = "btnFunciones";
            this.btnFunciones.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(237)))));
            this.btnFunciones.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnFunciones.OnHoverForeColor = System.Drawing.Color.White;
            this.btnFunciones.OnHoverImage = null;
            this.btnFunciones.OnPressedColor = System.Drawing.Color.Black;
            this.btnFunciones.Size = new System.Drawing.Size(167, 49);
            this.btnFunciones.TabIndex = 63;
            this.btnFunciones.Text = "Funciones";
            this.btnFunciones.TextOffsetX = 4;
            this.btnFunciones.Click += new System.EventHandler(this.btnFunciones_Click);
            // 
            // btnTarjetas
            // 
            this.btnTarjetas.AnimationHoverSpeed = 0.07F;
            this.btnTarjetas.AnimationSpeed = 0.03F;
            this.btnTarjetas.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.btnTarjetas.BorderColor = System.Drawing.Color.Black;
            this.animacionLogo.SetDecoration(this.btnTarjetas, Guna.UI.Animation.DecorationType.None);
            this.btnTarjetas.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnTarjetas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTarjetas.FocusedColor = System.Drawing.Color.Empty;
            this.btnTarjetas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTarjetas.ForeColor = System.Drawing.Color.White;
            this.btnTarjetas.Image = global::AppFlickAdministrador.Properties.Resources.icon_peliculas;
            this.btnTarjetas.ImageSize = new System.Drawing.Size(20, 20);
            this.btnTarjetas.Location = new System.Drawing.Point(0, 49);
            this.btnTarjetas.Margin = new System.Windows.Forms.Padding(0);
            this.btnTarjetas.Name = "btnTarjetas";
            this.btnTarjetas.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(237)))));
            this.btnTarjetas.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnTarjetas.OnHoverForeColor = System.Drawing.Color.White;
            this.btnTarjetas.OnHoverImage = null;
            this.btnTarjetas.OnPressedColor = System.Drawing.Color.Black;
            this.btnTarjetas.Size = new System.Drawing.Size(167, 49);
            this.btnTarjetas.TabIndex = 66;
            this.btnTarjetas.Text = "Peliculas";
            this.btnTarjetas.TextOffsetX = 4;
            this.btnTarjetas.Click += new System.EventHandler(this.btnTarjetas_Click);
            // 
            // labelFunciones
            // 
            this.animacionLogo.SetDecoration(this.labelFunciones, Guna.UI.Animation.DecorationType.None);
            this.labelFunciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelFunciones.Location = new System.Drawing.Point(167, 0);
            this.labelFunciones.Margin = new System.Windows.Forms.Padding(0);
            this.labelFunciones.Name = "labelFunciones";
            this.labelFunciones.Size = new System.Drawing.Size(4, 49);
            this.labelFunciones.TabIndex = 71;
            // 
            // btnHorarios
            // 
            this.btnHorarios.AnimationHoverSpeed = 0.07F;
            this.btnHorarios.AnimationSpeed = 0.03F;
            this.btnHorarios.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.btnHorarios.BorderColor = System.Drawing.Color.Black;
            this.animacionLogo.SetDecoration(this.btnHorarios, Guna.UI.Animation.DecorationType.None);
            this.btnHorarios.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnHorarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHorarios.FocusedColor = System.Drawing.Color.Empty;
            this.btnHorarios.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHorarios.ForeColor = System.Drawing.Color.White;
            this.btnHorarios.Image = global::AppFlickAdministrador.Properties.Resources.icon_horario;
            this.btnHorarios.ImageSize = new System.Drawing.Size(20, 20);
            this.btnHorarios.Location = new System.Drawing.Point(0, 98);
            this.btnHorarios.Margin = new System.Windows.Forms.Padding(0);
            this.btnHorarios.Name = "btnHorarios";
            this.btnHorarios.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(237)))));
            this.btnHorarios.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnHorarios.OnHoverForeColor = System.Drawing.Color.White;
            this.btnHorarios.OnHoverImage = null;
            this.btnHorarios.OnPressedColor = System.Drawing.Color.Black;
            this.btnHorarios.Size = new System.Drawing.Size(167, 49);
            this.btnHorarios.TabIndex = 65;
            this.btnHorarios.Text = "Horarios";
            this.btnHorarios.TextOffsetX = 4;
            this.btnHorarios.Click += new System.EventHandler(this.btnHorarios_Click);
            // 
            // btnFacturación
            // 
            this.btnFacturación.AnimationHoverSpeed = 0.07F;
            this.btnFacturación.AnimationSpeed = 0.03F;
            this.btnFacturación.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.btnFacturación.BorderColor = System.Drawing.Color.Black;
            this.animacionLogo.SetDecoration(this.btnFacturación, Guna.UI.Animation.DecorationType.None);
            this.btnFacturación.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnFacturación.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFacturación.FocusedColor = System.Drawing.Color.Empty;
            this.btnFacturación.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturación.ForeColor = System.Drawing.Color.White;
            this.btnFacturación.Image = global::AppFlickAdministrador.Properties.Resources.icon_facturacion;
            this.btnFacturación.ImageSize = new System.Drawing.Size(20, 20);
            this.btnFacturación.Location = new System.Drawing.Point(0, 147);
            this.btnFacturación.Margin = new System.Windows.Forms.Padding(0);
            this.btnFacturación.Name = "btnFacturación";
            this.btnFacturación.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(237)))));
            this.btnFacturación.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnFacturación.OnHoverForeColor = System.Drawing.Color.White;
            this.btnFacturación.OnHoverImage = null;
            this.btnFacturación.OnPressedColor = System.Drawing.Color.Black;
            this.btnFacturación.Size = new System.Drawing.Size(167, 49);
            this.btnFacturación.TabIndex = 72;
            this.btnFacturación.Text = "Facturación";
            this.btnFacturación.TextOffsetX = 4;
            this.btnFacturación.Click += new System.EventHandler(this.btnFacturacion_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.AnimationHoverSpeed = 0.07F;
            this.btnClientes.AnimationSpeed = 0.03F;
            this.btnClientes.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.btnClientes.BorderColor = System.Drawing.Color.Black;
            this.animacionLogo.SetDecoration(this.btnClientes, Guna.UI.Animation.DecorationType.None);
            this.btnClientes.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClientes.FocusedColor = System.Drawing.Color.Empty;
            this.btnClientes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.White;
            this.btnClientes.Image = global::AppFlickAdministrador.Properties.Resources.icon_clientes;
            this.btnClientes.ImageSize = new System.Drawing.Size(20, 20);
            this.btnClientes.Location = new System.Drawing.Point(0, 196);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(0);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(237)))));
            this.btnClientes.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnClientes.OnHoverForeColor = System.Drawing.Color.White;
            this.btnClientes.OnHoverImage = null;
            this.btnClientes.OnPressedColor = System.Drawing.Color.Black;
            this.btnClientes.Size = new System.Drawing.Size(167, 49);
            this.btnClientes.TabIndex = 73;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextOffsetX = 4;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // labelPeliculas
            // 
            this.animacionLogo.SetDecoration(this.labelPeliculas, Guna.UI.Animation.DecorationType.None);
            this.labelPeliculas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPeliculas.Location = new System.Drawing.Point(167, 49);
            this.labelPeliculas.Margin = new System.Windows.Forms.Padding(0);
            this.labelPeliculas.Name = "labelPeliculas";
            this.labelPeliculas.Size = new System.Drawing.Size(4, 49);
            this.labelPeliculas.TabIndex = 75;
            // 
            // labelHorarios
            // 
            this.animacionLogo.SetDecoration(this.labelHorarios, Guna.UI.Animation.DecorationType.None);
            this.labelHorarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelHorarios.Location = new System.Drawing.Point(167, 98);
            this.labelHorarios.Margin = new System.Windows.Forms.Padding(0);
            this.labelHorarios.Name = "labelHorarios";
            this.labelHorarios.Size = new System.Drawing.Size(4, 49);
            this.labelHorarios.TabIndex = 76;
            // 
            // labelFacturacion
            // 
            this.animacionLogo.SetDecoration(this.labelFacturacion, Guna.UI.Animation.DecorationType.None);
            this.labelFacturacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelFacturacion.Location = new System.Drawing.Point(167, 147);
            this.labelFacturacion.Margin = new System.Windows.Forms.Padding(0);
            this.labelFacturacion.Name = "labelFacturacion";
            this.labelFacturacion.Size = new System.Drawing.Size(4, 49);
            this.labelFacturacion.TabIndex = 77;
            // 
            // labelEmpleados
            // 
            this.animacionLogo.SetDecoration(this.labelEmpleados, Guna.UI.Animation.DecorationType.None);
            this.labelEmpleados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelEmpleados.Location = new System.Drawing.Point(167, 245);
            this.labelEmpleados.Margin = new System.Windows.Forms.Padding(0);
            this.labelEmpleados.Name = "labelEmpleados";
            this.labelEmpleados.Size = new System.Drawing.Size(4, 52);
            this.labelEmpleados.TabIndex = 78;
            // 
            // labelClientes
            // 
            this.animacionLogo.SetDecoration(this.labelClientes, Guna.UI.Animation.DecorationType.None);
            this.labelClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelClientes.Location = new System.Drawing.Point(167, 196);
            this.labelClientes.Margin = new System.Windows.Forms.Padding(0);
            this.labelClientes.Name = "labelClientes";
            this.labelClientes.Size = new System.Drawing.Size(4, 49);
            this.labelClientes.TabIndex = 79;
            // 
            // var_hora_actual
            // 
            this.var_hora_actual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.var_hora_actual.CausesValidation = false;
            this.animacionLogo.SetDecoration(this.var_hora_actual, Guna.UI.Animation.DecorationType.None);
            this.var_hora_actual.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.var_hora_actual.ForeColor = System.Drawing.Color.White;
            this.var_hora_actual.Location = new System.Drawing.Point(773, 39);
            this.var_hora_actual.Name = "var_hora_actual";
            this.var_hora_actual.Size = new System.Drawing.Size(180, 15);
            this.var_hora_actual.TabIndex = 61;
            this.var_hora_actual.Text = "10:01 PM";
            this.var_hora_actual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.AnimationHoverSpeed = 0.07F;
            this.btnCerrar.AnimationSpeed = 0.03F;
            this.btnCerrar.BaseColor = System.Drawing.Color.Transparent;
            this.btnCerrar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(237)))));
            this.animacionLogo.SetDecoration(this.btnCerrar, Guna.UI.Animation.DecorationType.None);
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCerrar.FocusedColor = System.Drawing.Color.Empty;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Image = global::AppFlickAdministrador.Properties.Resources.icon_cerrar;
            this.btnCerrar.ImageSize = new System.Drawing.Size(36, 36);
            this.btnCerrar.Location = new System.Drawing.Point(971, 18);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(237)))));
            this.btnCerrar.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(237)))));
            this.btnCerrar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCerrar.OnHoverImage = null;
            this.btnCerrar.OnPressedColor = System.Drawing.Color.Black;
            this.btnCerrar.Size = new System.Drawing.Size(36, 36);
            this.btnCerrar.TabIndex = 59;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // logoImagen
            // 
            this.logoImagen.BackColor = System.Drawing.Color.Transparent;
            this.animacionLogo.SetDecoration(this.logoImagen, Guna.UI.Animation.DecorationType.None);
            this.logoImagen.Image = global::AppFlickAdministrador.Properties.Resources.flick;
            this.logoImagen.Location = new System.Drawing.Point(12, 12);
            this.logoImagen.Name = "logoImagen";
            this.logoImagen.Size = new System.Drawing.Size(156, 42);
            this.logoImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoImagen.TabIndex = 23;
            this.logoImagen.TabStop = false;
            this.logoImagen.MouseHover += new System.EventHandler(this.animacion_logo);
            // 
            // var_nombre_usuario
            // 
            this.var_nombre_usuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.var_nombre_usuario.CausesValidation = false;
            this.animacionLogo.SetDecoration(this.var_nombre_usuario, Guna.UI.Animation.DecorationType.None);
            this.var_nombre_usuario.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.var_nombre_usuario.ForeColor = System.Drawing.Color.White;
            this.var_nombre_usuario.Location = new System.Drawing.Point(769, 18);
            this.var_nombre_usuario.Name = "var_nombre_usuario";
            this.var_nombre_usuario.Size = new System.Drawing.Size(184, 21);
            this.var_nombre_usuario.TabIndex = 57;
            this.var_nombre_usuario.Text = "Alan Brito";
            this.var_nombre_usuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // animacionLogo
            // 
            this.animacionLogo.AnimationType = Guna.UI.Animation.AnimationType.Scale;
            this.animacionLogo.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.animacionLogo.DefaultAnimation = animation2;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(24)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(1028, 609);
            this.Controls.Add(this.panel2);
            this.animacionLogo.SetDecoration(this, Guna.UI.Animation.DecorationType.None);
            this.DoubleBuffered = true;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox logoImagen;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaCircleButton btnCerrar;
        private Guna.UI.WinForms.GunaLabel var_nombre_usuario;
        private Guna.UI.WinForms.GunaLabel var_hora_actual;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI.WinForms.GunaButton btnFunciones;
        private Guna.UI.WinForms.GunaButton btnHorarios;
        private Guna.UI.WinForms.GunaButton btnTarjetas;
        private Guna.UI.WinForms.GunaTransition animacionLogo;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Timer timer;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaButton btnEmpleados;
        private System.Windows.Forms.Label labelFunciones;
        private Guna.UI.WinForms.GunaButton btnFacturación;
        private Guna.UI.WinForms.GunaButton btnClientes;
        private System.Windows.Forms.Label labelPeliculas;
        private System.Windows.Forms.Label labelHorarios;
        private System.Windows.Forms.Label labelFacturacion;
        private System.Windows.Forms.Label labelEmpleados;
        private System.Windows.Forms.Label labelClientes;
    }
}