
namespace DesignPatterns
{
    public class CalculadoraDeImpostos
    {
        public double Calcular(Orcamento orcamento, Imposto imposto)
        {
            return imposto.Calcular(orcamento);
        }
    }
}
