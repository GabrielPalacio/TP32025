using System;
using System.Collections.Generic;

namespace TrabajoPractico
{
    class VectorEstado
    {
        private int vehiculos_ingresados;

        // Vehículos
        public List<Vehiculo> Vehiculos { get; set; }

        // Generales
        public int Iteracion { get; set; }
        public string Evento { get; set; }
        public double Reloj { get; set; }

        // Llegada
        public double RndLlegada { get; set; }
        public double TiempoEntreLlegadas { get; set; }
        public double ProximaLlegada { get; set; }

        // Vehículo generado
        public double RndTipoVehiculo { get; set; }
        public string TipoVehiculo { get; set; }
        public double RndDuracionCarga { get; set; }
        public double DuracionCarga { get; set; }

        // Puestos de carga
        public List<string> EstadoPuestos { get; set; }
        public List<double> TiempoOcupadoPuestos { get; set; }

        // Zona de pago
        public double PorcentajeOcupacionPuestos;
        public double RndConcentracion { get; set; }
        public double NivelConcentracionObjetivo { get; set; }
        public double TiempoPago { get; set; }
        public string EstadoPago { get; set; }

        // Estadísticas
        public double MontoPorCarga { get; set; }
        public double MontoTotal { get; set; }
        public int AutosAtendidos { get; set; }
        public int AutosRechazados { get; set; }
        public double Recaudacion { get; set; }
        public int colaPuestoPago { get; set; }

        public VectorEstado()
        {
            vehiculos_ingresados = 0;
            Iteracion = 0;
            Evento = "";
            Reloj = 0;

            Vehiculos = new List<Vehiculo>();
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

        public void EventoInicio(double mediaLlegadas, int cantidadPuestos)
        {
            Evento = EventoCarga.INICIO;
            Reloj = 0;

            RndLlegada = GeneradorRND.RndLenguaje();
            TiempoEntreLlegadas = GeneradorRND.exponencial(mediaLlegadas, RndLlegada);
            ProximaLlegada = Reloj + TiempoEntreLlegadas;

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

            PorcentajeOcupacionPuestos = 0;
            MontoPorCarga = 0;
            MontoTotal = 0;
            EstadoPago = "Libre";
            colaPuestoPago = 0;
        }

        public void EventoLlegada(double mediaLlegadas)
        {
            vehiculos_ingresados++;
            Evento = EventoCarga.LLEGADA_VEHICULO + " " + vehiculos_ingresados;
            Reloj = ProximaLlegada;

            RndLlegada = GeneradorRND.RndLenguaje();
            TiempoEntreLlegadas = GeneradorRND.exponencial(mediaLlegadas, RndLlegada);
            ProximaLlegada = Reloj + TiempoEntreLlegadas;

            RndTipoVehiculo = GeneradorRND.RndLenguaje();
            TipoVehiculo = "Furgon"; // TODO
            RndDuracionCarga = GeneradorRND.RndLenguaje();
            DuracionCarga = 10; // TODO

            int puestoLibre = EstadoPuestos.FindIndex(e => e == "Libre");

            Vehiculo nuevo = new Vehiculo(vehiculos_ingresados, Reloj);

            if (puestoLibre != -1)
            {
                EstadoPuestos[puestoLibre] = "Cargando";
                TiempoOcupadoPuestos[puestoLibre] = 0;
                nuevo.PuestoAsignado = puestoLibre;
                nuevo.Estado = "Cargando";
                nuevo.tFinCarga = Reloj + DuracionCarga;
                AutosAtendidos++;
            }
            else
            {
                nuevo.Estado = "Rechazado";
                AutosRechazados++;
            }

            Vehiculos.Add(nuevo);
        }

        public void ActualizarTiemposOcupacion(double relojAnterior)
        {
            double deltaT = Reloj - relojAnterior;

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
            foreach (var v in Vehiculos)
            {
                if (v.Estado == "Cargando" && v.tFinCarga <= Reloj)
                {
                    v.Estado = "Esperando pago";
                }
            }
        }
    }
}
