using DesignPatterns.Strategy.Interfaces;

namespace DesignPatterns.Strategy.Entidades
{
    public class ISS : Imposto
    {
        public decimal Calcular(Orcamento orcamento)
        {
            return orcamento.Valor * 5 / 100;
        }
    }
}
