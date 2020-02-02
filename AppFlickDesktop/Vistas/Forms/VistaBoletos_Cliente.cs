using System.Collections.Generic;
using System.Windows.Forms;
using Controllers.Controller;
using Entity.Entidades;
using Guna.UI.Lib.ScrollBar;

namespace AppFlickDesktop.Vistas.Forms
{
    public partial class VistaBoletos_Cliente : UserControl
    {
       
        PanelScrollHelper scroll;
        private BoletoController boletoController = Utils.PropiedadesGenerales.BoletoController;
        private Cliente cliente;

        public VistaBoletos_Cliente(Cliente cliente)
        {
            InitializeComponent();         
            propiedadesScroll();
            this.cliente = cliente;
            rellenarBoletos();
        }
        private void propiedadesScroll()
        {
            scroll = new PanelScrollHelper(tablaBoletos, scrollBar, true);
            scroll.UpdateScrollBar();
        }
        private void rellenarBoletos()
        {
            List<Boleto> listaBoleto = boletoController.listarBoletos(cliente.id);
            for (int i = 0; i < listaBoleto.Count; i++)
            {
                Elem_boleto elemento = new Elem_boleto();
                tablaBoletos.Controls.Add(elemento);
                elemento.Dock = DockStyle.Fill;
            }
        }
    }
}
