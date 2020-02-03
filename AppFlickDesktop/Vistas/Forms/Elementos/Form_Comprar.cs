using System;
using System.Windows.Forms;
using AppFlickDesktop.Vistas.Init;
using AppFlickDesktop.Vistas.Notificaciones;
using Controllers.Controller;
using Entity.Entidades;
using Guna.UI.WinForms;
using Utils;

namespace AppFlickDesktop.Vistas.Forms.Elementos
{

    public partial class Form_Comprar : Form
    {
        internal FuncionesController FuncionesController = PropiedadesGenerales.FuncionesController;
        private Notificar notificar = PropiedadesGenerales.Notificar;

        internal Funcion Funcion { get; set; }
        internal Sala_Cine Sala_Cine { get; set; }
        internal Horarios Horarios { get; set; }
        internal Pelicula Pelicula { get; set; }
        internal Idioma Idioma { get; set; }
        internal Elem_CompraUno elem_CompraUno { get; set; }
        internal Elem_CompraDos elem_CompraDos { get; set; }
        internal Elem_CompraTres elem_CompraTres { get; set; }
        

        public Form_Comprar(Elem_funcion elem_funcion)
        {
            Funcion = elem_funcion.Funcion;
            Pelicula = elem_funcion.Pelicula;
            Idioma = elem_funcion.Idioma;
            InitializeComponent();
            InicializarPaneles();
        }

        private void InicializarPaneles()
        {
            elem_CompraUno = new Elem_CompraUno(this);
            elem_CompraDos = new Elem_CompraDos(this);
            elem_CompraTres = new Elem_CompraTres(this);

            contenedor.Controls.Add(elem_CompraUno);
            elem_CompraUno.Dock = DockStyle.Fill;
        }

        private void CambiarAPanel(UserControl elem)
        {
            if (!contenedor.Controls[0].Equals(elem))
            {
                contenedor.Controls.Clear();
                contenedor.Controls.Add(elem);
                elem.Dock = DockStyle.Fill;
            }

            if (contenedor.Controls[0].Equals(elem_CompraUno))
            {
                PintarBoton(btnCompraUno);
            }
            else if (contenedor.Controls[0].Equals(elem_CompraDos))
            {
                PintarBoton(btnCompraDos);
            }
            else
            {
                PintarBoton(btnCompraTres);
            }
        }

        internal void CambiarAUno(object sender, EventArgs e)
        {
            if (slide1.Expandido)
            {
                slide1.Contraer();
            }
            CambiarAPanel(elem_CompraUno);
        }

        private void PintarBoton(GunaCircleButton btn)
        {
            btn.BaseColor = System.Drawing.Color.FromArgb(12, 109, 237);
        }

        internal void CambiarADos(object sender, EventArgs e)
        {
            if (slide2.Expandido)
            {
                slide2.Contraer();
                CambiarAPanel(elem_CompraDos);
            }
            else if (elem_CompraUno.Confirmado)
            {
                slide1.Expandir();
                CambiarAPanel(elem_CompraDos);
            }
            else
            {
                notificar.notificarFallo("Advertencia",
                "Verifique que ha completado el primer paso");
            }
        }

        internal void CambiarATres(object sender, EventArgs e)
        {

            if (elem_CompraDos.Confirmado)
            {
                slide2.Expandir();
                CambiarAPanel(elem_CompraTres);
            }
            else
            {
                notificar.notificarFallo("Advertencia",
                "Verifique que ha completado el primer y segundo paso");
            }
        }
    }
}

