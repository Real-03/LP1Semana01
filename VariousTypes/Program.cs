using System;
using System.Text;
namespace VariousTypes
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int HP = 100;
            uint Number = 23U;

            Console.WriteLine(HP);
            Console.WriteLine(Number);

            char FirstChar = '\u0061';
            char airplaneIcon = '\u2708';
            char sun ='\u2600';

            Console.WriteLine(FirstChar);
            Console.WriteLine(airplaneIcon);
            Console.WriteLine(sun);

            float RealNumber = 3.634f;
            decimal DecimalNumber = 3.42478753235m;
            Console.WriteLine(RealNumber);
            Console.WriteLine(DecimalNumber);


            bool TrueVariable = true;
            bool FalseVariable = false;
            Console.WriteLine(TrueVariable);
            Console.WriteLine(FalseVariable);

        }
    }
}
