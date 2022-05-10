using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Entities
{
    internal class AutenticarAdm : Ingresso
    {
        private string Id = "22A3249k";
        private string Senha = "BokuNoHero";

        public void Autenticando(string id, string senha)
        {
            if(this.Id.Equals(id) && this.Senha.Equals(senha))
            {
                Console.Clear();
                Console.WriteLine("você está logado. Bem-vindo ADM!");
                double valor;
                bool possivel;
                Console.WriteLine("Digite um valor para substituir o atual:");
                possivel = double.TryParse(Console.ReadLine(), out valor);
                if (!possivel || valor > 30 || valor < 5)
                {
                    Console.Clear();
                    System.Console.WriteLine("É aqui?"); //Insira o valor no intervalo indicado
                    Thread.Sleep(1000);
                    EntradaDeDados();
                }
                else
                {
                    AlterarValorTabelado(valor);
                }
                
            }
            else
            {
                Console.WriteLine("Você não é um ADM, volte para seu lugar.");
                
            }
        }

        public void AlterarValorTabelado(double valor)
        {
             this.SetValor(valor);
        }

        public void EntradaDeDados()
        {
            Console.Clear();
            Console.WriteLine("Para utilizar as funcionalidade como ADM, é necessário que você seja Autenticado pelo sistema");

            Console.WriteLine("Entre com o id do usuário");
            string id = "";
            id = Console.ReadLine();

            Console.WriteLine("Entre com a senha");
            string senha = "";
            senha = Console.ReadLine();

            Autenticando(id, senha);
        }
    }
}
