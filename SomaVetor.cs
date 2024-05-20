using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SomaVetor
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num;
            double soma, media;

            Console.Write("Quantos numeros voce vai digitar? ");
            num = int.Parse(Console.ReadLine());

            double[] vet = new double[num];
            for (int i = 0; i < num; i++)
            {
                Console.Write("Digite um  numero: ");
                vet[i] = double.Parse(Console.ReadLine());
            }

            Console.Write("VALORES = ");
            for (int i = 0; i < num; i++)
            {
                Console.Write(vet[i].ToString("F1") + " ");
            }

            Console.WriteLine( );
            soma = 0;
            for (int i = 0; i < num; i++)
            {
                soma = soma + vet[i];
            }
            Console.Write("SOMA = " + soma.ToString("F2"));

            Console.WriteLine();
            media = soma / num;
            Console.WriteLine("MEDIA =" + media.ToString("F2"));
        }
    }
}
