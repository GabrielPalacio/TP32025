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
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSimular_Click(object sender, EventArgs e)
        {
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

                switch (nombre_prox_evento)
                {
                    case EventoCarga.INICIO:
                        this.fila_actual.EventoInicio(tiempo_entre_llegadas);
                        break;

                    case EventoCarga.LLEGADA_VEHICULO:
                        this.fila_actual.EventoLlegada(tiempo_entre_llegadas);
                        break;

                }

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
            dataGridView1.Rows.Add(
                    nroFila,
                    fila.Reloj.ToString("N4"),
                    fila.Evento,
                    (fila.RndLlegada == 0) ? "" : fila.RndLlegada.ToString("N4"),
                    (fila.TiempoEntreLlegadas == 0) ? "" : fila.TiempoEntreLlegadas.ToString(),
                    (fila.ProximaLlegada == 0) ? "" : fila.ProximaLlegada.ToString("N4")
            );

            int indice_fila_nueva = dataGridView1.Rows.Count - 1;




        }
        private void validarCamposCompletados()
        {
           // throw new NotImplementedException();
        }
    }
}
