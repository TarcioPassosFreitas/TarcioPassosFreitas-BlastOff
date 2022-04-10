programa
{
	
	funcao inicio()
	{
		inteiro M[3][2]
		inteiro linha, coluna

		para (linha = 0; linha < 3; linha++)
		{
			para (coluna = 0; coluna < 2; coluna++)
			{
				escreva("Entre com um número \n")
				leia(M[linha][coluna])
			}
		}

		escreva("Os valores do vetor são: \n")

		para (linha = 0; linha < 3; linha++)
		{
			escreva("\n")
			para (coluna = 0; coluna < 2; coluna++)
			{
				
				escreva(M[linha][coluna] + " ")
			}
		}
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 205; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */