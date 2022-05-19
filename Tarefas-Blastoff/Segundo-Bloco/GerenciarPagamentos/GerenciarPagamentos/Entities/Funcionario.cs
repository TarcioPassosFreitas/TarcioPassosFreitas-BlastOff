using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciarPagamentos.Entities
{
    internal class Funcionario
    {
        private string Nome;
        private string Cpf;
        private double Salario;

        public Funcionario(string nome, string cpf, double salario)
        {
            Nome = nome;
            Cpf = cpf;
            Salario = salario;
        }

        public string GetNome()
        {
            return Nome;
        }

        public string GetCpf()
        {
            return Cpf;
        }

        public double GetSalario()
        {
            return Salario;
        }

        public void SetSalario(double salario)
        {
            this.Salario = salario;
        }

        public virtual void CalcularBonificacao(Funcionario funcionario)
        {
            Console.WriteLine("O funcionário não pode receber bonificação no momento, mas quem sabe no futuro." +
                "Trabalhe bastante e conquiste. Plus Ultra!!!!");
        }
    }
}
