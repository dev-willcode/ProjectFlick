﻿namespace AppFlickAdministrador.Vistas.Forms.Elementos
{
    partial class Form_Pelicula
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel = new System.Windows.Forms.Panel();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.txtReparto = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.txtDirector = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.txtTitulo = new Guna.UI.WinForms.GunaTextBox();
            this.txtDuracion = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txtCensura = new Guna.UI.WinForms.GunaTextBox();
            this.var_titulo = new Guna.UI.WinForms.GunaLabel();
            this.var_segundo_titulo = new Guna.UI.WinForms.GunaLabel();
            this.var_censura = new Guna.UI.WinForms.GunaLabel();
            this.txtTituloOriginal = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.txtURL = new Guna.UI.WinForms.GunaTextBox();
            this.SelectorArchivo = new System.Windows.Forms.OpenFileDialog();
            this.txtSinopsis = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.tablaCategoria = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categorianombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnEliminarCategoria = new Guna.UI.WinForms.GunaButton();
            this.btnAnadirCategoria = new Guna.UI.WinForms.GunaButton();
            this.btnCambiarImagen = new Guna.UI.WinForms.GunaCircleButton();
            this.var_imagen_pelicula = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.btnGuardar = new Guna.UI.WinForms.GunaButton();
            this.btnCerrar = new Guna.UI.WinForms.GunaImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.var_imagen_pelicula)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(237)))));
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Margin = new System.Windows.Forms.Padding(4);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(863, 18);
            this.panel.TabIndex = 119;
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.gunaLabel8.CausesValidation = false;
            this.gunaLabel8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel8.ForeColor = System.Drawing.Color.White;
            this.gunaLabel8.Location = new System.Drawing.Point(612, 474);
            this.gunaLabel8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(70, 23);
            this.gunaLabel8.TabIndex = 167;
            this.gunaLabel8.Text = "Reparto";
            // 
            // txtReparto
            // 
            this.txtReparto.BackColor = System.Drawing.Color.Transparent;
            this.txtReparto.BaseColor = System.Drawing.Color.White;
            this.txtReparto.BorderColor = System.Drawing.Color.White;
            this.txtReparto.BorderSize = 0;
            this.txtReparto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtReparto.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtReparto.FocusedBorderColor = System.Drawing.Color.White;
            this.txtReparto.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.txtReparto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReparto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.txtReparto.Location = new System.Drawing.Point(614, 505);
            this.txtReparto.Margin = new System.Windows.Forms.Padding(4);
            this.txtReparto.MaxLength = 255;
            this.txtReparto.Name = "txtReparto";
            this.txtReparto.PasswordChar = '\0';
            this.txtReparto.Radius = 10;
            this.txtReparto.Size = new System.Drawing.Size(218, 39);
            this.txtReparto.TabIndex = 166;
            this.txtReparto.TextOffsetX = 2;
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.gunaLabel7.CausesValidation = false;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel7.ForeColor = System.Drawing.Color.White;
            this.gunaLabel7.Location = new System.Drawing.Point(380, 474);
            this.gunaLabel7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(71, 23);
            this.gunaLabel7.TabIndex = 165;
            this.gunaLabel7.Text = "Director";
            // 
            // txtDirector
            // 
            this.txtDirector.BackColor = System.Drawing.Color.Transparent;
            this.txtDirector.BaseColor = System.Drawing.Color.White;
            this.txtDirector.BorderColor = System.Drawing.Color.White;
            this.txtDirector.BorderSize = 0;
            this.txtDirector.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDirector.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtDirector.FocusedBorderColor = System.Drawing.Color.White;
            this.txtDirector.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.txtDirector.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDirector.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.txtDirector.Location = new System.Drawing.Point(379, 505);
            this.txtDirector.Margin = new System.Windows.Forms.Padding(4);
            this.txtDirector.MaxLength = 50;
            this.txtDirector.Name = "txtDirector";
            this.txtDirector.PasswordChar = '\0';
            this.txtDirector.Radius = 10;
            this.txtDirector.Size = new System.Drawing.Size(218, 39);
            this.txtDirector.TabIndex = 164;
            this.txtDirector.TextOffsetX = 2;
            this.txtDirector.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDirector_KeyPress);
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.gunaLabel6.CausesValidation = false;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel6.ForeColor = System.Drawing.Color.White;
            this.gunaLabel6.Location = new System.Drawing.Point(380, 294);
            this.gunaLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(71, 23);
            this.gunaLabel6.TabIndex = 163;
            this.gunaLabel6.Text = "Sinopsis";
            // 
            // txtTitulo
            // 
            this.txtTitulo.BackColor = System.Drawing.Color.Transparent;
            this.txtTitulo.BaseColor = System.Drawing.Color.White;
            this.txtTitulo.BorderColor = System.Drawing.Color.White;
            this.txtTitulo.BorderSize = 0;
            this.txtTitulo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTitulo.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtTitulo.FocusedBorderColor = System.Drawing.Color.White;
            this.txtTitulo.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.txtTitulo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.txtTitulo.Location = new System.Drawing.Point(379, 148);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTitulo.MaxLength = 50;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.PasswordChar = '\0';
            this.txtTitulo.Radius = 10;
            this.txtTitulo.Size = new System.Drawing.Size(218, 39);
            this.txtTitulo.TabIndex = 161;
            this.txtTitulo.TextOffsetX = 2;
            // 
            // txtDuracion
            // 
            this.txtDuracion.BackColor = System.Drawing.Color.Transparent;
            this.txtDuracion.BaseColor = System.Drawing.Color.White;
            this.txtDuracion.BorderColor = System.Drawing.Color.White;
            this.txtDuracion.BorderSize = 0;
            this.txtDuracion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDuracion.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtDuracion.FocusedBorderColor = System.Drawing.Color.White;
            this.txtDuracion.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.txtDuracion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuracion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.txtDuracion.Location = new System.Drawing.Point(379, 237);
            this.txtDuracion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDuracion.MaxLength = 3;
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.PasswordChar = '\0';
            this.txtDuracion.Radius = 10;
            this.txtDuracion.Size = new System.Drawing.Size(218, 39);
            this.txtDuracion.TabIndex = 160;
            this.txtDuracion.TextOffsetX = 2;
            this.txtDuracion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDuracion_KeyPress);
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.gunaLabel5.CausesValidation = false;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.ForeColor = System.Drawing.Color.White;
            this.gunaLabel5.Location = new System.Drawing.Point(375, 207);
            this.gunaLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(79, 23);
            this.gunaLabel5.TabIndex = 159;
            this.gunaLabel5.Text = "Duración";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.gunaLabel1.CausesValidation = false;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(610, 207);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(72, 23);
            this.gunaLabel1.TabIndex = 154;
            this.gunaLabel1.Text = "Censura";
            // 
            // txtCensura
            // 
            this.txtCensura.BackColor = System.Drawing.Color.Transparent;
            this.txtCensura.BaseColor = System.Drawing.Color.White;
            this.txtCensura.BorderColor = System.Drawing.Color.White;
            this.txtCensura.BorderSize = 0;
            this.txtCensura.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCensura.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtCensura.FocusedBorderColor = System.Drawing.Color.White;
            this.txtCensura.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.txtCensura.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCensura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.txtCensura.Location = new System.Drawing.Point(614, 237);
            this.txtCensura.Margin = new System.Windows.Forms.Padding(4);
            this.txtCensura.MaxLength = 50;
            this.txtCensura.Name = "txtCensura";
            this.txtCensura.PasswordChar = '\0';
            this.txtCensura.Radius = 10;
            this.txtCensura.Size = new System.Drawing.Size(218, 39);
            this.txtCensura.TabIndex = 153;
            this.txtCensura.TextOffsetX = 2;
            this.txtCensura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCensura_KeyPress);
            // 
            // var_titulo
            // 
            this.var_titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.var_titulo.CausesValidation = false;
            this.var_titulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.var_titulo.ForeColor = System.Drawing.Color.White;
            this.var_titulo.Location = new System.Drawing.Point(24, 29);
            this.var_titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.var_titulo.Name = "var_titulo";
            this.var_titulo.Size = new System.Drawing.Size(455, 39);
            this.var_titulo.TabIndex = 150;
            this.var_titulo.Text = "Añada una Película";
            // 
            // var_segundo_titulo
            // 
            this.var_segundo_titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.var_segundo_titulo.CausesValidation = false;
            this.var_segundo_titulo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.var_segundo_titulo.ForeColor = System.Drawing.Color.LightGray;
            this.var_segundo_titulo.Location = new System.Drawing.Point(26, 79);
            this.var_segundo_titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.var_segundo_titulo.Name = "var_segundo_titulo";
            this.var_segundo_titulo.Size = new System.Drawing.Size(453, 31);
            this.var_segundo_titulo.TabIndex = 155;
            this.var_segundo_titulo.Text = "Inserte la película";
            // 
            // var_censura
            // 
            this.var_censura.AutoSize = true;
            this.var_censura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.var_censura.CausesValidation = false;
            this.var_censura.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.var_censura.ForeColor = System.Drawing.Color.White;
            this.var_censura.Location = new System.Drawing.Point(375, 109);
            this.var_censura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.var_censura.Name = "var_censura";
            this.var_censura.Size = new System.Drawing.Size(53, 23);
            this.var_censura.TabIndex = 156;
            this.var_censura.Text = "Título";
            // 
            // txtTituloOriginal
            // 
            this.txtTituloOriginal.BackColor = System.Drawing.Color.Transparent;
            this.txtTituloOriginal.BaseColor = System.Drawing.Color.White;
            this.txtTituloOriginal.BorderColor = System.Drawing.Color.White;
            this.txtTituloOriginal.BorderSize = 0;
            this.txtTituloOriginal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTituloOriginal.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtTituloOriginal.FocusedBorderColor = System.Drawing.Color.White;
            this.txtTituloOriginal.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.txtTituloOriginal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTituloOriginal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.txtTituloOriginal.Location = new System.Drawing.Point(614, 148);
            this.txtTituloOriginal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTituloOriginal.MaxLength = 50;
            this.txtTituloOriginal.Name = "txtTituloOriginal";
            this.txtTituloOriginal.PasswordChar = '\0';
            this.txtTituloOriginal.Radius = 10;
            this.txtTituloOriginal.Size = new System.Drawing.Size(218, 39);
            this.txtTituloOriginal.TabIndex = 171;
            this.txtTituloOriginal.TextOffsetX = 2;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.gunaLabel2.CausesValidation = false;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.White;
            this.gunaLabel2.Location = new System.Drawing.Point(610, 109);
            this.gunaLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(122, 23);
            this.gunaLabel2.TabIndex = 170;
            this.gunaLabel2.Text = "Título Oiriginal";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.gunaLabel3.CausesValidation = false;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.White;
            this.gunaLabel3.Location = new System.Drawing.Point(385, 560);
            this.gunaLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(45, 23);
            this.gunaLabel3.TabIndex = 173;
            this.gunaLabel3.Text = "URL ";
            // 
            // txtURL
            // 
            this.txtURL.BackColor = System.Drawing.Color.Transparent;
            this.txtURL.BaseColor = System.Drawing.Color.White;
            this.txtURL.BorderColor = System.Drawing.Color.White;
            this.txtURL.BorderSize = 0;
            this.txtURL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtURL.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtURL.FocusedBorderColor = System.Drawing.Color.White;
            this.txtURL.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.txtURL.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtURL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.txtURL.Location = new System.Drawing.Point(384, 591);
            this.txtURL.Margin = new System.Windows.Forms.Padding(4);
            this.txtURL.MaxLength = 255;
            this.txtURL.Name = "txtURL";
            this.txtURL.PasswordChar = '\0';
            this.txtURL.Radius = 10;
            this.txtURL.Size = new System.Drawing.Size(448, 39);
            this.txtURL.TabIndex = 172;
            this.txtURL.TextOffsetX = 2;
            // 
            // txtSinopsis
            // 
            this.txtSinopsis.BackColor = System.Drawing.Color.Transparent;
            this.txtSinopsis.BaseColor = System.Drawing.Color.White;
            this.txtSinopsis.BorderColor = System.Drawing.Color.White;
            this.txtSinopsis.BorderSize = 0;
            this.txtSinopsis.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSinopsis.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtSinopsis.FocusedBorderColor = System.Drawing.Color.White;
            this.txtSinopsis.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.txtSinopsis.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSinopsis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.txtSinopsis.Location = new System.Drawing.Point(384, 323);
            this.txtSinopsis.Margin = new System.Windows.Forms.Padding(4);
            this.txtSinopsis.MaxLength = 255;
            this.txtSinopsis.Name = "txtSinopsis";
            this.txtSinopsis.PasswordChar = '\0';
            this.txtSinopsis.Radius = 10;
            this.txtSinopsis.Size = new System.Drawing.Size(448, 135);
            this.txtSinopsis.TabIndex = 162;
            this.txtSinopsis.TextOffsetX = 2;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.gunaLabel4.CausesValidation = false;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.Color.LightGray;
            this.gunaLabel4.Location = new System.Drawing.Point(26, 426);
            this.gunaLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(295, 31);
            this.gunaLabel4.TabIndex = 175;
            this.gunaLabel4.Text = "Categoría";
            // 
            // tablaCategoria
            // 
            this.tablaCategoria.AllowUserToAddRows = false;
            this.tablaCategoria.AllowUserToDeleteRows = false;
            this.tablaCategoria.AutoGenerateColumns = false;
            this.tablaCategoria.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.tablaCategoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaCategoria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaCategoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.categorianombreDataGridViewTextBoxColumn});
            this.tablaCategoria.DataSource = this.categoriaSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaCategoria.DefaultCellStyle = dataGridViewCellStyle2;
            this.tablaCategoria.EnableHeadersVisualStyles = false;
            this.tablaCategoria.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.tablaCategoria.Location = new System.Drawing.Point(48, 469);
            this.tablaCategoria.Name = "tablaCategoria";
            this.tablaCategoria.ReadOnly = true;
            this.tablaCategoria.RowHeadersWidth = 10;
            this.tablaCategoria.RowTemplate.Height = 24;
            this.tablaCategoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaCategoria.Size = new System.Drawing.Size(261, 212);
            this.tablaCategoria.TabIndex = 178;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // categorianombreDataGridViewTextBoxColumn
            // 
            this.categorianombreDataGridViewTextBoxColumn.DataPropertyName = "categoria_nombre";
            this.categorianombreDataGridViewTextBoxColumn.HeaderText = "Categoría";
            this.categorianombreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.categorianombreDataGridViewTextBoxColumn.Name = "categorianombreDataGridViewTextBoxColumn";
            this.categorianombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.categorianombreDataGridViewTextBoxColumn.Width = 125;
            // 
            // categoriaSource
            // 
            this.categoriaSource.DataSource = typeof(Entity.Entidades.Categoria);
            // 
            // btnEliminarCategoria
            // 
            this.btnEliminarCategoria.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEliminarCategoria.Animated = true;
            this.btnEliminarCategoria.AnimationHoverSpeed = 0.07F;
            this.btnEliminarCategoria.AnimationSpeed = 0.03F;
            this.btnEliminarCategoria.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminarCategoria.BaseColor = System.Drawing.Color.Transparent;
            this.btnEliminarCategoria.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(237)))));
            this.btnEliminarCategoria.BorderSize = 1;
            this.btnEliminarCategoria.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEliminarCategoria.FocusedColor = System.Drawing.Color.Empty;
            this.btnEliminarCategoria.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCategoria.ForeColor = System.Drawing.Color.White;
            this.btnEliminarCategoria.Image = global::AppFlickAdministrador.Properties.Resources.icon_menos;
            this.btnEliminarCategoria.ImageSize = new System.Drawing.Size(20, 20);
            this.btnEliminarCategoria.Location = new System.Drawing.Point(240, 426);
            this.btnEliminarCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarCategoria.Name = "btnEliminarCategoria";
            this.btnEliminarCategoria.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(237)))));
            this.btnEliminarCategoria.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(237)))));
            this.btnEliminarCategoria.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEliminarCategoria.OnHoverImage = null;
            this.btnEliminarCategoria.OnPressedColor = System.Drawing.Color.Black;
            this.btnEliminarCategoria.Radius = 10;
            this.btnEliminarCategoria.Size = new System.Drawing.Size(50, 37);
            this.btnEliminarCategoria.TabIndex = 177;
            this.btnEliminarCategoria.Click += new System.EventHandler(this.btnEliminarCategoria_Click);
            // 
            // btnAnadirCategoria
            // 
            this.btnAnadirCategoria.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAnadirCategoria.Animated = true;
            this.btnAnadirCategoria.AnimationHoverSpeed = 0.07F;
            this.btnAnadirCategoria.AnimationSpeed = 0.03F;
            this.btnAnadirCategoria.BackColor = System.Drawing.Color.Transparent;
            this.btnAnadirCategoria.BaseColor = System.Drawing.Color.Transparent;
            this.btnAnadirCategoria.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(237)))));
            this.btnAnadirCategoria.BorderSize = 1;
            this.btnAnadirCategoria.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAnadirCategoria.FocusedColor = System.Drawing.Color.Empty;
            this.btnAnadirCategoria.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnadirCategoria.ForeColor = System.Drawing.Color.White;
            this.btnAnadirCategoria.Image = global::AppFlickAdministrador.Properties.Resources.icon_mas;
            this.btnAnadirCategoria.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAnadirCategoria.Location = new System.Drawing.Point(175, 426);
            this.btnAnadirCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnadirCategoria.Name = "btnAnadirCategoria";
            this.btnAnadirCategoria.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(237)))));
            this.btnAnadirCategoria.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(237)))));
            this.btnAnadirCategoria.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAnadirCategoria.OnHoverImage = null;
            this.btnAnadirCategoria.OnPressedColor = System.Drawing.Color.Black;
            this.btnAnadirCategoria.Radius = 10;
            this.btnAnadirCategoria.Size = new System.Drawing.Size(50, 37);
            this.btnAnadirCategoria.TabIndex = 176;
            this.btnAnadirCategoria.Click += new System.EventHandler(this.btnAnadirCategoria_Click);
            // 
            // btnCambiarImagen
            // 
            this.btnCambiarImagen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCambiarImagen.AnimationHoverSpeed = 0.07F;
            this.btnCambiarImagen.AnimationSpeed = 0.03F;
            this.btnCambiarImagen.BackColor = System.Drawing.Color.Transparent;
            this.btnCambiarImagen.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(88)))), ((int)(((byte)(169)))));
            this.btnCambiarImagen.BorderColor = System.Drawing.Color.Black;
            this.btnCambiarImagen.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCambiarImagen.FocusedColor = System.Drawing.Color.Empty;
            this.btnCambiarImagen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCambiarImagen.ForeColor = System.Drawing.Color.White;
            this.btnCambiarImagen.Image = global::AppFlickAdministrador.Properties.Resources.icon_cambiar;
            this.btnCambiarImagen.ImageSize = new System.Drawing.Size(38, 38);
            this.btnCambiarImagen.Location = new System.Drawing.Point(229, 323);
            this.btnCambiarImagen.Margin = new System.Windows.Forms.Padding(4);
            this.btnCambiarImagen.Name = "btnCambiarImagen";
            this.btnCambiarImagen.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(237)))));
            this.btnCambiarImagen.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCambiarImagen.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCambiarImagen.OnHoverImage = null;
            this.btnCambiarImagen.OnPressedColor = System.Drawing.Color.Black;
            this.btnCambiarImagen.Size = new System.Drawing.Size(80, 74);
            this.btnCambiarImagen.TabIndex = 169;
            this.btnCambiarImagen.UseTransfarantBackground = true;
            this.btnCambiarImagen.Click += new System.EventHandler(this.btnCambiarImagen_Click);
            // 
            // var_imagen_pelicula
            // 
            this.var_imagen_pelicula.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.var_imagen_pelicula.BackColor = System.Drawing.Color.Transparent;
            this.var_imagen_pelicula.BaseColor = System.Drawing.Color.Transparent;
            this.var_imagen_pelicula.Image = global::AppFlickAdministrador.Properties.Resources.icon_peliculas;
            this.var_imagen_pelicula.Location = new System.Drawing.Point(31, 124);
            this.var_imagen_pelicula.Margin = new System.Windows.Forms.Padding(4);
            this.var_imagen_pelicula.Name = "var_imagen_pelicula";
            this.var_imagen_pelicula.Size = new System.Drawing.Size(267, 246);
            this.var_imagen_pelicula.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.var_imagen_pelicula.TabIndex = 168;
            this.var_imagen_pelicula.TabStop = false;
            this.var_imagen_pelicula.UseTransfarantBackground = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGuardar.Animated = true;
            this.btnGuardar.AnimationHoverSpeed = 0.07F;
            this.btnGuardar.AnimationSpeed = 0.03F;
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.BaseColor = System.Drawing.Color.Transparent;
            this.btnGuardar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(237)))));
            this.btnGuardar.BorderSize = 1;
            this.btnGuardar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnGuardar.FocusedColor = System.Drawing.Color.Empty;
            this.btnGuardar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Image = global::AppFlickAdministrador.Properties.Resources.icon_mas;
            this.btnGuardar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnGuardar.Location = new System.Drawing.Point(298, 704);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(237)))));
            this.btnGuardar.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(237)))));
            this.btnGuardar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnGuardar.OnHoverImage = null;
            this.btnGuardar.OnPressedColor = System.Drawing.Color.Black;
            this.btnGuardar.Radius = 10;
            this.btnGuardar.Size = new System.Drawing.Size(299, 49);
            this.btnGuardar.TabIndex = 152;
            this.btnGuardar.Text = "Guardar Película";
            this.btnGuardar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCerrar.Image = global::AppFlickAdministrador.Properties.Resources.icon_cerrar;
            this.btnCerrar.ImageSize = new System.Drawing.Size(32, 32);
            this.btnCerrar.Location = new System.Drawing.Point(769, 29);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.OnHoverImage = null;
            this.btnCerrar.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btnCerrar.Size = new System.Drawing.Size(43, 39);
            this.btnCerrar.TabIndex = 151;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // Form_Pelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(863, 766);
            this.Controls.Add(this.tablaCategoria);
            this.Controls.Add(this.btnEliminarCategoria);
            this.Controls.Add(this.btnAnadirCategoria);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.txtTituloOriginal);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.btnCambiarImagen);
            this.Controls.Add(this.var_imagen_pelicula);
            this.Controls.Add(this.gunaLabel8);
            this.Controls.Add(this.txtReparto);
            this.Controls.Add(this.gunaLabel7);
            this.Controls.Add(this.txtDirector);
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.txtSinopsis);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.txtDuracion);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.txtCensura);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.var_titulo);
            this.Controls.Add(this.var_segundo_titulo);
            this.Controls.Add(this.var_censura);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Pelicula";
            this.Text = "Form_Pelicula";
            ((System.ComponentModel.ISupportInitialize)(this.tablaCategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.var_imagen_pelicula)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI.WinForms.GunaTextBox txtReparto;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaTextBox txtDirector;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaTextBox txtTitulo;
        private Guna.UI.WinForms.GunaTextBox txtDuracion;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaTextBox txtCensura;
        private Guna.UI.WinForms.GunaButton btnGuardar;
        private Guna.UI.WinForms.GunaImageButton btnCerrar;
        private Guna.UI.WinForms.GunaLabel var_titulo;
        private Guna.UI.WinForms.GunaLabel var_segundo_titulo;
        private Guna.UI.WinForms.GunaLabel var_censura;
        private Guna.UI.WinForms.GunaCirclePictureBox var_imagen_pelicula;
        private Guna.UI.WinForms.GunaCircleButton btnCambiarImagen;
        private Guna.UI.WinForms.GunaTextBox txtTituloOriginal;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaTextBox txtURL;
        private System.Windows.Forms.OpenFileDialog SelectorArchivo;
        private Guna.UI.WinForms.GunaTextBox txtSinopsis;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaButton btnAnadirCategoria;
        private Guna.UI.WinForms.GunaButton btnEliminarCategoria;
        public System.Windows.Forms.BindingSource categoriaSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categorianombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView tablaCategoria;
    }
}