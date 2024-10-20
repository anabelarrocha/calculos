using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aplicação Cálculos");
            Console.WriteLine("Inserir dados");
            Console.WriteLine("Inserir o primeiro valor");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inserir o segundo valor");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{a} + {b} = {Aritmetica.Somar(a,b)}");
            Console.WriteLine($"{a} - {b} = {Aritmetica.Subtrair(a, b)}");
            Console.WriteLine("\nInserir temperaturas");
            Console.WriteLine("Inserir temperatura em Celsius");
            double c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inserir temperatura em Fahrenheit");
            double d = Convert.ToInt32(Console.ReadLine());
            double t1 = Conversoes.ConverterTemperatura(Conversoes.ConversaoTemperatura.CelsiusFahrenheit, c);
            double t2 = Conversoes.ConverterTemperatura(Conversoes.ConversaoTemperatura.FahrenheitCelsius, d);
            Console.WriteLine($"{c}º Celsius = {t1}º Fahrenheit");
            Console.WriteLine($"{d}º Fahrenheit = {t2}º Celsius");
            Console.ReadKey();
        }
    }
}
