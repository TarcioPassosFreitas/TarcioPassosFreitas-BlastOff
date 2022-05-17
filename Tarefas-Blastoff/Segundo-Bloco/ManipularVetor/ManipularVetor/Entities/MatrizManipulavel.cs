using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipularVetor.Entities
{
    internal class MatrizManipulavel
    {
        int[,] matriz = new int[3, 4];
        private Random random = new Random();

        public MatrizManipulavel()
        {

        }

        public int[,] GetMatriz()
        {
            return matriz;
        }

        public void GerarMatrizAleatoria()
        {
            for (int linha = 0; linha < 3; linha++)
            {
                for (int coluna = 0; coluna < 4; coluna++)
                {
                    matriz[linha, coluna] = random.Next(0, 50);
                }
            }
        }

        public void SomarNumerosMatriz()
        {
            int numeros = 0;
            for (int linha = 0; linha < 3; linha++)
            {
                for (int coluna = 0; coluna < 4; coluna++)
                {
                    numeros += matriz[linha, coluna];
                }
            }

            Console.WriteLine($"A soma de todos os números da matríz é de: {numeros}");
        }

        public void MenorEMaiorValor()
        {
            int menorValor = matriz[0, 0];
            int maiorValor = matriz[0, 0];
            for (int linha = 0; linha < 3; linha++)
            {
                for (int coluna = 0; coluna < 4; coluna++)
                {
                    if(menorValor > matriz[linha, coluna])
                    {
                        menorValor = matriz[linha, coluna];
                    }
                    if(maiorValor < matriz[linha, coluna])
                    {
                        maiorValor = matriz[linha, coluna];
                    }
                }
            }

            Console.WriteLine($"O maior valor é {maiorValor} e o menor valor é {menorValor}");
        }

        public void MediaValoresMatriz()
        {
            double media = 0;
            int soma = 0;
            int dividendo = 12;

            for (int linha = 0; linha < 3; linha++)
            {
                for (int coluna = 0; coluna < 4; coluna++)
                {
                    soma += matriz[linha, coluna];
                }
            }

            media = soma / dividendo;

            Console.WriteLine($"A media dos valores da matriz é de {media}");
        }


    }
}
