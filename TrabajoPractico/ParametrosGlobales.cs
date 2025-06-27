using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico
{
    public static class ParametrosGlobales
    {
        // Para la ecuación de Runge-Kutta
        public static double A { get; set; }
        public static double B { get; set; }
        public static double H { get; set; }

        // Para la distribución uniforme del nivel de concentración
        public static double ConcentracionDesde { get; set; }
        public static double ConcentracionHasta { get; set; }
        public static double MaxNivelConcentracion { get; set; } = 0;
    }
}

