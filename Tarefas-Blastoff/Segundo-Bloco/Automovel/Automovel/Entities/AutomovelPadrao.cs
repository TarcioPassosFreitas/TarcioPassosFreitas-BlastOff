using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automovel.Entities
{
    internal class AutomovelPadrao
    {
        private string Placa;
        private string Modelo;
        private byte Combustivel;
        private string Cor;
        private short Ano;
        private double Custo;

        public static byte GASOLINA = 1;
        public static byte ALCOOL = 2;
        public static byte DIESEL = 3;
        public static byte GAS = 4;





        public AutomovelPadrao(string placa, string modelo, byte combustivel, string cor, short ano)
        {
            this.Placa = placa;
            this.Modelo = modelo;
            this.Combustivel = combustivel;
            this.Cor = cor;
            this.Ano = ano;
        }

        public string GetPlaca()
        {
            return Placa;
        }
        public string GetModelo()
        {
            return Modelo;
        }
        public byte GetCombustivel()
        {
            return Combustivel;
        }

        public string GetCor()
        {
            return Cor;
        }

        public short GetAno()
        {
            return Ano;
        }

        public double GetCusto()
        {
            return Custo;
        }

        public void SetCusto(double custo)
        {
            this.Custo = custo;
        }

        public void QuantoCusta()
        {
            if(Combustivel == GASOLINA)
            {
                Custo = 12000;
                Console.WriteLine($"A Gasolina custa R$: {Custo:F2}");
            }else if(Combustivel == ALCOOL)
            {
                Custo = 10500;
                Console.WriteLine($"A ALCOOL custa R$: {Custo:F2}");
            }
            else if(Combustivel == DIESEL)
            {
                Custo = 11000;
                Console.WriteLine($"A DIESEL custa R$: {Custo:F2}");
            }
            else if (Combustivel == GAS)
            {
                Custo = 13000;
                Console.WriteLine($"A GAS custa R$: {Custo:F2}");
            }
        }
    }
}
