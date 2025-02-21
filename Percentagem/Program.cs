using System;

namespace Percentagem
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int contador = 0;
            float number1, number2,number3,number4;
            Console.WriteLine("Introduza 4 numeros reais entre 0 e 1");

            number1 = Convert.ToSingle(Console.ReadLine());
            number2 = Convert.ToSingle(Console.ReadLine());
            number3 = Convert.ToSingle(Console.ReadLine());
            number4 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine($"{number1,-5:p2}");
            Console.WriteLine($"{number2,-5:p2}");
            Console.WriteLine($"{number3,-5:p2}");
            Console.WriteLine($"{number4,-5:p2}");

        }
    }
}
