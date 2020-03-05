namespace AppFlickAdministrador.Vistas.Forms.Elementos
{
    partial class Form_ListadoPeliculas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel = new System.Windows.Forms.Panel();
            this.var_titulo = new Guna.UI.WinForms.GunaLabel();
            this.btnSeleccionar = new Guna.UI.WinForms.GunaButton();
            this.tablaPeliculas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPeliculas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(237)))));
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Margin = new System.Windows.Forms.Padding(4);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(940, 18);
            this.panel.TabIndex = 121;
            // 
            // var_titulo
            // 
            this.var_titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.var_titulo.CausesValidation = false;
            this.var_titulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.var_titulo.ForeColor = System.Drawing.Color.White;
            this.var_titulo.Location = new System.Drawing.Point(37, 37);
            this.var_titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.var_titulo.Name = "var_titulo";
            this.var_titulo.Size = new System.Drawing.Size(455, 39);
            this.var_titulo.TabIndex = 155;
            this.var_titulo.Text = "Listado de Películas";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSeleccionar.Animated = true;
            this.btnSeleccionar.AnimationHoverSpeed = 0.07F;
            this.btnSeleccionar.AnimationSpeed = 0.03F;
            this.btnSeleccionar.BackColor = System.Drawing.Color.Transparent;
            this.btnSeleccionar.BaseColor = System.Drawing.Color.Transparent;
            this.btnSeleccionar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(237)))));
            this.btnSeleccionar.BorderSize = 1;
            this.btnSeleccionar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSeleccionar.FocusedColor = System.Drawing.Color.Empty;
            this.btnSeleccionar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionar.Image = global::AppFlickAdministrador.Properties.Resources.icon_mas;
            this.btnSeleccionar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSeleccionar.Location = new System.Drawing.Point(339, 328);
            this.btnSeleccionar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(237)))));
            this.btnSeleccionar.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(237)))));
            this.btnSeleccionar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSeleccionar.OnHoverImage = null;
            this.btnSeleccionar.OnPressedColor = System.Drawing.Color.Black;
            this.btnSeleccionar.Radius = 10;
            this.btnSeleccionar.Size = new System.Drawing.Size(299, 49);
            this.btnSeleccionar.TabIndex = 153;
            this.btnSeleccionar.Text = "Seleccionar Película";
            this.btnSeleccionar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // tablaPeliculas
            // 
            this.tablaPeliculas.AllowUserToAddRows = false;
            this.tablaPeliculas.AllowUserToDeleteRows = false;
            this.tablaPeliculas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.tablaPeliculas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaPeliculas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaPeliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaPeliculas.DefaultCellStyle = dataGridViewCellStyle2;
            this.tablaPeliculas.EnableHeadersVisualStyles = false;
            this.tablaPeliculas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.tablaPeliculas.Location = new System.Drawing.Point(44, 110);
            this.tablaPeliculas.Name = "tablaPeliculas";
            this.tablaPeliculas.RowHeadersWidth = 10;
            this.tablaPeliculas.RowTemplate.Height = 24;
            this.tablaPeliculas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaPeliculas.Size = new System.Drawing.Size(850, 196);
            this.tablaPeliculas.TabIndex = 156;
            // 
            // Form_ListadoPeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(940, 394);
            this.Controls.Add(this.tablaPeliculas);
            this.Controls.Add(this.var_titulo);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.panel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form_ListadoPeliculas";
            this.Text = "Peliculas";
            ((System.ComponentModel.ISupportInitialize)(this.tablaPeliculas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private Guna.UI.WinForms.GunaButton btnSeleccionar;
        private Guna.UI.WinForms.GunaLabel var_titulo;
        private System.Windows.Forms.DataGridView tablaPeliculas;
    }
}