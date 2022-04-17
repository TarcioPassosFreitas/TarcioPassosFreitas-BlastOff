programa
{
	inclua biblioteca Tipos --> tipo
	
	funcao inicio()
	{
		//Destinado a Solução geral
		real kmInicial, kmFinal
		real quantidade_litros
		real km_litro
		real soma_valor_percorrido
		cadeia deseja_continuar

		//Destinado ao tratamento de erro geral para mensagem de erro para o usuário
		inteiro contador

		// recebe valor do tipo cadeia, para fazer o tratamento de erro e depois o valor recebido é convertido
		cadeia kmInicial_aux, kmFinal_aux
		cadeia quantidade_litros_aux

		//Destinado ao tratamento de erro para recebimento de dados do tipo cadeia
		logico resultado_cadeia_tem_caracter = falso
		logico resultado_cadeia_tem_inteiro = falso
		logico resultado_cadeia_tem_real = falso
		logico resultado_cadeia_tem_logico = falso

		faca{
			limpa()
			escreva("Bem-vindo ao sistema de monitoramento de consumo \n")
			escreva("Qual sua quilometragem inicial? \n")
			contador = 0
			faca{
				contador++
				se (contador > 1)
				{
					escreva("Você digitou um valor não aceitável, por favor, digite novamente \n")
				}
				leia(kmInicial_aux)
				resultado_cadeia_tem_caracter = tipo.cadeia_e_caracter(kmInicial_aux)
				resultado_cadeia_tem_inteiro = (tipo.cadeia_e_inteiro(kmInicial_aux, 10))
				resultado_cadeia_tem_logico = tipo.cadeia_e_logico(kmInicial_aux)
			}enquanto(resultado_cadeia_tem_caracter ou resultado_cadeia_tem_inteiro ou resultado_cadeia_tem_logico)

			escreva("Qual sua quilometragem final? \n")
			contador = 0
			faca{
				contador++
				se (contador > 1)
				{
					escreva("Você digitou um valor não aceitável, por favor, digite novamente \n")
				}
				leia(kmFinal_aux)
				resultado_cadeia_tem_caracter = tipo.cadeia_e_caracter(kmFinal_aux)
				resultado_cadeia_tem_inteiro = (tipo.cadeia_e_inteiro(kmFinal_aux, 10))
				resultado_cadeia_tem_logico = tipo.cadeia_e_logico(kmFinal_aux)
			}enquanto(resultado_cadeia_tem_caracter ou resultado_cadeia_tem_inteiro ou resultado_cadeia_tem_logico)

			escreva("Quantos litros de gasolina foi colocado? \n")
			contador = 0
			faca{
				contador++
				se (contador > 1)
				{
					escreva("Você digitou um valor não aceitável, por favor, digite novamente \n")
				}
				leia(quantidade_litros_aux)
				resultado_cadeia_tem_caracter = tipo.cadeia_e_caracter(quantidade_litros_aux)
				resultado_cadeia_tem_inteiro = (tipo.cadeia_e_inteiro(quantidade_litros_aux, 10))
				resultado_cadeia_tem_logico = tipo.cadeia_e_logico(quantidade_litros_aux)
			}enquanto(resultado_cadeia_tem_caracter ou resultado_cadeia_tem_inteiro ou resultado_cadeia_tem_logico)
			
			//convertendo os valores de cadeia para real
			kmInicial = tipo.cadeia_para_real(kmInicial_aux)
			kmFinal = tipo.cadeia_para_real(kmFinal_aux)
			quantidade_litros =tipo.cadeia_para_real(quantidade_litros_aux)

			soma_valor_percorrido = valor_percorrido(kmInicial, kmFinal)

			km_litro = (soma_valor_percorrido / quantidade_litros)
			escreva("Consumiu ", km_litro, " Km por litro de gasolina \n")
			escreva("Deseja monitorar outro consumo? \n sim - para continuar\n nao - para encerrar \n")
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

	funcao real valor_percorrido(real kmInicial, real kmFinal)
	{
		real valor_percorrido_km = kmFinal - kmInicial

		retorne valor_percorrido_km
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 3050; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */