using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Entities
{
    internal class IngressoNormal : Ingresso
    {
        public IngressoNormal() 
            : base()
        {
        }

        public void ImprimeIngressoNormal()
        {
            Console.WriteLine($"O valor do ingresso normal é de R$: {this.GetValor():F2}");
        }
    }
}
