programa
{
	
	funcao inicio()
	{
		inteiro valor

		escreva("Entre com um número: \n")
		leia(valor)

		escreva("Fatorial: ", fatorial(valor) + "\n")

		escreva("Fibonnaci: ", fibonacci(valor))

		
	}

	funcao inteiro fatorial(inteiro x)
	{
		se (x <= 1)
		{
			retorne 1
		}senao
		{
			retorne (x * fatorial(x-1))
		}
	}

	funcao inteiro fibonacci(inteiro x)
	{
		se ((x == 0) ou (x == 1))
		{
			retorne x
		}senao
		{
			retorne fibonacci(x-1) + fibonacci(x-2)
		}
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 199; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */