using System;
using System.Drawing;
using System.Windows.Forms;
using AppFlickDesktop.Vistas.Notificaciones;
using Utils;

namespace AppFlickDesktop.Vistas.Forms.Elementos
{
    internal class Elem_asiento : PictureBox
    {
        private Notificar Notificar = PropiedadesGenerales.Notificar;
        private Elem_CompraDos Elem_CompraDos { get; set; }
        internal bool Seleccionado { get; set; }
        internal bool Disponible { get; set; }
        internal string Nombre { get; set; }

        public Elem_asiento(Elem_CompraDos formularioPadre, string nombre, bool disponible)
        {
            Nombre = nombre;
            Disponible = disponible;
            Elem_CompraDos = formularioPadre;
            asignarPropiedades();
            asignarEventos();
        }

        private void asignarPropiedades()
        {
            if (Disponible)
            {
                BackgroundImage = Properties.Resources.asiento_cine;
            }
            else
            {
                BackgroundImage = Properties.Resources.asiento_cine_ocupado_;
            }

            BackgroundImageLayout = ImageLayout.Zoom;
            Dock = DockStyle.Fill;
            Margin = new Padding(0);
            Size = new Size(33, 29);
            TabStop = false;
        }

        private void asignarEventos()
        {
            if (Disponible)
            {
                Click += new EventHandler(ClickAsiento);
            }
        }

        private void ClickAsiento(object sender, EventArgs e)
        {
            if (Disponible)
            {
                if (Seleccionado)
                {
                    Seleccionado = false;
                    Elem_CompraDos.disminuirSeleccionados();
                    BackgroundImage = Properties.Resources.asiento_cine;

                }
                else
                {
                    if (Elem_CompraDos.CantBoletosSeleccionados < Elem_CompraDos.CantBoletosAComprar)
                    {
                        Seleccionado = true;
                        Elem_CompraDos.aumentarSeleccionados();
                        BackgroundImage = Properties.Resources.asiento_cine_seleccionado_;

                    }
                    else
                    {
                        Notificar.notificarFallo("Error al seleccionar el asiento",
                            "Ya ha alcanzado el numero máximo de asientos, regrese y añada más boletos a su compra");
                    }
                }
            }
        }
    }
}
