using DesignPatterns.Strategy;
using DesignPatterns.Strategy.Entidades;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var orcamento = new Orcamento(54);
            var calculadora = new CalculadoraDeImpostos();
            Console.WriteLine(calculadora.Calcular(orcamento, new ICMS()));
            Console.WriteLine(calculadora.Calcular(orcamento, new ISS()));
        }
    }
}
