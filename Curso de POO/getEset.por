programa
{
	
	funcao inicio()
	{
		cadeia c = novaCaneta()

		escreva(c.getModelo())
		c.setModelo("alguma coisa")
		escreva(c.getModelo())
		escreva(c.getPonta())
		c.setPonta("outra coisa")
		escreva(c.getPonta)
	}

	funcao Caneta{
		privado cadeia modelo
		privado cadeia ponta
		
		publico Caneta()
		{
			
		}

		funcao cadeia  getModelo()
		{
			retorne este.modelo
		}

		funcao vazio setModelo(cadeia modelo)
		{
			este.modelo = modelo
		}

		funcao cadeia  getPonta()
		{
			retorne este.ponta
		}

		funcao vazio setPonta(cadeia ponta)
		{
			este.ponta = ponta
		}

		
	}

	
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 453; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */