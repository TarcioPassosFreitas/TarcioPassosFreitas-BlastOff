programa
{
	
	funcao inicio()
	{
		real saldo_atual = 8000.00
		real cheque
		real novo_saldo
		caracter continuar = 's'

		faca
		{
		
		escreva("seu saldo atual é de: R$: ", saldo_atual + "\n")
		escreva("informe o valor do cheque que deseja descontar: \n")
		leia(cheque)

		se (cheque > saldo_atual)
		{
			escreva("O valor não pode ser descontado, pois o saldo é insuficiente\n") 
		}senao
		{
			escreva("O cheque foi descontato\n")
			novo_saldo = saldo_atual - cheque
			escreva("O seu novo saldo é de: R$: ",novo_saldo + "\n")
			saldo_atual = novo_saldo

			escreva("Você deseja continuar descontando algum cheque?\n s - Para Sim\n n - Para Não\n")
			leia(continuar)
		}
		} enquanto(continuar == 's')
			
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 628; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */