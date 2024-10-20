
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
    class Aritmetica
    {
     /// <summary>
     /// Tipo de connversão de temperatura a executar.
     /// </summary>
        public enum ConversaoTemperatura
        {
            Nulo = 0,
            CelsiusFahrenheit,
            FahrenheitCelsius
        }
        ///<summary>
        ///Operação soma.
        ///</summary>
        ///<return>Retorna a soma de dois números.</return>
        public int Somar(int x, int y)
        {
            return x + y;
        }
        /// <summary>
        /// Operação subtração.
        /// </summary>
        /// <returns>Retorna o resultado da subtração entre dois números.</returns>
        public int Subtrair(int x, int y)
        {
            return x - y;
        }
        public double ConverterTemperatura(ConversaoTemperatura conversao, double temperatura)
        {
            if (conversao == ConversaoTemperatura.CelsiusFahrenheit)
            {
                return (temperatura * 1.8000 + 32);
            }
            else if (conversao == ConversaoTemperatura.FahrenheitCelsius)
            {
                return ((temperatura + 32) / 1.8000);
            }
            return -1;
        }
    }
}
