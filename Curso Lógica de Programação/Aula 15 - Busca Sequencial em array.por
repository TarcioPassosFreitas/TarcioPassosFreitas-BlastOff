programa
{
	inclua biblioteca Util --> u
	
	funcao inicio()
	{
		inteiro vetor[3]
		inteiro contA
		inteiro posicao = 0
		inteiro num
		para (contA = 0; contA < (u.numero_elementos(vetor)); contA++)
		{
			escreva("Digite o número para a posição " + contA + "\n")
			leia(vetor[contA])
		}

		escreva("Digite um numero para pesquisar no array: \n")
		leia(num)

		enquanto ((posicao < 2) e (vetor[posicao] != num))
		{
			posicao++
		}

		se (vetor[posicao] == num)
		{
			escreva("Numero encontrado na posição ", posicao)
		}senao
		{
			escreva("Numero não encontrado no array")
		}
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 390; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */