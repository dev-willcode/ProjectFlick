using System;
using System.Windows.Forms;
using Controllers.Controller;
using Entity.Entidades;

namespace AppFlickDesktop.Vistas.Forms
{
    public partial class Elem_Factura : UserControl
    {
        internal CustomFacturaController CFacturaController { get; set; }
        public Elem_Factura() { }
        public Elem_Factura(Factura factura)
        {
            CFacturaController = new CustomFacturaController(factura);
            InitializeComponent();
            rellenarDatos();
        }

        private void rellenarDatos()
        {
            var_numero_factura.Text = CFacturaController.Factura.factura_numero;
            var_titulo.Text = CFacturaController.CFuncionesController.Pelicula.pelicula_titulo;
            var_fecha.Text = CFacturaController.Factura.factura_fecha_emision.ToShortDateString();
            var_hora.Text = CFacturaController.CFuncionesController.Horarios.horario_inicio.ToString();
            var_cant_boletos.Text = CFacturaController.ListaBoletos.Count.ToString();
            containerIdioma.Controls.Add(new Elem_idioma_funcion(CFacturaController.CFuncionesController.Idioma));
        }
    }
}
