using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoPractico
{
    public partial class Form1 : Form
    {
        private VectorEstado fila_actual = new VectorEstado(); //Fila nueva
        private VectorEstado vector_estado;
        public Form1()
        {
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Definir los colores del degradado
            Color colorInicio = Color.Black;
            Color colorFin = ColorTranslator.FromHtml("#03346E");

            // Definir el área del degradado
            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);

            // Crear el degradado
            using (LinearGradientBrush brush = new LinearGradientBrush(
                rect, colorInicio, colorFin, LinearGradientMode.Vertical))
            {
                // Ajustar la interpolación para que el negro ocupe menos de un tercio
                ColorBlend blend = new ColorBlend();
                blend.Positions = new float[] { 0.0f, 0.00001f, 1.0f };
                blend.Colors = new Color[] { colorInicio, colorInicio, colorFin };



                brush.InterpolationColors = blend;
                e.Graphics.FillRectangle(brush, rect);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvTipoVehiculo.Rows.Insert(0, "Compacto", 0.45, 0.45,300);
            dgvTipoVehiculo.Rows.Insert(1, "SUV", 0.25, 0.70, 500);
            dgvTipoVehiculo.Rows.Insert(2, "Furgon", 0.30, 1, 1000);

            dgvTiempoCarga.Rows.Insert(0, 60, 0.5, 0.5);
            dgvTiempoCarga.Rows.Insert(1, 120, 0.3, 0.8);
            dgvTiempoCarga.Rows.Insert(2, 180, 0.15, 0.95);
            dgvTiempoCarga.Rows.Insert(3, 240, 0.05, 1);


        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSimular_Click(object sender, EventArgs e)
        {
            int cantidadPuestos = rb8.Checked ? 8 : 10;

            ConfigurarColumnasPuestos();
            dataGridView1.Rows.Clear();
            validarCamposCompletados();
            ParametrosGlobales.MaxNivelConcentracion = 0;

            Int64 iteraciones = Convert.ToInt64(txtIteraciones.Text);
            Int64 tiempo_entre_llegadas = Convert.ToInt64(txtTllegada.Text);
            Double tiempo = Convert.ToDouble(txtTiempo.Text);
            Double tiempo_desde = Convert.ToDouble(txtDesde.Text);
            Double tiempo_hasta = Convert.ToDouble(txtHasta.Text);
            ParametrosGlobales.ConcentracionDesde = Convert.ToDouble(txtConcentracionA.Text);
            ParametrosGlobales.ConcentracionHasta = Convert.ToDouble(txtConcentracionB.Text);
            ParametrosGlobales.A = Convert.ToDouble(txtRKA.Text);
            ParametrosGlobales.B = Convert.ToDouble(txtRKB.Text);
            ParametrosGlobales.H = Convert.ToDouble(txtPaso.Text);

            List<TablaProbabilidadesTiempoCarga> tabla = dgvTiempoToList(dgvTiempoCarga);
            fila_actual = new VectorEstado();
            fila_actual.EventoInicio(tiempo_entre_llegadas, cantidadPuestos);

            // ✅ Agregar la fila de Inicio explícitamente
            agregarFila(0, fila_actual);

            Int64 i = 1;

            for (; i < iteraciones && fila_actual.Reloj <= tiempo; i++)
            {
                double relojAnterior = fila_actual.Reloj;

                var proximo = obtener_proximo_evento_completo(); // (evento, nroVehiculo)

                switch (proximo.evento)
                {
                    case EventoCarga.LLEGADA_VEHICULO:
                        fila_actual.EventoLlegada(tiempo_entre_llegadas,tabla);
                        break;

                    case EventoCarga.FIN_CARGA:
                        fila_actual.EventoFinCarga(proximo.nroVehiculo);
                        break;
                    case EventoCarga.FIN_ATENCION_VEHICULO:
                        fila_actual.EventoFinAtencion(proximo.nroVehiculo);
                        break;

                }

                fila_actual.ActualizarTiemposOcupacion(relojAnterior);
                fila_actual.CalcularPorcentajeOcupacion();
                fila_actual.ActualizarEstadosVehiculos();

                if (fila_actual.Reloj >= tiempo_desde && fila_actual.Reloj <= tiempo_hasta)
                {
                    agregarFila(i, fila_actual);
                }
            }

            if (dataGridView1.Rows.Count == 0 || fila_actual.Reloj > tiempo_hasta)
            {
                agregarFila(i, fila_actual);
            }
        }

        private List<TablaProbabilidadesTiempoCarga> dgvTiempoToList(DataGridView dgvTiempoCarga)
        {
            List<TablaProbabilidadesTiempoCarga> lista = new List<TablaProbabilidadesTiempoCarga>();

            foreach (DataGridViewRow row in dgvTiempoCarga.Rows)
            {
                TablaProbabilidadesTiempoCarga tpTCarga = new TablaProbabilidadesTiempoCarga();
                tpTCarga.TiempoCarga = Convert.ToInt16(row.Cells[0].Value);
                tpTCarga.Probabilidad = Convert.ToDouble(row.Cells[1].Value);
                tpTCarga.ProbabilidadAcumulada = Convert.ToDouble(row.Cells[2].Value); //TO DO : Realizar truncamientos

                lista.Add(tpTCarga);
            }
            return lista;
        }

        private (string evento, int nroVehiculo) obtener_proximo_evento_completo()
        {
            double tiempo_min = double.MaxValue;
            string evento = "";
            int nroVehiculo = -1;


            // LLEGADA
            if (fila_actual.ProximaLlegada > 0 && fila_actual.ProximaLlegada < tiempo_min)
            {
                tiempo_min = fila_actual.ProximaLlegada;
                evento = EventoCarga.LLEGADA_VEHICULO;
            }

            // FIN CARGA
            foreach (var v in fila_actual.Vehiculos)
            {
                if (v.Estado.StartsWith("C") && v.tFinCarga >= fila_actual.Reloj && v.tFinCarga < tiempo_min)
                {
                    tiempo_min = v.tFinCarga;
                    evento = EventoCarga.FIN_CARGA;
                    nroVehiculo = v.nro;
                }
            }
            // FIN PAGO
            if (fila_actual.TiempoFinPago > 0 && fila_actual.TiempoFinPago < tiempo_min)
            {
                tiempo_min = fila_actual.TiempoFinPago;
                evento = EventoCarga.FIN_ATENCION_VEHICULO;

                // Buscamos el vehículo que está en pago
                var pagando = fila_actual.Vehiculos.FirstOrDefault(x => x.Estado == EstadoVehiculo.REALIZANDO_PAGO);
                if (pagando != null)
                    nroVehiculo = pagando.nro;
            }


            return (evento, nroVehiculo);
        }



        private void agregarFila(Int64 nroFila, VectorEstado fila, bool visible = true)
        {
            int rowIndex = dataGridView1.Rows.Add(
                nroFila,
                fila.Reloj.ToString("N4"),
                fila.Evento,
                (fila.RndLlegada == 0) ? "" : fila.RndLlegada.ToString("N4"),
                (fila.TiempoEntreLlegadas == 0) ? "" : fila.TiempoEntreLlegadas.ToString(),
                (fila.ProximaLlegada == 0) ? "" : fila.ProximaLlegada.ToString("N4"),
                (fila.RndTipoVehiculo == 0) ? "" : fila.RndTipoVehiculo.ToString("N4"),
                fila.TipoVehiculo,
                fila.RndDuracionCarga.ToString("N4"),
                fila.DuracionCarga.ToString("N4")
            );

            // 🔁 Agregar dinámicamente los estados y tiempos de cada puesto
            int colBase = 10;
            for (int i = 0; i < fila.EstadoPuestos.Count; i++)
            {
                dataGridView1.Rows[rowIndex].Cells[colBase + (i * 2)].Value = fila.EstadoPuestos[i];
                dataGridView1.Rows[rowIndex].Cells[colBase + (i * 2) + 1].Value = fila.TiempoOcupadoPuestos[i].ToString("N2");
            }

            // Porcentaje de ocupación
            int colPorcentaje = colBase + (fila.EstadoPuestos.Count * 2);
            dataGridView1.Rows[rowIndex].Cells[colPorcentaje].Value = fila.PorcentajeOcupacionPuestos.ToString("N4");

            // Zona de pago
            int colZonaPago = colPorcentaje + 1;
            bool mostrarZonaPago = fila.EstadoPago == "Ocupado";

            dataGridView1.Rows[rowIndex].Cells[colZonaPago].Value = fila.EstadoPago;
            dataGridView1.Rows[rowIndex].Cells[colZonaPago + 1].Value =
                mostrarZonaPago && fila.RndConcentracion != 0 ? fila.RndConcentracion.ToString("N4") : "";
            dataGridView1.Rows[rowIndex].Cells[colZonaPago + 2].Value =
                mostrarZonaPago && fila.NivelConcentracionObjetivo != 0 ? fila.NivelConcentracionObjetivo.ToString("N4") : "";
            dataGridView1.Rows[rowIndex].Cells[colZonaPago + 3].Value =
                mostrarZonaPago && fila.DemoraPago != 0 ? fila.DemoraPago.ToString("N4") : "";
            dataGridView1.Rows[rowIndex].Cells[colZonaPago + 4].Value =
                mostrarZonaPago && fila.TiempoFinPago != 0 ? fila.TiempoFinPago.ToString("N4") : "";

            agregarVehiculos(fila, rowIndex);
        }



        private void validarCamposCompletados()
        {
           // esto lo dejo para el ultimo, que  va a ser validar los campos que no permita vacios y algunos caracteres especiales;
        }

        private void ConfigurarColumnasPuestos()
        {
            int cantidadPuestos = rb8.Checked ? 8 : 10;
            // 🔁 Eliminar TODAS las columnas excepto las fijas iniciales
            while (dataGridView1.Columns.Count > 10) // 10 o las que tengas fijas al inicio
            {
                dataGridView1.Columns.RemoveAt(dataGridView1.Columns.Count - 1);
            }
            // Remover columnas anteriores si ya existían (solo las dinámicas)
            for (int i = dataGridView1.Columns.Count - 1; i >= 0; i--)
            {
                string nombre = dataGridView1.Columns[i].Name;
                if (nombre.StartsWith("EstadoPuesto") || nombre.StartsWith("TiempoOcupado") ||
                    nombre == "PorcentajeOcupacion" || nombre == "EstadoPago" || nombre == "RNDPago" ||
                    nombre == "NivelConcentracion" || nombre == "DemoraPago" )
                {
                    dataGridView1.Columns.RemoveAt(i);
                }
            }

            // Agregamos columnas dinámicas por puesto
            for (int i = 1; i <= cantidadPuestos; i++)
            {
                dataGridView1.Columns.Add($"EstadoPuesto{i}", $"Estado Puesto {i}");
                dataGridView1.Columns.Add($"TiempoOcupado{i}", $"Tiempo ocupado Puesto {i}");
            }

            // Agregamos las columnas fijas finales
            dataGridView1.Columns.Add("PorcentajeOcupacion", "Porcentaje de ocupación de puestos");
            dataGridView1.Columns.Add("EstadoPago", "Estado Puesto de Pagos");
            dataGridView1.Columns.Add("RNDPago", "RND");
            dataGridView1.Columns.Add("NivelConcentracion", "Nivel de Concentración");
            dataGridView1.Columns.Add("DemoraPago", "Demora");
            dataGridView1.Columns.Add("TiempoCobro", "Tiempo Cobro");
            dataGridView1.Columns.Add("MontoPorCarga", "Monto por carga");
            dataGridView1.Columns.Add("MontoTotal", "Monto total");


        }
        private void agregarVehiculos(VectorEstado fila_actual, int rowIndex)
        {
            string baseCol = "Vehiculo";
            string headerPrefix = "Vehículo ";

            foreach (Vehiculo item in fila_actual.Vehiculos)
            {
                string colEstado = $"{baseCol}_{item.nro}_Estado";
                string colInicio = $"{baseCol}_{item.nro}_InicioCarga";
                string colFin = $"{baseCol}_{item.nro}_FinCarga";

                // Crear columnas si no existen
                if (!dataGridView1.Columns.Contains(colEstado))
                    dataGridView1.Columns.Add(colEstado, headerPrefix + item.nro + " Estado");

                if (!dataGridView1.Columns.Contains(colInicio))
                    dataGridView1.Columns.Add(colInicio, headerPrefix + item.nro + " Inicio");

                if (!dataGridView1.Columns.Contains(colFin))
                    dataGridView1.Columns.Add(colFin, headerPrefix + item.nro + " Fin");

                // Mostrar estado actual, con el puesto asignado si aplica
                if (item.Estado.StartsWith("C") && item.PuestoAsignado.HasValue)
                {
                    dataGridView1[colEstado, rowIndex].Value = FormatearEstadoVehiculo(item);
                }
                else
                {
                    dataGridView1[colEstado, rowIndex].Value = item.Estado;
                }

                // Mostrar tInicioCarga con 4 decimales
                dataGridView1[colInicio, rowIndex].Value = item.tInicioCarga > 0
                    ? item.tInicioCarga.ToString("N4")
                    : "";

                // Mostrar tFinCarga con 4 decimales
                dataGridView1[colFin, rowIndex].Value = item.tFinCarga > 0
                    ? item.tFinCarga.ToString("N4")
                    : "";
            }
        }

        private string FormatearEstadoVehiculo(Vehiculo v)
        {
            if (v.Estado.StartsWith("C"))
            {
                return v.PuestoAsignado.HasValue ? $"C ({v.PuestoAsignado.Value + 1})" : "C";
            }
            else if (v.Estado == EstadoVehiculo.ESPERANDO_PAGO)
            {
                return "EP";
            }
            else if (v.Estado == EstadoVehiculo.REALIZANDO_PAGO)
            {
                return "PP";
            }
            else if (v.Estado == EstadoVehiculo.ABANDONA_ESTACION)
            {
                return "AE";
            }
            else if (v.Estado == EstadoVehiculo.RECHAZADO)
            {
                return "R";
            }
            else
            {
                return v.Estado;
            }
        }

        private void btnRunge_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtConcentracionA.Text);
            double b = Convert.ToDouble(txtConcentracionB.Text);
            double h = Convert.ToDouble(txtPaso.Text);
            double rkA = Convert.ToDouble(txtRKA.Text);
            double rkB = Convert.ToDouble(txtRKB.Text);

            FormTablaRK formTabla = new FormTablaRK(a, b, h, rkA, rkB);
            formTabla.ShowDialog();
        }
    }
}
