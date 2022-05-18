using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaFinanceira.Entities
{
    internal class ContratoPessoaFisica : Contrato
    {
        private string Cpf;
        private int Idade;
        public ContratoPessoaFisica(int numero, string? contratante, float valor, int prazo, string cpf, int idade) 
            : base(numero, contratante, valor, prazo)
        {
            this.Cpf = cpf;
            this.Idade = idade;
        }

        public string GetCpf()
        {
            return this.Cpf;
        }

        public int GetIdade()
        {
            return this.Idade;
        }

        public override float calcularPrestacao()
        {
            
            if(this.Idade <= 30)
            {
                return base.calcularPrestacao() + 1;
            }else if(this.Idade <= 40)
            {
                return base.calcularPrestacao() + 2;
            }else if(this.Idade <= 50)
            {
                return base.calcularPrestacao() + 3;
            }
            else
            {
                return base.calcularPrestacao() + 4;
            }
        }

        public override void exibirInfo()
        {
            Console.WriteLine($"O Valor do Contrato é de R$: {base.GetValor():F2}, o prazo é de {base.GetPrazo()}" +
                $" O valor da prestação é R$: {calcularPrestacao():F2} e a Idade do contratante é {this.Idade} anos");
        }

        public override float calcularPrestacaoPolimorfico(Contrato contrato)
        {
            if (this.Idade <= 30)
            {
                return base.calcularPrestacaoPolimorfico(contrato) + 1;
            }
            else if (this.Idade <= 40)
            {
                return base.calcularPrestacaoPolimorfico(contrato) + 2;
            }
            else if (this.Idade <= 50)
            {
                return base.calcularPrestacaoPolimorfico(contrato) + 3;
            }
            else
            {
                return base.calcularPrestacaoPolimorfico(contrato) + 4;
            }
           
        }
    }
}
