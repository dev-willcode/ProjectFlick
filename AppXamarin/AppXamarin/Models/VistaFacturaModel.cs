using Entity.Entidades.EntidadesPersonalizadas;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppXamarin.Models
{
    public class VistaFacturaModel : VistaFacturaFuncion
    {
        public VistaFacturaModel(VistaFacturaFuncion factura)
        {
            id = factura.id;
            factura_funcion = factura.factura_funcion;
            factura_cliente = factura.factura_cliente;
            funcion_precio_boleto = factura.funcion_precio_boleto;
            factura_numero = factura.factura_numero;
            pelicula_titulo = factura.pelicula_titulo;
            idioma_abreviatura = factura.idioma_abreviatura;
            funcion_fecha_evento = factura.funcion_fecha_evento;
            horario_inicio = factura.horario_inicio;
            factura_fecha_emision = factura.factura_fecha_emision;
            numero_boletos = factura.numero_boletos;
            valor_total = numero_boletos * funcion_precio_boleto;
        }

        public decimal valor_total { get; set; }
    }
}
