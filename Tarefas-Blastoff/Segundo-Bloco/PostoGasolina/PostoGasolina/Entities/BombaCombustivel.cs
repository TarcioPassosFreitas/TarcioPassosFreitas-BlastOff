using PostoGasolina.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PostoGasolina.Entities
{
    internal class BombaCombustivel
    {
        private TipoBomba tipoBomba;
        private double valorLitro = 5.00;
        private double quantidadeCombustivel = 10000.00;
        double quantidadeLitros = 1;



        public TipoBomba GetTypePump()
        {
            return this.tipoBomba;
        }

        public double GetValorLitro()
        {
            return this.valorLitro;
        }

        public double GetQuantidadeCombustivel()
        {
            return this.quantidadeCombustivel;
        }

        //método onde é informado o valor a ser abastecido e mostra a quantidade de litros que foi colocada no veículo
        public void abastecerPorValor(double valorReais)
        {
            this.quantidadeLitros = (valorReais / valorLitro);
            Console.WriteLine($"A quantidade de litros correspondente a R$: {valorReais:F2} de {this.tipoBomba} é de {quantidadeLitros} Litros");
            alterarQuantidadeCombustivel(quantidadeLitros);
        }

        //método onde é informado a quantidade em litros de combustível e mostra o valor a ser pago pelo cliente
        public void abastecerPorLitro(double litro)
        {
            double litrosEmReais = (valorLitro * litro);
            Console.WriteLine($"Para abastecer {litro:F2} litros de {this.tipoBomba} o valor é de R$: {litrosEmReais:F2} ");
            alterarQuantidadeCombustivel(litro);

        }

        //altera o valor do litro do combustível
        public void alterarValor(double novoValorLitro)
        {
            this.valorLitro = novoValorLitro;
            Console.WriteLine("O valorLitro foi atualizado");
        }

        //Inserir tipo do combustível
        public void InserirCombustivel(TipoBomba tp)
        {
            this.tipoBomba = tp;
        }
        //Inserir valor 

        //altera o tipo do combustível
        public void alterarCombustivel(TipoBomba novoValor)
        {
            TipoBomba aux = this.tipoBomba;
            this.tipoBomba = novoValor;
            Console.WriteLine($"O tipo de combustível, foi alterado de {aux} para {this.tipoBomba}");
        }

        // altera a quantidade de combustível restante na bomba
        // A cada abastecimento dos carros
        public void alterarQuantidadeCombustivel(double litro)
        {
            this.quantidadeCombustivel = (this.quantidadeCombustivel - litro);
        }

        // Caminhão com mais combustível para o posto
        public void alterarQuantidadeCombustivelPosto(double litroPosto)
        {
            this.quantidadeCombustivel = (this.quantidadeCombustivel + litroPosto);
        }

        

    }
}
