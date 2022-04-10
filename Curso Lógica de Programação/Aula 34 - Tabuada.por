programa
{
	
	funcao inicio()
	{
		inteiro num, cont
		caracter continua = 's'

		escreva("Entre com o número para mostrar sua tabuada: \n")
		leia(num)


		enquanto (continua == 's')
		{
			para (cont = 1; cont <= 10; cont++)
			{
			escreva(cont, " x ", num, " = ", cont * num + "\n") 
			}

			escreva("Deseja continuar? tecle 's' para sim e 'n' para não \n")
			leia(continua)
		}
		
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 385; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */