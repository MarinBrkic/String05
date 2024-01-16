using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite jedan cijeli i jedan decimalni broj i razdvojite ih razmakom:");
            string unos = Console.ReadLine();
            string[] brojevi = unos.Split(' ');

            int x = int.Parse(brojevi[0]);
            float y = float.Parse(brojevi[1]);
            x = x * 2;
            y = y * 2;

            Console.WriteLine("Cijeli: " + x);
            Console.WriteLine("Decimalni: " + y);

            Console.ReadKey();
        }
    }
}
