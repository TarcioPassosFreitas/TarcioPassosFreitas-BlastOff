programa
{
	
	funcao inicio()
	{
		inteiro i

		para (i = 1; i <= 10; i++)
		{
			escreva("O valor da base ao cubo é: ", cubo(i) + "\n")
		}

		 
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
 * @POSICAO-CURSOR = 140; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */