programa
{
	inclua biblioteca Matematica --> mat
	
	funcao inicio()
	{

		cadeia nome_funcionario
		inteiro quantidade_software
		real salario_total

		
		escreva("Seja bem-vindo ao sistema de monitoramento de funcionários manual \n")
		escreva("Digite o nome do funcionário: \n")
		leia(nome_funcionario)
		escreva("Digite a quantidade de software que foi vendido pelo funcionário: \n")
		leia(quantidade_software)

		salario_total = 50.0 * quantidade_software

		escreva("O salário final do vendedor " + nome_funcionario + ", é de R$: ", mat.arredondar(salario_total, 2))
		
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 531; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */