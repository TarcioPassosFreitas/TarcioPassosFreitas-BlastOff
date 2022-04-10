programa
{
	inclua biblioteca Util --> u 
	
	funcao inicio()
	{
		inteiro vetor[10]
		inteiro aux
		inteiro contA, contB
		inteiro temp
		inteiro Valor_inicial = 1, valor_final = u.numero_elementos(vetor), meio = 0
		logico dado_encontrado = falso
		inteiro busca

		para (contA = 0; contA < (u.numero_elementos(vetor)); contA++)
		{
			escreva("Digite o número para a posição " + contA + "\n")
			leia(vetor[contA])
		}

		escreva("Valores desordenados \n")

		para (temp = 0; temp < (u.numero_elementos(vetor)); temp++)
		{
			escreva(vetor[temp] + "\n")
		}


		escreva("Valores sendo ordenados....Aguarde.... \n")

		para (contA = 1; contA < (u.numero_elementos(vetor) - 1); contA++)
		{
			para(contB = contA + 1; contB < (u.numero_elementos(vetor)); contB++)
			{
				se (vetor[contA] > vetor[contB])
				{
					aux = vetor[contB]
					vetor[contB] = vetor[contA]
					vetor[contA] = aux
				}
			}
		}

		escreva("Valores ordenados \n")

		para (temp = 0; temp < (u.numero_elementos(vetor)); temp++)
		{
			escreva(vetor[temp] + "\n")
		}

		escreva("Digite o valor que deseja buscar \n")
		leia(busca)

		enquanto ((Valor_inicial <= valor_final) e nao dado_encontrado)
		{
			meio = ((Valor_inicial + valor_final) / 2)
			se (vetor[meio] == busca)
			{
				dado_encontrado = verdadeiro
			}
			se (vetor[meio] > busca)
			{
				valor_final = meio - 1
			}senao
			{
				Valor_inicial = meio + 1
			}
			
		}

		escreva("Foi encontrado o valor ", busca + "? \n")
		escreva(dado_encontrado)
		
		
		
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 1301; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */