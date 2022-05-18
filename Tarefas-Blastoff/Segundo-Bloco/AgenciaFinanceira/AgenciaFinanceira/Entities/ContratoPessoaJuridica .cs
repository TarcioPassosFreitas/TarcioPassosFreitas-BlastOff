using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaFinanceira.Entities
{
    internal class ContratoPessoaJuridica : Contrato
    {
        private string? Cnpj;
        private string IncricaoEstadual;
        public ContratoPessoaJuridica(int numero, string? contratante, float valor, int prazo, string? cnpj, string incricaoEstadual) 
            : base(numero, contratante, valor, prazo)
        {
            this.Cnpj = cnpj;
            this.IncricaoEstadual = incricaoEstadual;
        }

        public string? GetCnpj()
        {
            return this.Cnpj;
        }

        public string GetIncricaoEstadual()
        {
            return IncricaoEstadual;
        }

        public override float calcularPrestacao()
        {
            return base.calcularPrestacao() + 3;
            
        }

        public override void exibirInfo()
        {
            Console.WriteLine($"O Valor do Contrato é de R$: {base.GetValor():F2}, o prazo é de {base.GetPrazo()}" +
                $" O valor da prestação é R$: {calcularPrestacao():F2}");
        }

        public override float calcularPrestacaoPolimorfico(Contrato contrato)
        {
            return base.calcularPrestacaoPolimorfico(contrato) + 3;
        }
    }
}
