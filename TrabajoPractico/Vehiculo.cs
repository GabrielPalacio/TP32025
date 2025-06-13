using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico
{
    internal class Vehiculo
    {
        public Vehiculo(int nro, double tiempo_ingreso) {
            this.nro = nro;
        }
        public int nro { get; set; }
        public string Estado { get; set; } 
        public String tipoVehiculo { get; set; }
        public String tInicioCarga { get; set; }
        public String tFinCarga { get; set; }

    }
}
