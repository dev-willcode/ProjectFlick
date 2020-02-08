namespace AppFlickDesktop.Vistas.Forms.Elementos
{
    partial class Elem_tarjeta_vacia
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
            this.panelAnadir = new System.Windows.Forms.Panel();
            this.btnMasTarjetas = new Guna.UI.WinForms.GunaCircleButton();
            this.panelAnadir.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAnadir
            // 
            this.panelAnadir.BackgroundImage = global::AppFlickDesktop.Properties.Resources.tarjeta_nueva;
            this.panelAnadir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelAnadir.Controls.Add(this.btnMasTarjetas);
            this.panelAnadir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAnadir.Location = new System.Drawing.Point(0, 0);
            this.panelAnadir.Margin = new System.Windows.Forms.Padding(5);
            this.panelAnadir.Name = "panelAnadir";
            this.panelAnadir.Padding = new System.Windows.Forms.Padding(5);
            this.panelAnadir.Size = new System.Drawing.Size(386, 241);
            this.panelAnadir.TabIndex = 1;
            // 
            // btnMasTarjetas
            // 
            this.btnMasTarjetas.AnimationHoverSpeed = 0.07F;
            this.btnMasTarjetas.AnimationSpeed = 0.03F;
            this.btnMasTarjetas.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(88)))), ((int)(((byte)(169)))));
            this.btnMasTarjetas.BorderColor = System.Drawing.Color.Black;
            this.btnMasTarjetas.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMasTarjetas.FocusedColor = System.Drawing.Color.Empty;
            this.btnMasTarjetas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMasTarjetas.ForeColor = System.Drawing.Color.White;
            this.btnMasTarjetas.Image = global::AppFlickDesktop.Properties.Resources.icon_mas;
            this.btnMasTarjetas.ImageSize = new System.Drawing.Size(38, 38);
            this.btnMasTarjetas.Location = new System.Drawing.Point(129, 57);
            this.btnMasTarjetas.Margin = new System.Windows.Forms.Padding(4);
            this.btnMasTarjetas.Name = "btnMasTarjetas";
            this.btnMasTarjetas.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(237)))));
            this.btnMasTarjetas.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnMasTarjetas.OnHoverForeColor = System.Drawing.Color.White;
            this.btnMasTarjetas.OnHoverImage = null;
            this.btnMasTarjetas.OnPressedColor = System.Drawing.Color.Black;
            this.btnMasTarjetas.Size = new System.Drawing.Size(134, 123);
            this.btnMasTarjetas.TabIndex = 0;
            this.btnMasTarjetas.Click += new System.EventHandler(this.btnMasTarjetas_Click);
            // 
            // Elem_tarjeta_vacia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.Controls.Add(this.panelAnadir);
            this.Name = "Elem_tarjeta_vacia";
            this.Size = new System.Drawing.Size(386, 241);
            this.panelAnadir.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAnadir;
        private Guna.UI.WinForms.GunaCircleButton btnMasTarjetas;
    }
}
