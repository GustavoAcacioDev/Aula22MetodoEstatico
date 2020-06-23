using System;

namespace Aula22MetodoEstatico
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            Conversor.CotacaoDolarReal = 5.23f;
            System.Console.WriteLine(Conversor.ConverterDolarParReal(200));
            System.Console.WriteLine("---------------------------------------");

            System.Console.WriteLine(Conversor.ConverterRealParaDolar(200));
            System.Console.WriteLine("---------------------------------------");

            System.Console.WriteLine(Conversor.ConverterDolarParaEuro(200));
            System.Console.WriteLine("---------------------------------------");

            System.Console.WriteLine(Conversor.ConverterEuroParaDolar(200));
            System.Console.WriteLine("---------------------------------------");
            
            Console.ResetColor();
        }
    }
}
