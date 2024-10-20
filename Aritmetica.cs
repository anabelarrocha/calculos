
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    ///<summary>
    ///Implementação de operações aritméticas.
    ///</summary
    static class Aritmetica
    {
    
        ///<summary>
        ///Operação soma.
        ///</summary>
        ///<return>Retorna a soma de dois números.</return>
        public static int Somar(int x, int y)
        {
            return x + y;
        }
        /// <summary>
        /// Operação subtração.
        /// </summary>
        /// <returns>Retorna o resultado da subtração entre dois números.</returns>
        public static int Subtrair(int x, int y)
        {
            return x - y;
        }
        /// <summary>
        /// Operação multiplicação.
        /// </summary>
        /// <returns>Retorna o resultado da multiplicação de dois números.</returns>
        public static int Multiplicar(int x, int y)
        {
            return x * y;
        }
    }
}
