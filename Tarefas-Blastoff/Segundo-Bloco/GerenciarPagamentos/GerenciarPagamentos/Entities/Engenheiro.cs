using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciarPagamentos.Entities
{
    internal class Engenheiro : Funcionario
    {
        private string Crea;
        private string Categoria;
        private string ProjetoAtual;
        public Engenheiro(string nome, string cpf, double salario, string crea, string categoria, string projetoAtual)
            : base(nome, cpf, salario)
        {
            this.Crea = crea;
            this.Categoria = categoria;
            this.ProjetoAtual = projetoAtual;
        }

        public string GetCrea()
        {
            return Crea;
        }

        public string GetCategoria()
        {
            return Categoria;
        }

        public string GetProjetoAtual()
        {
            return ProjetoAtual;
        }
        
        public override void CalcularBonificacao(Funcionario funcionario)
        {
            funcionario.SetSalario(1.05 * funcionario.GetSalario());
            Console.WriteLine($"A bonificação foi feita ao Engenheiro {funcionario.GetNome()}");
        }
    }
}
