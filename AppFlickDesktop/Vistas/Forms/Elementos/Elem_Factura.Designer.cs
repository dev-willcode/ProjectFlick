namespace AppFlickDesktop.Vistas.Forms
{
    partial class Elem_Factura
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
            this.btnImprimir = new Guna.UI.WinForms.GunaButton();
            this.var_costo_total = new Guna.UI.WinForms.GunaLabel();
            this.var_cant_boletos = new Guna.UI.WinForms.GunaLabel();
            this.var_hora = new Guna.UI.WinForms.GunaLabel();
            this.var_fecha = new Guna.UI.WinForms.GunaLabel();
            this.var_titulo = new Guna.UI.WinForms.GunaLabel();
            this.var_numero_factura = new Guna.UI.WinForms.GunaLabel();
            this.tableContainer = new System.Windows.Forms.TableLayoutPanel();
            this.containerIdioma = new System.Windows.Forms.TableLayoutPanel();
            this.tableContainer.SuspendLayout();
            this.containerIdioma.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnImprimir
            // 
            this.btnImprimir.Animated = true;
            this.btnImprimir.AnimationHoverSpeed = 0.07F;
            this.btnImprimir.AnimationSpeed = 0.03F;
            this.btnImprimir.BackColor = System.Drawing.Color.Transparent;
            this.btnImprimir.BaseColor = System.Drawing.Color.Transparent;
            this.btnImprimir.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(237)))));
            this.btnImprimir.BorderSize = 1;
            this.btnImprimir.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnImprimir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnImprimir.FocusedColor = System.Drawing.Color.Empty;
            this.btnImprimir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.White;
            this.btnImprimir.Image = null;
            this.btnImprimir.ImageSize = new System.Drawing.Size(20, 20);
            this.btnImprimir.Location = new System.Drawing.Point(791, 3);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(237)))));
            this.btnImprimir.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(237)))));
            this.btnImprimir.OnHoverForeColor = System.Drawing.Color.White;
            this.btnImprimir.OnHoverImage = null;
            this.btnImprimir.OnPressedColor = System.Drawing.Color.Black;
            this.btnImprimir.Radius = 10;
            this.btnImprimir.Size = new System.Drawing.Size(106, 44);
            this.btnImprimir.TabIndex = 85;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.var_costo_total.Text = "5,90";
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
            this.var_cant_boletos.Text = "4";
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
            this.var_hora.Text = "16:00 PM";
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
            this.var_fecha.Text = "12 Dec 2019";
            this.var_fecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // var_titulo
            // 
            this.var_titulo.CausesValidation = false;
            this.var_titulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.var_titulo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.var_titulo.ForeColor = System.Drawing.Color.White;
            this.var_titulo.Location = new System.Drawing.Point(3, 0);
            this.var_titulo.Name = "var_titulo";
            this.var_titulo.Size = new System.Drawing.Size(230, 44);
            this.var_titulo.TabIndex = 70;
            this.var_titulo.Text = "AVENGERS: ENDGAME";
            this.var_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.var_numero_factura.Text = "0001";
            this.var_numero_factura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableContainer
            // 
            this.tableContainer.ColumnCount = 7;
            this.tableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.500729F));
            this.tableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.19006F));
            this.tableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.93887F));
            this.tableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.06336F));
            this.tableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.532984F));
            this.tableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.710646F));
            this.tableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.06336F));
            this.tableContainer.Controls.Add(this.var_numero_factura, 0, 0);
            this.tableContainer.Controls.Add(this.btnImprimir, 8, 0);
            this.tableContainer.Controls.Add(this.containerIdioma, 1, 0);
            this.tableContainer.Controls.Add(this.var_costo_total, 5, 0);
            this.tableContainer.Controls.Add(this.var_fecha, 2, 0);
            this.tableContainer.Controls.Add(this.var_cant_boletos, 4, 0);
            this.tableContainer.Controls.Add(this.var_hora, 3, 0);
            this.tableContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableContainer.Location = new System.Drawing.Point(0, 0);
            this.tableContainer.Name = "tableContainer";
            this.tableContainer.RowCount = 1;
            this.tableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableContainer.Size = new System.Drawing.Size(900, 50);
            this.tableContainer.TabIndex = 88;
            // 
            // containerIdioma
            // 
            this.containerIdioma.ColumnCount = 2;
            this.containerIdioma.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.98119F));
            this.containerIdioma.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.01881F));
            this.containerIdioma.Controls.Add(this.var_titulo, 0, 0);
            this.containerIdioma.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerIdioma.Location = new System.Drawing.Point(79, 3);
            this.containerIdioma.Name = "containerIdioma";
            this.containerIdioma.RowCount = 1;
            this.containerIdioma.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.containerIdioma.Size = new System.Drawing.Size(319, 44);
            this.containerIdioma.TabIndex = 71;
            // 
            // Elem_Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.Controls.Add(this.tableContainer);
            this.Name = "Elem_Factura";
            this.Size = new System.Drawing.Size(900, 50);
            this.tableContainer.ResumeLayout(false);
            this.containerIdioma.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaLabel var_costo_total;
        private Guna.UI.WinForms.GunaLabel var_cant_boletos;
        private Guna.UI.WinForms.GunaLabel var_hora;
        private Guna.UI.WinForms.GunaLabel var_fecha;
        private Guna.UI.WinForms.GunaLabel var_titulo;
        private Guna.UI.WinForms.GunaLabel var_numero_factura;
        private Guna.UI.WinForms.GunaButton btnImprimir;
        private System.Windows.Forms.TableLayoutPanel tableContainer;
        private System.Windows.Forms.TableLayoutPanel containerIdioma;
    }
}
