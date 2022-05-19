using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciarPagamentos.Entities
{
    internal class Gerente : Funcionario
    {
        private float SenhaEspecial;
        private int QuantidadeFuncionarios;
        
        public Gerente(string nome, string cpf, double salario, float senhaEspecial, int quantidadeFuncionarios) 
            : base(nome, cpf, salario)
        {
            this.SenhaEspecial = senhaEspecial;
            this.QuantidadeFuncionarios = quantidadeFuncionarios;
        }

        public float GetSenhaEspecial()
        {
            return this.SenhaEspecial;
        }

        public int GetQuantidadeFuncionarios()
        {
            return this.QuantidadeFuncionarios;
        }

        
        public override void CalcularBonificacao(Funcionario funcionario)
        {
            funcionario.SetSalario(1.1 * funcionario.GetSalario());
            Console.WriteLine($"A bonificação foi feita ao Gerente {funcionario.GetNome()}");
        }
    }
}
