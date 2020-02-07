using System.Collections.Generic;
using Entity.Entidades;

namespace Controllers.Controller
{
    /* 
     * Clase personalizada que agrupa las carácteristicas principales de una Función,
     * Permite agrupar en propiedades, para un mejor acceso a los datos.
     */
    public class CustomFacturaController
    {
        /* 
         * Crea la clase personalizada e inicializa las propiedades de la Factura, 
         * en base a la Funcion de la factura entregada.
         */
        public CustomFacturaController(Factura factura)
        {
            Factura = factura;
            inicializarPropiedades();
        }
        private void inicializarPropiedades()
        {
            CFuncionesController = new CustomFuncionesController(new FuncionesController().Get(Factura.factura_funcion));
            ListaBoletos = new BoletoController().listarBoletos(Factura.factura_cliente);
        }

        public Factura Factura { get; set; }
        public CustomFuncionesController CFuncionesController { get; set; }
        public List<Boleto> ListaBoletos { get; set; }

    }
}
