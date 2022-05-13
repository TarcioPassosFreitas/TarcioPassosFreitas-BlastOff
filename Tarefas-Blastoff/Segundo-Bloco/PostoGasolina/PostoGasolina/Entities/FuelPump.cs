using PostoGasolina.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PostoGasolina.Entities
{
    internal class FuelPump
    {
        private TypePump typePump;
        private double valorLitro = 5.00;
        private double quantidadeCombustivel = 10000.00;
        double quantidadeLitros = 1;

        public TypePump GetTypePump()
        {
            return this.typePump;
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
            Console.WriteLine($"A quantidade de litros correspondente a R$: {valorReais:F2} de {this.typePump} é de {quantidadeLitros:F2} Litros");
            alterarQuantidadeCombustivel(quantidadeLitros);
        }

        //método onde é informado a quantidade em litros de combustível e mostra o valor a ser pago pelo cliente
        public void abastecerPorLitro(double litro)
        {
            this.quantidadeLitros = litro;
            double litrosEmReais = (valorLitro * this.quantidadeLitros);
            Console.WriteLine($"Para abastecer {this.quantidadeLitros:F2} litros de {this.typePump} o valor é de R$: {litrosEmReais:F2} ");
            alterarQuantidadeCombustivel(this.quantidadeLitros);

        }

        //altera o valor do litro do combustível
        public void alterarValor(double novoValorLitro)
        {
            this.valorLitro = novoValorLitro;
            Console.WriteLine("O valorLitro foi atualizado");
        }

        //Inserir tipo do combustível
        public void InserirCombustivel(TypePump tp)
        {
            this.typePump = tp;
        }
        //Inserir valor 

        //altera o tipo do combustível
        public void alterarCombustivel(TypePump novoValor)
        {
            TypePump aux = this.typePump;
            this.typePump = novoValor;
            Console.WriteLine($"O tipo de combustível, foi alterado de {aux} para {this.typePump}");
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
