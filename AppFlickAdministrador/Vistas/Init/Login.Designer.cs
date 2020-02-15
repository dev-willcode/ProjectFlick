namespace AppFlickAdministrador
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
            Guna.UI.Animation.Animation animation1 = new Guna.UI.Animation.Animation();
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
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.btnCerrar = new Guna.UI.WinForms.GunaImageButton();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaDragControl2 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaDragControl3 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.efecto = new Guna.UI.WinForms.GunaTransition(this.components);
            this.container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoImagen)).BeginInit();
            this.containerIzq.SuspendLayout();
            this.containerDer.SuspendLayout();
            this.parent.SuspendLayout();
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
            this.logoImagen.Image = global::AppFlickAdministrador.Properties.Resources.flick;
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
            this.parent.Controls.Add(this.label1);
            this.parent.Controls.Add(this.label6);
            this.efecto.SetDecoration(this.parent, Guna.UI.Animation.DecorationType.None);
            this.parent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parent.Location = new System.Drawing.Point(0, 55);
            this.parent.Name = "parent";
            this.parent.Size = new System.Drawing.Size(385, 445);
            this.parent.TabIndex = 25;
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
            this.btnCerrar.Image = global::AppFlickAdministrador.Properties.Resources.icon_cerrar;
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
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.efecto.DefaultAnimation = animation1;
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
        private System.Windows.Forms.Panel parent;
        private System.Windows.Forms.Panel panelSuperior;
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
        private Guna.UI.WinForms.GunaDragControl gunaDragControl3;
        private Guna.UI.WinForms.GunaTransition efecto;
    }
}