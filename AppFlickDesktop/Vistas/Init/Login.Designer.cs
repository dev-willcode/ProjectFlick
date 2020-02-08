namespace AppFlickDesktop
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            Guna.UI.Animation.Animation animation2 = new Guna.UI.Animation.Animation();
            this.container = new System.Windows.Forms.Panel();
            this.logoImagen = new System.Windows.Forms.PictureBox();
            this.containerIzq = new System.Windows.Forms.Panel();
            this.txtPassword = new Guna.UI.WinForms.GunaTextBox();
            this.txtUsername = new Guna.UI.WinForms.GunaTextBox();
            this.btnLogin = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.containerDer = new System.Windows.Forms.Panel();
            this.parent = new System.Windows.Forms.Panel();
            this.movible = new Guna.UI.WinForms.GunaElipsePanel();
            this.btnCancelar = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel11 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel12 = new Guna.UI.WinForms.GunaLabel();
            this.txtnUsuario = new Guna.UI.WinForms.GunaTextBox();
            this.txtnContrasena = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel10 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel9 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.txtnEmail = new Guna.UI.WinForms.GunaTextBox();
            this.txtnDireccion = new Guna.UI.WinForms.GunaTextBox();
            this.txtnNombres = new Guna.UI.WinForms.GunaTextBox();
            this.txtnTelefono = new Guna.UI.WinForms.GunaTextBox();
            this.btnRegistrar = new Guna.UI.WinForms.GunaButton();
            this.txtnCedula = new Guna.UI.WinForms.GunaTextBox();
            this.txtnApellidos = new Guna.UI.WinForms.GunaTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRegistro = new Guna.UI.WinForms.GunaButton();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.btnCerrar = new Guna.UI.WinForms.GunaImageButton();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaDragControl2 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaDragControl3 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.efecto = new Guna.UI.WinForms.GunaTransition(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoImagen)).BeginInit();
            this.containerIzq.SuspendLayout();
            this.containerDer.SuspendLayout();
            this.parent.SuspendLayout();
            this.movible.SuspendLayout();
            this.panelSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("container.BackgroundImage")));
            this.container.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.container.Controls.Add(this.logoImagen);
            this.container.Controls.Add(this.containerIzq);
            this.container.Controls.Add(this.containerDer);
            this.efecto.SetDecoration(this.container, Guna.UI.Animation.DecorationType.None);
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(0, 0);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(825, 500);
            this.container.TabIndex = 22;
            // 
            // logoImagen
            // 
            this.logoImagen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.logoImagen.BackColor = System.Drawing.Color.Transparent;
            this.efecto.SetDecoration(this.logoImagen, Guna.UI.Animation.DecorationType.None);
            this.logoImagen.Image = global::AppFlickDesktop.Properties.Resources.flick;
            this.logoImagen.Location = new System.Drawing.Point(68, 98);
            this.logoImagen.Name = "logoImagen";
            this.logoImagen.Size = new System.Drawing.Size(232, 83);
            this.logoImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.logoImagen.TabIndex = 19;
            this.logoImagen.TabStop = false;
            this.logoImagen.Click += new System.EventHandler(this.efecto_logo);
            // 
            // containerIzq
            // 
            this.containerIzq.BackColor = System.Drawing.Color.Transparent;
            this.containerIzq.Controls.Add(this.txtPassword);
            this.containerIzq.Controls.Add(this.txtUsername);
            this.containerIzq.Controls.Add(this.btnLogin);
            this.containerIzq.Controls.Add(this.gunaLabel1);
            this.containerIzq.Controls.Add(this.gunaLabel2);
            this.containerIzq.Controls.Add(this.gunaLabel3);
            this.containerIzq.Controls.Add(this.gunaLabel4);
            this.efecto.SetDecoration(this.containerIzq, Guna.UI.Animation.DecorationType.None);
            this.containerIzq.Location = new System.Drawing.Point(0, 0);
            this.containerIzq.Name = "containerIzq";
            this.containerIzq.Size = new System.Drawing.Size(440, 500);
            this.containerIzq.TabIndex = 26;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtPassword.BaseColor = System.Drawing.Color.White;
            this.txtPassword.BorderColor = System.Drawing.Color.White;
            this.txtPassword.BorderSize = 0;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.efecto.SetDecoration(this.txtPassword, Guna.UI.Animation.DecorationType.None);
            this.txtPassword.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtPassword.FocusedBorderColor = System.Drawing.Color.White;
            this.txtPassword.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.txtPassword.Location = new System.Drawing.Point(79, 275);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Radius = 10;
            this.txtPassword.Size = new System.Drawing.Size(273, 30);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.TextOffsetX = 10;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtUsername.BackColor = System.Drawing.Color.Transparent;
            this.txtUsername.BaseColor = System.Drawing.Color.White;
            this.txtUsername.BorderColor = System.Drawing.Color.White;
            this.txtUsername.BorderSize = 0;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.efecto.SetDecoration(this.txtUsername, Guna.UI.Animation.DecorationType.None);
            this.txtUsername.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtUsername.FocusedBorderColor = System.Drawing.Color.White;
            this.txtUsername.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.txtUsername.Location = new System.Drawing.Point(79, 220);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.Radius = 10;
            this.txtUsername.Size = new System.Drawing.Size(273, 30);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.TextOffsetX = 10;
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLogin.Animated = true;
            this.btnLogin.AnimationHoverSpeed = 0.07F;
            this.btnLogin.AnimationSpeed = 0.03F;
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(88)))), ((int)(((byte)(169)))));
            this.btnLogin.BorderColor = System.Drawing.Color.Black;
            this.efecto.SetDecoration(this.btnLogin, Guna.UI.Animation.DecorationType.None);
            this.btnLogin.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLogin.FocusedColor = System.Drawing.Color.Empty;
            this.btnLogin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Image = null;
            this.btnLogin.ImageSize = new System.Drawing.Size(20, 20);
            this.btnLogin.Location = new System.Drawing.Point(206, 323);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(237)))));
            this.btnLogin.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLogin.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLogin.OnHoverImage = null;
            this.btnLogin.OnPressedColor = System.Drawing.Color.Black;
            this.btnLogin.Radius = 10;
            this.btnLogin.Size = new System.Drawing.Size(146, 40);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.CausesValidation = false;
            this.efecto.SetDecoration(this.gunaLabel1, Guna.UI.Animation.DecorationType.None);
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(76, 333);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(123, 15);
            this.gunaLabel1.TabIndex = 10;
            this.gunaLabel1.Text = "Olvidó su contraseña?";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.CausesValidation = false;
            this.efecto.SetDecoration(this.gunaLabel2, Guna.UI.Animation.DecorationType.None);
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.ForeColor = System.Drawing.Color.White;
            this.gunaLabel2.Location = new System.Drawing.Point(91, 256);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(70, 15);
            this.gunaLabel2.TabIndex = 11;
            this.gunaLabel2.Text = "Contraseña:";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.CausesValidation = false;
            this.efecto.SetDecoration(this.gunaLabel3, Guna.UI.Animation.DecorationType.None);
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.ForeColor = System.Drawing.Color.White;
            this.gunaLabel3.Location = new System.Drawing.Point(91, 202);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(50, 15);
            this.gunaLabel3.TabIndex = 12;
            this.gunaLabel3.Text = "Usuario:";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.CausesValidation = false;
            this.efecto.SetDecoration(this.gunaLabel4, Guna.UI.Animation.DecorationType.None);
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel4.ForeColor = System.Drawing.Color.White;
            this.gunaLabel4.Location = new System.Drawing.Point(129, 434);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(157, 15);
            this.gunaLabel4.TabIndex = 13;
            this.gunaLabel4.Text = "ProjectFlick 2019 © GPL v3.0";
            // 
            // containerDer
            // 
            this.containerDer.BackColor = System.Drawing.Color.Transparent;
            this.containerDer.Controls.Add(this.parent);
            this.containerDer.Controls.Add(this.panelSuperior);
            this.efecto.SetDecoration(this.containerDer, Guna.UI.Animation.DecorationType.None);
            this.containerDer.Location = new System.Drawing.Point(440, 0);
            this.containerDer.Name = "containerDer";
            this.containerDer.Size = new System.Drawing.Size(385, 500);
            this.containerDer.TabIndex = 22;
            // 
            // parent
            // 
            this.parent.Controls.Add(this.movible);
            this.parent.Controls.Add(this.label1);
            this.parent.Controls.Add(this.label6);
            this.parent.Controls.Add(this.btnRegistro);
            this.efecto.SetDecoration(this.parent, Guna.UI.Animation.DecorationType.None);
            this.parent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parent.Location = new System.Drawing.Point(0, 55);
            this.parent.Name = "parent";
            this.parent.Size = new System.Drawing.Size(385, 445);
            this.parent.TabIndex = 25;
            // 
            // movible
            // 
            this.movible.BackColor = System.Drawing.Color.Transparent;
            this.movible.BaseColor = System.Drawing.Color.Transparent;
            this.movible.Controls.Add(this.btnCancelar);
            this.movible.Controls.Add(this.gunaLabel11);
            this.movible.Controls.Add(this.gunaLabel12);
            this.movible.Controls.Add(this.txtnUsuario);
            this.movible.Controls.Add(this.txtnContrasena);
            this.movible.Controls.Add(this.gunaLabel10);
            this.movible.Controls.Add(this.gunaLabel9);
            this.movible.Controls.Add(this.gunaLabel8);
            this.movible.Controls.Add(this.gunaLabel7);
            this.movible.Controls.Add(this.gunaLabel6);
            this.movible.Controls.Add(this.gunaLabel5);
            this.movible.Controls.Add(this.txtnEmail);
            this.movible.Controls.Add(this.txtnDireccion);
            this.movible.Controls.Add(this.txtnNombres);
            this.movible.Controls.Add(this.txtnTelefono);
            this.movible.Controls.Add(this.btnRegistrar);
            this.movible.Controls.Add(this.txtnCedula);
            this.movible.Controls.Add(this.txtnApellidos);
            this.efecto.SetDecoration(this.movible, Guna.UI.Animation.DecorationType.None);
            this.movible.Location = new System.Drawing.Point(0, 430);
            this.movible.Name = "movible";
            this.movible.Radius = 20;
            this.movible.Size = new System.Drawing.Size(360, 440);
            this.movible.TabIndex = 24;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancelar.Animated = true;
            this.btnCancelar.AnimationHoverSpeed = 0.07F;
            this.btnCancelar.AnimationSpeed = 0.03F;
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.BaseColor = System.Drawing.Color.Transparent;
            this.btnCancelar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(237)))));
            this.btnCancelar.BorderSize = 1;
            this.efecto.SetDecoration(this.btnCancelar, Guna.UI.Animation.DecorationType.None);
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCancelar.FocusedColor = System.Drawing.Color.Empty;
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Image = null;
            this.btnCancelar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnCancelar.Location = new System.Drawing.Point(107, 354);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(237)))));
            this.btnCancelar.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(237)))));
            this.btnCancelar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCancelar.OnHoverImage = null;
            this.btnCancelar.OnPressedColor = System.Drawing.Color.Black;
            this.btnCancelar.Radius = 10;
            this.btnCancelar.Size = new System.Drawing.Size(153, 28);
            this.btnCancelar.TabIndex = 22;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // gunaLabel11
            // 
            this.gunaLabel11.AutoSize = true;
            this.gunaLabel11.CausesValidation = false;
            this.efecto.SetDecoration(this.gunaLabel11, Guna.UI.Animation.DecorationType.None);
            this.gunaLabel11.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel11.ForeColor = System.Drawing.Color.White;
            this.gunaLabel11.Location = new System.Drawing.Point(39, 27);
            this.gunaLabel11.Name = "gunaLabel11";
            this.gunaLabel11.Size = new System.Drawing.Size(50, 15);
            this.gunaLabel11.TabIndex = 21;
            this.gunaLabel11.Text = "Usuario:";
            // 
            // gunaLabel12
            // 
            this.gunaLabel12.AutoSize = true;
            this.gunaLabel12.CausesValidation = false;
            this.efecto.SetDecoration(this.gunaLabel12, Guna.UI.Animation.DecorationType.None);
            this.gunaLabel12.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel12.ForeColor = System.Drawing.Color.White;
            this.gunaLabel12.Location = new System.Drawing.Point(198, 27);
            this.gunaLabel12.Name = "gunaLabel12";
            this.gunaLabel12.Size = new System.Drawing.Size(70, 15);
            this.gunaLabel12.TabIndex = 20;
            this.gunaLabel12.Text = "Contraseña:";
            // 
            // txtnUsuario
            // 
            this.txtnUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtnUsuario.BackColor = System.Drawing.Color.Transparent;
            this.txtnUsuario.BaseColor = System.Drawing.Color.White;
            this.txtnUsuario.BorderColor = System.Drawing.Color.White;
            this.txtnUsuario.BorderSize = 0;
            this.txtnUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.efecto.SetDecoration(this.txtnUsuario, Guna.UI.Animation.DecorationType.None);
            this.txtnUsuario.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtnUsuario.FocusedBorderColor = System.Drawing.Color.White;
            this.txtnUsuario.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.txtnUsuario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.txtnUsuario.Location = new System.Drawing.Point(27, 45);
            this.txtnUsuario.Name = "txtnUsuario";
            this.txtnUsuario.PasswordChar = '\0';
            this.txtnUsuario.Radius = 10;
            this.txtnUsuario.Size = new System.Drawing.Size(144, 30);
            this.txtnUsuario.TabIndex = 5;
            this.txtnUsuario.TextOffsetX = 10;
            // 
            // txtnContrasena
            // 
            this.txtnContrasena.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtnContrasena.BackColor = System.Drawing.Color.Transparent;
            this.txtnContrasena.BaseColor = System.Drawing.Color.White;
            this.txtnContrasena.BorderColor = System.Drawing.Color.White;
            this.txtnContrasena.BorderSize = 0;
            this.txtnContrasena.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.efecto.SetDecoration(this.txtnContrasena, Guna.UI.Animation.DecorationType.None);
            this.txtnContrasena.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtnContrasena.FocusedBorderColor = System.Drawing.Color.White;
            this.txtnContrasena.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.txtnContrasena.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnContrasena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.txtnContrasena.Location = new System.Drawing.Point(178, 46);
            this.txtnContrasena.Name = "txtnContrasena";
            this.txtnContrasena.PasswordChar = '●';
            this.txtnContrasena.Radius = 10;
            this.txtnContrasena.Size = new System.Drawing.Size(159, 30);
            this.txtnContrasena.TabIndex = 6;
            this.txtnContrasena.TextOffsetX = 10;
            this.txtnContrasena.UseSystemPasswordChar = true;
            // 
            // gunaLabel10
            // 
            this.gunaLabel10.AutoSize = true;
            this.gunaLabel10.CausesValidation = false;
            this.efecto.SetDecoration(this.gunaLabel10, Guna.UI.Animation.DecorationType.None);
            this.gunaLabel10.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel10.ForeColor = System.Drawing.Color.White;
            this.gunaLabel10.Location = new System.Drawing.Point(198, 185);
            this.gunaLabel10.Name = "gunaLabel10";
            this.gunaLabel10.Size = new System.Drawing.Size(39, 15);
            this.gunaLabel10.TabIndex = 17;
            this.gunaLabel10.Text = "Email:";
            // 
            // gunaLabel9
            // 
            this.gunaLabel9.AutoSize = true;
            this.gunaLabel9.CausesValidation = false;
            this.efecto.SetDecoration(this.gunaLabel9, Guna.UI.Animation.DecorationType.None);
            this.gunaLabel9.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel9.ForeColor = System.Drawing.Color.White;
            this.gunaLabel9.Location = new System.Drawing.Point(39, 185);
            this.gunaLabel9.Name = "gunaLabel9";
            this.gunaLabel9.Size = new System.Drawing.Size(55, 15);
            this.gunaLabel9.TabIndex = 16;
            this.gunaLabel9.Text = "Teléfono:";
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.CausesValidation = false;
            this.efecto.SetDecoration(this.gunaLabel8, Guna.UI.Animation.DecorationType.None);
            this.gunaLabel8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel8.ForeColor = System.Drawing.Color.White;
            this.gunaLabel8.Location = new System.Drawing.Point(39, 234);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(60, 15);
            this.gunaLabel8.TabIndex = 15;
            this.gunaLabel8.Text = "Dirección:";
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.CausesValidation = false;
            this.efecto.SetDecoration(this.gunaLabel7, Guna.UI.Animation.DecorationType.None);
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel7.ForeColor = System.Drawing.Color.White;
            this.gunaLabel7.Location = new System.Drawing.Point(39, 131);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(59, 15);
            this.gunaLabel7.TabIndex = 14;
            this.gunaLabel7.Text = "Apellidos:";
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.CausesValidation = false;
            this.efecto.SetDecoration(this.gunaLabel6, Guna.UI.Animation.DecorationType.None);
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel6.ForeColor = System.Drawing.Color.White;
            this.gunaLabel6.Location = new System.Drawing.Point(198, 131);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(59, 15);
            this.gunaLabel6.TabIndex = 13;
            this.gunaLabel6.Text = "Nombres:";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.CausesValidation = false;
            this.efecto.SetDecoration(this.gunaLabel5, Guna.UI.Animation.DecorationType.None);
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel5.ForeColor = System.Drawing.Color.White;
            this.gunaLabel5.Location = new System.Drawing.Point(39, 78);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(47, 15);
            this.gunaLabel5.TabIndex = 12;
            this.gunaLabel5.Text = "Cedula:";
            // 
            // txtnEmail
            // 
            this.txtnEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtnEmail.BackColor = System.Drawing.Color.Transparent;
            this.txtnEmail.BaseColor = System.Drawing.Color.White;
            this.txtnEmail.BorderColor = System.Drawing.Color.White;
            this.txtnEmail.BorderSize = 0;
            this.txtnEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.efecto.SetDecoration(this.txtnEmail, Guna.UI.Animation.DecorationType.None);
            this.txtnEmail.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtnEmail.FocusedBorderColor = System.Drawing.Color.White;
            this.txtnEmail.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.txtnEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.txtnEmail.Location = new System.Drawing.Point(182, 201);
            this.txtnEmail.Name = "txtnEmail";
            this.txtnEmail.PasswordChar = '\0';
            this.txtnEmail.Radius = 10;
            this.txtnEmail.Size = new System.Drawing.Size(159, 30);
            this.txtnEmail.TabIndex = 11;
            this.txtnEmail.TextOffsetX = 10;
            // 
            // txtnDireccion
            // 
            this.txtnDireccion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtnDireccion.BackColor = System.Drawing.Color.Transparent;
            this.txtnDireccion.BaseColor = System.Drawing.Color.White;
            this.txtnDireccion.BorderColor = System.Drawing.Color.White;
            this.txtnDireccion.BorderSize = 0;
            this.txtnDireccion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.efecto.SetDecoration(this.txtnDireccion, Guna.UI.Animation.DecorationType.None);
            this.txtnDireccion.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtnDireccion.FocusedBorderColor = System.Drawing.Color.White;
            this.txtnDireccion.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.txtnDireccion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.txtnDireccion.Location = new System.Drawing.Point(31, 252);
            this.txtnDireccion.Name = "txtnDireccion";
            this.txtnDireccion.PasswordChar = '\0';
            this.txtnDireccion.Radius = 10;
            this.txtnDireccion.Size = new System.Drawing.Size(310, 30);
            this.txtnDireccion.TabIndex = 12;
            this.txtnDireccion.TextOffsetX = 10;
            // 
            // txtnNombres
            // 
            this.txtnNombres.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtnNombres.BackColor = System.Drawing.Color.Transparent;
            this.txtnNombres.BaseColor = System.Drawing.Color.White;
            this.txtnNombres.BorderColor = System.Drawing.Color.White;
            this.txtnNombres.BorderSize = 0;
            this.txtnNombres.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.efecto.SetDecoration(this.txtnNombres, Guna.UI.Animation.DecorationType.None);
            this.txtnNombres.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtnNombres.FocusedBorderColor = System.Drawing.Color.White;
            this.txtnNombres.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.txtnNombres.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnNombres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.txtnNombres.Location = new System.Drawing.Point(182, 149);
            this.txtnNombres.Name = "txtnNombres";
            this.txtnNombres.PasswordChar = '\0';
            this.txtnNombres.Radius = 10;
            this.txtnNombres.Size = new System.Drawing.Size(156, 30);
            this.txtnNombres.TabIndex = 9;
            this.txtnNombres.TextOffsetX = 10;
            // 
            // txtnTelefono
            // 
            this.txtnTelefono.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtnTelefono.BackColor = System.Drawing.Color.Transparent;
            this.txtnTelefono.BaseColor = System.Drawing.Color.White;
            this.txtnTelefono.BorderColor = System.Drawing.Color.White;
            this.txtnTelefono.BorderSize = 0;
            this.txtnTelefono.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.efecto.SetDecoration(this.txtnTelefono, Guna.UI.Animation.DecorationType.None);
            this.txtnTelefono.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtnTelefono.FocusedBorderColor = System.Drawing.Color.White;
            this.txtnTelefono.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.txtnTelefono.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.txtnTelefono.Location = new System.Drawing.Point(31, 201);
            this.txtnTelefono.Name = "txtnTelefono";
            this.txtnTelefono.PasswordChar = '\0';
            this.txtnTelefono.Radius = 10;
            this.txtnTelefono.Size = new System.Drawing.Size(140, 30);
            this.txtnTelefono.TabIndex = 10;
            this.txtnTelefono.TextOffsetX = 10;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRegistrar.Animated = true;
            this.btnRegistrar.AnimationHoverSpeed = 0.07F;
            this.btnRegistrar.AnimationSpeed = 0.03F;
            this.btnRegistrar.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistrar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(88)))), ((int)(((byte)(169)))));
            this.btnRegistrar.BorderColor = System.Drawing.Color.Black;
            this.efecto.SetDecoration(this.btnRegistrar, Guna.UI.Animation.DecorationType.None);
            this.btnRegistrar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRegistrar.FocusedColor = System.Drawing.Color.Empty;
            this.btnRegistrar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Image = null;
            this.btnRegistrar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnRegistrar.Location = new System.Drawing.Point(73, 302);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(237)))));
            this.btnRegistrar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnRegistrar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnRegistrar.OnHoverImage = null;
            this.btnRegistrar.OnPressedColor = System.Drawing.Color.Black;
            this.btnRegistrar.Radius = 10;
            this.btnRegistrar.Size = new System.Drawing.Size(220, 40);
            this.btnRegistrar.TabIndex = 13;
            this.btnRegistrar.Text = "Registrarse ahora";
            this.btnRegistrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtnCedula
            // 
            this.txtnCedula.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtnCedula.BackColor = System.Drawing.Color.Transparent;
            this.txtnCedula.BaseColor = System.Drawing.Color.White;
            this.txtnCedula.BorderColor = System.Drawing.Color.White;
            this.txtnCedula.BorderSize = 0;
            this.txtnCedula.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.efecto.SetDecoration(this.txtnCedula, Guna.UI.Animation.DecorationType.None);
            this.txtnCedula.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtnCedula.FocusedBorderColor = System.Drawing.Color.White;
            this.txtnCedula.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.txtnCedula.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnCedula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.txtnCedula.Location = new System.Drawing.Point(27, 96);
            this.txtnCedula.Name = "txtnCedula";
            this.txtnCedula.PasswordChar = '\0';
            this.txtnCedula.Radius = 10;
            this.txtnCedula.Size = new System.Drawing.Size(310, 30);
            this.txtnCedula.TabIndex = 7;
            this.txtnCedula.TextOffsetX = 10;
            // 
            // txtnApellidos
            // 
            this.txtnApellidos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtnApellidos.BackColor = System.Drawing.Color.Transparent;
            this.txtnApellidos.BaseColor = System.Drawing.Color.White;
            this.txtnApellidos.BorderColor = System.Drawing.Color.White;
            this.txtnApellidos.BorderSize = 0;
            this.txtnApellidos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.efecto.SetDecoration(this.txtnApellidos, Guna.UI.Animation.DecorationType.None);
            this.txtnApellidos.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtnApellidos.FocusedBorderColor = System.Drawing.Color.White;
            this.txtnApellidos.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.txtnApellidos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnApellidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.txtnApellidos.Location = new System.Drawing.Point(27, 149);
            this.txtnApellidos.Name = "txtnApellidos";
            this.txtnApellidos.PasswordChar = '\0';
            this.txtnApellidos.Radius = 10;
            this.txtnApellidos.Size = new System.Drawing.Size(144, 30);
            this.txtnApellidos.TabIndex = 8;
            this.txtnApellidos.TextOffsetX = 10;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.efecto.SetDecoration(this.label1, Guna.UI.Animation.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(76, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 40);
            this.label1.TabIndex = 22;
            this.label1.Text = "La mejor experiencia";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.efecto.SetDecoration(this.label6, Guna.UI.Animation.DecorationType.None);
            this.label6.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(181, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 40);
            this.label6.TabIndex = 23;
            this.label6.Text = "a tu alcance.";
            // 
            // btnRegistro
            // 
            this.btnRegistro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRegistro.Animated = true;
            this.btnRegistro.AnimationHoverSpeed = 0.07F;
            this.btnRegistro.AnimationSpeed = 0.03F;
            this.btnRegistro.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistro.BaseColor = System.Drawing.Color.Transparent;
            this.btnRegistro.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(237)))));
            this.btnRegistro.BorderSize = 1;
            this.efecto.SetDecoration(this.btnRegistro, Guna.UI.Animation.DecorationType.None);
            this.btnRegistro.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRegistro.FocusedColor = System.Drawing.Color.Empty;
            this.btnRegistro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistro.ForeColor = System.Drawing.Color.White;
            this.btnRegistro.Image = null;
            this.btnRegistro.ImageSize = new System.Drawing.Size(20, 20);
            this.btnRegistro.Location = new System.Drawing.Point(188, 288);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(237)))));
            this.btnRegistro.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(237)))));
            this.btnRegistro.OnHoverForeColor = System.Drawing.Color.White;
            this.btnRegistro.OnHoverImage = null;
            this.btnRegistro.OnPressedColor = System.Drawing.Color.Black;
            this.btnRegistro.Radius = 10;
            this.btnRegistro.Size = new System.Drawing.Size(153, 40);
            this.btnRegistro.TabIndex = 4;
            this.btnRegistro.Text = "Registrarse";
            this.btnRegistro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // panelSuperior
            // 
            this.panelSuperior.Controls.Add(this.btnCerrar);
            this.efecto.SetDecoration(this.panelSuperior, Guna.UI.Animation.DecorationType.None);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(385, 55);
            this.panelSuperior.TabIndex = 24;
            // 
            // btnCerrar
            // 
            this.efecto.SetDecoration(this.btnCerrar, Guna.UI.Animation.DecorationType.None);
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCerrar.Image = global::AppFlickDesktop.Properties.Resources.icon_cerrar;
            this.btnCerrar.ImageSize = new System.Drawing.Size(32, 32);
            this.btnCerrar.Location = new System.Drawing.Point(320, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.OnHoverImage = null;
            this.btnCerrar.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btnCerrar.Size = new System.Drawing.Size(32, 32);
            this.btnCerrar.TabIndex = 21;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this.containerIzq;
            // 
            // gunaDragControl2
            // 
            this.gunaDragControl2.TargetControl = this.panelSuperior;
            // 
            // gunaDragControl3
            // 
            this.gunaDragControl3.TargetControl = this.parent;
            // 
            // efecto
            // 
            this.efecto.AnimationType = Guna.UI.Animation.AnimationType.Scale;
            this.efecto.Cursor = null;
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
            this.efecto.DefaultAnimation = animation2;
            // 
            // timer
            // 
            this.timer.Interval = 30;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(825, 500);
            this.Controls.Add(this.container);
            this.efecto.SetDecoration(this, Guna.UI.Animation.DecorationType.None);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.container.ResumeLayout(false);
            this.container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoImagen)).EndInit();
            this.containerIzq.ResumeLayout(false);
            this.containerIzq.PerformLayout();
            this.containerDer.ResumeLayout(false);
            this.parent.ResumeLayout(false);
            this.parent.PerformLayout();
            this.movible.ResumeLayout(false);
            this.movible.PerformLayout();
            this.panelSuperior.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel containerDer;
        private Guna.UI.WinForms.GunaImageButton btnCerrar;
        private System.Windows.Forms.Panel container;
        private System.Windows.Forms.PictureBox logoImagen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaButton btnRegistro;
        private System.Windows.Forms.Panel parent;
        private System.Windows.Forms.Panel panelSuperior;
        private Guna.UI.WinForms.GunaElipsePanel movible;
        private Guna.UI.WinForms.GunaTextBox txtnEmail;
        private Guna.UI.WinForms.GunaTextBox txtnDireccion;
        private Guna.UI.WinForms.GunaTextBox txtnNombres;
        private Guna.UI.WinForms.GunaTextBox txtnTelefono;
        private Guna.UI.WinForms.GunaButton btnRegistrar;
        private Guna.UI.WinForms.GunaTextBox txtnCedula;
        private Guna.UI.WinForms.GunaTextBox txtnApellidos;
        private Guna.UI.WinForms.GunaLabel gunaLabel11;
        private Guna.UI.WinForms.GunaLabel gunaLabel12;
        private Guna.UI.WinForms.GunaTextBox txtnUsuario;
        private Guna.UI.WinForms.GunaTextBox txtnContrasena;
        private Guna.UI.WinForms.GunaLabel gunaLabel10;
        private Guna.UI.WinForms.GunaLabel gunaLabel9;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private System.Windows.Forms.Panel containerIzq;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaButton btnLogin;
        private Guna.UI.WinForms.GunaTextBox txtUsername;
        private Guna.UI.WinForms.GunaTextBox txtPassword;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl2;
        private Guna.UI.WinForms.GunaButton btnCancelar;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl3;
        private Guna.UI.WinForms.GunaTransition efecto;
        private System.Windows.Forms.Timer timer;
    }
}