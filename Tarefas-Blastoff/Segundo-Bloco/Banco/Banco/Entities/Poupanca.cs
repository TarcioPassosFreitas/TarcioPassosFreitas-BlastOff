using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Entities
{
    internal class Poupanca : Conta
    {
        private double rendimento = 0.2;
        private int NMeses = 6;
        public Poupanca(string numero, string agencia, double saldo) 
            : base(numero, agencia, saldo)
        {
        }

        public double GetRentimento()
        {
            return rendimento;
        }

        public int GetNMeses()
        {
            return NMeses;
        }

        public double CalculaRendimento(int nMeses)
        {
            double saldoFinal = 0;
            saldoFinal = this.GetSaldo() + this.GetSaldo() * rendimento * nMeses;
            this.SetSaldo(saldoFinal);
            return saldoFinal;
        }
    }
}
