using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automovel.Entities
{
    internal class Luxo : AutomovelPadrao
    {
        public Luxo(string placa, string modelo, byte combustivel, string cor, short ano) 
            : base(placa, modelo, combustivel, cor, ano)
        {
        }

        public void adicionarArCondicionado()
        {
            SetCusto(GetCusto() + 2000);
            Console.WriteLine($"Valor atual do curso é R$: {GetCusto():F2}");
        }

        public void direcaoHidraulica()
        {
            SetCusto(GetCusto() +1500);
            Console.WriteLine($"Valor atual do curso é R$: {GetCusto():F2}");
        }

        public void vidroEletrico()
        {
            SetCusto(GetCusto() + 800);
            Console.WriteLine($"Valor atual do curso é R$: {GetCusto():F2}");
        }


    }
}
