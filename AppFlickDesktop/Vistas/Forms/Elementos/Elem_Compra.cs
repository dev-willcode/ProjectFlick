using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppFlickDesktop.Vistas.Forms.Elementos
{
    public class Elem_Compra: UserControl
    {
        internal bool Confirmado { get; set; }
        internal Form_Comprar FormPadre { get; set; }
    }
}
