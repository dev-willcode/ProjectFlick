using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AppFlickDesktop.Vistas.Init;
using FlickLib.DAO.Vistas;
using FlickLib.Entidades.Vistas;
using Guna.UI.Lib.ScrollBar;

namespace AppFlickDesktop.Vistas.Forms.Cliente
{
    public partial class VistaFunciones_Cliente : UserControl
    {
        PanelScrollHelper scroll;
        private FuncionesActivasDAO daoFunciones = new FuncionesActivasDAO();
        public VistaFunciones_Cliente()
        {
            InitializeComponent();
            rellenarFunciones();
            propiedadesScroll();
        }
        private void propiedadesScroll()
        {
            scroll = new PanelScrollHelper(panelFunciones, scrollBar, true);
            scroll.UpdateScrollBar();
        }

        private void rellenarFunciones()
        {
            List<FuncionesActivas> listaFuncionesActivas = daoFunciones.GetAll();
            for (int i = 0; i < listaFuncionesActivas.Count; i++)
            {
                Elem_funcion elemento = new Elem_funcion(listaFuncionesActivas[i]);
                panelFunciones.Controls.Add(elemento);
                elemento.Dock = DockStyle.Top;
            }
        }
    }
}
