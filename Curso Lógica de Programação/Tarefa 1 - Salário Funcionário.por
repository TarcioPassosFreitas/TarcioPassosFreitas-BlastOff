programa
{
	inclua biblioteca Matematica --> mat
	inclua biblioteca Tipos --> tipo
	
	funcao inicio()
	{
		//Destinado a Solução geral
		cadeia nome_funcionario
		// recebe valor do tipo cadeia, para fazer o tratamento de erro e depois o valor recebido é convertido
		cadeia quantidade_software_aux
		inteiro quantidade_software
		real salario_total

		//Destinado ao tratamento de erro geral para mensagem de erro para o usuário
		inteiro contador = 0

		//Destinado ao tratamento de erro para recebimento de dados do tipo cadeia
		logico resultado_cadeia_tem_caracter = falso
		logico resultado_cadeia_tem_inteiro = falso
		logico resultado_cadeia_tem_real = falso
		logico resultado_cadeia_tem_logico = falso

		

		
		escreva("Seja bem-vindo ao sistema de monitoramento de funcionários manual \n")
		escreva("Digite o nome do funcionário: \n")
		faca{
			contador++
			se (contador > 1)
			{
				escreva("Você digitou um valor não aceitável, por favor, digite novamente \n")
			}
			leia(nome_funcionario)
			resultado_cadeia_tem_caracter = tipo.cadeia_e_caracter(nome_funcionario)
			resultado_cadeia_tem_inteiro = (tipo.cadeia_e_inteiro(nome_funcionario, 10))
			resultado_cadeia_tem_real = tipo.cadeia_e_real(nome_funcionario)
			resultado_cadeia_tem_logico = tipo.cadeia_e_logico(nome_funcionario)
		}enquanto(resultado_cadeia_tem_caracter ou resultado_cadeia_tem_inteiro ou resultado_cadeia_tem_real  ou resultado_cadeia_tem_logico)
		
		escreva("Digite a quantidade de software que foi vendido pelo funcionário: \n")
		contador = 0
		faca{
			contador++
			se (contador > 1)
			{
				escreva("Você digitou um valor não aceitável, por favor, digite novamente \n")
			}
			leia(quantidade_software_aux)
			resultado_cadeia_tem_caracter = tipo.cadeia_e_caracter(quantidade_software_aux)
			resultado_cadeia_tem_real = tipo.cadeia_e_real(quantidade_software_aux)
			resultado_cadeia_tem_logico = tipo.cadeia_e_logico(quantidade_software_aux)
		}enquanto(resultado_cadeia_tem_caracter ou resultado_cadeia_tem_real  ou resultado_cadeia_tem_logico)
		
		quantidade_software = tipo.cadeia_para_inteiro(quantidade_software_aux, 10)
		
		salario_total = 50.0 * quantidade_software

		escreva("O salário final do vendedor " + nome_funcionario + ", é de R$: ", mat.arredondar(salario_total, 2))
		
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 409; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */