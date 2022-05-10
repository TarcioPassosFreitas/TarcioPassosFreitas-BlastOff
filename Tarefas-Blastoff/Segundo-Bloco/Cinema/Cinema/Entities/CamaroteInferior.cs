using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Entities
{
    internal class CamaroteInferior : IngressoVip
    {
        private string Localizacao;
        private double PorcentagemInferior = 1.7;

        public CamaroteInferior(string Localizacao) 
            : base()
        {
            this.Localizacao = Localizacao;
        }

        public string GetLocalizacao()
        {
            return Localizacao;
        }

        public double GetPorcentagemInferior()
        {
            return PorcentagemInferior;
        }

        public double ValorIngressoCamaroteInferior()
        {
            return this.GetValor() * this.PorcentagemInferior;
        }

        public void ImprimeIngressoCamaroteInferior()
        {
            Console.WriteLine($"O valor do ingresso do camarote inferior é de R$: {ValorIngressoCamaroteInferior():F2} " +
                $"E tem localização em {this.Localizacao}");
        }
    }
}
