using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Entities
{
    internal class Corrente : Conta
    {
        private double mensalidade = 13.75;
        public Corrente(string numero, string agencia, double saldo) 
            : base(numero, agencia, saldo)
        {
        }

        public void DescontaMensalidade()
        {
            double saldoFinal = 0;
            if((this.GetSaldo() - mensalidade) < 0)
            {
                Console.WriteLine("Seu saldo está muito baixo, no momento não conseguimos descontar a mensalidade");
            }
            else
            {
                saldoFinal = this.GetSaldo() - mensalidade;
                this.SetSaldo(saldoFinal);
            }

            Console.WriteLine($"Seu saldo final é: R$: {saldoFinal:F2}");
        }


    }
}
