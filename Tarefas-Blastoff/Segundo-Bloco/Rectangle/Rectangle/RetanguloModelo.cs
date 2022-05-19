using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    internal class RetanguloModelo
    {
        private double Comprimento;
        private double Largura;

        private double ComprimentoPiso;
        private double LarguraPiso;


        public RetanguloModelo(double comprimento, double largura, double comprimentoPiso, double larguraPiso)
        {
            this.Comprimento = comprimento;
            this.Largura = largura;
            this.ComprimentoPiso = comprimentoPiso;
            this.LarguraPiso = larguraPiso;
        }

        public void Setcomprimento(double comprimento)
        {
            Comprimento = comprimento;
        }

        public void Setlargura(double largura)
        {
            Largura = largura;
        }

        public double Getcomprimento()
        {
            return this.Comprimento;
        }

        public double Getlargura()
        {
            return this.Largura;
        }

        public double GetcomprimentoPiso()
        {
            return this.ComprimentoPiso;
        }

        public double GetlarguraPiso()
        {
            return this.LarguraPiso;
        }

        public double CalculateArea()
        {
            return (this.Comprimento * this.Largura);
        }

        public double CalculatePremeter()
        {
            return ((2 * this.Comprimento) + (2 * this.Largura));
        }

        public double CalcularAreaPiso()
        {
            return (this.ComprimentoPiso * this.LarguraPiso);
        }

        public void QuantidadePisos()
        {
            double resultado = Math.Ceiling(CalculateArea() / CalcularAreaPiso());
            Console.WriteLine($"A quantidade de piso necessário é {resultado}");
        }

        public void QuantidadeRodapes()
        {
            double resultado = Math.Ceiling((CalculateArea() / CalcularAreaPiso()) * 0.1 );
            Console.WriteLine($"A quantidade de piso necessário para o rodapé é {resultado}");
        }


    }
}
