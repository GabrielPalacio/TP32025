using System;
using System.Collections.Generic;
using System.Linq;

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



            InicializarPuestos(cantidadPuestos);

            Recaudacion = 0;

            PorcentajeOcupacionPuestos = 0;
            MontoPorCarga = 0;
            MontoTotal = 0;
            EstadoPago = "Libre";

        }

        public void EventoLlegada(double mediaLlegadas,List<TablaProbabilidadesTiempoCarga> tabla)
        {
            vehiculos_ingresados++;
            Evento = EventoCarga.LLEGADA_VEHICULO + " " + vehiculos_ingresados;
            Reloj = ProximaLlegada;

            RndLlegada = GeneradorRND.RndLenguaje();
            TiempoEntreLlegadas = GeneradorRND.exponencial(mediaLlegadas, RndLlegada);
            ProximaLlegada = Reloj + TiempoEntreLlegadas;

            calcular_tiempo_carga(tabla);

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

        public void EventoFinCarga(int nroVehiculo)
        {
            Evento = $"Fin Carga Vehículo {nroVehiculo}";


            // Buscamos el vehículo
            Vehiculo v = Vehiculos.FirstOrDefault(veh => veh.nro == nroVehiculo);
            if (v == null || v.PuestoAsignado == null) return;

            int puesto = v.PuestoAsignado.Value;

            // Actualizamos reloj al tiempo en que termina la carga
            Reloj = v.tFinCarga;

            // Liberamos el puesto
            EstadoPuestos[puesto] = "Libre";
            TiempoOcupadoPuestos[puesto] += (v.tFinCarga - v.tInicioCarga); // Acumulamos

            // Decidir el estado del pago
            if (EstadoPago == "Libre")
            {
                EstadoPago = "Ocupado";
                v.Estado = EstadoVehiculo.REALIZANDO_PAGO;

                // Acá luego se integrará lógica de Runge-Kutta para demora y tiempo de pago
            }
            else
            {
                v.Estado = EstadoVehiculo.ESPERANDO_PAGO;
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
        private void calcular_tiempo_carga(List<TablaProbabilidadesTiempoCarga> tablaProbabilidads)
        {
            this.RndDuracionCarga = GeneradorRND.RndLenguaje();


            //Buscamos el tipo y tiempo de carga según la tabla de probabilidades
            foreach (TablaProbabilidadesTiempoCarga item in tablaProbabilidads)
            {
                if (this.RndDuracionCarga < item.ProbabilidadAcumulada)
                {
                    this.DuracionCarga = item.TiempoCarga;

                    //Luego de encontrar el trabajo, finaliza la ejecución del ciclo
                    break;
                }
            }
        }
        public void CalcularPorcentajeOcupacion()
        {
            if (Reloj <= 0 || EstadoPuestos.Count == 0)
            {
                PorcentajeOcupacionPuestos = 0;
                return;
            }

            double sumaTiempos = TiempoOcupadoPuestos.Sum();
            double totalPosible = EstadoPuestos.Count * Reloj;
            PorcentajeOcupacionPuestos = (sumaTiempos / totalPosible) * 100;
        }

    }
}
