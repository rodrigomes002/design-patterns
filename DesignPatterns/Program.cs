using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //var orcamento = new Orcamento(54);
            //var calculadora = new CalculadoraDeImpostos();
            //Console.WriteLine(calculadora.Calcular(orcamento, new ICMS()));
            //Console.WriteLine(calculadora.Calcular(orcamento, new ISS()));


            CalculadorDeDescontos calculador = new CalculadorDeDescontos();

            Orcamento orcamento = new Orcamento(500.0);
            orcamento.AdicionaItem(new Item("CANETA", 250));
            orcamento.AdicionaItem(new Item("LAPIS", 250));

            double desconto = calculador.Calcula(orcamento);
            Console.WriteLine(desconto);
            Console.ReadKey();
        }
    }
}
