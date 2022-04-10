programa
{
	inclua biblioteca Texto --> t
	
	funcao inicio()
	{
		cadeia data, dia, mes, ano

		escreva("Digite a data no formato dd/mm/aaaa: \n")
		leia(data)
		dia = t.extrair_subtexto(data, 0, 2)
		mes = t.extrair_subtexto(data, 3, 5)
		ano = t.extrair_subtexto(data, 8, 10)

		escreva(dia, mes, ano)
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 310; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */