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

        public double Recaudacion { get; set; }
        public List<bool> PuestoFueUsado { get; set; } = new List<bool>();
        public HashSet<int> PuestosRecienOcupados { get; set; } = new HashSet<int>();



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
            PuestoFueUsado.Clear();

            for (int i = 0; i < cantidadPuestos; i++)
            {
                EstadoPuestos.Add("Libre");
                TiempoOcupadoPuestos.Add(0);
                PuestoFueUsado.Add(false); // Al inicio, todos sin uso
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

            Recaudacion = 0;

            PorcentajeOcupacionPuestos = 0;
            MontoPorCarga = 0;
            MontoTotal = 0;
            EstadoPago = "Libre";

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

            Vehiculo nuevoVehiculo = new Vehiculo(vehiculos_ingresados, Reloj);

            if (puestoLibre != -1)
            {
                EstadoPuestos[puestoLibre] = "Cargando";

                // Solo reiniciamos si es la primera vez que se usa ese puesto
                if (!PuestoFueUsado[puestoLibre])
                {
                    TiempoOcupadoPuestos[puestoLibre] = 0.0;
                    PuestoFueUsado[puestoLibre] = true;
                }

                PuestosRecienOcupados.Add(puestoLibre); 

                nuevoVehiculo.PuestoAsignado = puestoLibre;
                nuevoVehiculo.Estado = EstadoVehiculo.CARGANDO;
                nuevoVehiculo.tInicioCarga = Reloj;
                nuevoVehiculo.tFinCarga = Reloj + DuracionCarga;

            }
            else
            {
                nuevoVehiculo.Estado = EstadoVehiculo.RECHAZADO;
            }

            Vehiculos.Add(nuevoVehiculo);
        }


        public void ActualizarTiemposOcupacion(double relojAnterior)
        {
            double deltaT = Reloj - relojAnterior;

            for (int i = 0; i < EstadoPuestos.Count; i++)
            {
                if (EstadoPuestos[i] == "Cargando" && !PuestosRecienOcupados.Contains(i))
                {
                    TiempoOcupadoPuestos[i] += deltaT;
                }
            }

            // Limpiar la lista después de actualizar
            PuestosRecienOcupados.Clear();
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
