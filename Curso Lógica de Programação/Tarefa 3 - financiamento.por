programa
{
	
	funcao inicio()
	{
		real salario_pessoa
		real financiamento_pretendido
		real aprovar_financiamento
		
		escreva("informe o valor do seu salario: ")
		leia(salario_pessoa)

		escreva("informe o valor do financiamento pretendido")
		leia(financiamento_pretendido)

		aprovar_financiamento = (salario_pessoa * 5)

		se (financiamento_pretendido <= aprovar_financiamento) 
		{
			escreva("financiamento concedido\n")
		}senao
		{
			escreva("financiamento negado\n")
		}

		escreva("Obrigado por nos consultar")
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 338; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */