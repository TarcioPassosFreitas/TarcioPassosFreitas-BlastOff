using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaFinanceira.Entities
{
    internal abstract class Contrato
    {
        private int Numero;
        private string? Contratante;
        private float Valor;
        private int Prazo;

        public Contrato(int numero, string? contratante, float valor, int prazo)
        {
            Numero = numero;
            Contratante = contratante;
            Valor = valor;
            Prazo = prazo;
        }

        public int GetNumero()
        {
            return Numero;
        }

        public string? GetContratante()
        {
            return Contratante;
        }

        public float GetValor()
        {
            return Valor;
        }

        public int GetPrazo()
        {
            return Prazo;
        }

        public virtual float calcularPrestacao()
        {
            return Valor / Prazo;
            
        }

        public virtual void exibirInfo()
        {
            Console.WriteLine($"O Valor do Contrato é de R$: {Valor:F2}, o prazo é de {Prazo}" +
                $" O valor da prestação é R$: {calcularPrestacao():F2}");
        }

        public virtual float calcularPrestacaoPolimorfico(Contrato contrato)
        {
            return contrato.GetValor() /contrato.GetPrazo();
        }
    }
}
