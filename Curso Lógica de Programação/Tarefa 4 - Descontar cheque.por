programa
{
	inclua biblioteca Tipos --> tipo
	
	funcao inicio()
	{
		//Destinado a Solução geral
		real saldo_atual = 8000.00
		real valor_cheque
		real novo_saldo
		caracter continuar = 's'

		//Destinado ao tratamento de erro geral para mensagem de erro para o usuário
		inteiro contador

		// recebe valor do tipo cadeia, para fazer o tratamento de erro e depois o valor recebido é convertido
		cadeia cheque_aux

		//recebe o valor sim ou não a respeito de continuar fazendo novas simulações
		cadeia deseja_continuar

		//Destinado ao tratamento de erro para recebimento de dados do tipo cadeia
		logico resultado_cadeia_tem_caracter = falso
		logico resultado_cadeia_tem_inteiro = falso
		logico resultado_cadeia_tem_real = falso
		logico resultado_cadeia_tem_logico = falso

		faca{
			limpa()
			escreva("Bem-vindo ao sistema de desconto de cheques \n")
			escreva("seu saldo atual é de: R$: ", saldo_atual + "\n")
			escreva("informe o valor do cheque que deseja descontar: \n")
			contador = 0
			faca{
				contador++
				se (contador > 1)
				{
					escreva("Você digitou um valor não aceitável, por favor, digite novamente \n")
				}
				leia(cheque_aux)
				resultado_cadeia_tem_caracter = tipo.cadeia_e_caracter(cheque_aux)
				resultado_cadeia_tem_inteiro = (tipo.cadeia_e_inteiro(cheque_aux, 10))
				resultado_cadeia_tem_logico = tipo.cadeia_e_logico(cheque_aux)
			}enquanto(resultado_cadeia_tem_caracter ou resultado_cadeia_tem_inteiro ou resultado_cadeia_tem_logico)

			//convertendo os valores de cadeia para real
			valor_cheque = tipo.cadeia_para_real(cheque_aux)

			se (valor_cheque > saldo_atual)
			{
				escreva("O valor não pode ser descontado, pois o saldo é insuficiente\n") 
			}senao
			{
				escreva("O cheque foi descontato\n")
				novo_saldo = saldo_atual - valor_cheque
				escreva("O seu novo saldo é de: R$: ",novo_saldo + "\n")
				saldo_atual = novo_saldo
			}
			
			escreva("Deseja descontar outro cheque? \n sim - para continuar\n nao - para encerrar \n")
			contador = 0
			faca{
				contador++
			se (contador > 1)
			{
				escreva("Você digitou um valor não aceitável, por favor, digite novamente \n")
			}

			leia(deseja_continuar)
			resultado_cadeia_tem_caracter = tipo.cadeia_e_caracter(deseja_continuar)
			resultado_cadeia_tem_inteiro = (tipo.cadeia_e_inteiro(deseja_continuar, 10))
			resultado_cadeia_tem_real = tipo.cadeia_e_real(deseja_continuar)
			resultado_cadeia_tem_logico = tipo.cadeia_e_logico(deseja_continuar)
			}enquanto(resultado_cadeia_tem_caracter ou resultado_cadeia_tem_inteiro ou resultado_cadeia_tem_real  ou resultado_cadeia_tem_logico)
			
		}enquanto(deseja_continuar == "sim")

			
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 96; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */