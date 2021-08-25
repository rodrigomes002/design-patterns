using DesignPatterns.Strategy.Interfaces;

namespace DesignPatterns.Strategy.Entidades
{
    public class ICMS : Imposto
    {
        public decimal Calcular(Orcamento orcamento)
        {
            return orcamento.Valor * 10 / 100;
        }
    }
}
