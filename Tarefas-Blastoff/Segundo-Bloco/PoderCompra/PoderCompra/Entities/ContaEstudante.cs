using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoderCompra.Entities
{
    internal class ContaEstudante : Compra
    {
        public ContaEstudante(double preco, int parcelas, string tipo) 
            : base(preco, parcelas, tipo)
        {
        }

        public override void PagarParcela()
        {
            base.SetParcelas(base.GetParcelas() - 1);
        }

        public override void QuitarCompra()
        {
            base.SetParcelas(0);
        }

        public void Valores(Object valor)
        {
            if(valor.GetType() == typeof(Compra))
            {
                Console.WriteLine($"O preço é {base.GetPreco} e as parcelas {base.GetParcelas}");
            }else if (valor.GetType() == typeof(ContaEstudante))
            {
                base.SetPreco(base.GetPreco() / 2);
                base.SetParcelas(base.GetParcelas() / 2);
                Console.WriteLine($"O preço é {base.GetPreco} e as parcelas {base.GetParcelas}");
            }
        }
    }
}
