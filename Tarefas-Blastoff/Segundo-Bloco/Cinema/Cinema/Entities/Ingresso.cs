using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Entities
{
    internal class Ingresso
    {
        private double valor = 15.00;

        public Ingresso()
        {
            
        }

        public double GetValor()
        {
            return valor;
        }

        public void SetValor(double valor)
        {
            this.valor = valor;
        }

        public void ImprimeValor()
        {
            Console.WriteLine($"O valor do ingresso é de R$: {this.valor:F2}");
        }
    }
}
