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
            this.Estado = "Cargando";
            this.tInicioCarga = tiempo_ingreso;
        }
        public int nro { get; set; }
        public string Estado { get; set; }
        public double TiempoCobro { get; set; }
        public double tInicioCarga { get; set; }
        public double tFinCarga { get; set; }
        public int? PuestoAsignado { get; set; }

    }
}
