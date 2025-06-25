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

        public List<string> EstadoPuestos { get; set; }
        public List<double> TiempoOcupadoPuestos { get; set; }

        public double PorcentajeOcupacionPuestos;

        // Zona de pago
        public double RndConcentracion { get; set; }
        public double NivelConcentracionObjetivo { get; set; }
        public double TiempoPago { get; set; }
        public string EstadoPago { get; set; }

        // Estadísticas
        public double MontoPorCarga { get; set; }
        public double MontoPorPago { get; set; }
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

            // Inicialización vacía, luego se setea según si hay 8 o 10 puestos
            EstadoPuestos = new List<string>();
            TiempoOcupadoPuestos = new List<double>();

        }

        public void InicializarPuestos(int cantidadPuestos)
        {
            EstadoPuestos.Clear();
            TiempoOcupadoPuestos.Clear();
            for (int i = 0; i < cantidadPuestos; i++)
            {
                EstadoPuestos.Add("Libre");
                TiempoOcupadoPuestos.Add(0);
            }
        }



        //Este es el evento 0, con el cual siempre va a inicial el sistema
        public void EventoInicio(double mediaLlegadas, int cantidadPuestos)
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

            InicializarPuestos(cantidadPuestos);

            AutosAtendidos = 0;
            AutosRechazados = 0;
            Recaudacion = 0;
        }

        public void EventoLlegada(double mediaLlegadas)
        {
            this.vehiculos_ingresados++;
            this.Evento = EventoCarga.LLEGADA_VEHICULO + " " + this.vehiculos_ingresados;
            this.Reloj = this.ProximaLlegada;

            // Calculamos próxima llegada
            this.RndLlegada = GeneradorRND.RndLenguaje();
            this.TiempoEntreLlegadas = GeneradorRND.exponencial(mediaLlegadas, this.RndLlegada);
            this.ProximaLlegada = this.Reloj + this.TiempoEntreLlegadas;



            // Calculamos el tipo de vehículo y su duración de carga
            this.RndTipoVehiculo = GeneradorRND.RndLenguaje();
            this.TipoVehiculo = "Furgon"; // TO DO
            this.RndDuracionCarga = GeneradorRND.RndLenguaje();
            this.DuracionCarga = 10; //TO DO
            // Intentamos asignar un puesto de carga
            int puestoLibre = EstadoPuestos.FindIndex(e => e == "Libre");

            // Creamos el nuevo vehículo
            Vehiculo nuevo_vehiculo = new Vehiculo(this.vehiculos_ingresados, this.Reloj);

            if (puestoLibre != -1)
            {
                EstadoPuestos[puestoLibre] = "Cargando";
                TiempoOcupadoPuestos[puestoLibre] = 0;
                nuevo_vehiculo.PuestoAsignado = puestoLibre;
                nuevo_vehiculo.Estado = "Cargando";
                nuevo_vehiculo.tFinCarga = this.Reloj + this.DuracionCarga; // Duración de carga
                AutosAtendidos++;
            }
            else
            {
                nuevo_vehiculo.Estado = "Rechazado";
                AutosRechazados++;
            }

            // Registramos el vehículo (si necesitás rastrearlo después)
            this.vehiculos.Add(nuevo_vehiculo);
        }

        public void ActualizarTiemposOcupacion(double relojAnterior)
        {
            double deltaT = this.Reloj - relojAnterior;

            for (int i = 0; i < EstadoPuestos.Count; i++)
            {
                if (EstadoPuestos[i] == "Cargando")
                {
                    TiempoOcupadoPuestos[i] += deltaT;
                }
            }
        }
        public void ActualizarEstadosVehiculos()
        {
            foreach (var v in vehiculos)
            {
                if (v.Estado == "Cargando" && v.tFinCarga <= Reloj)
                {
                    v.Estado = "Esperando pago";
           

                }
                else if (v.Estado == "Esperando pago")
                {
                    // Podés implementar cola o evento de pago futuro
                }
            }
        }


    }


}
