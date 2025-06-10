using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio.Metodo
{
    public partial class Formulario_Euler : Form
    {
        public Formulario_Euler()
        {
            InitializeComponent();

            //Agregamos las columnas para Euler para sector 1000
            dgvSector1000.Columns.Add(ColumnasGrillaEuler.C_VARIABLE_INDEPENDIENTE, ColumnasGrillaEuler.N_VARIABLE_INDEPENDIENTE);
            dgvSector1000.Columns.Add(ColumnasGrillaEuler.C_VARIABLE_DEPENDIENTE, ColumnasGrillaEuler.N_VARIABLE_DEPENDIENTE);
            dgvSector1000.Columns.Add(ColumnasGrillaEuler.C_DIFERENCIAL, ColumnasGrillaEuler.N_DIFERENCIAL);
            dgvSector1000.Columns.Add(ColumnasGrillaEuler.C_PROXIMO_VALOR, ColumnasGrillaEuler.N_PROXIMO_VALOR);

            //Agregamos las columnas para Euler para sector 1500
            dgvSector1500.Columns.Add(ColumnasGrillaEuler.C_VARIABLE_INDEPENDIENTE, ColumnasGrillaEuler.N_VARIABLE_INDEPENDIENTE);
            dgvSector1500.Columns.Add(ColumnasGrillaEuler.C_VARIABLE_DEPENDIENTE, ColumnasGrillaEuler.N_VARIABLE_DEPENDIENTE);
            dgvSector1500.Columns.Add(ColumnasGrillaEuler.C_DIFERENCIAL, ColumnasGrillaEuler.N_DIFERENCIAL);
            dgvSector1500.Columns.Add(ColumnasGrillaEuler.C_PROXIMO_VALOR, ColumnasGrillaEuler.N_PROXIMO_VALOR);

            //Agregamos las columnas para Euler para sector 2000
            dgvSector2000.Columns.Add(ColumnasGrillaEuler.C_VARIABLE_INDEPENDIENTE, ColumnasGrillaEuler.N_VARIABLE_INDEPENDIENTE);
            dgvSector2000.Columns.Add(ColumnasGrillaEuler.C_VARIABLE_DEPENDIENTE, ColumnasGrillaEuler.N_VARIABLE_DEPENDIENTE);
            dgvSector2000.Columns.Add(ColumnasGrillaEuler.C_DIFERENCIAL, ColumnasGrillaEuler.N_DIFERENCIAL);
            dgvSector2000.Columns.Add(ColumnasGrillaEuler.C_PROXIMO_VALOR, ColumnasGrillaEuler.N_PROXIMO_VALOR);

        }

        public void agregar_fila(Double t, Double S, Double ds, Double proximo, int grilla)
        {
            switch (grilla)
            {
                case 1:
                    dgvSector1000.Rows.Add(t, S, ds, proximo);
                    break;
                case 2:
                    dgvSector1500.Rows.Add(t, S, ds, proximo);
                    break;
                case 3:
                    dgvSector2000.Rows.Add(t, S, ds, proximo);
                    break;
            }
        }

        public void pintar_fila_seleccionada(int grilla)
        {
            switch (grilla)
            {
                case 1:
                    dgvSector1000.Rows[dgvSector1000.Rows.Count - 2].DefaultCellStyle.BackColor = Color.Yellow;
                    break;
                case 2:
                    dgvSector1500.Rows[dgvSector1500.Rows.Count - 2].DefaultCellStyle.BackColor = Color.Yellow;
                    break;
                case 3:
                    dgvSector2000.Rows[dgvSector2000.Rows.Count - 2].DefaultCellStyle.BackColor = Color.Yellow;
                    break;
            }

        }
    }
}
