using System.Windows.Forms;
using Controllers.Controller;

namespace AppFlickDesktop.Vistas.Forms.Elementos
{
    public class Elem_Compra : UserControl
    {
        public Elem_Compra()
        {
        }
        public Elem_Compra(Form_Comprar form)
        {
            FormPadre = form;
            CFuncionesController = form.CFuncionesController;
        }

        internal bool Confirmado { get; set; }
        internal CustomFuncionesController CFuncionesController { get; set; }
        internal Form_Comprar FormPadre { get; set; }
    }
}
