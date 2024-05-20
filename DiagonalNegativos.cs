using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagonalNegativos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ordem, negativos;

            Console.Write("Qual a ordem da matriz? ");
            ordem = int.Parse(Console.ReadLine());

            int[,] mat = new int[ordem, ordem];
            for (int i = 0; i < ordem; i++)
            {
                for (int j = 0; j < ordem; j++)
                {
                    Console.Write("Elemento [" + i + ", " + j + "]: ");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }


            Console.WriteLine( );
            Console.WriteLine("DIAGONAL PRINCIPAL: ");
            for (int i = 0; i < ordem; i++)
            {
                Console.Write(mat[i, i] + " "); 
            }


            Console.WriteLine();
            negativos = 0;
            for (int i = 0; i < ordem; i++)
            {
                for (int j = 0; j < ordem; j++)
                {
                  if (mat[i , j] < 0) 
                    {
                        negativos++;
                    }
                }
            }
            Console.WriteLine("QUANTIDADE DE NEGATIVOS: " + negativos);
        }
    }
}
