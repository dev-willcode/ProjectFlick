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
            this.tablaBoletos = new System.Windows.Forms.TableLayoutPanel();
            this.scrollBar = new Guna.UI.WinForms.GunaVScrollBar();
            this.btnBuscarBoleto = new Guna.UI.WinForms.GunaCircleButton();
            this.label_boletos = new Guna.UI.WinForms.GunaLabel();
            this.txtBuscarBoleto = new Guna.UI.WinForms.GunaTextBox();
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
            this.container.Location = new System.Drawing.Point(41, 97);
            this.container.Margin = new System.Windows.Forms.Padding(4);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(1227, 502);
            this.container.TabIndex = 70;
            // 
            // panelFunciones
            // 
            this.panelFunciones.Controls.Add(this.tablaBoletos);
            this.panelFunciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFunciones.Location = new System.Drawing.Point(0, 0);
            this.panelFunciones.Margin = new System.Windows.Forms.Padding(4);
            this.panelFunciones.Name = "panelFunciones";
            this.panelFunciones.Size = new System.Drawing.Size(1204, 502);
            this.panelFunciones.TabIndex = 70;
            // 
            // tablaBoletos
            // 
            this.tablaBoletos.ColumnCount = 2;
            this.tablaBoletos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tablaBoletos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tablaBoletos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablaBoletos.Location = new System.Drawing.Point(0, 0);
            this.tablaBoletos.Margin = new System.Windows.Forms.Padding(4);
            this.tablaBoletos.Name = "tablaBoletos";
            this.tablaBoletos.RowCount = 2;
            this.tablaBoletos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablaBoletos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablaBoletos.Size = new System.Drawing.Size(1204, 502);
            this.tablaBoletos.TabIndex = 0;
            // 
            // scrollBar
            // 
            this.scrollBar.Dock = System.Windows.Forms.DockStyle.Right;
            this.scrollBar.LargeChange = 10;
            this.scrollBar.Location = new System.Drawing.Point(1204, 0);
            this.scrollBar.Margin = new System.Windows.Forms.Padding(4);
            this.scrollBar.Maximum = 100;
            this.scrollBar.Name = "scrollBar";
            this.scrollBar.ScrollbarSize = 12;
            this.scrollBar.ScrollIdleColor = System.Drawing.Color.Silver;
            this.scrollBar.Size = new System.Drawing.Size(23, 502);
            this.scrollBar.TabIndex = 71;
            this.scrollBar.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(237)))));
            this.scrollBar.ThumbHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(237)))));
            this.scrollBar.ThumbPressedColor = System.Drawing.Color.DarkGray;
            // 
            // btnBuscarBoleto
            // 
            this.btnBuscarBoleto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarBoleto.AnimationHoverSpeed = 0.07F;
            this.btnBuscarBoleto.AnimationSpeed = 0.03F;
            this.btnBuscarBoleto.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(75)))), ((int)(((byte)(140)))));
            this.btnBuscarBoleto.BorderColor = System.Drawing.Color.White;
            this.btnBuscarBoleto.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBuscarBoleto.FocusedColor = System.Drawing.Color.Empty;
            this.btnBuscarBoleto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBuscarBoleto.ForeColor = System.Drawing.Color.White;
            this.btnBuscarBoleto.Image = global::AppFlickDesktop.Properties.Resources.icon_buscar;
            this.btnBuscarBoleto.ImageSize = new System.Drawing.Size(20, 20);
            this.btnBuscarBoleto.Location = new System.Drawing.Point(1228, 30);
            this.btnBuscarBoleto.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarBoleto.Name = "btnBuscarBoleto";
            this.btnBuscarBoleto.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(237)))));
            this.btnBuscarBoleto.OnHoverBorderColor = System.Drawing.Color.White;
            this.btnBuscarBoleto.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBuscarBoleto.OnHoverImage = null;
            this.btnBuscarBoleto.OnPressedColor = System.Drawing.Color.Black;
            this.btnBuscarBoleto.Size = new System.Drawing.Size(40, 39);
            this.btnBuscarBoleto.TabIndex = 69;
            // 
            // label_boletos
            // 
            this.label_boletos.AutoSize = true;
            this.label_boletos.CausesValidation = false;
            this.label_boletos.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_boletos.ForeColor = System.Drawing.Color.White;
            this.label_boletos.Location = new System.Drawing.Point(32, 23);
            this.label_boletos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_boletos.Name = "label_boletos";
            this.label_boletos.Size = new System.Drawing.Size(215, 46);
            this.label_boletos.TabIndex = 68;
            this.label_boletos.Text = "Mis boletos ";
            // 
            // txtBuscarBoleto
            // 
            this.txtBuscarBoleto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscarBoleto.BackColor = System.Drawing.Color.Transparent;
            this.txtBuscarBoleto.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.txtBuscarBoleto.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txtBuscarBoleto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscarBoleto.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.txtBuscarBoleto.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(237)))));
            this.txtBuscarBoleto.FocusedForeColor = System.Drawing.Color.White;
            this.txtBuscarBoleto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarBoleto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txtBuscarBoleto.Location = new System.Drawing.Point(455, 30);
            this.txtBuscarBoleto.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscarBoleto.Name = "txtBuscarBoleto";
            this.txtBuscarBoleto.PasswordChar = '\0';
            this.txtBuscarBoleto.Radius = 10;
            this.txtBuscarBoleto.Size = new System.Drawing.Size(752, 39);
            this.txtBuscarBoleto.TabIndex = 67;
            this.txtBuscarBoleto.Text = "Buscar....";
            this.txtBuscarBoleto.TextOffsetX = 10;
            // 
            // VistaBoletos_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.Controls.Add(this.container);
            this.Controls.Add(this.btnBuscarBoleto);
            this.Controls.Add(this.label_boletos);
            this.Controls.Add(this.txtBuscarBoleto);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VistaBoletos_Cliente";
            this.Size = new System.Drawing.Size(1299, 623);
            this.container.ResumeLayout(false);
            this.panelFunciones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel container;
        private System.Windows.Forms.Panel panelFunciones;
        private Guna.UI.WinForms.GunaVScrollBar scrollBar;
        private Guna.UI.WinForms.GunaCircleButton btnBuscarBoleto;
        private Guna.UI.WinForms.GunaLabel label_boletos;
        private Guna.UI.WinForms.GunaTextBox txtBuscarBoleto;
        private System.Windows.Forms.TableLayoutPanel tablaBoletos;
    }
}
