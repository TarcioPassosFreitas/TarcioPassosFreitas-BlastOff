using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipularVetor.Entities
{
    internal class Pessoa
    {
        private string Name;
        private string Endereco;
        private string Telefone;
        private int Idade;
        private double Altura;

        public Pessoa(string name, string endereco, string telefone, int idade, double altura)
        {
            this.Name = name;
            this.Endereco = endereco;
            this.Telefone = telefone;
            this.Idade = idade;
            this.Altura = altura;
        }
        public string GetName()
        {
            return Name;
        }

        public string GetEndereco()
        {
            return Endereco;
        }

        public string GetTelefone()
        {
            return Telefone;
        }

        public int GetIdade()
        {
            return Idade;
        }

        public double GetAltura()
        {
            return Altura;
        }

        public void ImprimirMensagem(string mensagem)
        {
            Console.WriteLine(mensagem);
        }
    }
}
