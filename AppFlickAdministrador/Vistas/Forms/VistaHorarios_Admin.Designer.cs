namespace AppFlickAdministrador.Vistas.Forms
{
    partial class VistaHorarios_Admin
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
            this.scrollBar = new Guna.UI.WinForms.GunaVScrollBar();
            this.panelHorarios = new System.Windows.Forms.Panel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.tableContainer = new System.Windows.Forms.TableLayoutPanel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.var_numero_factura = new Guna.UI.WinForms.GunaLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAnadir = new Guna.UI.WinForms.GunaButton();
            this.container.SuspendLayout();
            this.tableContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.Controls.Add(this.scrollBar);
            this.container.Controls.Add(this.panelHorarios);
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(0, 50);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(742, 305);
            this.container.TabIndex = 70;
            // 
            // scrollBar
            // 
            this.scrollBar.Dock = System.Windows.Forms.DockStyle.Right;
            this.scrollBar.LargeChange = 10;
            this.scrollBar.Location = new System.Drawing.Point(725, 0);
            this.scrollBar.Maximum = 100;
            this.scrollBar.Name = "scrollBar";
            this.scrollBar.ScrollbarSize = 12;
            this.scrollBar.ScrollIdleColor = System.Drawing.Color.Silver;
            this.scrollBar.Size = new System.Drawing.Size(17, 305);
            this.scrollBar.TabIndex = 72;
            this.scrollBar.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(237)))));
            this.scrollBar.ThumbHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(237)))));
            this.scrollBar.ThumbPressedColor = System.Drawing.Color.DarkGray;
            // 
            // panelHorarios
            // 
            this.panelHorarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHorarios.Location = new System.Drawing.Point(0, 0);
            this.panelHorarios.Name = "panelHorarios";
            this.panelHorarios.Size = new System.Drawing.Size(742, 305);
            this.panelHorarios.TabIndex = 70;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.CausesValidation = false;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.ForeColor = System.Drawing.Color.White;
            this.gunaLabel5.Location = new System.Drawing.Point(24, 19);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(129, 37);
            this.gunaLabel5.TabIndex = 68;
            this.gunaLabel5.Text = "Horarios";
            // 
            // tableContainer
            // 
            this.tableContainer.ColumnCount = 3;
            this.tableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableContainer.Controls.Add(this.gunaLabel3, 0, 0);
            this.tableContainer.Controls.Add(this.gunaLabel1, 1, 0);
            this.tableContainer.Controls.Add(this.var_numero_factura, 0, 0);
            this.tableContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableContainer.Location = new System.Drawing.Point(0, 0);
            this.tableContainer.Name = "tableContainer";
            this.tableContainer.RowCount = 1;
            this.tableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableContainer.Size = new System.Drawing.Size(742, 50);
            this.tableContainer.TabIndex = 89;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.CausesValidation = false;
            this.gunaLabel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.White;
            this.gunaLabel3.Location = new System.Drawing.Point(250, 0);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(241, 50);
            this.gunaLabel3.TabIndex = 76;
            this.gunaLabel3.Text = "Hora Fin";
            this.gunaLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.CausesValidation = false;
            this.gunaLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(497, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(242, 50);
            this.gunaLabel1.TabIndex = 75;
            this.gunaLabel1.Text = "Edición";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // var_numero_factura
            // 
            this.var_numero_factura.CausesValidation = false;
            this.var_numero_factura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.var_numero_factura.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.var_numero_factura.ForeColor = System.Drawing.Color.White;
            this.var_numero_factura.Location = new System.Drawing.Point(3, 0);
            this.var_numero_factura.Name = "var_numero_factura";
            this.var_numero_factura.Size = new System.Drawing.Size(241, 50);
            this.var_numero_factura.TabIndex = 69;
            this.var_numero_factura.Text = "Hora Inicio";
            this.var_numero_factura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.container);
            this.panel1.Controls.Add(this.tableContainer);
            this.panel1.Location = new System.Drawing.Point(31, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(742, 355);
            this.panel1.TabIndex = 91;
            // 
            // btnAnadir
            // 
            this.btnAnadir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnadir.Animated = true;
            this.btnAnadir.AnimationHoverSpeed = 0.07F;
            this.btnAnadir.AnimationSpeed = 0.03F;
            this.btnAnadir.BackColor = System.Drawing.Color.Transparent;
            this.btnAnadir.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.btnAnadir.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(237)))));
            this.btnAnadir.BorderSize = 1;
            this.btnAnadir.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAnadir.FocusedColor = System.Drawing.Color.Empty;
            this.btnAnadir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnadir.ForeColor = System.Drawing.Color.White;
            this.btnAnadir.Image = global::AppFlickAdministrador.Properties.Resources.icon_mas;
            this.btnAnadir.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAnadir.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAnadir.Location = new System.Drawing.Point(659, 19);
            this.btnAnadir.Name = "btnAnadir";
            this.btnAnadir.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(237)))));
            this.btnAnadir.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(237)))));
            this.btnAnadir.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAnadir.OnHoverImage = null;
            this.btnAnadir.OnPressedColor = System.Drawing.Color.Black;
            this.btnAnadir.Radius = 7;
            this.btnAnadir.Size = new System.Drawing.Size(110, 32);
            this.btnAnadir.TabIndex = 92;
            this.btnAnadir.Text = "Añadir";
            this.btnAnadir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAnadir.UseTransfarantBackground = true;
            this.btnAnadir.Click += new System.EventHandler(this.btnAnadir_Click);
            // 
            // VistaHorarios_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.Controls.Add(this.btnAnadir);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gunaLabel5);
            this.Name = "VistaHorarios_Admin";
            this.Size = new System.Drawing.Size(809, 506);
            this.container.ResumeLayout(false);
            this.tableContainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel container;
        private System.Windows.Forms.Panel panelHorarios;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private System.Windows.Forms.TableLayoutPanel tableContainer;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel var_numero_factura;
        private Guna.UI.WinForms.GunaVScrollBar scrollBar;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaButton btnAnadir;
    }
}
