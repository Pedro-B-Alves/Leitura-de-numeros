using System;

namespace Leitura_de_numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] numeros = new float[15];
            for (var i = 0; i < 15; i++)
            {
                Console.WriteLine($"Digite o {i+1}º número");
                numeros[i] = float.Parse(Console.ReadLine());
            }
            Console.WriteLine("--------------------");
            Console.WriteLine("Números digitados nesta ordem:");
            foreach(float numero in numeros){
                Console.WriteLine(numero);
            }
            Console.WriteLine("A ordem inversa deles seria:");
            for (var i = 14; i >= 0; i=i-1)
            {
                Console.WriteLine(numeros[i]); 
            }
        }
    }
}
