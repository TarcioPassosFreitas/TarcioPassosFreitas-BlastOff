programa
{
	
	funcao inicio()
	{
		c = novo cachorro()
	
		c.reagir("ola") 
		c.reagir(11, 45) 
		c.reagir(21,00)
		c.reagir(verdadeiro) 
		c.reagir(falso)
		c.reagir(2, 12.5)
		c.reagir(17, 4.5)
	}

	classe abstrata Animal
	{
		protegido real peso
		protegido inteiro idade
		protegido inteiro membros
		
		publico metodo abstrato emitirSom()
		{
			
		}
	}

	classe Mamifero estende Animal
	{
		protegido corPelo> Caractere

		@sobrepor
		publico metodo emitirSom() 
		{
			Escreva("som de Mamifero")
		}
			
	}

	classe Lobo estende Mamifero
	{
		@sobrepor
		publico metodo emitirSom()
		{
			Escreva("Auuuuuuu") 
		}
		
	}

	classe Cachorro estende Lobo
	{
		@sobrepor
		publico metodo emitirSom()
		{
			Escreva("AU AU AU")	
		}
		
	}


	classe Cachorro estende Lobo
	{
		
	}
	publico metodo reagir(frase: Caractere)
	{
		se (frase = "comida" ou "frase = "ola)
		{
			escreva("Abanar e latir")
		}senao
		{
			escreva("rosnar")	
		}
		
	}

	publico metodo reagir(hora, min: Inteiro)
	{
		se(hora < 12)
		{
			escreva("Abanar")
		}senao se (hora >= 18)
		{
			
			escreva("ignorar")
		}senao
		{
			escreva("abanar e latir")
		}
	}

	publico metodo reagir(dono: Logico)
	{
		se (dono = verdadeiro)
		{
			escreva("Abanar")
		}senao
		{
			escreva("Rosnar e latir")
		}
	}

	publico metodo reagir( idade: Inteiro, peso: Real)
	{
		se (idade < 5()
		{
			se (peso < 10)
			{
				escreva("abanar")
			}senao
			{
				escreva("latir")	
			}	
		}senao
			se(peso < 10)
			{
				escreva("rosnar")
			}senao
			{
				escreva("ignorar")
			}
				
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 59; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */