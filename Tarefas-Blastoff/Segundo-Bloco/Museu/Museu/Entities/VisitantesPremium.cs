using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museu.Entities
{
    internal class VisitantesPremium : Visitantes
    {
        private int NumeroVale = new Random().Next();
        private double Vale_refeicao = 100.00;
        public VisitantesPremium(string nome, string cpf, DateTime dataNascimento, byte codTema) 
            : base(nome, cpf, dataNascimento, codTema)
        {
        }

        public int GetNumeroVale()
        {
            return NumeroVale;
        }
        public double Saldo()
        {
            return Vale_refeicao;
        }

        public void Gastar(double valor)
        {
            if(valor > Vale_refeicao)
            {
                Console.WriteLine("Não é possível comprar mais");
            }
            else
            {
                Vale_refeicao = Vale_refeicao - valor;
            }
            
        }

    }
}
