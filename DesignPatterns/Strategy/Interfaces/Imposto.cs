using DesignPatterns.Strategy.Entidades;

namespace DesignPatterns.Strategy.Interfaces
{
    public interface Imposto
    {
        decimal Calcular(Orcamento orcamento);
    }
}
