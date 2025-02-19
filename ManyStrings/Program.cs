using System;

namespace ManyStrings
{
    public class Program
    {
        private static void Main(string[] args)
        {

            string  text = "C:\\Teste\\Teste";
            string  text2 = "C:\t Este texto tem um tab";
            Console.WriteLine(text);
            Console.WriteLine(text2);


            string concatnacao = "Isto é fixe "+3;
            string interpolacao = $"valor de x e’ {text}";
            Console.WriteLine(concatnacao);
            Console.WriteLine(interpolacao);
        }
    }
}
