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
            dgvTipoVehiculo.Rows.Insert(0, "Compacto", 45, 0.45,300);
            dgvTipoVehiculo.Rows.Insert(1, "SUV", 25, 0.70, 500);
            dgvTipoVehiculo.Rows.Insert(2, "Furgon", 30, 1, 1000);

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

            //Llamamos a la funcion que va a configurar las columnas(puestos) de la grilla ver que demora
            ConfigurarColumnasPuestos();

            //arrancamos con la grilla limpia
            dataGridView1.Rows.Clear();

            //Validamos campos completados
            validarCamposCompletados();

            Int64 iteraciones = Convert.ToInt64(txtIteraciones.Text);
            Int64 tiempo_entre_llegadas = Convert.ToInt64(txtTllegada.Text);
            Double tiempo = Convert.ToDouble(txtTiempo.Text);
            Double tiempo_desde = Convert.ToDouble(txtDesde.Text);
            Double tiempo_hasta = Convert.ToDouble(txtHasta.Text);


            fila_actual = new VectorEstado();

            Int64 i = 0;
            for (; i <= iteraciones && this.fila_actual.Reloj <= tiempo; i++)
            {
                string nombre_prox_evento = obtener_proximo_evento();
                double relojAnterior = fila_actual.Reloj;

                switch (nombre_prox_evento)
                {
                    case EventoCarga.INICIO:
                        this.fila_actual.EventoInicio(tiempo_entre_llegadas, cantidadPuestos);
                        break;

                    case EventoCarga.LLEGADA_VEHICULO:
                        this.fila_actual.EventoLlegada(tiempo_entre_llegadas);
                        break;

                }
                fila_actual.ActualizarTiemposOcupacion(relojAnterior);
                fila_actual.ActualizarEstadosVehiculos();

                //Calculos estadisticos



                if (this.fila_actual.Reloj >= tiempo_desde && this.fila_actual.Reloj <= tiempo_hasta)
                {
                    agregarFila(i, fila_actual);
                }
            }

            if (dataGridView1.Rows.Count != i)
            {
                agregarFila(i, fila_actual);
            }



        }
        private string obtener_proximo_evento()
        {
            double tiempo_min = Double.MaxValue;
            string nombre_evento = "";

            if (fila_actual.Reloj == 0 && fila_actual.Evento == "")
            {
                tiempo_min = fila_actual.Reloj;
                nombre_evento = EventoCarga.INICIO;
            }

            if (fila_actual.ProximaLlegada > 0 && fila_actual.ProximaLlegada < tiempo_min)
            {
                tiempo_min = fila_actual.ProximaLlegada;
                nombre_evento = EventoCarga.LLEGADA_VEHICULO;
            }

            return nombre_evento;
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
                fila.RndTipoVehiculo.ToString("N4"),
                fila.TipoVehiculo,
                fila.RndDuracionCarga.ToString("N4"),
                fila.DuracionCarga.ToString("N2")

            );

            // 🔁 Agregar dinámicamente los estados y tiempos de cada puesto
            int colBase = 10; 
            for (int i = 0; i < fila.EstadoPuestos.Count; i++)
            {
                dataGridView1.Rows[rowIndex].Cells[colBase + (i * 2)].Value = fila.EstadoPuestos[i];
                dataGridView1.Rows[rowIndex].Cells[colBase + (i * 2) + 1].Value = fila.TiempoOcupadoPuestos[i].ToString("N2");
            }
            agregarVehiculos(fila,rowIndex);

        }

        private void validarCamposCompletados()
        {
           // esto lo dejo para el ultimo, que  va a ser validar los campos que no permita vacios y algunos caracteres especiales;
        }

        private void ConfigurarColumnasPuestos()
        {
            int cantidadPuestos = rb8.Checked ? 8 : 10;

            // Remover columnas anteriores si ya existían (solo las dinámicas)
            for (int i = dataGridView1.Columns.Count - 1; i >= 0; i--)
            {
                string nombre = dataGridView1.Columns[i].Name;
                if (nombre.StartsWith("EstadoPuesto") || nombre.StartsWith("TiempoOcupado") ||
                    nombre == "PorcentajeOcupacion" || nombre == "EstadoPago" || nombre == "RNDPago" ||
                    nombre == "NivelConcentracion" || nombre == "DemoraPago" || nombre == "ColaPago")
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
            dataGridView1.Columns.Add("EstadoPago", "Estado");
            dataGridView1.Columns.Add("RNDPago", "RND");
            dataGridView1.Columns.Add("NivelConcentracion", "Nivel de Concentración");
            dataGridView1.Columns.Add("DemoraPago", "Demora");
            dataGridView1.Columns.Add("ColaPago", "Cola pago");
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
                string colCarga = $"{baseCol}_{item.nro}_Carga";
                string colCobro = $"{baseCol}_{item.nro}_Cobro";

                // Agregar columnas si no existen
                if (!dataGridView1.Columns.Contains(colEstado))
                    dataGridView1.Columns.Add(colEstado, headerPrefix + item.nro + " Estado");

                if (!dataGridView1.Columns.Contains(colCarga))
                    dataGridView1.Columns.Add(colCarga, headerPrefix + item.nro + " Carga");

                if (!dataGridView1.Columns.Contains(colCobro))
                    dataGridView1.Columns.Add(colCobro, headerPrefix + item.nro + " Cobro");

                // Mostrar estado actual, con el puesto asignado si aplica
                if (item.Estado.StartsWith("Cargando") && item.PuestoAsignado.HasValue)
                {
                    dataGridView1[colEstado, rowIndex].Value = $"Cargando ({item.PuestoAsignado.Value + 1})";
                }
                else
                {
                    dataGridView1[colEstado, rowIndex].Value = item.Estado;
                }


                // Mostrar rango de carga si aplica
                if (item.Estado.Contains("Cargando") && item.tFinCarga > 0)
                {
                    dataGridView1[colCarga, rowIndex].Value = $"{item.tInicioCarga:N2} - {item.tFinCarga:N4}";
                }
                else
                {
                    dataGridView1[colCarga, rowIndex].Value = "";
                }

                // Mostrar tiempo de cobro solo si está pagando o finalizó
                if (item.Estado == "En puesto de pago" || item.Estado == "Abandona la estación")
                {
                    dataGridView1[colCobro, rowIndex].Value = item.TiempoCobro > 0 ? item.TiempoCobro.ToString("N4") : "";
                }
                else
                {
                    dataGridView1[colCobro, rowIndex].Value = "";
                }
            }
        }



    }
}
