programa
{
	
	funcao inicio()
	{
		real n1, n2
		real media

		escreva("Digite o valor da nota 1! \n")
		leia(n1)
		escreva("Digite o valor da nota 2! \n")
		leia(n2)

		media = ((n1 + n2) / 2)

		se (media >= 7)
		{
			escreva("foi aprovado \n")
			se ( media == 10)
			{
				escreva("Parabéns, você foi aprovado com louvor")
			}
		} senao
		{
			se (media >= 4.5 e media < 7)
			{
				escreva("Você está de recuperação")
			}senao
			{
				escreva("Você foi reprovado")
			}
		}
		
		
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 249; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */