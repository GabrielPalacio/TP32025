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
        public static double CalcularTiempo(double nivelObjetivo, double a, double b, double h)
        {
            double t = 0;
            double c = 0;

            while (c < nivelObjetivo)
            {
                double k1 = a * Math.Sqrt(c + b);
                double k2 = a * Math.Sqrt(c + b + h * k1 / 2.0);
                double k3 = a * Math.Sqrt(c + b + h * k2 / 2.0);
                double k4 = a * Math.Sqrt(c + b + h * k3);

                double incremento = (h / 6.0) * (k1 + 2 * k2 + 2 * k3 + k4);

                c += incremento;
                t += h;

                if (double.IsNaN(c) || double.IsInfinity(c)) break; // evitar bucles infinitos
            }

            return t;
        }
        public static List<FilaRK> ObtenerTablaCompleta(double nivelObjetivo, double a, double b, double h)
        {
            List<FilaRK> tabla = new List<FilaRK>();

            double x = 0;
            double y = 0;

            while (true)
            {
                double k1 = a * Math.Sqrt(y + b);
                double k2 = a * Math.Sqrt(y + b + h * k1 / 2.0);
                double k3 = a * Math.Sqrt(y + b + h * k2 / 2.0);
                double k4 = a * Math.Sqrt(y + b + h * k3);

                double incremento = (h / 6.0) * (k1 + 2 * k2 + 2 * k3 + k4);

                tabla.Add(new FilaRK
                {
                    X = x,
                    Y = y,
                    K1 = k1,
                    K2 = k2,
                    K3 = k3,
                    K4 = k4
                });

                y += incremento;
                x += h;

                if (y >= nivelObjetivo)
                {
                    // Agregar la fila que alcanzó o superó el objetivo
                    double k1Final = a * Math.Sqrt(y + b);
                    double k2Final = a * Math.Sqrt(y + b + h * k1Final / 2.0);
                    double k3Final = a * Math.Sqrt(y + b + h * k2Final / 2.0);
                    double k4Final = a * Math.Sqrt(y + b + h * k3Final);

                    tabla.Add(new FilaRK
                    {
                        X = x,
                        Y = y,
                        K1 = k1Final,
                        K2 = k2Final,
                        K3 = k3Final,
                        K4 = k4Final
                    });

                    break;
                }
            }

            return tabla;
        }


    }
}
