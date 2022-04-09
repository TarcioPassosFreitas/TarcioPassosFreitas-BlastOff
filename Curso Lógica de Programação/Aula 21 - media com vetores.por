programa
{
	inclua biblioteca Matematica --> m
	inclua biblioteca Util --> u
	
	funcao inicio()
	{
		real notas[3]
		real soma = 0.0, media = 0.0

		para(inteiro i = 0; i < u.numero_elementos(notas); i++)
		{
			escreva("Digite a nota " + (i + 1) + "\n")
			leia(notas[i])
			soma += notas[i]
		}
		media = soma / u.numero_elementos(notas)

		escreva("A média é: \n", m.arredondar(media, 2))

		

		
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 393; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */