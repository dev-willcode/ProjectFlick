using System.Windows.Forms;
using AppFlickAdministrador.Vistas.Init;

namespace AppFlickAdministrador.Vistas.Forms
{
    public class Vistas : UserControl
    {
        public Vistas () { }
        public Vistas(Dashboard dashboard)
        {
            Dashboard = dashboard;
        }

        internal Dashboard Dashboard { get; set; }
    }
}
