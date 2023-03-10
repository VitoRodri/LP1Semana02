using System;

namespace PerguntaValores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduza a altura:");
            string altura=Console.ReadLine();
            Console.WriteLine("Introduza o raio:");
            string raio=Console.ReadLine();
            float a=float.Parse(altura);
            float r=float.Parse(raio);
            double pi=Math.PI;

            double V=pi*Math.Pow(r,2)*a;
            Console.WriteLine($"O valor do volume é: {V}");

            double S=2*pi*r*(r+a);
            Console.WriteLine($"O valor da area de superficie é: {S}");
        }
    }
}
