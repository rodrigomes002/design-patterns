
namespace DesignPatterns
{
    public class ICMS : Imposto
    {
        public double Calcular(Orcamento orcamento)
        {
            return orcamento.Valor * 10 / 100;
        }
    }
}
