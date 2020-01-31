namespace AppFlickDesktop.Vistas.Forms
{
    partial class VistaFacturas_Cliente
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
            this.container = new System.Windows.Forms.Panel();
            this.panelFunciones = new System.Windows.Forms.Panel();
            this.elem_Factura_Cliente1 = new AppFlickDesktop.Vistas.Forms.Elem_Factura_Cliente();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.scrollBar = new Guna.UI.WinForms.GunaVScrollBar();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.txtBuscarFactura = new Guna.UI.WinForms.GunaTextBox();
            this.btnBuscarFactura = new Guna.UI.WinForms.GunaCircleButton();
            this.container.SuspendLayout();
            this.panelFunciones.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.container.Controls.Add(this.panelFunciones);
            this.container.Controls.Add(this.scrollBar);
            this.container.Location = new System.Drawing.Point(31, 79);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(920, 408);
            this.container.TabIndex = 70;
            // 
            // panelFunciones
            // 
            this.panelFunciones.Controls.Add(this.elem_Factura_Cliente1);
            this.panelFunciones.Controls.Add(this.panel1);
            this.panelFunciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFunciones.Location = new System.Drawing.Point(0, 0);
            this.panelFunciones.Name = "panelFunciones";
            this.panelFunciones.Size = new System.Drawing.Size(903, 408);
            this.panelFunciones.TabIndex = 70;
            // 
            // elem_Factura_Cliente1
            // 
            this.elem_Factura_Cliente1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.elem_Factura_Cliente1.Dock = System.Windows.Forms.DockStyle.Top;
            this.elem_Factura_Cliente1.Location = new System.Drawing.Point(0, 63);
            this.elem_Factura_Cliente1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.elem_Factura_Cliente1.Name = "elem_Factura_Cliente1";
            this.elem_Factura_Cliente1.Size = new System.Drawing.Size(903, 50);
            this.elem_Factura_Cliente1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gunaLabel8);
            this.panel1.Controls.Add(this.gunaLabel7);
            this.panel1.Controls.Add(this.gunaLabel6);
            this.panel1.Controls.Add(this.gunaLabel4);
            this.panel1.Controls.Add(this.gunaLabel3);
            this.panel1.Controls.Add(this.gunaLabel2);
            this.panel1.Controls.Add(this.gunaLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(903, 63);
            this.panel1.TabIndex = 1;
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.CausesValidation = false;
            this.gunaLabel8.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel8.ForeColor = System.Drawing.Color.White;
            this.gunaLabel8.Location = new System.Drawing.Point(785, 0);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(118, 63);
            this.gunaLabel8.TabIndex = 75;
            this.gunaLabel8.Text = "Imprimir";
            this.gunaLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.CausesValidation = false;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel7.ForeColor = System.Drawing.Color.White;
            this.gunaLabel7.Location = new System.Drawing.Point(713, 0);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(72, 63);
            this.gunaLabel7.TabIndex = 74;
            this.gunaLabel7.Text = "Total";
            this.gunaLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.CausesValidation = false;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel6.ForeColor = System.Drawing.Color.White;
            this.gunaLabel6.Location = new System.Drawing.Point(649, 0);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(64, 63);
            this.gunaLabel6.TabIndex = 73;
            this.gunaLabel6.Text = "Cant.";
            this.gunaLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.CausesValidation = false;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.Color.White;
            this.gunaLabel4.Location = new System.Drawing.Point(540, 0);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(109, 63);
            this.gunaLabel4.TabIndex = 72;
            this.gunaLabel4.Text = "Hora";
            this.gunaLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.CausesValidation = false;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.White;
            this.gunaLabel3.Location = new System.Drawing.Point(418, 0);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(122, 63);
            this.gunaLabel3.TabIndex = 71;
            this.gunaLabel3.Text = "Fecha";
            this.gunaLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.CausesValidation = false;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.White;
            this.gunaLabel2.Location = new System.Drawing.Point(85, 0);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(333, 63);
            this.gunaLabel2.TabIndex = 70;
            this.gunaLabel2.Text = "Película";
            this.gunaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.CausesValidation = false;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(0, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(85, 63);
            this.gunaLabel1.TabIndex = 69;
            this.gunaLabel1.Text = "N° Factura";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scrollBar
            // 
            this.scrollBar.Dock = System.Windows.Forms.DockStyle.Right;
            this.scrollBar.LargeChange = 10;
            this.scrollBar.Location = new System.Drawing.Point(903, 0);
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
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.CausesValidation = false;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.ForeColor = System.Drawing.Color.White;
            this.gunaLabel5.Location = new System.Drawing.Point(24, 19);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(173, 37);
            this.gunaLabel5.TabIndex = 68;
            this.gunaLabel5.Text = "Mis facturas";
            // 
            // txtBuscarFactura
            // 
            this.txtBuscarFactura.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscarFactura.BackColor = System.Drawing.Color.Transparent;
            this.txtBuscarFactura.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.txtBuscarFactura.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txtBuscarFactura.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscarFactura.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.txtBuscarFactura.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(237)))));
            this.txtBuscarFactura.FocusedForeColor = System.Drawing.Color.White;
            this.txtBuscarFactura.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarFactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txtBuscarFactura.Location = new System.Drawing.Point(341, 24);
            this.txtBuscarFactura.Name = "txtBuscarFactura";
            this.txtBuscarFactura.PasswordChar = '\0';
            this.txtBuscarFactura.Radius = 10;
            this.txtBuscarFactura.Size = new System.Drawing.Size(564, 32);
            this.txtBuscarFactura.TabIndex = 67;
            this.txtBuscarFactura.Text = "Buscar....";
            this.txtBuscarFactura.TextOffsetX = 10;
            // 
            // btnBuscarFactura
            // 
            this.btnBuscarFactura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarFactura.AnimationHoverSpeed = 0.07F;
            this.btnBuscarFactura.AnimationSpeed = 0.03F;
            this.btnBuscarFactura.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(75)))), ((int)(((byte)(140)))));
            this.btnBuscarFactura.BorderColor = System.Drawing.Color.White;
            this.btnBuscarFactura.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBuscarFactura.FocusedColor = System.Drawing.Color.Empty;
            this.btnBuscarFactura.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBuscarFactura.ForeColor = System.Drawing.Color.White;
            this.btnBuscarFactura.Image = global::AppFlickDesktop.Properties.Resources.icon_buscar;
            this.btnBuscarFactura.ImageSize = new System.Drawing.Size(20, 20);
            this.btnBuscarFactura.Location = new System.Drawing.Point(921, 24);
            this.btnBuscarFactura.Name = "btnBuscarFactura";
            this.btnBuscarFactura.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(237)))));
            this.btnBuscarFactura.OnHoverBorderColor = System.Drawing.Color.White;
            this.btnBuscarFactura.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBuscarFactura.OnHoverImage = null;
            this.btnBuscarFactura.OnPressedColor = System.Drawing.Color.Black;
            this.btnBuscarFactura.Size = new System.Drawing.Size(30, 32);
            this.btnBuscarFactura.TabIndex = 69;
            this.btnBuscarFactura.Click += new System.EventHandler(this.btnBuscarFactura_Click);
            // 
            // VistaFacturas_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.Controls.Add(this.container);
            this.Controls.Add(this.btnBuscarFactura);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.txtBuscarFactura);
            this.Name = "VistaFacturas_Cliente";
            this.Size = new System.Drawing.Size(974, 506);
            this.container.ResumeLayout(false);
            this.panelFunciones.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel container;
        private System.Windows.Forms.Panel panelFunciones;
        private Guna.UI.WinForms.GunaVScrollBar scrollBar;
        private Guna.UI.WinForms.GunaCircleButton btnBuscarFactura;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaTextBox txtBuscarFactura;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Elem_Factura_Cliente elem_Factura_Cliente1;
    }
}
