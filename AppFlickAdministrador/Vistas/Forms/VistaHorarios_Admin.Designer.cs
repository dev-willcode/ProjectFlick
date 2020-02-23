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
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnActualizarDatos = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.txthoraInicio = new Guna.UI.WinForms.GunaTextBox();
            this.txthoraFin = new Guna.UI.WinForms.GunaTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.container.SuspendLayout();
            this.tableContainer.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.container.Size = new System.Drawing.Size(454, 305);
            this.container.TabIndex = 70;
            // 
            // scrollBar
            // 
            this.scrollBar.Dock = System.Windows.Forms.DockStyle.Right;
            this.scrollBar.LargeChange = 10;
            this.scrollBar.Location = new System.Drawing.Point(437, 0);
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
            this.panelHorarios.Size = new System.Drawing.Size(454, 305);
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
            this.tableContainer.Size = new System.Drawing.Size(454, 50);
            this.tableContainer.TabIndex = 89;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.CausesValidation = false;
            this.gunaLabel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.White;
            this.gunaLabel3.Location = new System.Drawing.Point(154, 0);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(145, 50);
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
            this.gunaLabel1.Location = new System.Drawing.Point(305, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(146, 50);
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
            this.var_numero_factura.Size = new System.Drawing.Size(145, 50);
            this.var_numero_factura.TabIndex = 69;
            this.var_numero_factura.Text = "Hora Inicio";
            this.var_numero_factura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnActualizarDatos);
            this.panel3.Controls.Add(this.gunaLabel2);
            this.panel3.Controls.Add(this.gunaLabel4);
            this.panel3.Controls.Add(this.txthoraInicio);
            this.panel3.Controls.Add(this.txthoraFin);
            this.panel3.Location = new System.Drawing.Point(31, 78);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(270, 355);
            this.panel3.TabIndex = 90;
            // 
            // btnActualizarDatos
            // 
            this.btnActualizarDatos.Animated = true;
            this.btnActualizarDatos.AnimationHoverSpeed = 0.07F;
            this.btnActualizarDatos.AnimationSpeed = 0.03F;
            this.btnActualizarDatos.BackColor = System.Drawing.Color.Transparent;
            this.btnActualizarDatos.BaseColor = System.Drawing.Color.Transparent;
            this.btnActualizarDatos.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(237)))));
            this.btnActualizarDatos.BorderSize = 1;
            this.btnActualizarDatos.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnActualizarDatos.FocusedColor = System.Drawing.Color.Empty;
            this.btnActualizarDatos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarDatos.ForeColor = System.Drawing.Color.White;
            this.btnActualizarDatos.Image = null;
            this.btnActualizarDatos.ImageSize = new System.Drawing.Size(20, 20);
            this.btnActualizarDatos.Location = new System.Drawing.Point(33, 170);
            this.btnActualizarDatos.Name = "btnActualizarDatos";
            this.btnActualizarDatos.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(237)))));
            this.btnActualizarDatos.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(237)))));
            this.btnActualizarDatos.OnHoverForeColor = System.Drawing.Color.White;
            this.btnActualizarDatos.OnHoverImage = null;
            this.btnActualizarDatos.OnPressedColor = System.Drawing.Color.Black;
            this.btnActualizarDatos.Radius = 10;
            this.btnActualizarDatos.Size = new System.Drawing.Size(218, 34);
            this.btnActualizarDatos.TabIndex = 84;
            this.btnActualizarDatos.Text = "Guardar";
            this.btnActualizarDatos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.CausesValidation = false;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.White;
            this.gunaLabel2.Location = new System.Drawing.Point(33, 88);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(199, 28);
            this.gunaLabel2.TabIndex = 68;
            this.gunaLabel2.Text = "Hora de finalización:";
            this.gunaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.CausesValidation = false;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.Color.White;
            this.gunaLabel4.Location = new System.Drawing.Point(33, 22);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(199, 28);
            this.gunaLabel4.TabIndex = 70;
            this.gunaLabel4.Text = "Hora de inicio:";
            this.gunaLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txthoraInicio
            // 
            this.txthoraInicio.BackColor = System.Drawing.Color.Transparent;
            this.txthoraInicio.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.txthoraInicio.BorderColor = System.Drawing.Color.White;
            this.txthoraInicio.BorderSize = 0;
            this.txthoraInicio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txthoraInicio.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txthoraInicio.FocusedBorderColor = System.Drawing.Color.White;
            this.txthoraInicio.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.txthoraInicio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthoraInicio.ForeColor = System.Drawing.Color.White;
            this.txthoraInicio.Location = new System.Drawing.Point(33, 53);
            this.txthoraInicio.Name = "txthoraInicio";
            this.txthoraInicio.PasswordChar = '\0';
            this.txthoraInicio.Radius = 10;
            this.txthoraInicio.Size = new System.Drawing.Size(218, 32);
            this.txthoraInicio.TabIndex = 74;
            this.txthoraInicio.TextOffsetX = 10;
            // 
            // txthoraFin
            // 
            this.txthoraFin.BackColor = System.Drawing.Color.Transparent;
            this.txthoraFin.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.txthoraFin.BorderColor = System.Drawing.Color.White;
            this.txthoraFin.BorderSize = 0;
            this.txthoraFin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txthoraFin.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txthoraFin.FocusedBorderColor = System.Drawing.Color.White;
            this.txthoraFin.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.txthoraFin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthoraFin.ForeColor = System.Drawing.Color.White;
            this.txthoraFin.Location = new System.Drawing.Point(33, 119);
            this.txthoraFin.Name = "txthoraFin";
            this.txthoraFin.PasswordChar = '\0';
            this.txthoraFin.Radius = 10;
            this.txthoraFin.Size = new System.Drawing.Size(218, 32);
            this.txthoraFin.TabIndex = 75;
            this.txthoraFin.TextOffsetX = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.container);
            this.panel1.Controls.Add(this.tableContainer);
            this.panel1.Location = new System.Drawing.Point(319, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(454, 355);
            this.panel1.TabIndex = 91;
            // 
            // VistaHorarios_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.gunaLabel5);
            this.Name = "VistaHorarios_Admin";
            this.Size = new System.Drawing.Size(809, 506);
            this.container.ResumeLayout(false);
            this.tableContainer.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel3;
        private Guna.UI.WinForms.GunaButton btnActualizarDatos;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaTextBox txthoraInicio;
        private Guna.UI.WinForms.GunaTextBox txthoraFin;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
    }
}
