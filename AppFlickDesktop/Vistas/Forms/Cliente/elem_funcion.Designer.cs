namespace AppFlickDesktop.Vistas.Init
{
    partial class Elem_funcion
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
            this.container_pelicula = new Guna.UI.WinForms.GunaElipsePanel();
            this.container_idiomas = new System.Windows.Forms.TableLayoutPanel();
            this.var_categoria = new Guna.UI.WinForms.GunaLabel();
            this.var_duracion_pelicula = new Guna.UI.WinForms.GunaLabel();
            this.var_censura = new Guna.UI.WinForms.GunaLabel();
            this.var_titulo_original = new Guna.UI.WinForms.GunaLabel();
            this.var_titulo = new Guna.UI.WinForms.GunaLabel();
            this.var_imagen_pelicula = new Guna.UI.WinForms.GunaPictureBox();
            this.btnComprar = new Guna.UI.WinForms.GunaButton();
            this.btnMas = new Guna.UI.WinForms.GunaButton();
            this.btnTrailer = new Guna.UI.WinForms.GunaButton();
            this.container_funcion.SuspendLayout();
            this.container_pelicula.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.var_imagen_pelicula)).BeginInit();
            this.SuspendLayout();
            // 
            // container_funcion
            // 
            this.container_funcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.container_funcion.Controls.Add(this.var_imagen_pelicula);
            this.container_funcion.Controls.Add(this.btnComprar);
            this.container_funcion.Controls.Add(this.btnMas);
            this.container_funcion.Controls.Add(this.btnTrailer);
            this.container_funcion.Controls.Add(this.container_pelicula);
            this.container_funcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container_funcion.Location = new System.Drawing.Point(0, 0);
            this.container_funcion.Name = "container_funcion";
            this.container_funcion.Size = new System.Drawing.Size(950, 200);
            this.container_funcion.TabIndex = 69;
            // 
            // container_pelicula
            // 
            this.container_pelicula.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.container_pelicula.BackColor = System.Drawing.Color.Transparent;
            this.container_pelicula.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(75)))), ((int)(((byte)(140)))));
            this.container_pelicula.Controls.Add(this.container_idiomas);
            this.container_pelicula.Controls.Add(this.var_categoria);
            this.container_pelicula.Controls.Add(this.var_duracion_pelicula);
            this.container_pelicula.Controls.Add(this.var_censura);
            this.container_pelicula.Controls.Add(this.var_titulo_original);
            this.container_pelicula.Controls.Add(this.var_titulo);
            this.container_pelicula.Location = new System.Drawing.Point(12, 29);
            this.container_pelicula.Name = "container_pelicula";
            this.container_pelicula.Radius = 15;
            this.container_pelicula.Size = new System.Drawing.Size(923, 121);
            this.container_pelicula.TabIndex = 52;
            // 
            // container_idiomas
            // 
            this.container_idiomas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(75)))), ((int)(((byte)(140)))));
            this.container_idiomas.ColumnCount = 4;
            this.container_idiomas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.container_idiomas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.container_idiomas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.container_idiomas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.container_idiomas.Location = new System.Drawing.Point(180, 57);
            this.container_idiomas.Name = "container_idiomas";
            this.container_idiomas.RowCount = 1;
            this.container_idiomas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.container_idiomas.Size = new System.Drawing.Size(475, 34);
            this.container_idiomas.TabIndex = 52;
            // 
            // var_categoria
            // 
            this.var_categoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.var_categoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(75)))), ((int)(((byte)(140)))));
            this.var_categoria.CausesValidation = false;
            this.var_categoria.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.var_categoria.ForeColor = System.Drawing.Color.White;
            this.var_categoria.Location = new System.Drawing.Point(670, 34);
            this.var_categoria.Name = "var_categoria";
            this.var_categoria.Size = new System.Drawing.Size(241, 50);
            this.var_categoria.TabIndex = 32;
            // 
            // var_duracion_pelicula
            // 
            this.var_duracion_pelicula.AutoSize = true;
            this.var_duracion_pelicula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(75)))), ((int)(((byte)(140)))));
            this.var_duracion_pelicula.CausesValidation = false;
            this.var_duracion_pelicula.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.var_duracion_pelicula.ForeColor = System.Drawing.Color.White;
            this.var_duracion_pelicula.Location = new System.Drawing.Point(549, 34);
            this.var_duracion_pelicula.Name = "var_duracion_pelicula";
            this.var_duracion_pelicula.Size = new System.Drawing.Size(0, 15);
            this.var_duracion_pelicula.TabIndex = 31;
            // 
            // var_censura
            // 
            this.var_censura.AutoSize = true;
            this.var_censura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(75)))), ((int)(((byte)(140)))));
            this.var_censura.CausesValidation = false;
            this.var_censura.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.var_censura.ForeColor = System.Drawing.Color.White;
            this.var_censura.Location = new System.Drawing.Point(417, 34);
            this.var_censura.Name = "var_censura";
            this.var_censura.Size = new System.Drawing.Size(0, 15);
            this.var_censura.TabIndex = 30;
            // 
            // var_titulo_original
            // 
            this.var_titulo_original.AutoSize = true;
            this.var_titulo_original.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(75)))), ((int)(((byte)(140)))));
            this.var_titulo_original.CausesValidation = false;
            this.var_titulo_original.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.var_titulo_original.ForeColor = System.Drawing.Color.LightGray;
            this.var_titulo_original.Location = new System.Drawing.Point(177, 34);
            this.var_titulo_original.Name = "var_titulo_original";
            this.var_titulo_original.Size = new System.Drawing.Size(0, 20);
            this.var_titulo_original.TabIndex = 25;
            // 
            // var_titulo
            // 
            this.var_titulo.AutoSize = true;
            this.var_titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(75)))), ((int)(((byte)(140)))));
            this.var_titulo.CausesValidation = false;
            this.var_titulo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.var_titulo.ForeColor = System.Drawing.Color.White;
            this.var_titulo.Location = new System.Drawing.Point(175, 9);
            this.var_titulo.Name = "var_titulo";
            this.var_titulo.Size = new System.Drawing.Size(0, 25);
            this.var_titulo.TabIndex = 23;
            // 
            // var_imagen_pelicula
            // 
            this.var_imagen_pelicula.BackColor = System.Drawing.Color.Transparent;
            this.var_imagen_pelicula.BaseColor = System.Drawing.Color.White;
            this.var_imagen_pelicula.Image = global::AppFlickDesktop.Properties.Resources.pelicula_muestra;
            this.var_imagen_pelicula.Location = new System.Drawing.Point(22, -1);
            this.var_imagen_pelicula.Name = "var_imagen_pelicula";
            this.var_imagen_pelicula.Size = new System.Drawing.Size(131, 188);
            this.var_imagen_pelicula.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.var_imagen_pelicula.TabIndex = 53;
            this.var_imagen_pelicula.TabStop = false;
            this.var_imagen_pelicula.UseTransfarantBackground = true;
            // 
            // btnComprar
            // 
            this.btnComprar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnComprar.Animated = true;
            this.btnComprar.AnimationHoverSpeed = 0.07F;
            this.btnComprar.AnimationSpeed = 0.03F;
            this.btnComprar.BackColor = System.Drawing.Color.Transparent;
            this.btnComprar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(237)))));
            this.btnComprar.BorderColor = System.Drawing.Color.Black;
            this.btnComprar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnComprar.FocusedColor = System.Drawing.Color.Empty;
            this.btnComprar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprar.ForeColor = System.Drawing.Color.White;
            this.btnComprar.Image = global::AppFlickDesktop.Properties.Resources.icon_comprar;
            this.btnComprar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnComprar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnComprar.Location = new System.Drawing.Point(577, 129);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(237)))));
            this.btnComprar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnComprar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnComprar.OnHoverImage = null;
            this.btnComprar.OnPressedColor = System.Drawing.Color.Black;
            this.btnComprar.Radius = 7;
            this.btnComprar.Size = new System.Drawing.Size(124, 37);
            this.btnComprar.TabIndex = 47;
            this.btnComprar.Text = "Comprar!";
            this.btnComprar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnComprar.UseTransfarantBackground = true;
            // 
            // btnMas
            // 
            this.btnMas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnMas.Animated = true;
            this.btnMas.AnimationHoverSpeed = 0.07F;
            this.btnMas.AnimationSpeed = 0.03F;
            this.btnMas.BackColor = System.Drawing.Color.Transparent;
            this.btnMas.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.btnMas.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(237)))));
            this.btnMas.BorderSize = 1;
            this.btnMas.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMas.FocusedColor = System.Drawing.Color.Empty;
            this.btnMas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMas.ForeColor = System.Drawing.Color.White;
            this.btnMas.Image = global::AppFlickDesktop.Properties.Resources.icon_etiqueta_verde;
            this.btnMas.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnMas.ImageSize = new System.Drawing.Size(20, 20);
            this.btnMas.Location = new System.Drawing.Point(317, 129);
            this.btnMas.Name = "btnMas";
            this.btnMas.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(237)))));
            this.btnMas.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(237)))));
            this.btnMas.OnHoverForeColor = System.Drawing.Color.White;
            this.btnMas.OnHoverImage = null;
            this.btnMas.OnPressedColor = System.Drawing.Color.Black;
            this.btnMas.Radius = 7;
            this.btnMas.Size = new System.Drawing.Size(124, 37);
            this.btnMas.TabIndex = 50;
            this.btnMas.Text = "Más";
            this.btnMas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnMas.UseTransfarantBackground = true;
            // 
            // btnTrailer
            // 
            this.btnTrailer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTrailer.Animated = true;
            this.btnTrailer.AnimationHoverSpeed = 0.07F;
            this.btnTrailer.AnimationSpeed = 0.03F;
            this.btnTrailer.BackColor = System.Drawing.Color.Transparent;
            this.btnTrailer.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.btnTrailer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(237)))));
            this.btnTrailer.BorderSize = 1;
            this.btnTrailer.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnTrailer.FocusedColor = System.Drawing.Color.Empty;
            this.btnTrailer.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrailer.ForeColor = System.Drawing.Color.White;
            this.btnTrailer.Image = global::AppFlickDesktop.Properties.Resources.icon_trailer;
            this.btnTrailer.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnTrailer.ImageSize = new System.Drawing.Size(20, 20);
            this.btnTrailer.Location = new System.Drawing.Point(447, 129);
            this.btnTrailer.Name = "btnTrailer";
            this.btnTrailer.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(237)))));
            this.btnTrailer.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(237)))));
            this.btnTrailer.OnHoverForeColor = System.Drawing.Color.White;
            this.btnTrailer.OnHoverImage = null;
            this.btnTrailer.OnPressedColor = System.Drawing.Color.Black;
            this.btnTrailer.Radius = 7;
            this.btnTrailer.Size = new System.Drawing.Size(124, 37);
            this.btnTrailer.TabIndex = 49;
            this.btnTrailer.Text = "Trailer";
            this.btnTrailer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnTrailer.UseTransfarantBackground = true;
            // 
            // Elem_funcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.Controls.Add(this.container_funcion);
            this.DoubleBuffered = true;
            this.Name = "Elem_funcion";
            this.Size = new System.Drawing.Size(950, 200);
            this.container_funcion.ResumeLayout(false);
            this.container_pelicula.ResumeLayout(false);
            this.container_pelicula.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.var_imagen_pelicula)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel container_funcion;
        private Guna.UI.WinForms.GunaButton btnComprar;
        private Guna.UI.WinForms.GunaButton btnMas;
        private Guna.UI.WinForms.GunaButton btnTrailer;
        private Guna.UI.WinForms.GunaElipsePanel container_pelicula;
        private System.Windows.Forms.TableLayoutPanel container_idiomas;
        private Guna.UI.WinForms.GunaLabel var_categoria;
        private Guna.UI.WinForms.GunaLabel var_duracion_pelicula;
        private Guna.UI.WinForms.GunaLabel var_censura;
        private Guna.UI.WinForms.GunaLabel var_titulo_original;
        private Guna.UI.WinForms.GunaPictureBox var_imagen_pelicula;
        private Guna.UI.WinForms.GunaLabel var_titulo;
    }
}
