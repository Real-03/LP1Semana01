using System;

namespace AskForInput
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int UserNumberInt;
            float UserNumberFloat;
            Console.WriteLine("Introduza 1 numero inteiro");
            UserNumberInt=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduza 1 numero real");
            UserNumberFloat=Convert.ToSingle(Console.ReadLine());

            Console.WriteLine($"{UserNumberInt} mais {UserNumberFloat} é igual a {UserNumberInt + UserNumberFloat}");
        }
    }
}
