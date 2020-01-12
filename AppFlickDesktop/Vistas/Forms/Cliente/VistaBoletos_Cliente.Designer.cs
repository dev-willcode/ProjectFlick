namespace AppFlickDesktop.Vistas.Forms.Cliente
{
    partial class VistaBoletos_Cliente
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
            this.scrollBar = new Guna.UI.WinForms.GunaVScrollBar();
            this.btnBuscarFuncion = new Guna.UI.WinForms.GunaCircleButton();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.txtBuscarFuncion = new Guna.UI.WinForms.GunaTextBox();
            this.tablaBoletos = new System.Windows.Forms.TableLayoutPanel();
            this.container.SuspendLayout();
            this.panelFunciones.SuspendLayout();
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
            this.panelFunciones.Controls.Add(this.tablaBoletos);
            this.panelFunciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFunciones.Location = new System.Drawing.Point(0, 0);
            this.panelFunciones.Name = "panelFunciones";
            this.panelFunciones.Size = new System.Drawing.Size(903, 408);
            this.panelFunciones.TabIndex = 70;
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
            // btnBuscarFuncion
            // 
            this.btnBuscarFuncion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarFuncion.AnimationHoverSpeed = 0.07F;
            this.btnBuscarFuncion.AnimationSpeed = 0.03F;
            this.btnBuscarFuncion.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(75)))), ((int)(((byte)(140)))));
            this.btnBuscarFuncion.BorderColor = System.Drawing.Color.White;
            this.btnBuscarFuncion.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBuscarFuncion.FocusedColor = System.Drawing.Color.Empty;
            this.btnBuscarFuncion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBuscarFuncion.ForeColor = System.Drawing.Color.White;
            this.btnBuscarFuncion.Image = global::AppFlickDesktop.Properties.Resources.icon_buscar;
            this.btnBuscarFuncion.ImageSize = new System.Drawing.Size(20, 20);
            this.btnBuscarFuncion.Location = new System.Drawing.Point(921, 24);
            this.btnBuscarFuncion.Name = "btnBuscarFuncion";
            this.btnBuscarFuncion.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(237)))));
            this.btnBuscarFuncion.OnHoverBorderColor = System.Drawing.Color.White;
            this.btnBuscarFuncion.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBuscarFuncion.OnHoverImage = null;
            this.btnBuscarFuncion.OnPressedColor = System.Drawing.Color.Black;
            this.btnBuscarFuncion.Size = new System.Drawing.Size(30, 32);
            this.btnBuscarFuncion.TabIndex = 69;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.CausesValidation = false;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.ForeColor = System.Drawing.Color.White;
            this.gunaLabel5.Location = new System.Drawing.Point(24, 19);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(174, 37);
            this.gunaLabel5.TabIndex = 68;
            this.gunaLabel5.Text = "Mis boletos ";
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
            this.txtBuscarFuncion.Location = new System.Drawing.Point(341, 24);
            this.txtBuscarFuncion.Name = "txtBuscarFuncion";
            this.txtBuscarFuncion.PasswordChar = '\0';
            this.txtBuscarFuncion.Radius = 10;
            this.txtBuscarFuncion.Size = new System.Drawing.Size(564, 32);
            this.txtBuscarFuncion.TabIndex = 67;
            this.txtBuscarFuncion.Text = "Buscar....";
            this.txtBuscarFuncion.TextOffsetX = 10;
            // 
            // tablaBoletos
            // 
            this.tablaBoletos.ColumnCount = 2;
            this.tablaBoletos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tablaBoletos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tablaBoletos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablaBoletos.Location = new System.Drawing.Point(0, 0);
            this.tablaBoletos.Name = "tablaBoletos";
            this.tablaBoletos.RowCount = 2;
            this.tablaBoletos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablaBoletos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablaBoletos.Size = new System.Drawing.Size(903, 408);
            this.tablaBoletos.TabIndex = 0;
            // 
            // VistaBoletos_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.Controls.Add(this.container);
            this.Controls.Add(this.btnBuscarFuncion);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.txtBuscarFuncion);
            this.Name = "VistaBoletos_Cliente";
            this.Size = new System.Drawing.Size(974, 506);
            this.container.ResumeLayout(false);
            this.panelFunciones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel container;
        private System.Windows.Forms.Panel panelFunciones;
        private Guna.UI.WinForms.GunaVScrollBar scrollBar;
        private Guna.UI.WinForms.GunaCircleButton btnBuscarFuncion;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaTextBox txtBuscarFuncion;
        private System.Windows.Forms.TableLayoutPanel tablaBoletos;
    }
}
