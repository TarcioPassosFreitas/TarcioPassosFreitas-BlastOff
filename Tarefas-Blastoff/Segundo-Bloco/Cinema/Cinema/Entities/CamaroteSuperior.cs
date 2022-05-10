using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Entities
{
    internal class CamaroteSuperior : IngressoVip
    {
        private string Localizacao;
        private double PorcentagemSuperior = 1.9;

        public CamaroteSuperior(string localizacao)
            : base()
        {
            this.Localizacao = localizacao;
        }

        public string GetLocalizacao()
        {
            return Localizacao;
        }

        public double GetPorcentagemSuperior()
        {
            return PorcentagemSuperior;
        }

        public double ValorIngressoCamaroteSuperior()
        {
            return this.GetValor() * this.PorcentagemSuperior;
        }

        public void ImprimeIngressoCamaroteSuperior()
        {
            Console.WriteLine($"O valor do ingresso do camarote Superior é de R$: {ValorIngressoCamaroteSuperior():F2} " +
                $"E tem localização em {this.Localizacao}");

        }
    }
}
