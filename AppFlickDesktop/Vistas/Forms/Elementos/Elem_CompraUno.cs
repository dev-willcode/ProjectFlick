using System;

namespace AppFlickCliente.Vistas.Forms.Elementos
{
    public partial class Elem_CompraUno : Elem_Compra
    {
        public Elem_CompraUno()
            : base()
        {
            InitializeComponent();
        }
        public Elem_CompraUno(Form_Comprar form)
            : base(form)
        {
            InitializeComponent();
            mostrarDatos();
        }

        private void mostrarDatos()
        {
            var_titulo.Text = VistaFunciones.pelicula_titulo;
            var_sala.Text = "N° Sala: " + VistaFunciones.sala_nombre;
            var_fecha.Text = "Fecha: " + VistaFunciones.funcion_fecha_evento.ToShortDateString();
            var_hora.Text = "Hora: " + VistaFunciones.horario_inicio.ToString();
            var_duracion.Text = "Duración: " + VistaFunciones.pelicula_duracion;
            var_censura.Text = "Censura: " + VistaFunciones.pelicula_tipo_censura;
            var_precio.Text = " x $ " + VistaFunciones.funcion_precio_boleto.ToString();
            var_total.Text = " $ " + VistaFunciones.funcion_precio_boleto.ToString();
            containerIdioma.Controls.Add(new Elem_idioma_funcion(VistaFunciones.idioma_abreviatura));
            var_cant_boletos.Value = 1;
            if (VistaFunciones.pelicula_imagen != null)
            {
                var_imagen_pelicula.Image = Utils.UtilsProcedimientos.generarImagen(VistaFunciones.pelicula_imagen);
            }
        }

        private void btnContinuar_Click(object sender, System.EventArgs e)
        {
            Confirmado = true;
            FormPadre.PrecioTotal = double.Parse(var_total.Text.Substring(1));
            FormPadre.elem_CompraDos.ActualizarNumeroAsientos();
            FormPadre.CambiarADos(sender, e);
        }

        private void var_cant_boletos_ValueChanged(object sender, EventArgs e)
        {
            var_total.Text = "$" + (VistaFunciones.funcion_precio_boleto * var_cant_boletos.Value);
            FormPadre.CantBoletosAComprar = (int)var_cant_boletos.Value;
        }
    }
}
