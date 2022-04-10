programa
{
	inclua biblioteca Util --> u
	
	funcao inicio()
	{
		inteiro num, num_aleatorio
		inteiro resultado
		cadeia texto

		escreva("Digite um número: \n")
		leia(num)

		escreva("Número escolhido pelo computador: \n")
		num_aleatorio = u.sorteia(0, 10)

		resultado = num * num_aleatorio

		escreva("O produto dos número é: ", resultado + "\n")
		
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 355; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */