namespace AppFlickAdministrador.Vistas.Forms
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
            this.var_fecha = new Guna.UI.WinForms.GunaLabel();
            this.var_numero_factura = new Guna.UI.WinForms.GunaLabel();
            this.tableContainer = new System.Windows.Forms.TableLayoutPanel();
            this.btnAnular = new Guna.UI.WinForms.GunaButton();
            this.var_titulo = new Guna.UI.WinForms.GunaLabel();
            this.var_cliente = new Guna.UI.WinForms.GunaLabel();
            this.tableContainer.SuspendLayout();
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
            this.btnImprimir.Location = new System.Drawing.Point(792, 10);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(237)))));
            this.btnImprimir.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(237)))));
            this.btnImprimir.OnHoverForeColor = System.Drawing.Color.White;
            this.btnImprimir.OnHoverImage = null;
            this.btnImprimir.OnPressedColor = System.Drawing.Color.Black;
            this.btnImprimir.Radius = 10;
            this.btnImprimir.Size = new System.Drawing.Size(112, 51);
            this.btnImprimir.TabIndex = 85;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // var_costo_total
            // 
            this.var_costo_total.CausesValidation = false;
            this.var_costo_total.Dock = System.Windows.Forms.DockStyle.Fill;
            this.var_costo_total.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.var_costo_total.ForeColor = System.Drawing.Color.White;
            this.var_costo_total.Location = new System.Drawing.Point(719, 0);
            this.var_costo_total.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.var_costo_total.Name = "var_costo_total";
            this.var_costo_total.Size = new System.Drawing.Size(61, 71);
            this.var_costo_total.TabIndex = 74;
            this.var_costo_total.Text = "5,90";
            this.var_costo_total.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // var_fecha
            // 
            this.var_fecha.CausesValidation = false;
            this.var_fecha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.var_fecha.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.var_fecha.ForeColor = System.Drawing.Color.White;
            this.var_fecha.Location = new System.Drawing.Point(609, 0);
            this.var_fecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.var_fecha.Name = "var_fecha";
            this.var_fecha.Size = new System.Drawing.Size(102, 71);
            this.var_fecha.TabIndex = 71;
            this.var_fecha.Text = "12 Dec 2019";
            this.var_fecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // var_numero_factura
            // 
            this.var_numero_factura.CausesValidation = false;
            this.var_numero_factura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.var_numero_factura.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.var_numero_factura.ForeColor = System.Drawing.Color.White;
            this.var_numero_factura.Location = new System.Drawing.Point(4, 0);
            this.var_numero_factura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.var_numero_factura.Name = "var_numero_factura";
            this.var_numero_factura.Size = new System.Drawing.Size(81, 71);
            this.var_numero_factura.TabIndex = 69;
            this.var_numero_factura.Text = "0001";
            this.var_numero_factura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableContainer
            // 
            this.tableContainer.ColumnCount = 7;
            this.tableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.927316F));
            this.tableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.69291F));
            this.tableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.69291F));
            this.tableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.01125F));
            this.tableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.854648F));
            this.tableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.73006F));
            this.tableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableContainer.Controls.Add(this.btnAnular, 6, 0);
            this.tableContainer.Controls.Add(this.var_titulo, 2, 0);
            this.tableContainer.Controls.Add(this.var_cliente, 1, 0);
            this.tableContainer.Controls.Add(this.var_numero_factura, 0, 0);
            this.tableContainer.Controls.Add(this.btnImprimir, 5, 0);
            this.tableContainer.Controls.Add(this.var_costo_total, 4, 0);
            this.tableContainer.Controls.Add(this.var_fecha, 3, 0);
            this.tableContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableContainer.Location = new System.Drawing.Point(0, 0);
            this.tableContainer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableContainer.Name = "tableContainer";
            this.tableContainer.RowCount = 1;
            this.tableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableContainer.Size = new System.Drawing.Size(1007, 71);
            this.tableContainer.TabIndex = 88;
            // 
            // btnAnular
            // 
            this.btnAnular.Animated = true;
            this.btnAnular.AnimationHoverSpeed = 0.07F;
            this.btnAnular.AnimationSpeed = 0.03F;
            this.btnAnular.BackColor = System.Drawing.Color.Transparent;
            this.btnAnular.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(100)))), ((int)(((byte)(235)))));
            this.btnAnular.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(237)))));
            this.btnAnular.BorderSize = 1;
            this.btnAnular.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAnular.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAnular.FocusedColor = System.Drawing.Color.Empty;
            this.btnAnular.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnular.ForeColor = System.Drawing.Color.White;
            this.btnAnular.Image = null;
            this.btnAnular.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAnular.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAnular.Location = new System.Drawing.Point(920, 10);
            this.btnAnular.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(237)))));
            this.btnAnular.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(237)))));
            this.btnAnular.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAnular.OnHoverImage = null;
            this.btnAnular.OnPressedColor = System.Drawing.Color.Black;
            this.btnAnular.Radius = 7;
            this.btnAnular.Size = new System.Drawing.Size(79, 51);
            this.btnAnular.TabIndex = 88;
            this.btnAnular.Text = "Anular";
            this.btnAnular.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAnular.UseTransfarantBackground = true;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // var_titulo
            // 
            this.var_titulo.CausesValidation = false;
            this.var_titulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.var_titulo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.var_titulo.ForeColor = System.Drawing.Color.White;
            this.var_titulo.Location = new System.Drawing.Point(351, 0);
            this.var_titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.var_titulo.Name = "var_titulo";
            this.var_titulo.Size = new System.Drawing.Size(250, 71);
            this.var_titulo.TabIndex = 87;
            this.var_titulo.Text = "AVENGERS: ENDGAME";
            this.var_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // var_cliente
            // 
            this.var_cliente.CausesValidation = false;
            this.var_cliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.var_cliente.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.var_cliente.ForeColor = System.Drawing.Color.White;
            this.var_cliente.Location = new System.Drawing.Point(93, 0);
            this.var_cliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.var_cliente.Name = "var_cliente";
            this.var_cliente.Size = new System.Drawing.Size(250, 71);
            this.var_cliente.TabIndex = 86;
            this.var_cliente.Text = "Alan Brito";
            this.var_cliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Elem_Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.Controls.Add(this.tableContainer);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Elem_Factura";
            this.Size = new System.Drawing.Size(1007, 71);
            this.tableContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaLabel var_costo_total;
        private Guna.UI.WinForms.GunaLabel var_fecha;
        private Guna.UI.WinForms.GunaLabel var_numero_factura;
        private Guna.UI.WinForms.GunaButton btnImprimir;
        private System.Windows.Forms.TableLayoutPanel tableContainer;
        private Guna.UI.WinForms.GunaLabel var_titulo;
        private Guna.UI.WinForms.GunaLabel var_cliente;
        private Guna.UI.WinForms.GunaButton btnAnular;
    }
}
