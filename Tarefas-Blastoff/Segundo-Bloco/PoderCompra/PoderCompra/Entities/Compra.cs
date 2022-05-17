using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoderCompra.Entities
{
    internal class Compra
    {
        private double Preco;
        private int Parcelas;
        private string Tipo;

        public Compra(double preco, int parcelas, string tipo)
        {
            this.Preco = preco;
            this.Parcelas = parcelas;
            this.Tipo = tipo;
        }

        public double GetPreco()
        {
            return Preco;
        }
        public void SetPreco(double preco)
        {
            this.Preco=preco;
        }

        public int GetParcelas()
        {
            return Parcelas;
        }
        public void SetParcelas(int parcelas)
        {
            this.Parcelas =parcelas;
        }
        public string GetTipo()
        {
            return Tipo;
        }

        public virtual void PagarParcela()
        {
            Parcelas--;
        }

        public virtual void QuitarCompra()
        {
            Parcelas = 0;
        }

        public void CancelarCompra()
        {
            Console.WriteLine("A compra foi cancelada!!!!");
            Parcelas = 0;
        }

        public void atualizarParcela(int parcelas, double taxaJuros)
        {
            this.Parcelas = parcelas;
            double precoFinal = (Preco + (Preco * taxaJuros * parcelas));
            Preco = precoFinal;
            Console.WriteLine($"O valor final é {Preco:F2}");
        }
    }
}
