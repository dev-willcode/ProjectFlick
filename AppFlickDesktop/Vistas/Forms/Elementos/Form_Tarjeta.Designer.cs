namespace AppFlickDesktop.Vistas.Forms.Elementos
{
    partial class Form_Tarjeta
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
            this.var_titulo = new Guna.UI.WinForms.GunaLabel();
            this.var_segundo_titulo = new Guna.UI.WinForms.GunaLabel();
            this.var_censura = new Guna.UI.WinForms.GunaLabel();
            this.btnGuardar = new Guna.UI.WinForms.GunaButton();
            this.btnCerrar = new Guna.UI.WinForms.GunaImageButton();
            this.txtNumeroTarjeta = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.comboBancos = new Guna.UI.WinForms.GunaComboBox();
            this.comboAnio = new Guna.UI.WinForms.GunaComboBox();
            this.comboMes = new Guna.UI.WinForms.GunaComboBox();
            this.txtPropietario = new Guna.UI.WinForms.GunaTextBox();
            this.txtCCV = new Guna.UI.WinForms.GunaTextBox();
            this.comboTipo = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(237)))));
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Margin = new System.Windows.Forms.Padding(4);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(899, 18);
            this.panel.TabIndex = 0;
            // 
            // var_titulo
            // 
            this.var_titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.var_titulo.CausesValidation = false;
            this.var_titulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.var_titulo.ForeColor = System.Drawing.Color.White;
            this.var_titulo.Location = new System.Drawing.Point(59, 53);
            this.var_titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.var_titulo.Name = "var_titulo";
            this.var_titulo.Size = new System.Drawing.Size(455, 39);
            this.var_titulo.TabIndex = 0;
            this.var_titulo.Text = "Añada un método de pago";
            // 
            // var_segundo_titulo
            // 
            this.var_segundo_titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.var_segundo_titulo.CausesValidation = false;
            this.var_segundo_titulo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.var_segundo_titulo.ForeColor = System.Drawing.Color.LightGray;
            this.var_segundo_titulo.Location = new System.Drawing.Point(60, 103);
            this.var_segundo_titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.var_segundo_titulo.Name = "var_segundo_titulo";
            this.var_segundo_titulo.Size = new System.Drawing.Size(453, 31);
            this.var_segundo_titulo.TabIndex = 0;
            this.var_segundo_titulo.Text = "Inserte los datos de su tarjeta";
            // 
            // var_censura
            // 
            this.var_censura.AutoSize = true;
            this.var_censura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.var_censura.CausesValidation = false;
            this.var_censura.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.var_censura.ForeColor = System.Drawing.Color.White;
            this.var_censura.Location = new System.Drawing.Point(63, 153);
            this.var_censura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.var_censura.Name = "var_censura";
            this.var_censura.Size = new System.Drawing.Size(147, 23);
            this.var_censura.TabIndex = 0;
            this.var_censura.Text = "Entidad financiera";
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
            this.btnGuardar.Image = global::AppFlickDesktop.Properties.Resources.icon_mas;
            this.btnGuardar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnGuardar.Location = new System.Drawing.Point(297, 418);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(237)))));
            this.btnGuardar.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(237)))));
            this.btnGuardar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnGuardar.OnHoverImage = null;
            this.btnGuardar.OnPressedColor = System.Drawing.Color.Black;
            this.btnGuardar.Radius = 10;
            this.btnGuardar.Size = new System.Drawing.Size(299, 49);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar tarjeta";
            this.btnGuardar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCerrar.Image = global::AppFlickDesktop.Properties.Resources.icon_cerrar;
            this.btnCerrar.ImageSize = new System.Drawing.Size(32, 32);
            this.btnCerrar.Location = new System.Drawing.Point(804, 53);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.OnHoverImage = null;
            this.btnCerrar.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btnCerrar.Size = new System.Drawing.Size(43, 39);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // txtNumeroTarjeta
            // 
            this.txtNumeroTarjeta.BackColor = System.Drawing.Color.Transparent;
            this.txtNumeroTarjeta.BaseColor = System.Drawing.Color.White;
            this.txtNumeroTarjeta.BorderColor = System.Drawing.Color.White;
            this.txtNumeroTarjeta.BorderSize = 0;
            this.txtNumeroTarjeta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumeroTarjeta.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtNumeroTarjeta.FocusedBorderColor = System.Drawing.Color.White;
            this.txtNumeroTarjeta.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.txtNumeroTarjeta.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroTarjeta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.txtNumeroTarjeta.Location = new System.Drawing.Point(67, 352);
            this.txtNumeroTarjeta.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumeroTarjeta.MaxLength = 16;
            this.txtNumeroTarjeta.Name = "txtNumeroTarjeta";
            this.txtNumeroTarjeta.PasswordChar = '\0';
            this.txtNumeroTarjeta.Radius = 10;
            this.txtNumeroTarjeta.Size = new System.Drawing.Size(364, 39);
            this.txtNumeroTarjeta.TabIndex = 0;
            this.txtNumeroTarjeta.TextOffsetX = 2;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.gunaLabel1.CausesValidation = false;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(63, 319);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(169, 23);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Número de la tarjeta";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.gunaLabel2.CausesValidation = false;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.White;
            this.gunaLabel2.Location = new System.Drawing.Point(460, 153);
            this.gunaLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(176, 23);
            this.gunaLabel2.TabIndex = 0;
            this.gunaLabel2.Text = "Fecha de vencimiento";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.gunaLabel3.CausesValidation = false;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.White;
            this.gunaLabel3.Location = new System.Drawing.Point(736, 153);
            this.gunaLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(43, 23);
            this.gunaLabel3.TabIndex = 0;
            this.gunaLabel3.Text = "CCV";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.gunaLabel4.CausesValidation = false;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.Color.White;
            this.gunaLabel4.Location = new System.Drawing.Point(460, 238);
            this.gunaLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(190, 23);
            this.gunaLabel4.TabIndex = 91;
            this.gunaLabel4.Text = "Propietario de la tarjeta";
            // 
            // comboBancos
            // 
            this.comboBancos.BackColor = System.Drawing.Color.Transparent;
            this.comboBancos.BaseColor = System.Drawing.Color.White;
            this.comboBancos.BorderColor = System.Drawing.Color.Silver;
            this.comboBancos.BorderSize = 0;
            this.comboBancos.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBancos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBancos.FocusedColor = System.Drawing.Color.Empty;
            this.comboBancos.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBancos.ForeColor = System.Drawing.Color.Black;
            this.comboBancos.FormattingEnabled = true;
            this.comboBancos.Items.AddRange(new object[] {
            "pichincha",
            "machala",
            "ue"});
            this.comboBancos.Location = new System.Drawing.Point(67, 188);
            this.comboBancos.Margin = new System.Windows.Forms.Padding(4);
            this.comboBancos.Name = "comboBancos";
            this.comboBancos.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(237)))));
            this.comboBancos.OnHoverItemForeColor = System.Drawing.Color.White;
            this.comboBancos.Radius = 10;
            this.comboBancos.Size = new System.Drawing.Size(363, 31);
            this.comboBancos.TabIndex = 1;
            // 
            // comboAnio
            // 
            this.comboAnio.BackColor = System.Drawing.Color.Transparent;
            this.comboAnio.BaseColor = System.Drawing.Color.White;
            this.comboAnio.BorderColor = System.Drawing.Color.Silver;
            this.comboAnio.BorderSize = 0;
            this.comboAnio.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAnio.FocusedColor = System.Drawing.Color.Empty;
            this.comboAnio.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboAnio.ForeColor = System.Drawing.Color.Black;
            this.comboAnio.FormattingEnabled = true;
            this.comboAnio.Items.AddRange(new object[] {
            "pichincha",
            "machala",
            "ue"});
            this.comboAnio.Location = new System.Drawing.Point(464, 188);
            this.comboAnio.Margin = new System.Windows.Forms.Padding(4);
            this.comboAnio.Name = "comboAnio";
            this.comboAnio.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(237)))));
            this.comboAnio.OnHoverItemForeColor = System.Drawing.Color.White;
            this.comboAnio.Radius = 10;
            this.comboAnio.Size = new System.Drawing.Size(115, 31);
            this.comboAnio.TabIndex = 93;
            // 
            // comboMes
            // 
            this.comboMes.BackColor = System.Drawing.Color.Transparent;
            this.comboMes.BaseColor = System.Drawing.Color.White;
            this.comboMes.BorderColor = System.Drawing.Color.Silver;
            this.comboMes.BorderSize = 0;
            this.comboMes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMes.FocusedColor = System.Drawing.Color.Empty;
            this.comboMes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboMes.ForeColor = System.Drawing.Color.Black;
            this.comboMes.FormattingEnabled = true;
            this.comboMes.Items.AddRange(new object[] {
            "pichincha",
            "machala",
            "ue"});
            this.comboMes.Location = new System.Drawing.Point(588, 188);
            this.comboMes.Margin = new System.Windows.Forms.Padding(4);
            this.comboMes.Name = "comboMes";
            this.comboMes.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(237)))));
            this.comboMes.OnHoverItemForeColor = System.Drawing.Color.White;
            this.comboMes.Radius = 10;
            this.comboMes.Size = new System.Drawing.Size(115, 31);
            this.comboMes.TabIndex = 94;
            // 
            // txtPropietario
            // 
            this.txtPropietario.BackColor = System.Drawing.Color.Transparent;
            this.txtPropietario.BaseColor = System.Drawing.Color.White;
            this.txtPropietario.BorderColor = System.Drawing.Color.White;
            this.txtPropietario.BorderSize = 0;
            this.txtPropietario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPropietario.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtPropietario.FocusedBorderColor = System.Drawing.Color.White;
            this.txtPropietario.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.txtPropietario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPropietario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.txtPropietario.Location = new System.Drawing.Point(464, 271);
            this.txtPropietario.Margin = new System.Windows.Forms.Padding(4);
            this.txtPropietario.MaxLength = 100;
            this.txtPropietario.Name = "txtPropietario";
            this.txtPropietario.PasswordChar = '\0';
            this.txtPropietario.Radius = 10;
            this.txtPropietario.Size = new System.Drawing.Size(383, 39);
            this.txtPropietario.TabIndex = 96;
            this.txtPropietario.TextOffsetX = 2;
            // 
            // txtCCV
            // 
            this.txtCCV.BackColor = System.Drawing.Color.Transparent;
            this.txtCCV.BaseColor = System.Drawing.Color.White;
            this.txtCCV.BorderColor = System.Drawing.Color.White;
            this.txtCCV.BorderSize = 0;
            this.txtCCV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCCV.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtCCV.FocusedBorderColor = System.Drawing.Color.White;
            this.txtCCV.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.txtCCV.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCCV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.txtCCV.Location = new System.Drawing.Point(731, 186);
            this.txtCCV.Margin = new System.Windows.Forms.Padding(4);
            this.txtCCV.MaxLength = 3;
            this.txtCCV.Name = "txtCCV";
            this.txtCCV.PasswordChar = '\0';
            this.txtCCV.Radius = 10;
            this.txtCCV.Size = new System.Drawing.Size(116, 39);
            this.txtCCV.TabIndex = 97;
            this.txtCCV.TextOffsetX = 2;
            // 
            // comboTipo
            // 
            this.comboTipo.BackColor = System.Drawing.Color.Transparent;
            this.comboTipo.BaseColor = System.Drawing.Color.White;
            this.comboTipo.BorderColor = System.Drawing.Color.Silver;
            this.comboTipo.BorderSize = 0;
            this.comboTipo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTipo.FocusedColor = System.Drawing.Color.Empty;
            this.comboTipo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboTipo.ForeColor = System.Drawing.Color.Black;
            this.comboTipo.FormattingEnabled = true;
            this.comboTipo.Items.AddRange(new object[] {
            "DEBITO",
            "CRÉDITO"});
            this.comboTipo.Location = new System.Drawing.Point(67, 273);
            this.comboTipo.Margin = new System.Windows.Forms.Padding(4);
            this.comboTipo.Name = "comboTipo";
            this.comboTipo.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(109)))), ((int)(((byte)(237)))));
            this.comboTipo.OnHoverItemForeColor = System.Drawing.Color.White;
            this.comboTipo.Radius = 10;
            this.comboTipo.Size = new System.Drawing.Size(363, 31);
            this.comboTipo.StartIndex = 0;
            this.comboTipo.TabIndex = 99;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.gunaLabel5.CausesValidation = false;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.ForeColor = System.Drawing.Color.White;
            this.gunaLabel5.Location = new System.Drawing.Point(63, 238);
            this.gunaLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(121, 23);
            this.gunaLabel5.TabIndex = 98;
            this.gunaLabel5.Text = "Tipo de tarjeta";
            // 
            // Form_Tarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(899, 492);
            this.Controls.Add(this.comboTipo);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.txtCCV);
            this.Controls.Add(this.txtPropietario);
            this.Controls.Add(this.comboMes);
            this.Controls.Add(this.comboAnio);
            this.Controls.Add(this.comboBancos);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.txtNumeroTarjeta);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.var_titulo);
            this.Controls.Add(this.var_segundo_titulo);
            this.Controls.Add(this.var_censura);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Tarjeta";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Tarjeta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaButton btnGuardar;
        private System.Windows.Forms.Panel panel;
        private Guna.UI.WinForms.GunaImageButton btnCerrar;
        private Guna.UI.WinForms.GunaLabel var_titulo;
        private Guna.UI.WinForms.GunaLabel var_segundo_titulo;
        private Guna.UI.WinForms.GunaLabel var_censura;
        private Guna.UI.WinForms.GunaTextBox txtNumeroTarjeta;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaComboBox comboBancos;
        private Guna.UI.WinForms.GunaComboBox comboAnio;
        private Guna.UI.WinForms.GunaComboBox comboMes;
        private Guna.UI.WinForms.GunaTextBox txtPropietario;
        private Guna.UI.WinForms.GunaTextBox txtCCV;
        private Guna.UI.WinForms.GunaComboBox comboTipo;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
    }
}