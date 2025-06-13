using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico
{
    internal class TablaProbabilidadesTiempoCarga
    {

        double probabilidad;
        double probabilidadAcumulada;
        double tiempoCarga;
        public double Probabilidad { get => probabilidad; set => probabilidad = value; }
        public double ProbabilidadAcumulada { get => probabilidadAcumulada; set => probabilidadAcumulada = value; }
        public double TiempoCarga { get => tiempoCarga; set => tiempoCarga = value; }
    }
}
