using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico
{
    internal class TablaProbabilidadesTipoVehiculo
    {
        String nombreVehiculo;
        double probabilidad;
        double probabilidadAcumulada;
        double precio;

        public string NombreVehiculo { get => nombreVehiculo; set => nombreVehiculo = value; }
        public double Probabilidad { get => probabilidad; set => probabilidad = value; }
        public double ProbabilidadAcumulada { get => probabilidadAcumulada; set => probabilidadAcumulada = value; }
        public double Precio { get => precio; set => precio = value; }
    }
}
