using System.Linq;

namespace DesignPatterns
{
    public class DescontoPorVendaCasada : Desconto
    {
        public Desconto Proximo { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            if (this.Existe(orcamento))
            {
                return orcamento.Valor * 0.05;
            }
            else
            {
                return Proximo.Desconta(orcamento);
            }
        }

        private bool Existe(Orcamento orcamento)
        {
            string[] nomes = new string[] { "LAPIS", "CANETA" };
            if (orcamento.Itens.Any(item => nomes.Contains(item.Nome)))
                return true;

            return false;
        }
    }
}
