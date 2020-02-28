namespace AppFlickAdministrador.Vistas.Forms
{
    partial class VistaFunciones_Admin
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBuscarFuncion = new Guna.UI.WinForms.GunaCircleButton();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.txtBuscarFuncion = new Guna.UI.WinForms.GunaTextBox();
            this.container = new System.Windows.Forms.Panel();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.scrollBar = new Guna.UI.WinForms.GunaVScrollBar();
            this.btnEditar = new Guna.UI.WinForms.GunaButton();
            this.container.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBuscarFuncion
            // 
            this.btnBuscarFuncion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarFuncion.Animated = true;
            this.btnBuscarFuncion.AnimationHoverSpeed = 0.07F;
            this.btnBuscarFuncion.AnimationSpeed = 0.03F;
            this.btnBuscarFuncion.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(75)))), ((int)(((byte)(140)))));
            this.btnBuscarFuncion.BorderColor = System.Drawing.Color.White;
            this.btnBuscarFuncion.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBuscarFuncion.FocusedColor = System.Drawing.Color.Empty;
            this.btnBuscarFuncion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBuscarFuncion.ForeColor = System.Drawing.Color.White;
            this.btnBuscarFuncion.Image = global::AppFlickAdministrador.Properties.Resources.icon_buscar;
            this.btnBuscarFuncion.ImageSize = new System.Drawing.Size(20, 20);
            this.btnBuscarFuncion.Location = new System.Drawing.Point(618, 21);
            this.btnBuscarFuncion.Name = "btnBuscarFuncion";
            this.btnBuscarFuncion.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(237)))));
            this.btnBuscarFuncion.OnHoverBorderColor = System.Drawing.Color.White;
            this.btnBuscarFuncion.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBuscarFuncion.OnHoverImage = null;
            this.btnBuscarFuncion.OnPressedColor = System.Drawing.Color.Black;
            this.btnBuscarFuncion.Size = new System.Drawing.Size(30, 32);
            this.btnBuscarFuncion.TabIndex = 65;
            this.btnBuscarFuncion.Click += new System.EventHandler(this.BtnBuscarFuncion_Click);
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.CausesValidation = false;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.ForeColor = System.Drawing.Color.White;
            this.gunaLabel5.Location = new System.Drawing.Point(19, 16);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(144, 37);
            this.gunaLabel5.TabIndex = 64;
            this.gunaLabel5.Text = "Funciones";
            // 
            // txtBuscarFuncion
            // 
            this.txtBuscarFuncion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscarFuncion.BackColor = System.Drawing.Color.Transparent;
            this.txtBuscarFuncion.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.txtBuscarFuncion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txtBuscarFuncion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscarFuncion.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.txtBuscarFuncion.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(237)))));
            this.txtBuscarFuncion.FocusedForeColor = System.Drawing.Color.White;
            this.txtBuscarFuncion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarFuncion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txtBuscarFuncion.Location = new System.Drawing.Point(213, 21);
            this.txtBuscarFuncion.Name = "txtBuscarFuncion";
            this.txtBuscarFuncion.PasswordChar = '\0';
            this.txtBuscarFuncion.Radius = 10;
            this.txtBuscarFuncion.Size = new System.Drawing.Size(399, 32);
            this.txtBuscarFuncion.TabIndex = 63;
            this.txtBuscarFuncion.Text = "Buscar....";
            this.txtBuscarFuncion.TextOffsetX = 10;
            this.txtBuscarFuncion.TextChanged += new System.EventHandler(this.TxtBuscarFuncion_TextChanged);
            this.txtBuscarFuncion.Enter += new System.EventHandler(this.TxtBuscarFuncion_Enter);
            this.txtBuscarFuncion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarFuncion_KeyPress);
            // 
            // container
            // 
            this.container.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.container.Controls.Add(this.panelContenedor);
            this.container.Controls.Add(this.scrollBar);
            this.container.Location = new System.Drawing.Point(26, 76);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(755, 408);
            this.container.TabIndex = 66;
            // 
            // panelFunciones
            // 
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.Name = "panelFunciones";
            this.panelContenedor.Size = new System.Drawing.Size(738, 408);
            this.panelContenedor.TabIndex = 70;
            // 
            // scrollBar
            // 
            this.scrollBar.Dock = System.Windows.Forms.DockStyle.Right;
            this.scrollBar.LargeChange = 10;
            this.scrollBar.Location = new System.Drawing.Point(738, 0);
            this.scrollBar.Maximum = 100;
            this.scrollBar.Name = "scrollBar";
            this.scrollBar.ScrollbarSize = 12;
            this.scrollBar.ScrollIdleColor = System.Drawing.Color.Silver;
            this.scrollBar.Size = new System.Drawing.Size(17, 408);
            this.scrollBar.TabIndex = 71;
            this.scrollBar.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(237)))));
            this.scrollBar.ThumbHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(237)))));
            this.scrollBar.ThumbPressedColor = System.Drawing.Color.DarkGray;
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.Animated = true;
            this.btnEditar.AnimationHoverSpeed = 0.07F;
            this.btnEditar.AnimationSpeed = 0.03F;
            this.btnEditar.BackColor = System.Drawing.Color.Transparent;
            this.btnEditar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.btnEditar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(237)))));
            this.btnEditar.BorderSize = 1;
            this.btnEditar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEditar.FocusedColor = System.Drawing.Color.Empty;
            this.btnEditar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Image = global::AppFlickAdministrador.Properties.Resources.icon_mas;
            this.btnEditar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEditar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnEditar.Location = new System.Drawing.Point(671, 21);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(237)))));
            this.btnEditar.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(237)))));
            this.btnEditar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEditar.OnHoverImage = null;
            this.btnEditar.OnPressedColor = System.Drawing.Color.Black;
            this.btnEditar.Radius = 7;
            this.btnEditar.Size = new System.Drawing.Size(110, 32);
            this.btnEditar.TabIndex = 68;
            this.btnEditar.Text = "Añadir";
            this.btnEditar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEditar.UseTransfarantBackground = true;
            // 
            // VistaFunciones_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.container);
            this.Controls.Add(this.btnBuscarFuncion);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.txtBuscarFuncion);
            this.Name = "VistaFunciones_Admin";
            this.Size = new System.Drawing.Size(809, 506);
            this.container.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaCircleButton btnBuscarFuncion;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaTextBox txtBuscarFuncion;
        private System.Windows.Forms.Panel container;
        private System.Windows.Forms.Panel panelContenedor;
        private Guna.UI.WinForms.GunaVScrollBar scrollBar;
        private Guna.UI.WinForms.GunaButton btnEditar;
    }
}
