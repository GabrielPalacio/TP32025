using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico
{
    class VectorEstado
    {
        private List<Vehiculo> vehiculos;
        // Generales
        public int Iteracion { get; set; }
        public string Evento { get; set; }
        public double Reloj { get; set; }

        // Llegada
        public double RndLlegada { get; set; }
        public double TiempoEntreLlegadas { get; set; }
        public double ProximaLlegada { get; set; }

        // Vehículo
        public double RndTipoVehiculo { get; set; }
        public string TipoVehiculo { get; set; }
        public double RndDuracionCarga { get; set; }
        public double DuracionCarga { get; set; }

        // Puestos de carga dinámicos (Inicio y Fin de carga por puesto)
        //public List<double?> TInicioCarga { get; set; } = new(); // indexado 0 a n-1
       // public List<double?> TFinCarga { get; set; } = new();

        // Zona de pago
        public double RndConcentracion { get; set; }
        public double NivelConcentracionObjetivo { get; set; }
        public double TiempoPago { get; set; }
        public string EstadoPago { get; set; }

        // Estadísticas
        public int AutosAtendidos { get; set; }
        public int AutosRechazados { get; set; }
        public double Recaudacion { get; set; }
    }

}
