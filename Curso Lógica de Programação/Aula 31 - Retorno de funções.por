programa
{
	
	funcao inicio()
	{
		inteiro n

		escreva("Digite um valor para a base: \n")
		leia(n)

		escreva("O valor da base ao cubo é: ", cubo(n)) 

		
	}

	funcao inteiro cubo(inteiro x)
	{
		inteiro resultado

		resultado = x * x * x

		retorne resultado
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 154; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */