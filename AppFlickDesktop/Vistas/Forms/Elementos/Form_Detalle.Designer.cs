namespace AppFlickCliente.Vistas.Forms
{
    partial class Form_Detalle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel = new System.Windows.Forms.Panel();
            this.var_categoria = new Guna.UI.WinForms.GunaLabel();
            this.var_titulo = new Guna.UI.WinForms.GunaLabel();
            this.var_titulo_original = new Guna.UI.WinForms.GunaLabel();
            this.var_duracion_pelicula = new Guna.UI.WinForms.GunaLabel();
            this.var_censura = new Guna.UI.WinForms.GunaLabel();
            this.var_imagen_pelicula = new Guna.UI.WinForms.GunaPictureBox();
            this.btnCerrar = new Guna.UI.WinForms.GunaImageButton();
            this.var_sinopsis = new Guna.UI.WinForms.GunaLabel();
            this.var_directores = new Guna.UI.WinForms.GunaLabel();
            this.var_reparto = new Guna.UI.WinForms.GunaLabel();
            ((System.ComponentModel.ISupportInitialize)(this.var_imagen_pelicula)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(237)))));
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(863, 15);
            this.panel.TabIndex = 70;
            // 
            // var_categoria
            // 
            this.var_categoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.var_categoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.var_categoria.CausesValidation = false;
            this.var_categoria.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.var_categoria.ForeColor = System.Drawing.Color.White;
            this.var_categoria.Location = new System.Drawing.Point(276, 146);
            this.var_categoria.Name = "var_categoria";
            this.var_categoria.Size = new System.Drawing.Size(517, 37);
            this.var_categoria.TabIndex = 62;
            // 
            // var_titulo
            // 
            this.var_titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.var_titulo.CausesValidation = false;
            this.var_titulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.var_titulo.ForeColor = System.Drawing.Color.White;
            this.var_titulo.Location = new System.Drawing.Point(273, 43);
            this.var_titulo.Name = "var_titulo";
            this.var_titulo.Size = new System.Drawing.Size(341, 32);
            this.var_titulo.TabIndex = 67;
            // 
            // var_titulo_original
            // 
            this.var_titulo_original.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.var_titulo_original.CausesValidation = false;
            this.var_titulo_original.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.var_titulo_original.ForeColor = System.Drawing.Color.LightGray;
            this.var_titulo_original.Location = new System.Drawing.Point(274, 77);
            this.var_titulo_original.Name = "var_titulo_original";
            this.var_titulo_original.Size = new System.Drawing.Size(340, 25);
            this.var_titulo_original.TabIndex = 66;
            // 
            // var_duracion_pelicula
            // 
            this.var_duracion_pelicula.AutoSize = true;
            this.var_duracion_pelicula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.var_duracion_pelicula.CausesValidation = false;
            this.var_duracion_pelicula.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.var_duracion_pelicula.ForeColor = System.Drawing.Color.White;
            this.var_duracion_pelicula.Location = new System.Drawing.Point(276, 127);
            this.var_duracion_pelicula.Name = "var_duracion_pelicula";
            this.var_duracion_pelicula.Size = new System.Drawing.Size(0, 17);
            this.var_duracion_pelicula.TabIndex = 64;
            // 
            // var_censura
            // 
            this.var_censura.AutoSize = true;
            this.var_censura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.var_censura.CausesValidation = false;
            this.var_censura.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.var_censura.ForeColor = System.Drawing.Color.White;
            this.var_censura.Location = new System.Drawing.Point(276, 110);
            this.var_censura.Name = "var_censura";
            this.var_censura.Size = new System.Drawing.Size(0, 17);
            this.var_censura.TabIndex = 65;
            // 
            // var_imagen_pelicula
            // 
            this.var_imagen_pelicula.BackColor = System.Drawing.Color.Transparent;
            this.var_imagen_pelicula.BaseColor = System.Drawing.Color.White;
            this.var_imagen_pelicula.Image = global::AppFlickCliente.Properties.Resources.pelicula_muestra;
            this.var_imagen_pelicula.Location = new System.Drawing.Point(40, 43);
            this.var_imagen_pelicula.Name = "var_imagen_pelicula";
            this.var_imagen_pelicula.Size = new System.Drawing.Size(227, 340);
            this.var_imagen_pelicula.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.var_imagen_pelicula.TabIndex = 68;
            this.var_imagen_pelicula.TabStop = false;
            this.var_imagen_pelicula.UseTransfarantBackground = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCerrar.Image = global::AppFlickCliente.Properties.Resources.icon_cerrar;
            this.btnCerrar.ImageSize = new System.Drawing.Size(32, 32);
            this.btnCerrar.Location = new System.Drawing.Point(794, 43);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.OnHoverImage = null;
            this.btnCerrar.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btnCerrar.Size = new System.Drawing.Size(32, 32);
            this.btnCerrar.TabIndex = 63;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // var_sinopsis
            // 
            this.var_sinopsis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.var_sinopsis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.var_sinopsis.CausesValidation = false;
            this.var_sinopsis.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.var_sinopsis.ForeColor = System.Drawing.Color.White;
            this.var_sinopsis.Location = new System.Drawing.Point(276, 183);
            this.var_sinopsis.Name = "var_sinopsis";
            this.var_sinopsis.Size = new System.Drawing.Size(517, 68);
            this.var_sinopsis.TabIndex = 71;
            // 
            // var_directores
            // 
            this.var_directores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.var_directores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.var_directores.CausesValidation = false;
            this.var_directores.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.var_directores.ForeColor = System.Drawing.Color.White;
            this.var_directores.Location = new System.Drawing.Point(276, 251);
            this.var_directores.Name = "var_directores";
            this.var_directores.Size = new System.Drawing.Size(517, 37);
            this.var_directores.TabIndex = 72;
            // 
            // var_reparto
            // 
            this.var_reparto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.var_reparto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.var_reparto.CausesValidation = false;
            this.var_reparto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.var_reparto.ForeColor = System.Drawing.Color.White;
            this.var_reparto.Location = new System.Drawing.Point(276, 288);
            this.var_reparto.Name = "var_reparto";
            this.var_reparto.Size = new System.Drawing.Size(517, 52);
            this.var_reparto.TabIndex = 73;
            // 
            // Form_Detalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(863, 421);
            this.Controls.Add(this.var_reparto);
            this.Controls.Add(this.var_directores);
            this.Controls.Add(this.var_sinopsis);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.var_imagen_pelicula);
            this.Controls.Add(this.var_categoria);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.var_titulo);
            this.Controls.Add(this.var_titulo_original);
            this.Controls.Add(this.var_duracion_pelicula);
            this.Controls.Add(this.var_censura);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Detalle";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Detalle";
            ((System.ComponentModel.ISupportInitialize)(this.var_imagen_pelicula)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private Guna.UI.WinForms.GunaPictureBox var_imagen_pelicula;
        private Guna.UI.WinForms.GunaLabel var_categoria;
        private Guna.UI.WinForms.GunaImageButton btnCerrar;
        private Guna.UI.WinForms.GunaLabel var_titulo;
        private Guna.UI.WinForms.GunaLabel var_titulo_original;
        private Guna.UI.WinForms.GunaLabel var_duracion_pelicula;
        private Guna.UI.WinForms.GunaLabel var_censura;
        private Guna.UI.WinForms.GunaLabel var_sinopsis;
        private Guna.UI.WinForms.GunaLabel var_directores;
        private Guna.UI.WinForms.GunaLabel var_reparto;
    }
}