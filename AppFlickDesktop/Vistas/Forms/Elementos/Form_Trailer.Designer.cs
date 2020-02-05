namespace AppFlickDesktop.Vistas.Forms
{
    partial class Form_Trailer
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
            this.container = new System.Windows.Forms.Panel();
            this.panel = new System.Windows.Forms.Panel();
            this.webview = new System.Windows.Forms.WebBrowser();
            this.var_categoria = new Guna.UI.WinForms.GunaLabel();
            this.btnCerrar = new Guna.UI.WinForms.GunaImageButton();
            this.var_titulo = new Guna.UI.WinForms.GunaLabel();
            this.var_titulo_original = new Guna.UI.WinForms.GunaLabel();
            this.var_duracion_pelicula = new Guna.UI.WinForms.GunaLabel();
            this.var_censura = new Guna.UI.WinForms.GunaLabel();
            this.container.SuspendLayout();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.container.Controls.Add(this.panel);
            this.container.Controls.Add(this.webview);
            this.container.Controls.Add(this.var_categoria);
            this.container.Controls.Add(this.btnCerrar);
            this.container.Controls.Add(this.var_titulo);
            this.container.Controls.Add(this.var_titulo_original);
            this.container.Controls.Add(this.var_duracion_pelicula);
            this.container.Controls.Add(this.var_censura);
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(0, 0);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(898, 541);
            this.container.TabIndex = 0;
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(237)))));
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(898, 15);
            this.panel.TabIndex = 61;
            // 
            // webview
            // 
            this.webview.AllowWebBrowserDrop = false;
            this.webview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webview.IsWebBrowserContextMenuEnabled = false;
            this.webview.Location = new System.Drawing.Point(36, 88);
            this.webview.MinimumSize = new System.Drawing.Size(20, 20);
            this.webview.Name = "webview";
            this.webview.ScriptErrorsSuppressed = true;
            this.webview.ScrollBarsEnabled = false;
            this.webview.Size = new System.Drawing.Size(825, 431);
            this.webview.TabIndex = 60;
            // 
            // var_categoria
            // 
            this.var_categoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.var_categoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.var_categoria.CausesValidation = false;
            this.var_categoria.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.var_categoria.ForeColor = System.Drawing.Color.White;
            this.var_categoria.Location = new System.Drawing.Point(514, 32);
            this.var_categoria.Name = "var_categoria";
            this.var_categoria.Size = new System.Drawing.Size(294, 37);
            this.var_categoria.TabIndex = 2;
            // 
            // btnCerrar
            // 
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCerrar.Image = global::AppFlickDesktop.Properties.Resources.icon_cerrar;
            this.btnCerrar.ImageSize = new System.Drawing.Size(32, 32);
            this.btnCerrar.Location = new System.Drawing.Point(829, 32);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.OnHoverImage = null;
            this.btnCerrar.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btnCerrar.Size = new System.Drawing.Size(32, 32);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // var_titulo
            // 
            this.var_titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.var_titulo.CausesValidation = false;
            this.var_titulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.var_titulo.ForeColor = System.Drawing.Color.White;
            this.var_titulo.Location = new System.Drawing.Point(30, 23);
            this.var_titulo.Name = "var_titulo";
            this.var_titulo.Size = new System.Drawing.Size(341, 32);
            this.var_titulo.TabIndex = 7;
            // 
            // var_titulo_original
            // 
            this.var_titulo_original.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.var_titulo_original.CausesValidation = false;
            this.var_titulo_original.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.var_titulo_original.ForeColor = System.Drawing.Color.LightGray;
            this.var_titulo_original.Location = new System.Drawing.Point(31, 57);
            this.var_titulo_original.Name = "var_titulo_original";
            this.var_titulo_original.Size = new System.Drawing.Size(340, 25);
            this.var_titulo_original.TabIndex = 6;
            // 
            // var_duracion_pelicula
            // 
            this.var_duracion_pelicula.AutoSize = true;
            this.var_duracion_pelicula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.var_duracion_pelicula.CausesValidation = false;
            this.var_duracion_pelicula.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.var_duracion_pelicula.ForeColor = System.Drawing.Color.White;
            this.var_duracion_pelicula.Location = new System.Drawing.Point(377, 52);
            this.var_duracion_pelicula.Name = "var_duracion_pelicula";
            this.var_duracion_pelicula.Size = new System.Drawing.Size(0, 17);
            this.var_duracion_pelicula.TabIndex = 4;
            // 
            // var_censura
            // 
            this.var_censura.AutoSize = true;
            this.var_censura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.var_censura.CausesValidation = false;
            this.var_censura.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.var_censura.ForeColor = System.Drawing.Color.White;
            this.var_censura.Location = new System.Drawing.Point(377, 35);
            this.var_censura.Name = "var_censura";
            this.var_censura.Size = new System.Drawing.Size(0, 17);
            this.var_censura.TabIndex = 5;
            // 
            // Form_Trailer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 541);
            this.Controls.Add(this.container);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Trailer";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Trailer";
            this.container.ResumeLayout(false);
            this.container.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel container;
        private Guna.UI.WinForms.GunaLabel var_duracion_pelicula;
        private Guna.UI.WinForms.GunaLabel var_censura;
        private Guna.UI.WinForms.GunaLabel var_titulo_original;
        private Guna.UI.WinForms.GunaLabel var_titulo;
        private Guna.UI.WinForms.GunaImageButton btnCerrar;
        private Guna.UI.WinForms.GunaLabel var_categoria;
        private System.Windows.Forms.WebBrowser webview;
        private System.Windows.Forms.Panel panel;
    }
}