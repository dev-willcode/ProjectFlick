﻿namespace AppFlickAdministrador.Vistas.Init
{
    partial class Elem_Horario
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
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.var_duracion_pelicula = new Guna.UI.WinForms.GunaLabel();
            this.btnBorrar = new Guna.UI.WinForms.GunaButton();
            this.container_funcion.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // container_funcion
            // 
            this.container_funcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.container_funcion.Controls.Add(this.tableLayoutPanel1);
            this.container_funcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container_funcion.Location = new System.Drawing.Point(0, 0);
            this.container_funcion.Name = "container_funcion";
            this.container_funcion.Padding = new System.Windows.Forms.Padding(5);
            this.container_funcion.Size = new System.Drawing.Size(377, 50);
            this.container_funcion.TabIndex = 69;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.74555F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.74554F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.74554F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.76337F));
            this.tableLayoutPanel1.Controls.Add(this.btnBorrar, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnEditar, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.gunaLabel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.var_duracion_pelicula, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(367, 40);
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
            this.btnEditar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditar.FocusedColor = System.Drawing.Color.Empty;
            this.btnEditar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Image = global::AppFlickAdministrador.Properties.Resources.icon_cambiar;
            this.btnEditar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEditar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnEditar.Location = new System.Drawing.Point(213, 3);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(237)))));
            this.btnEditar.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(237)))));
            this.btnEditar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEditar.OnHoverImage = null;
            this.btnEditar.OnPressedColor = System.Drawing.Color.Black;
            this.btnEditar.Radius = 7;
            this.btnEditar.Size = new System.Drawing.Size(99, 34);
            this.btnEditar.TabIndex = 56;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEditar.UseTransfarantBackground = true;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.gunaLabel1.CausesValidation = false;
            this.gunaLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(108, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(99, 40);
            this.gunaLabel1.TabIndex = 55;
            this.gunaLabel1.Text = "lorem ipsum";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // var_duracion_pelicula
            // 
            this.var_duracion_pelicula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.var_duracion_pelicula.CausesValidation = false;
            this.var_duracion_pelicula.Dock = System.Windows.Forms.DockStyle.Fill;
            this.var_duracion_pelicula.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.var_duracion_pelicula.ForeColor = System.Drawing.Color.White;
            this.var_duracion_pelicula.Location = new System.Drawing.Point(3, 0);
            this.var_duracion_pelicula.Name = "var_duracion_pelicula";
            this.var_duracion_pelicula.Size = new System.Drawing.Size(99, 40);
            this.var_duracion_pelicula.TabIndex = 32;
            this.var_duracion_pelicula.Text = "lorem ipsum";
            this.var_duracion_pelicula.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnBorrar.Location = new System.Drawing.Point(318, 3);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(237)))));
            this.btnBorrar.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(237)))));
            this.btnBorrar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBorrar.OnHoverImage = null;
            this.btnBorrar.OnPressedColor = System.Drawing.Color.Black;
            this.btnBorrar.Radius = 7;
            this.btnBorrar.Size = new System.Drawing.Size(46, 34);
            this.btnBorrar.TabIndex = 57;
            this.btnBorrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBorrar.UseTransfarantBackground = true;
            // 
            // Elem_Horario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.Controls.Add(this.container_funcion);
            this.DoubleBuffered = true;
            this.Name = "Elem_Horario";
            this.Size = new System.Drawing.Size(377, 50);
            this.container_funcion.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel container_funcion;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel var_duracion_pelicula;
        private Guna.UI.WinForms.GunaButton btnEditar;
        private Guna.UI.WinForms.GunaButton btnBorrar;
    }
}