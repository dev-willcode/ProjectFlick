using System;
using System.Windows.Forms;
using AppFlickCliente.Vistas.Notificaciones;
using Controllers.Controller;
using Guna.UI.WinForms;
using Utils;

namespace AppFlickCliente.Vistas.Forms.Elementos
{

    public partial class Form_Comprar : Form
    {
        private Notificar notificar = PropiedadesGenerales.Notificar;

        internal double PrecioTotal { get; set; }
        internal int CantBoletosAComprar { get; set; }
        internal string AsientosSeleccionados { get; set; }
        internal Elem_CompraUno elem_CompraUno { get; set; }
        internal Elem_CompraDos elem_CompraDos { get; set; }
        internal Elem_CompraTres elem_CompraTres { get; set; }
        public CustomFuncionesController CFuncionesController { get; set; }

        public Form_Comprar(CustomFuncionesController cFuncionesController)
        {
            CFuncionesController = cFuncionesController;
            InitializeComponent();
            InicializarPaneles();
        }

        private void InicializarPaneles()
        {
            elem_CompraTres = new Elem_CompraTres(this);
            elem_CompraDos = new Elem_CompraDos(this);
            elem_CompraUno = new Elem_CompraUno(this);

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

