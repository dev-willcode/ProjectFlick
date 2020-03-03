using System.Windows.Forms;
using AppFlickCliente.Vistas.Init;

namespace AppFlickCliente.Vistas.Forms
{
    public class Vistas : UserControl
    {
        public Vistas():base() { }
        public Vistas(Dashboard dashboard)
        {
            Dashboard = dashboard;
        }

        internal Dashboard Dashboard { get; set; }
    }
}
