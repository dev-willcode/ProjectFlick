using System.Windows.Forms;
using Entity.Entidades.EntidadesPersonalizadas;

namespace AppFlickCliente.Vistas.Forms.Elementos
{
    public class Elem_Compra : UserControl
    {
        public Elem_Compra()
        {
        }
        public Elem_Compra(Form_Comprar form)
        {
            FormPadre = form;
            VistaFunciones = form.funcion;
        }

        internal bool Confirmado { get; set; }
        internal VistaFunciones VistaFunciones { get; set; }
        internal Form_Comprar FormPadre { get; set; }
    }
}
