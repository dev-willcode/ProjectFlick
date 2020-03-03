using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrystalDecisions.CrystalReports.Engine;

namespace Controllers.Reportes
{
    public class ReporteController
    {
        public byte[] byteReporte { get; set; }
        public ReportDocument reporte { get; set; }

        public ReporteController()
        {
        }

        /*
         * Método que genera el reporte de una factura, a partir de la id especificada
         * genera un el reporte, que es usado para representar el archivo
         */
        public bool generarReporte(int idFactura)
        {
            return false;
        }
        
    }
}
