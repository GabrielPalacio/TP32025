using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio.Metodo
{
    internal class ColumnasGrillaEuler
    {
        public const String C_VARIABLE_INDEPENDIENTE = "cVariableIndependiente";
        public const String N_VARIABLE_INDEPENDIENTE = "t";

        public const String C_VARIABLE_DEPENDIENTE = "cS";
        public const String N_VARIABLE_DEPENDIENTE = "S";

        public const String C_DIFERENCIAL = "cDerivada";
        public const String N_DIFERENCIAL = "dS/dt";

        public const String C_PROXIMO_VALOR = "cProximoValor";
        public const String N_PROXIMO_VALOR = "S(i+1)";
    }
}
