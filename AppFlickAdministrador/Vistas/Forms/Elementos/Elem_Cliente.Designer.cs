namespace AppFlickAdministrador.Vistas.Init
{
    partial class Elem_Cliente
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
            this.container_funcion = new System.Windows.Forms.Panel();
            this.tableContainer = new System.Windows.Forms.TableLayoutPanel();
            this.var_cedula = new Guna.UI.WinForms.GunaLabel();
            this.var_nombre_completo = new Guna.UI.WinForms.GunaLabel();
            this.var_direccion = new Guna.UI.WinForms.GunaLabel();
            this.var_email = new Guna.UI.WinForms.GunaLabel();
            this.btnEditar = new Guna.UI.WinForms.GunaButton();
            this.btnBorrar = new Guna.UI.WinForms.GunaButton();
            this.container_funcion.SuspendLayout();
            this.tableContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // container_funcion
            // 
            this.container_funcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.container_funcion.Controls.Add(this.tableContainer);
            this.container_funcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container_funcion.Location = new System.Drawing.Point(0, 0);
            this.container_funcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.container_funcion.Name = "container_funcion";
            this.container_funcion.Size = new System.Drawing.Size(1007, 62);
            this.container_funcion.TabIndex = 69;
            // 
            // tableContainer
            // 
            this.tableContainer.ColumnCount = 6;
            this.tableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.89927F));
            this.tableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.81375F));
            this.tableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.53857F));
            this.tableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.71721F));
            this.tableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.02035F));
            this.tableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.010852F));
            this.tableContainer.Controls.Add(this.var_cedula, 0, 0);
            this.tableContainer.Controls.Add(this.var_nombre_completo, 1, 0);
            this.tableContainer.Controls.Add(this.var_direccion, 2, 0);
            this.tableContainer.Controls.Add(this.var_email, 3, 0);
            this.tableContainer.Controls.Add(this.btnEditar, 4, 0);
            this.tableContainer.Controls.Add(this.btnBorrar, 5, 0);
            this.tableContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableContainer.Location = new System.Drawing.Point(0, 0);
            this.tableContainer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableContainer.Name = "tableContainer";
            this.tableContainer.RowCount = 1;
            this.tableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableContainer.Size = new System.Drawing.Size(1007, 62);
            this.tableContainer.TabIndex = 92;
            // 
            // var_cedula
            // 
            this.var_cedula.CausesValidation = false;
            this.var_cedula.Dock = System.Windows.Forms.DockStyle.Fill;
            this.var_cedula.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.var_cedula.ForeColor = System.Drawing.Color.White;
            this.var_cedula.Location = new System.Drawing.Point(4, 0);
            this.var_cedula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.var_cedula.Name = "var_cedula";
            this.var_cedula.Size = new System.Drawing.Size(182, 62);
            this.var_cedula.TabIndex = 69;
            this.var_cedula.Text = " ";
            this.var_cedula.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // var_nombre_completo
            // 
            this.var_nombre_completo.CausesValidation = false;
            this.var_nombre_completo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.var_nombre_completo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.var_nombre_completo.ForeColor = System.Drawing.Color.White;
            this.var_nombre_completo.Location = new System.Drawing.Point(194, 0);
            this.var_nombre_completo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.var_nombre_completo.Name = "var_nombre_completo";
            this.var_nombre_completo.Size = new System.Drawing.Size(191, 62);
            this.var_nombre_completo.TabIndex = 77;
            this.var_nombre_completo.Text = " ";
            this.var_nombre_completo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // var_direccion
            // 
            this.var_direccion.CausesValidation = false;
            this.var_direccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.var_direccion.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.var_direccion.ForeColor = System.Drawing.Color.White;
            this.var_direccion.Location = new System.Drawing.Point(393, 0);
            this.var_direccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.var_direccion.Name = "var_direccion";
            this.var_direccion.Size = new System.Drawing.Size(239, 62);
            this.var_direccion.TabIndex = 71;
            this.var_direccion.Text = " ";
            this.var_direccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // var_email
            // 
            this.var_email.CausesValidation = false;
            this.var_email.Dock = System.Windows.Forms.DockStyle.Fill;
            this.var_email.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.var_email.ForeColor = System.Drawing.Color.White;
            this.var_email.Location = new System.Drawing.Point(640, 0);
            this.var_email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.var_email.Name = "var_email";
            this.var_email.Size = new System.Drawing.Size(130, 62);
            this.var_email.TabIndex = 74;
            this.var_email.Text = " ";
            this.var_email.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnEditar
            // 
            this.btnEditar.Animated = true;
            this.btnEditar.AnimationHoverSpeed = 0.07F;
            this.btnEditar.AnimationSpeed = 0.03F;
            this.btnEditar.BackColor = System.Drawing.Color.Transparent;
            this.btnEditar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.btnEditar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(237)))));
            this.btnEditar.BorderSize = 1;
            this.btnEditar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEditar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditar.FocusedColor = System.Drawing.Color.Empty;
            this.btnEditar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Image = global::AppFlickAdministrador.Properties.Resources.icon_cambiar;
            this.btnEditar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEditar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnEditar.Location = new System.Drawing.Point(778, 4);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(237)))));
            this.btnEditar.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(237)))));
            this.btnEditar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEditar.OnHoverImage = null;
            this.btnEditar.OnPressedColor = System.Drawing.Color.Black;
            this.btnEditar.Radius = 7;
            this.btnEditar.Size = new System.Drawing.Size(143, 54);
            this.btnEditar.TabIndex = 49;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEditar.UseTransfarantBackground = true;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Animated = true;
            this.btnBorrar.AnimationHoverSpeed = 0.07F;
            this.btnBorrar.AnimationSpeed = 0.03F;
            this.btnBorrar.BackColor = System.Drawing.Color.Transparent;
            this.btnBorrar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(100)))), ((int)(((byte)(235)))));
            this.btnBorrar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(237)))));
            this.btnBorrar.BorderSize = 1;
            this.btnBorrar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBorrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBorrar.FocusedColor = System.Drawing.Color.Empty;
            this.btnBorrar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ForeColor = System.Drawing.Color.White;
            this.btnBorrar.Image = global::AppFlickAdministrador.Properties.Resources.icon_menos;
            this.btnBorrar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBorrar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnBorrar.Location = new System.Drawing.Point(929, 4);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(237)))));
            this.btnBorrar.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(237)))));
            this.btnBorrar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBorrar.OnHoverImage = null;
            this.btnBorrar.OnPressedColor = System.Drawing.Color.Black;
            this.btnBorrar.Radius = 7;
            this.btnBorrar.Size = new System.Drawing.Size(74, 54);
            this.btnBorrar.TabIndex = 50;
            this.btnBorrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBorrar.UseTransfarantBackground = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // Elem_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.Controls.Add(this.container_funcion);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Elem_Cliente";
            this.Size = new System.Drawing.Size(1007, 62);
            this.container_funcion.ResumeLayout(false);
            this.tableContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel container_funcion;
        private Guna.UI.WinForms.GunaButton btnBorrar;
        private Guna.UI.WinForms.GunaButton btnEditar;
        private System.Windows.Forms.TableLayoutPanel tableContainer;
        private Guna.UI.WinForms.GunaLabel var_cedula;
        private Guna.UI.WinForms.GunaLabel var_nombre_completo;
        private Guna.UI.WinForms.GunaLabel var_direccion;
        private Guna.UI.WinForms.GunaLabel var_email;
    }
}
