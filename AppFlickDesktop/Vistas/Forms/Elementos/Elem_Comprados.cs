using System.Collections.Generic;
using AppFlickCliente.Vistas.Notificaciones;
using Controllers;
using Entity.Entidades;
using Utils;

namespace AppFlickCliente.Vistas.Forms.Elementos
{
    public partial class Elem_CompraDos : Elem_Compra
    {
        private Notificar Notificar = PropiedadesGenerales.Notificar;
        internal int CantBoletosSeleccionados { get; set; }
        internal int CantBoletosAComprar { get; set; }

        public Elem_CompraDos()
            : base()
        {
            InitializeComponent();
        }

        public Elem_CompraDos(Form_Comprar form)
            : base(form)
        {
            InitializeComponent();
            rellenarAsientos();
        }

        private void rellenarAsientos()
        {
            int letra;
            string nombre;
            try
            {
                List<Boleto> boletosComprados = PropiedadesGenerales.BoletoController.ListarBoletosFuncion(VistaFunciones.id);
                for (int i = 1; i < tablaAsientos.ColumnCount; i++)
                {
                    letra = 74;
                    for (int j = 0; j < tablaAsientos.RowCount - 1; j++)
                    {
                        nombre = (char)letra-- + i.ToString();
                        if (boletosComprados.FindIndex(e => (e.boleto_asiento.Trim().Equals(nombre))) == -1)
                        {
                            tablaAsientos.Controls.Add(new Elem_asiento(this, nombre, true), i, j);
                        }
                        else
                        {
                            tablaAsientos.Controls.Add(new Elem_asiento(this, nombre, false), i, j);
                        }
                    }
                }
            }
            catch (ControllerException ex)
            {
                PropiedadesGenerales.Notificar.notificarError(ex);
            }
        }

        private void btnContinuar_Click(object sender, System.EventArgs e)
        {
            if (CantBoletosSeleccionados == CantBoletosAComprar)
            {
                Confirmado = true;
                FormPadre.AsientosSeleccionados = var_infoAsientos.Text;
                FormPadre.elem_CompraTres.ActualizarInformacionCompra();
                FormPadre.CambiarATres(sender, e);
            }
            else
            {
                Notificar.notificarFallo("Error al validar sus asientos",
                    "Verifique que ha seleccionado todos sus asientos disponibles");
            }
        }

        internal void ActualizarNumeroAsientos()
        {
            CantBoletosAComprar = FormPadre.CantBoletosAComprar;
            var_asientos.Text = CantBoletosSeleccionados + "/" + CantBoletosAComprar;
            ActualizarInformacionSeleccionados();
        }

        internal void disminuirSeleccionados()
        {
            CantBoletosSeleccionados -= 1;
            ActualizarNumeroAsientos();
        }
        internal void aumentarSeleccionados()
        {
            CantBoletosSeleccionados += 1;
            ActualizarNumeroAsientos();
        }

        internal void ActualizarInformacionSeleccionados()
        {
            string result = "";
            Elem_asiento asiento;
            if (CantBoletosSeleccionados != 0)
            {
                for (int i = 1; i < tablaAsientos.ColumnCount; i++)
                {
                    for (int j = 0; j < tablaAsientos.RowCount - 1; j++)
                    {
                        asiento = tablaAsientos.GetControlFromPosition(i, j) as Elem_asiento;
                        if (asiento.Seleccionado)
                        {
                            result += asiento.Nombre + ", ";
                        }
                    }
                }
                var_infoAsientos.Text = result.Substring(0, result.Length - 2);
            }
        }
    }
}
