using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Entities
{
    internal class IngressoVip : Ingresso
    {
        private double porcentagemVip = 1.5;
        public IngressoVip() 
            : base()
        {
        }

        public double GetPorcentagemVip()
        {
            return porcentagemVip;
        }

        public double ValorIngressoVip()
        {
            return this.GetValor() * this.porcentagemVip;
        }

        public void ImprimeIngressoVip()
        {
            Console.WriteLine($"O valor do ingresso Vip é de R$: {ValorIngressoVip():F2}");
        }


    }
}
