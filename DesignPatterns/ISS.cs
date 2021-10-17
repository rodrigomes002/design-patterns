
namespace DesignPatterns
{
    public class ISS : Imposto
    {
        public double Calcular(Orcamento orcamento)
        {
            return orcamento.Valor * 5 / 100;
        }
    }
}
