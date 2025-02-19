using System;
using System.Text;
namespace ManyStrings
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            double xx = 1.23456;
            int ii = 19;


            string  text = "C:\\Teste\\Teste";
            string  text2 = "C:\t Este texto tem um tab";
            Console.WriteLine(text);
            Console.WriteLine(text2);


            string concatnacao = "Isto é fixe "+3;
            string interpolacao = $"valor de x e’ {text}";
            Console.WriteLine(concatnacao);
            Console.WriteLine(interpolacao);

            Console.WriteLine($"{xx:f2} e {xx:p}");
            Console.WriteLine($"{ii:x} e {ii:c}");



        }
    }
}
