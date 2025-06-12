using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TrabajoPractico
{
    internal class MetodoRungeKutta
    {
        public double H { get; private set; }  // Paso de integración
        public double CInicial { get; private set; }  // Valor inicial de C(t)

        public MetodoRungeKutta(double h = 0.1, double cInicial = 0.0)
        {
            this.H = h;
            this.CInicial = cInicial;
        }

        // Función derivada: dC/dt = 2 * sqrt(C + 3)
        private double FuncionDerivada(double c)
        {
            return 2 * Math.Sqrt(c + 3);
        }

        // Método de Runge-Kutta para hallar el tiempo hasta alcanzar CObjetivo
        public double CalcularTiempoCobro(double cObjetivo)
        {
            double t = 0;
            double c = CInicial;

            while (c < cObjetivo)
            {
                double k1 = H * FuncionDerivada(c);
                double k2 = H * FuncionDerivada(c + k1 / 2);
                double k3 = H * FuncionDerivada(c + k2 / 2);
                double k4 = H * FuncionDerivada(c + k3);

                c = c + (k1 + 2 * k2 + 2 * k3 + k4) / 6;
                t += H;
            }

            return t;
        }

        // Para mostrar la tabla completa de integración (opcional)
        public List<(double t, double c)> GenerarTabla(double cObjetivo)
        {
            List<(double, double)> tabla = new List<(double, double)>();

            double t = 0;
            double c = CInicial;

            tabla.Add((t, c));

            while (c < cObjetivo)
            {
                double k1 = H * FuncionDerivada(c);
                double k2 = H * FuncionDerivada(c + k1 / 2);
                double k3 = H * FuncionDerivada(c + k2 / 2);
                double k4 = H * FuncionDerivada(c + k3);

                c = c + (k1 + 2 * k2 + 2 * k3 + k4) / 6;
                t += H;

                tabla.Add((t, c));
            }

            return tabla;
        }
    }
}
