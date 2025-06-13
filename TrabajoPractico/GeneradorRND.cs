using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico
{
    internal class GeneradorRND
    {
        public static Double RndLenguaje()
        {
            return Utilidades.truncar(random());
        }

        private static double random()
        {
            Guid guid = Guid.NewGuid();
            String justNumber = new String(guid.ToString().Where(Char.IsDigit).ToArray());
            int seed = int.Parse(justNumber.Substring(0, 4));

            return Utilidades.truncar(new Random(seed).NextDouble());
        }

        public static Double uniforme(double A, double B, double rnd)
        {
            Double x = A + (rnd * (B - A));

            return Utilidades.truncar(x);
        }

        public static Double exponencial(double media, double nro_rnd)
        {
            Double x = (-1)*(media) * Math.Log(1 - nro_rnd);

            return Utilidades.truncar(x);
        }
    }
}
