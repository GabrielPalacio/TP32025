using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TrabajoPractico
{
    public partial class FormTablaRK : Form
    {
        public FormTablaRK(double desde, double hasta, double h, double A, double B)
        {
            InitializeComponent();
            this.Load += FormTablaRK_Load;
        }

        private void FormTablaRK_Load(object sender, EventArgs e)
        {
            List<FilaRK> filas = MetodoRungeKutta.ObtenerTablaCompleta(
                ParametrosGlobales.MaxNivelConcentracion,
                ParametrosGlobales.A,
                ParametrosGlobales.B,
                ParametrosGlobales.H
            );

            foreach (var fila in filas)
            {
                dataGridView1.Rows.Add(
                    fila.X.ToString("N4"),
                    fila.Y.ToString("N4"),
                    fila.K1.ToString("N4"),
                    fila.K2.ToString("N4"),
                    fila.K3.ToString("N4"),
                    fila.K4.ToString("N4")
                );
            }
        }
    }
}
