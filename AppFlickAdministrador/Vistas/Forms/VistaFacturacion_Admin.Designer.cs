﻿namespace AppFlickAdministrador.Vistas.Forms
{
    partial class VistaFacturacion_Admin
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
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.txtBuscarFactura = new Guna.UI.WinForms.GunaTextBox();
            this.btnBuscarFactura = new Guna.UI.WinForms.GunaCircleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.container = new System.Windows.Forms.Panel();
            this.scrollBar = new Guna.UI.WinForms.GunaVScrollBar();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.tableContainer = new System.Windows.Forms.TableLayoutPanel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.var_imprimir = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.var_numero_factura = new Guna.UI.WinForms.GunaLabel();
            this.var_costo_total = new Guna.UI.WinForms.GunaLabel();
            this.var_fecha = new Guna.UI.WinForms.GunaLabel();
            this.panel1.SuspendLayout();
            this.container.SuspendLayout();
            this.tableContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.CausesValidation = false;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.ForeColor = System.Drawing.Color.White;
            this.gunaLabel5.Location = new System.Drawing.Point(24, 19);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(165, 37);
            this.gunaLabel5.TabIndex = 68;
            this.gunaLabel5.Text = "Facturación";
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
            this.txtBuscarFactura.Location = new System.Drawing.Point(346, 24);
            this.txtBuscarFactura.Name = "txtBuscarFactura";
            this.txtBuscarFactura.PasswordChar = '\0';
            this.txtBuscarFactura.Radius = 10;
            this.txtBuscarFactura.Size = new System.Drawing.Size(399, 32);
            this.txtBuscarFactura.TabIndex = 67;
            this.txtBuscarFactura.Text = "Buscar....";
            this.txtBuscarFactura.TextOffsetX = 10;
            this.txtBuscarFactura.TextChanged += new System.EventHandler(this.txtBuscarFactura_TextChanged);
            this.txtBuscarFactura.Enter += new System.EventHandler(this.txtBuscarFactura_Enter);
            this.txtBuscarFactura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarFactura_KeyPress);
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
            this.btnBuscarFactura.Image = global::AppFlickAdministrador.Properties.Resources.icon_buscar;
            this.btnBuscarFactura.ImageSize = new System.Drawing.Size(20, 20);
            this.btnBuscarFactura.Location = new System.Drawing.Point(751, 24);
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
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.container);
            this.panel1.Controls.Add(this.tableContainer);
            this.panel1.Location = new System.Drawing.Point(26, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(755, 401);
            this.panel1.TabIndex = 70;
            // 
            // container
            // 
            this.container.Controls.Add(this.scrollBar);
            this.container.Controls.Add(this.panelContenedor);
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(0, 50);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(755, 351);
            this.container.TabIndex = 90;
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
            this.scrollBar.Size = new System.Drawing.Size(17, 351);
            this.scrollBar.TabIndex = 72;
            this.scrollBar.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(237)))));
            this.scrollBar.ThumbHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(237)))));
            this.scrollBar.ThumbPressedColor = System.Drawing.Color.DarkGray;
            // 
            // panelFacturas
            // 
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.Name = "panelFacturas";
            this.panelContenedor.Size = new System.Drawing.Size(755, 351);
            this.panelContenedor.TabIndex = 70;
            // 
            // tableContainer
            // 
            this.tableContainer.ColumnCount = 6;
            this.tableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.73735F));
            this.tableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.20412F));
            this.tableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.20412F));
            this.tableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.08748F));
            this.tableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.948684F));
            this.tableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.81825F));
            this.tableContainer.Controls.Add(this.gunaLabel2, 0, 0);
            this.tableContainer.Controls.Add(this.var_imprimir, 5, 0);
            this.tableContainer.Controls.Add(this.gunaLabel1, 1, 0);
            this.tableContainer.Controls.Add(this.var_numero_factura, 0, 0);
            this.tableContainer.Controls.Add(this.var_costo_total, 4, 0);
            this.tableContainer.Controls.Add(this.var_fecha, 2, 0);
            this.tableContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableContainer.Location = new System.Drawing.Point(0, 0);
            this.tableContainer.Name = "tableContainer";
            this.tableContainer.RowCount = 1;
            this.tableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableContainer.Size = new System.Drawing.Size(755, 50);
            this.tableContainer.TabIndex = 91;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.CausesValidation = false;
            this.gunaLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.White;
            this.gunaLabel2.Location = new System.Drawing.Point(76, 0);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(206, 50);
            this.gunaLabel2.TabIndex = 77;
            this.gunaLabel2.Text = "Cliente";
            this.gunaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // var_imprimir
            // 
            this.var_imprimir.CausesValidation = false;
            this.var_imprimir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.var_imprimir.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.var_imprimir.ForeColor = System.Drawing.Color.White;
            this.var_imprimir.Location = new System.Drawing.Point(651, 0);
            this.var_imprimir.Name = "var_imprimir";
            this.var_imprimir.Size = new System.Drawing.Size(101, 50);
            this.var_imprimir.TabIndex = 76;
            this.var_imprimir.Text = "Factura";
            this.var_imprimir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.CausesValidation = false;
            this.gunaLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(288, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(206, 50);
            this.gunaLabel1.TabIndex = 75;
            this.gunaLabel1.Text = "Función";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // var_numero_factura
            // 
            this.var_numero_factura.CausesValidation = false;
            this.var_numero_factura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.var_numero_factura.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.var_numero_factura.ForeColor = System.Drawing.Color.White;
            this.var_numero_factura.Location = new System.Drawing.Point(3, 0);
            this.var_numero_factura.Name = "var_numero_factura";
            this.var_numero_factura.Size = new System.Drawing.Size(67, 50);
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
            this.var_costo_total.Location = new System.Drawing.Point(591, 0);
            this.var_costo_total.Name = "var_costo_total";
            this.var_costo_total.Size = new System.Drawing.Size(54, 50);
            this.var_costo_total.TabIndex = 74;
            this.var_costo_total.Text = "Total";
            this.var_costo_total.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // var_fecha
            // 
            this.var_fecha.CausesValidation = false;
            this.var_fecha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.var_fecha.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.var_fecha.ForeColor = System.Drawing.Color.White;
            this.var_fecha.Location = new System.Drawing.Point(500, 0);
            this.var_fecha.Name = "var_fecha";
            this.var_fecha.Size = new System.Drawing.Size(85, 50);
            this.var_fecha.TabIndex = 71;
            this.var_fecha.Text = "Fecha";
            this.var_fecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // VistaFacturacion_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBuscarFactura);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.txtBuscarFactura);
            this.Name = "VistaFacturacion_Admin";
            this.Size = new System.Drawing.Size(809, 506);
            this.panel1.ResumeLayout(false);
            this.container.ResumeLayout(false);
            this.tableContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaCircleButton btnBuscarFactura;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaTextBox txtBuscarFactura;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel container;
        private Guna.UI.WinForms.GunaVScrollBar scrollBar;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.TableLayoutPanel tableContainer;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel var_imprimir;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel var_numero_factura;
        private Guna.UI.WinForms.GunaLabel var_costo_total;
        private Guna.UI.WinForms.GunaLabel var_fecha;
    }
}
