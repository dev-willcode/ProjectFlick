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
            this.panelFacturas = new System.Windows.Forms.Panel();
            this.scrollBar = new Guna.UI.WinForms.GunaVScrollBar();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.txtBuscarFactura = new Guna.UI.WinForms.GunaTextBox();
            this.btnBuscarFactura = new Guna.UI.WinForms.GunaCircleButton();
            this.tableContainer = new System.Windows.Forms.TableLayoutPanel();
            this.var_numero_factura = new Guna.UI.WinForms.GunaLabel();
            this.var_costo_total = new Guna.UI.WinForms.GunaLabel();
            this.var_cant_boletos = new Guna.UI.WinForms.GunaLabel();
            this.var_hora = new Guna.UI.WinForms.GunaLabel();
            this.var_fecha = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.var_imprimir = new Guna.UI.WinForms.GunaLabel();
            this.container.SuspendLayout();
            this.tableContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.container.Controls.Add(this.panelFacturas);
            this.container.Controls.Add(this.scrollBar);
            this.container.Location = new System.Drawing.Point(31, 122);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(920, 365);
            this.container.TabIndex = 70;
            // 
            // panelFacturas
            // 
            this.panelFacturas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFacturas.Location = new System.Drawing.Point(0, 0);
            this.panelFacturas.Name = "panelFacturas";
            this.panelFacturas.Size = new System.Drawing.Size(903, 365);
            this.panelFacturas.TabIndex = 70;
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
            this.scrollBar.Size = new System.Drawing.Size(17, 365);
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
            // tableContainer
            // 
            this.tableContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableContainer.ColumnCount = 7;
            this.tableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.500729F));
            this.tableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.19006F));
            this.tableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.93887F));
            this.tableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.06336F));
            this.tableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.532984F));
            this.tableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.710646F));
            this.tableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.06336F));
            this.tableContainer.Controls.Add(this.var_imprimir, 6, 0);
            this.tableContainer.Controls.Add(this.gunaLabel1, 1, 0);
            this.tableContainer.Controls.Add(this.var_numero_factura, 0, 0);
            this.tableContainer.Controls.Add(this.var_costo_total, 5, 0);
            this.tableContainer.Controls.Add(this.var_fecha, 2, 0);
            this.tableContainer.Controls.Add(this.var_cant_boletos, 4, 0);
            this.tableContainer.Controls.Add(this.var_hora, 3, 0);
            this.tableContainer.Location = new System.Drawing.Point(34, 66);
            this.tableContainer.Name = "tableContainer";
            this.tableContainer.RowCount = 1;
            this.tableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableContainer.Size = new System.Drawing.Size(900, 50);
            this.tableContainer.TabIndex = 89;
            // 
            // var_numero_factura
            // 
            this.var_numero_factura.CausesValidation = false;
            this.var_numero_factura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.var_numero_factura.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.var_numero_factura.ForeColor = System.Drawing.Color.White;
            this.var_numero_factura.Location = new System.Drawing.Point(3, 0);
            this.var_numero_factura.Name = "var_numero_factura";
            this.var_numero_factura.Size = new System.Drawing.Size(70, 50);
            this.var_numero_factura.TabIndex = 69;
            this.var_numero_factura.Text = "N° ";
            this.var_numero_factura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // var_costo_total
            // 
            this.var_costo_total.CausesValidation = false;
            this.var_costo_total.Dock = System.Windows.Forms.DockStyle.Fill;
            this.var_costo_total.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.var_costo_total.ForeColor = System.Drawing.Color.White;
            this.var_costo_total.Location = new System.Drawing.Point(713, 0);
            this.var_costo_total.Name = "var_costo_total";
            this.var_costo_total.Size = new System.Drawing.Size(72, 50);
            this.var_costo_total.TabIndex = 74;
            this.var_costo_total.Text = "Total";
            this.var_costo_total.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // var_cant_boletos
            // 
            this.var_cant_boletos.CausesValidation = false;
            this.var_cant_boletos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.var_cant_boletos.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.var_cant_boletos.ForeColor = System.Drawing.Color.White;
            this.var_cant_boletos.Location = new System.Drawing.Point(655, 0);
            this.var_cant_boletos.Name = "var_cant_boletos";
            this.var_cant_boletos.Size = new System.Drawing.Size(52, 50);
            this.var_cant_boletos.TabIndex = 73;
            this.var_cant_boletos.Text = "Cant";
            this.var_cant_boletos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // var_hora
            // 
            this.var_hora.CausesValidation = false;
            this.var_hora.Dock = System.Windows.Forms.DockStyle.Fill;
            this.var_hora.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.var_hora.ForeColor = System.Drawing.Color.White;
            this.var_hora.Location = new System.Drawing.Point(547, 0);
            this.var_hora.Name = "var_hora";
            this.var_hora.Size = new System.Drawing.Size(102, 50);
            this.var_hora.TabIndex = 72;
            this.var_hora.Text = "Hora";
            this.var_hora.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // var_fecha
            // 
            this.var_fecha.CausesValidation = false;
            this.var_fecha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.var_fecha.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.var_fecha.ForeColor = System.Drawing.Color.White;
            this.var_fecha.Location = new System.Drawing.Point(404, 0);
            this.var_fecha.Name = "var_fecha";
            this.var_fecha.Size = new System.Drawing.Size(137, 50);
            this.var_fecha.TabIndex = 71;
            this.var_fecha.Text = "Fecha";
            this.var_fecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.CausesValidation = false;
            this.gunaLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(79, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(319, 50);
            this.gunaLabel1.TabIndex = 75;
            this.gunaLabel1.Text = "Título";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // var_imprimir
            // 
            this.var_imprimir.CausesValidation = false;
            this.var_imprimir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.var_imprimir.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.var_imprimir.ForeColor = System.Drawing.Color.White;
            this.var_imprimir.Location = new System.Drawing.Point(791, 0);
            this.var_imprimir.Name = "var_imprimir";
            this.var_imprimir.Size = new System.Drawing.Size(106, 50);
            this.var_imprimir.TabIndex = 76;
            this.var_imprimir.Text = "Factura";
            this.var_imprimir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // VistaFacturas_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.Controls.Add(this.tableContainer);
            this.Controls.Add(this.container);
            this.Controls.Add(this.btnBuscarFactura);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.txtBuscarFactura);
            this.Name = "VistaFacturas_Cliente";
            this.Size = new System.Drawing.Size(974, 506);
            this.container.ResumeLayout(false);
            this.tableContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel container;
        private System.Windows.Forms.Panel panelFacturas;
        private Guna.UI.WinForms.GunaVScrollBar scrollBar;
        private Guna.UI.WinForms.GunaCircleButton btnBuscarFactura;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaTextBox txtBuscarFactura;
        private System.Windows.Forms.TableLayoutPanel tableContainer;
        private Guna.UI.WinForms.GunaLabel var_imprimir;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel var_numero_factura;
        private Guna.UI.WinForms.GunaLabel var_costo_total;
        private Guna.UI.WinForms.GunaLabel var_fecha;
        private Guna.UI.WinForms.GunaLabel var_cant_boletos;
        private Guna.UI.WinForms.GunaLabel var_hora;
    }
}
