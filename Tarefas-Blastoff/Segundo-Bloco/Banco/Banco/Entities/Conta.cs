using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Entities
{
    internal class Conta
    {
        private string Numero;
        private string Agencia;
        private double Saldo;

        public Conta(string numero, string agencia, double saldo)
        {
            this.Numero = numero;
            this.Agencia = agencia;
            this.Saldo = saldo;  
        }

        public string GetNumero()
        {
            return this.Numero;
        }

        public string GetAgencia()
        {
            return Agencia;
        }

        public double GetSaldo()
        {
            return Saldo;
        }

        public void SetSaldo(double saldo)
        {
            this.Saldo = saldo;
        }
    }
}
