using System;

namespace Aula60Exe100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero");
            int numeroUsuario = int.Parse(Console.ReadLine());

            int[] listaA = new int[numeroUsuario];
            int[] listaB = new int[numeroUsuario];

            int[] listasSomadas = new int[numeroUsuario];

            for (int i = 0; i < numeroUsuario; i++)
            {
                Console.WriteLine($"Informe o  {i+1} numero do primeiro Array ");
                listaA[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < numeroUsuario; i++)
            {
                Console.WriteLine($"Informe o {i+1} numero do segundo Array");
                listaB[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < numeroUsuario; i++)
            {
                listasSomadas[i] = listaA[i] + listaB[i];
            }

            for (int i = 0; i < numeroUsuario; i++)
            {
                Console.WriteLine("Resultado: " + listasSomadas[i]);
            }
            
        }
    }
}
