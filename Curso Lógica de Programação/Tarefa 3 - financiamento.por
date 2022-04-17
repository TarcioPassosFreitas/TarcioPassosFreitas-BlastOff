programa
{
	inclua biblioteca Tipos --> tipo
	
	funcao inicio()
	{
		//Destinado a Solução geral
		real salario_pessoa
		real financiamento_pretendido
		real aprovar_financiamento

		//Destinado ao tratamento de erro geral para mensagem de erro para o usuário
		inteiro contador

		// recebe valor do tipo cadeia, para fazer o tratamento de erro e depois o valor recebido é convertido
		cadeia salario_pessoa_aux
		cadeia financiamento_pretendido_aux

		//recebe o valor sim ou não a respeito de continuar fazendo novas simulações
		cadeia deseja_continuar

		//Destinado ao tratamento de erro para recebimento de dados do tipo cadeia
		logico resultado_cadeia_tem_caracter = falso
		logico resultado_cadeia_tem_inteiro = falso
		logico resultado_cadeia_tem_real = falso
		logico resultado_cadeia_tem_logico = falso

		faca{
			limpa()
			escreva("Bem-vindo ao sistema de financiamento \n")
			escreva("informe o valor do seu salario: \n")
			contador = 0
			faca{
				contador++
				se (contador > 1)
				{
					escreva("Você digitou um valor não aceitável, por favor, digite novamente \n")
				}
				leia(salario_pessoa_aux)
				resultado_cadeia_tem_caracter = tipo.cadeia_e_caracter(salario_pessoa_aux)
				resultado_cadeia_tem_inteiro = (tipo.cadeia_e_inteiro(salario_pessoa_aux, 10))
				resultado_cadeia_tem_logico = tipo.cadeia_e_logico(salario_pessoa_aux)
			}enquanto(resultado_cadeia_tem_caracter ou resultado_cadeia_tem_inteiro ou resultado_cadeia_tem_logico)

			escreva("informe o valor do financiamento pretendido \n")
			contador = 0
			faca{
				contador++
				se (contador > 1)
				{
					escreva("Você digitou um valor não aceitável, por favor, digite novamente \n")
				}
				leia(financiamento_pretendido_aux)
				resultado_cadeia_tem_caracter = tipo.cadeia_e_caracter(financiamento_pretendido_aux)
				resultado_cadeia_tem_inteiro = (tipo.cadeia_e_inteiro(financiamento_pretendido_aux, 10))
				resultado_cadeia_tem_logico = tipo.cadeia_e_logico(financiamento_pretendido_aux)
			}enquanto(resultado_cadeia_tem_caracter ou resultado_cadeia_tem_inteiro ou resultado_cadeia_tem_logico)
			
			//convertendo os valores de cadeia para real
			salario_pessoa = tipo.cadeia_para_real(salario_pessoa_aux)
			financiamento_pretendido = tipo.cadeia_para_real(financiamento_pretendido_aux)

			aprovar_financiamento = (salario_pessoa * 5)

			se (financiamento_pretendido <= aprovar_financiamento) 
			{
				escreva("financiamento concedido\n")
			}senao
			{
				escreva("financiamento negado\n")
			}

			escreva("Obrigado por nos consultar \n")
			
			escreva("Deseja um novo financiamento? \n sim - para continuar\n nao - para encerrar \n")
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
 * @POSICAO-CURSOR = 2602; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */