namespace AppFlickAdministrador.Vistas.Init
{
    partial class Elem_pelicula
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnEditar = new Guna.UI.WinForms.GunaButton();
            this.var_reparto = new Guna.UI.WinForms.GunaLabel();
            this.var_directores = new Guna.UI.WinForms.GunaLabel();
            this.btnBorrar = new Guna.UI.WinForms.GunaButton();
            this.var_imagen_pelicula = new Guna.UI.WinForms.GunaPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.var_titulo_original = new Guna.UI.WinForms.GunaLabel();
            this.var_titulo = new Guna.UI.WinForms.GunaLabel();
            this.var_duracion_pelicula = new Guna.UI.WinForms.GunaLabel();
            this.var_sinopsis = new Guna.UI.WinForms.GunaLabel();
            this.var_censura = new Guna.UI.WinForms.GunaLabel();
            this.container_funcion.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.var_imagen_pelicula)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // container_funcion
            // 
            this.container_funcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.container_funcion.Controls.Add(this.tableLayoutPanel1);
            this.container_funcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container_funcion.Location = new System.Drawing.Point(0, 0);
            this.container_funcion.Margin = new System.Windows.Forms.Padding(4);
            this.container_funcion.Name = "container_funcion";
            this.container_funcion.Padding = new System.Windows.Forms.Padding(20, 12, 20, 12);
            this.container_funcion.Size = new System.Drawing.Size(1267, 204);
            this.container_funcion.TabIndex = 69;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.94886F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.3123F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.13166F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.60719F));
            this.tableLayoutPanel1.Controls.Add(this.var_censura, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnEditar, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.var_reparto, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.var_directores, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnBorrar, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.var_imagen_pelicula, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.var_duracion_pelicula, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.var_sinopsis, 2, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 12);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.83562F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.80822F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.9589F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.39726F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1227, 180);
            this.tableLayoutPanel1.TabIndex = 53;
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
            this.btnEditar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditar.FocusedColor = System.Drawing.Color.Empty;
            this.btnEditar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Image = global::AppFlickAdministrador.Properties.Resources.icon_cambiar;
            this.btnEditar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEditar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnEditar.Location = new System.Drawing.Point(1001, 4);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(237)))));
            this.btnEditar.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(237)))));
            this.btnEditar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEditar.OnHoverImage = null;
            this.btnEditar.OnPressedColor = System.Drawing.Color.Black;
            this.btnEditar.Radius = 7;
            this.btnEditar.Size = new System.Drawing.Size(222, 52);
            this.btnEditar.TabIndex = 64;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEditar.UseTransfarantBackground = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // var_reparto
            // 
            this.var_reparto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.var_reparto.CausesValidation = false;
            this.var_reparto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.var_reparto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.var_reparto.ForeColor = System.Drawing.Color.White;
            this.var_reparto.Location = new System.Drawing.Point(497, 78);
            this.var_reparto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.var_reparto.Name = "var_reparto";
            this.var_reparto.Padding = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.tableLayoutPanel1.SetRowSpan(this.var_reparto, 2);
            this.var_reparto.Size = new System.Drawing.Size(496, 51);
            this.var_reparto.TabIndex = 63;
            this.var_reparto.Text = "lorem ipsum lorem ipsum lorem ipsum lorem ipsum lorem ipsum lorem ipsum";
            // 
            // var_directores
            // 
            this.var_directores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.var_directores.CausesValidation = false;
            this.var_directores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.var_directores.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.var_directores.ForeColor = System.Drawing.Color.White;
            this.var_directores.Location = new System.Drawing.Point(497, 0);
            this.var_directores.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.var_directores.Name = "var_directores";
            this.var_directores.Padding = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.var_directores.Size = new System.Drawing.Size(496, 78);
            this.var_directores.TabIndex = 62;
            this.var_directores.Text = "lorem ipsum lorem ipsum lorem ipsum lorem ipsum lorem ipsum lorem ipsum";
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
            this.btnBorrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBorrar.FocusedColor = System.Drawing.Color.Empty;
            this.btnBorrar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ForeColor = System.Drawing.Color.White;
            this.btnBorrar.Image = global::AppFlickAdministrador.Properties.Resources.icon_menos;
            this.btnBorrar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBorrar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnBorrar.Location = new System.Drawing.Point(1001, 78);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(237)))));
            this.btnBorrar.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(237)))));
            this.btnBorrar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBorrar.OnHoverImage = null;
            this.btnBorrar.OnPressedColor = System.Drawing.Color.Black;
            this.btnBorrar.Radius = 7;
            this.btnBorrar.Size = new System.Drawing.Size(222, 32);
            this.btnBorrar.TabIndex = 51;
            this.btnBorrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBorrar.UseTransfarantBackground = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // var_imagen_pelicula
            // 
            this.var_imagen_pelicula.BackColor = System.Drawing.Color.Transparent;
            this.var_imagen_pelicula.BaseColor = System.Drawing.Color.White;
            this.var_imagen_pelicula.Dock = System.Windows.Forms.DockStyle.Fill;
            this.var_imagen_pelicula.Image = global::AppFlickAdministrador.Properties.Resources.pelicula_muestra;
            this.var_imagen_pelicula.Location = new System.Drawing.Point(4, 4);
            this.var_imagen_pelicula.Margin = new System.Windows.Forms.Padding(4);
            this.var_imagen_pelicula.Name = "var_imagen_pelicula";
            this.tableLayoutPanel1.SetRowSpan(this.var_imagen_pelicula, 4);
            this.var_imagen_pelicula.Size = new System.Drawing.Size(150, 172);
            this.var_imagen_pelicula.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.var_imagen_pelicula.TabIndex = 55;
            this.var_imagen_pelicula.TabStop = false;
            this.var_imagen_pelicula.UseTransfarantBackground = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.var_titulo_original);
            this.panel1.Controls.Add(this.var_titulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(162, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 70);
            this.panel1.TabIndex = 54;
            // 
            // var_titulo_original
            // 
            this.var_titulo_original.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.var_titulo_original.CausesValidation = false;
            this.var_titulo_original.Dock = System.Windows.Forms.DockStyle.Top;
            this.var_titulo_original.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.var_titulo_original.ForeColor = System.Drawing.Color.LightGray;
            this.var_titulo_original.Location = new System.Drawing.Point(0, 31);
            this.var_titulo_original.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.var_titulo_original.Name = "var_titulo_original";
            this.var_titulo_original.Size = new System.Drawing.Size(327, 25);
            this.var_titulo_original.TabIndex = 25;
            this.var_titulo_original.Text = "lorem ipsum";
            // 
            // var_titulo
            // 
            this.var_titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.var_titulo.CausesValidation = false;
            this.var_titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.var_titulo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.var_titulo.ForeColor = System.Drawing.Color.White;
            this.var_titulo.Location = new System.Drawing.Point(0, 0);
            this.var_titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.var_titulo.Name = "var_titulo";
            this.var_titulo.Size = new System.Drawing.Size(327, 31);
            this.var_titulo.TabIndex = 23;
            this.var_titulo.Text = "lorem ipsum";
            // 
            // var_duracion_pelicula
            // 
            this.var_duracion_pelicula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.var_duracion_pelicula.CausesValidation = false;
            this.var_duracion_pelicula.Dock = System.Windows.Forms.DockStyle.Fill;
            this.var_duracion_pelicula.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.var_duracion_pelicula.ForeColor = System.Drawing.Color.White;
            this.var_duracion_pelicula.Location = new System.Drawing.Point(162, 78);
            this.var_duracion_pelicula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.var_duracion_pelicula.Name = "var_duracion_pelicula";
            this.var_duracion_pelicula.Size = new System.Drawing.Size(327, 32);
            this.var_duracion_pelicula.TabIndex = 60;
            this.var_duracion_pelicula.Text = "lorem ipsum";
            // 
            // var_sinopsis
            // 
            this.var_sinopsis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.var_sinopsis.CausesValidation = false;
            this.var_sinopsis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.var_sinopsis.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.var_sinopsis.ForeColor = System.Drawing.Color.White;
            this.var_sinopsis.Location = new System.Drawing.Point(497, 129);
            this.var_sinopsis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.var_sinopsis.Name = "var_sinopsis";
            this.var_sinopsis.Padding = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.var_sinopsis.Size = new System.Drawing.Size(496, 51);
            this.var_sinopsis.TabIndex = 61;
            this.var_sinopsis.Text = "lorem ipsum lorem ipsum lorem ipsum lorem ipsum lorem ipsum lorem ipsum";
            // 
            // var_censura
            // 
            this.var_censura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.var_censura.CausesValidation = false;
            this.var_censura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.var_censura.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.var_censura.ForeColor = System.Drawing.Color.White;
            this.var_censura.Location = new System.Drawing.Point(162, 129);
            this.var_censura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.var_censura.Name = "var_censura";
            this.var_censura.Size = new System.Drawing.Size(327, 51);
            this.var_censura.TabIndex = 65;
            this.var_censura.Text = "lorem ipsum";
            // 
            // Elem_pelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.Controls.Add(this.container_funcion);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Elem_pelicula";
            this.Size = new System.Drawing.Size(1267, 204);
            this.container_funcion.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.var_imagen_pelicula)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel container_funcion;
        private Guna.UI.WinForms.GunaLabel var_titulo_original;
        private Guna.UI.WinForms.GunaLabel var_titulo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaLabel var_duracion_pelicula;
        private Guna.UI.WinForms.GunaPictureBox var_imagen_pelicula;
        private Guna.UI.WinForms.GunaButton btnEditar;
        private Guna.UI.WinForms.GunaLabel var_reparto;
        private Guna.UI.WinForms.GunaLabel var_directores;
        private Guna.UI.WinForms.GunaLabel var_sinopsis;
        private Guna.UI.WinForms.GunaButton btnBorrar;
        private Guna.UI.WinForms.GunaLabel var_censura;
    }
}
