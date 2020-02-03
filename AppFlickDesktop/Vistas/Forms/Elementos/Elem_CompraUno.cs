using System;

namespace AppFlickDesktop.Vistas.Forms.Elementos
{
    public partial class Elem_CompraUno : Elem_Compra
    {

        public Elem_CompraUno(Form_Comprar form)
        {
            InitializeComponent();
            FormPadre = form;
            mostrarDatos();
        }

        private void mostrarDatos()
        {
            var_titulo.Text = FormPadre.Pelicula.pelicula_titulo;
            //var_sala.Text = "N° Sala: " + FormPadre.Sala_Cine.sala_nombre;
            var_fecha.Text = "Fecha: " + FormPadre.Funcion.funcion_fecha_evento.ToShortDateString();
            //var_hora.Text = "Hora: " + FormPadre.Horarios.horario_inicio.ToShortDateString();
            var_duracion.Text = "Duración: " + FormPadre.Pelicula.pelicula_duracion;
            var_censura.Text = "Censura: " + FormPadre.Pelicula.pelicula_tipo_censura;
            var_precio.Text = " x $ " + FormPadre.Funcion.funcion_precio_boleto.ToString();
            var_total.Text = " $ " + FormPadre.Funcion.funcion_precio_boleto.ToString();
            containerIdioma.Controls.Add(new Elem_idioma_funcion(FormPadre.Idioma));
        }

        private void btnContinuar_Click(object sender, System.EventArgs e)
        {
            Confirmado = true;
            FormPadre.CambiarADos(sender, e);
        }

        private void var_cant_boletos_ValueChanged(object sender, EventArgs e)
        {
            var_total.Text = " $ "+ (FormPadre.Funcion.funcion_precio_boleto * var_cant_boletos.Value);
        }
    }
}
