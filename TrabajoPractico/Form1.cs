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
            dgvTipoVehiculo.Rows.Insert(0, "Compacto", 45);
            dgvTipoVehiculo.Rows.Insert(1, "SUV", 25);
            dgvTipoVehiculo.Rows.Insert(2, "Furgon", 30);
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
