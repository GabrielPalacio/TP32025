using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico
{
    class VectorEstado
    {
        private int vehiculos_ingresados;
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

        public VectorEstado()
        {
            this.vehiculos_ingresados = 0;

            this.Iteracion = 0;
            this.Evento = "";
            this.Reloj = 0;
            this.RndLlegada = 0;
            this.TiempoEntreLlegadas = 0;
            this.ProximaLlegada = 0;

            this.vehiculos = new List<Vehiculo>();


        }

        //Este es el evento 0, con el cual siempre va a inicial el sistema
        public void EventoInicio(double mediaLlegadas)
        {
            Evento = EventoCarga.INICIO;
            Reloj = 0;

            // Generar próxima llegada con distribución exponencial
            RndLlegada = GeneradorRND.RndLenguaje();
            TiempoEntreLlegadas = GeneradorRND.exponencial(mediaLlegadas, RndLlegada);
            ProximaLlegada = Reloj + TiempoEntreLlegadas;

            // Estado inicial del sistema
            RndTipoVehiculo = 0;
            TipoVehiculo = "";
            RndDuracionCarga = 0;
            DuracionCarga = 0;

            RndConcentracion = 0;
            NivelConcentracionObjetivo = 0;
            TiempoPago = 0;
            EstadoPago = "Libre";

            AutosAtendidos = 0;
            AutosRechazados = 0;
            Recaudacion = 0;
        }

        public void EventoLlegada(double mediaLlegadas)
        {
            this.vehiculos_ingresados++;

            this.Evento = EventoCarga.LLEGADA_VEHICULO + " " + this.vehiculos_ingresados;
            this.Reloj = this.TiempoEntreLlegadas;

            //Calculamos la proxima llegada
            this.RndLlegada = GeneradorRND.RndLenguaje();
            //ponemos los valoes de 30 y 90 que no pedían ser parametizables
            this.TiempoEntreLlegadas = GeneradorRND.exponencial(mediaLlegadas, this.RndLlegada);
            this.ProximaLlegada = this.Reloj + this.TiempoEntreLlegadas;


            //Creamos un nuevo vehiculo, con estado EA por defecto
            Vehiculo nuevo_vehiculo = new Vehiculo(this.vehiculos_ingresados, this.Reloj);

        }

    }


}
