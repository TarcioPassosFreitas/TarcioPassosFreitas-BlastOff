programa
{
	
	funcao inicio()
	{
		inteiro quantidade_numero, contador
		inteiro anterior = 0, atual = 1, proximo = 1

		escreva("Digite a quantidade de numeros desejados: \n")
		leia(quantidade_numero)

		para (contador = 1; contador < quantidade_numero; contador++)
		{
			escreva(proximo)
			proximo = atual + anterior
			anterior = atual
			atual = proximo
		}

		
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 365; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */