namespace AppFlickAdministrador.Vistas.Forms
{
    partial class Elem_idioma_funcion
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
            this.container = new Guna.UI.WinForms.GunaElipsePanel();
            this.var_idioma = new Guna.UI.WinForms.GunaLabel();
            this.imagenBoleto = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagenBoleto)).BeginInit();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.BackColor = System.Drawing.Color.Transparent;
            this.container.BaseColor = System.Drawing.Color.Orange;
            this.container.Controls.Add(this.var_idioma);
            this.container.Controls.Add(this.imagenBoleto);
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(0, 0);
            this.container.Name = "container";
            this.container.Padding = new System.Windows.Forms.Padding(3);
            this.container.Radius = 8;
            this.container.Size = new System.Drawing.Size(112, 28);
            this.container.TabIndex = 27;
            // 
            // var_idioma
            // 
            this.var_idioma.CausesValidation = false;
            this.var_idioma.Dock = System.Windows.Forms.DockStyle.Fill;
            this.var_idioma.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.var_idioma.ForeColor = System.Drawing.Color.White;
            this.var_idioma.Location = new System.Drawing.Point(41, 3);
            this.var_idioma.Name = "var_idioma";
            this.var_idioma.Size = new System.Drawing.Size(68, 22);
            this.var_idioma.TabIndex = 26;
            this.var_idioma.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imagenBoleto
            // 
            this.imagenBoleto.BaseColor = System.Drawing.Color.White;
            this.imagenBoleto.Dock = System.Windows.Forms.DockStyle.Left;
            this.imagenBoleto.Image = global::AppFlickAdministrador.Properties.Resources.icon_boletos;
            this.imagenBoleto.Location = new System.Drawing.Point(3, 3);
            this.imagenBoleto.Name = "imagenBoleto";
            this.imagenBoleto.Size = new System.Drawing.Size(38, 22);
            this.imagenBoleto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagenBoleto.TabIndex = 28;
            this.imagenBoleto.TabStop = false;
            this.imagenBoleto.UseTransfarantBackground = false;
            // 
            // Elem_idioma_funcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.container);
            this.Name = "Elem_idioma_funcion";
            this.Size = new System.Drawing.Size(112, 28);
            this.container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imagenBoleto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipsePanel container;
        private Guna.UI.WinForms.GunaLabel var_idioma;
        private Guna.UI.WinForms.GunaCirclePictureBox imagenBoleto;
    }
}
