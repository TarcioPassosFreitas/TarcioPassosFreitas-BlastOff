programa
{
	inclua biblioteca Util --> u
	
	funcao inicio()
	{
		inteiro vetor[3]
		inteiro aux
		inteiro contA, contB
		inteiro temp

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

		para (contA = 0; contA < (u.numero_elementos(vetor) - 1); contA++)
		{
			para(contB = 1; contB < (u.numero_elementos(vetor)); contB++)
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
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 678; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */