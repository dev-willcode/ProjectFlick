using System;
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
            try
            {
                CFuncionesController = new CustomFuncionesController(new FuncionesController().Get(Factura.factura_funcion));
                ListaBoletos = new BoletoController().listarBoletos(Factura.factura_cliente);
            }
            catch (Exception ex)
            {
                throw new ControllerException("No se consiguió listar los Boletos", ex);
            }
        }

        public Factura Factura { get; set; }
        public CustomFuncionesController CFuncionesController { get; set; }
        public List<Boleto> ListaBoletos { get; set; }

    }
}
