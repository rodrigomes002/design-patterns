using DesignPatterns.Strategy.Entidades;
using DesignPatterns.Strategy.Interfaces;

namespace DesignPatterns.Strategy
{
    public class CalculadoraDeImpostos
    {
        public decimal Calcular(Orcamento orcamento, Imposto imposto)
        {
            return imposto.Calcular(orcamento);
        }
    }
}
