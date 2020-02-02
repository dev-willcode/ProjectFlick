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
            this.label_MetodoPago = new Guna.UI.WinForms.GunaLabel();
            this.label_InsertDatos = new Guna.UI.WinForms.GunaLabel();
            this.var_censura = new Guna.UI.WinForms.GunaLabel();
            this.btnGuardar = new Guna.UI.WinForms.GunaButton();
            this.btnCerrar = new Guna.UI.WinForms.GunaImageButton();
            this.txtNumeroTarjeta = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.comboBancos = new Guna.UI.WinForms.GunaComboBox();
            this.comboAno = new Guna.UI.WinForms.GunaComboBox();
            this.comboMes = new Guna.UI.WinForms.GunaComboBox();
            this.txtPropietario = new Guna.UI.WinForms.GunaTextBox();
            this.txtCCV = new Guna.UI.WinForms.GunaTextBox();
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
            // label_MetodoPago
            // 
            this.label_MetodoPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label_MetodoPago.CausesValidation = false;
            this.label_MetodoPago.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MetodoPago.ForeColor = System.Drawing.Color.White;
            this.label_MetodoPago.Location = new System.Drawing.Point(59, 53);
            this.label_MetodoPago.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_MetodoPago.Name = "label_MetodoPago";
            this.label_MetodoPago.Size = new System.Drawing.Size(455, 39);
            this.label_MetodoPago.TabIndex = 0;
            this.label_MetodoPago.Text = "Añada un método de pago";
            // 
            // label_InsertDatos
            // 
            this.label_InsertDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label_InsertDatos.CausesValidation = false;
            this.label_InsertDatos.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_InsertDatos.ForeColor = System.Drawing.Color.LightGray;
            this.label_InsertDatos.Location = new System.Drawing.Point(60, 103);
            this.label_InsertDatos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_InsertDatos.Name = "label_InsertDatos";
            this.label_InsertDatos.Size = new System.Drawing.Size(453, 31);
            this.label_InsertDatos.TabIndex = 0;
            this.label_InsertDatos.Text = "Inserte los datos de su tarjeta";
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
            this.btnGuardar.Location = new System.Drawing.Point(296, 338);
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
            this.txtNumeroTarjeta.Location = new System.Drawing.Point(67, 271);
            this.txtNumeroTarjeta.Margin = new System.Windows.Forms.Padding(4);
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
            this.gunaLabel1.Location = new System.Drawing.Point(63, 238);
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
            // comboAno
            // 
            this.comboAno.BackColor = System.Drawing.Color.Transparent;
            this.comboAno.BaseColor = System.Drawing.Color.White;
            this.comboAno.BorderColor = System.Drawing.Color.Silver;
            this.comboAno.BorderSize = 0;
            this.comboAno.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboAno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAno.FocusedColor = System.Drawing.Color.Empty;
            this.comboAno.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboAno.ForeColor = System.Drawing.Color.Black;
            this.comboAno.FormattingEnabled = true;
            this.comboAno.Items.AddRange(new object[] {
            "pichincha",
            "machala",
            "ue"});
            this.comboAno.Location = new System.Drawing.Point(464, 188);
            this.comboAno.Margin = new System.Windows.Forms.Padding(4);
            this.comboAno.Name = "comboAno";
            this.comboAno.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.comboAno.OnHoverItemForeColor = System.Drawing.Color.White;
            this.comboAno.Radius = 10;
            this.comboAno.Size = new System.Drawing.Size(115, 31);
            this.comboAno.TabIndex = 93;
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
            this.comboMes.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
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
            this.txtCCV.Name = "txtCCV";
            this.txtCCV.PasswordChar = '\0';
            this.txtCCV.Radius = 10;
            this.txtCCV.Size = new System.Drawing.Size(116, 39);
            this.txtCCV.TabIndex = 97;
            this.txtCCV.TextOffsetX = 2;
            // 
            // Form_Tarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(899, 418);
            this.Controls.Add(this.txtCCV);
            this.Controls.Add(this.txtPropietario);
            this.Controls.Add(this.comboMes);
            this.Controls.Add(this.comboAno);
            this.Controls.Add(this.comboBancos);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.txtNumeroTarjeta);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.label_MetodoPago);
            this.Controls.Add(this.label_InsertDatos);
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
        private Guna.UI.WinForms.GunaLabel label_MetodoPago;
        private Guna.UI.WinForms.GunaLabel label_InsertDatos;
        private Guna.UI.WinForms.GunaLabel var_censura;
        private Guna.UI.WinForms.GunaTextBox txtNumeroTarjeta;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaComboBox comboBancos;
        private Guna.UI.WinForms.GunaComboBox comboAno;
        private Guna.UI.WinForms.GunaComboBox comboMes;
        private Guna.UI.WinForms.GunaTextBox txtPropietario;
        private Guna.UI.WinForms.GunaTextBox txtCCV;
    }
}