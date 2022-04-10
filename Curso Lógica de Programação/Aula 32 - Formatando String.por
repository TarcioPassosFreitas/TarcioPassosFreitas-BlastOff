programa
{
	inclua biblioteca Texto --> t
	
	funcao inicio()
	{
		cadeia valor
		cadeia convertida
		inteiro tamanho, posicao
		caracter letra

		escreva("Digite uma palavra qualquer: \n")
		leia(valor)
		convertida = t.caixa_alta(valor)

		escreva(convertida + "\n")

		convertida = t.caixa_baixa(valor)

		escreva(convertida + "\n")

		convertida = t.extrair_subtexto(valor, 1, 5)

		escreva(convertida + "\n")

		tamanho = t.numero_caracteres(valor)

		escreva(tamanho + "\n")

		letra = t.obter_caracter(valor, 5)

		escreva(letra + "\n")

		posicao = t.posicao_texto(valor, "tar", 4)

		escreva(posicao)

		
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 590; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */