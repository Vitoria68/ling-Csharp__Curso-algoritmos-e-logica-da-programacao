using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crescente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;

            Console.WriteLine("Digite dois numeros: ");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            while (x != y)
            {
                if (x > y)
                {
                    Console.WriteLine("DECRESCENTE!");
                }
                else if (y > x)
                {
                    Console.WriteLine("CRESCENTE!");
                }
              
                Console.WriteLine("Digite outros dois numeros: ");
                x = int.Parse(Console.ReadLine());
                y = int.Parse(Console.ReadLine());
            }
        }
    }
}
